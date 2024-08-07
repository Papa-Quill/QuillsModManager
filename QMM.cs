﻿using Guna.UI2.WinForms;
using Newtonsoft.Json;
using QMM.Info_Forms;
using QMM.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QMM
{
    public partial class MainForm : Form
    {
        #region Variables
        public static FModInfo fModInfo;
        public string gameDir = Properties.Settings.Default.GameDir;
        public string backupFolder = AppDomain.CurrentDomain.BaseDirectory + "\\Backup";
        public string dataFolder = Properties.Settings.Default.GameDir + "\\data";
        public string userDataFolder = Properties.Settings.Default.UserDataDir;
        public static bool RefreshQueued = false;
        private readonly Timer RefreshTimer;

        private const int ButtonWidth = 350;
        private const int ButtonHeight = 30;
        private const int VerticalSpacing = 10;
        private int currentY = 0;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            SettingsChangedEvent(this, null);
            Properties.Settings.Default.SettingsLoaded += SettingsChangedEvent;
            CreateButtonsFromModTitles();

            RefreshTimer = new Timer();
            RefreshTimer.Interval = 1000;
            RefreshTimer.Tick += Timer_Tick;
            RefreshTimer.Start();

            // Initialize BackgroundWorker
            bgWorker = new BackgroundWorker();
            bgWorker.WorkerReportsProgress = true;
            bgWorker.DoWork += bgWorker_DoWork;
            bgWorker.ProgressChanged += bgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;
        }

        #region Hotkeys
        private DateTime lastEscapeKeyPress = DateTime.MinValue;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.L))
            {
                BtnLaunchGame.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.A))
            {
                BtnAddMod.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                BtnRefreshModList.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.E))
            {
                BtnUserSettings.PerformClick();
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                BtnCloseInfo.PerformClick();
                if ((DateTime.Now - lastEscapeKeyPress).TotalMilliseconds < 500)
                {
                    BtnClose.PerformClick();
                    return true;
                }
                lastEscapeKeyPress = DateTime.Now;
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                if ((DateTime.Now - lastEscapeKeyPress).TotalMilliseconds < 500)
                {
                    BtnClose.PerformClick();
                    return true;
                }
                lastEscapeKeyPress = DateTime.Now;
            }
            else if (keyData == (Keys.Control | Keys.K))
            {
                Properties.Settings.Default.HotKeyForm = "Main";
                FHotKeys HotKeys = new FHotKeys(); HotKeys.Show();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Form base
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams shadowParams = base.CreateParams;
                if (Properties.Settings.Default.FormShadows)
                    shadowParams.ClassStyle |= 0x00020000;
                return shadowParams;
            }
        }

        private void MoveWindow(object sender, MouseEventArgs e)
        { if (e.Button == MouseButtons.Left) CFormUtil.GrabWindow(Handle); }

        private void SettingsChangedEvent(object sender, System.Configuration.SettingsLoadedEventArgs e)
        {
            var controlsToModify = new Control[] {
                BtnClose, BtnMinimize, BtnInfo, BtnUserSettings,
                BtnAddMod, BtnRefreshModList, BtnRemoveMod, BtnLaunchGame,
                BtnCloseInfo, BtnCreateBackup, BtnRestoreBackup, BtnBackupSave,
                BtnRestoreSave };
            CUpdateTheme.Refresh(this, controlsToModify);
            CNotification.CreateNotif(Color.White, "Settings Changed");
            BtnRefreshModList.PerformClick();
        }
        #endregion

        #region Functions
        private void OpenModInfoForm(object sender, EventArgs e)
        {
            CFormUtil.CloseAllOpenModInfoForms();
            fModInfo = new FModInfo(this, "ModTitle", "ModAuthor", "ModVersion", "ModDescription", "ModLocation"); fModInfo.Show();
            fModInfo.SetLocationRelativeToForm1();
        }

        private int DirectoryFileMeasurement(string dir, bool directoriesOnly)
        {
            int fileCount = 0;

            if (!directoriesOnly)
            {
                fileCount += Directory.GetFiles(dir).Length;
            }

            foreach (string subDir in Directory.GetDirectories(dir))
            {
                fileCount += DirectoryFileMeasurement(subDir, directoriesOnly);
            }

            return fileCount;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (RefreshQueued)
            {
                CreateButtonsFromModTitles();
                RefreshQueued = false;
            }
        }

        private void BtnRefreshButtons_Click(object sender, EventArgs e)
        { CreateButtonsFromModTitles(); }

        private void AdjustButtonWidths()
        {
            int buttonCount = PanelModList.Controls.OfType<Guna2Button>().Count();

            if (buttonCount > 10)
            {
                int newWidth = PanelModList.Width - 40;
                foreach (Guna2Button button in PanelModList.Controls.OfType<Guna2Button>())
                {
                    button.Width = newWidth;
                }
            }
        }

        private void CreateButtonsFromModTitles()
        {
            CFormUtil.CloseAllOpenModInfoForms();
            PanelModList.Controls.Clear();
            currentY = 10;

            if (File.Exists(CModListManager.ModListFilePath))
            {
                List<Mod> modList = DeserializeModList();
                foreach (Mod mod in modList)
                {
                    ContextMenuStrip contextMenu = CreateModContextMenu(mod);
                    Guna2Button button = CreateModButton(mod, contextMenu);

                    PanelModList.Controls.Add(button);
                    AdjustButtonWidths();
                }
            }
        }

        private List<Mod> DeserializeModList()
        {
            string json = File.ReadAllText(CModListManager.ModListFilePath);
            return JsonConvert.DeserializeObject<List<Mod>>(json);
        }

        private ContextMenuStrip CreateModContextMenu(Mod mod)
        {
            CustomContextMenuStripRenderer customRenderer = new CustomContextMenuStripRenderer();
            ContextMenuStrip contextMenu = new ContextMenuStrip
            {
                Renderer = customRenderer,
                ShowImageMargin = false,
                BackColor = Properties.Settings.Default.BGTertiary,
                ForeColor = Properties.Settings.Default.TextColor
            };

            ToolStripMenuItem moveUpMenuItem = new ToolStripMenuItem("Move Up");
            moveUpMenuItem.Click += (sender, e) => MoveModItem(mod.ModTitle, -1);
            ToolStripMenuItem moveDownMenuItem = new ToolStripMenuItem("Move Down");
            moveDownMenuItem.Click += (sender, e) => MoveModItem(mod.ModTitle, 1);
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            deleteMenuItem.Click += (sender, e) => DeleteModItem(mod.ModTitle, mod.ModVersion);

            contextMenu.Items.Add(moveUpMenuItem);
            contextMenu.Items.Add(moveDownMenuItem);
            contextMenu.Items.Add(deleteMenuItem);

            return contextMenu;
        }

        private Guna2Button CreateModButton(Mod mod, ContextMenuStrip contextMenu)
        {
            Guna2Button button = new Guna2Button
            {
                Name = "Btn" + mod.ModTitle.Replace(" .", ""),
                Text = $"{mod.ModTitle} | v{mod.ModVersion}",
                Width = ButtonWidth,
                Height = ButtonHeight,
                Location = new Point(10, currentY),
                Animated = true,
                BorderColor = Properties.Settings.Default.DetailColor,
                BorderThickness = 1,
                Font = new Font("Gadugi", 10F),
                PressedColor = Color.FromArgb(30, 30, 36),
                Cursor = Cursors.Hand,
                ContextMenuStrip = contextMenu
            };

            button.CheckedState.CustomBorderColor = Color.White;
            button.CheckedState.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.DataBindings.Add(new Binding("FillColor", Properties.Settings.Default, "ButtonColor", true, DataSourceUpdateMode.OnPropertyChanged));
            button.DataBindings.Add(new Binding("ForeColor", Properties.Settings.Default, "TextColor", true, DataSourceUpdateMode.OnPropertyChanged));
            button.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
            button.CheckedState.BorderColor = Properties.Settings.Default.DetailActive;

            if (Properties.Settings.Default.RoundedControls)
                button.BorderRadius = Properties.Settings.Default.BorderRadius;
            else
                button.BorderRadius = 0;

            button.Click += Button_Click;

            currentY += ButtonHeight + VerticalSpacing;

            return button;
        }

        private void DeleteModItem(string modTitle, string modVersion)
        {
            CModListManager.RemoveMod(modTitle, modVersion);
            CreateButtonsFromModTitles();
        }

        private void MoveModItem(string modTitle, int direction)
        {
            List<Mod> modList = CModListManager.LoadModList();
            int index = modList.FindIndex(mod => mod.ModTitle == modTitle);
            if (index >= 0 && index < modList.Count)
            {
                int newIndex = index + direction;
                if (newIndex >= 0 && newIndex < modList.Count)
                {
                    CModListManager.MoveModPosition(index, newIndex);
                    CreateButtonsFromModTitles();
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            CFormUtil.CloseAllOpenModInfoForms();
            Guna2Button clickedButton = (Guna2Button)sender;
            string buttonText = clickedButton.Text;
            string[] parts = buttonText.Split('|');
            if (parts.Length == 2)
            {
                string modTitle = parts[0].Trim();
                Mod clickedMod = GetModByTitle(modTitle);
                if (clickedMod != null)
                {
                    FModInfo fModInfo = new FModInfo(this, clickedMod.ModTitle, clickedMod.ModAuthor, clickedMod.ModVersion, clickedMod.ModDescription, clickedMod.ModLocation);
                    fModInfo.Show();
                    fModInfo.SetLocationRelativeToForm1();
                    Focus();
                }
                else
                    CNotification.CreateNotif(Color.Red, "Mod not found.");
            }
            else
                CNotification.CreateNotif(Color.Red, "Invalid button text format.");
        }

        private Mod GetModByTitle(string modTitle)
        {
            string json = File.ReadAllText(CModListManager.ModListFilePath);
            List<Mod> modList = JsonConvert.DeserializeObject<List<Mod>>(json);
            Mod clickedMod = modList.Find(mod => mod.ModTitle == modTitle);
            return clickedMod;
        }

        private void OpenFileOrFolder(string path)
        {
            using (var process = new Process())
            {
                try
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        FileName = path
                    };
                    process.Start();
                }
                catch (Exception ex)
                {
                    CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"Error: {ex.Message}");
                }
            }
        }

        private void LabelMadeBy_Click(object sender, EventArgs e)
        { Process.Start("https://github.com/Papa-Quill/"); }

        private BackgroundWorker bgWorker;
        private void CopyDirectory(string sourceDir, string destinationDir, bool directoriesOnly, string progressMessage)
        {
            ProgressBar.Value = 0;
            LabelProgress.Visible = true;
            ProgressBar.Visible = true;

            if (!Directory.Exists(destinationDir))
                Directory.CreateDirectory(destinationDir);

            var args = new CopyDirectoryArgs(sourceDir, destinationDir, directoriesOnly, progressMessage)
            {
                OperationType = "backup" // Set the operation type here
            };

            // Start the background worker
            bgWorker.RunWorkerAsync(args);
        }

        private void CopyDirectoryRecursive(string sourceDir, string destinationDir, bool directoriesOnly, string progressMessage, BackgroundWorker worker, DoWorkEventArgs e)
        {
            try
            {
                Debug.WriteLine("Copying directory from " + sourceDir + " to " + destinationDir);

                if (!directoriesOnly)
                {
                    foreach (string file in Directory.GetFiles(sourceDir))
                    {
                        string targetFilePath = Path.Combine(destinationDir, Path.GetFileName(file));
                        Debug.WriteLine("Copying file " + file + " to " + targetFilePath);
                        File.Copy(file, targetFilePath, true);

                        var state = new CopyProgressState
                        {
                            ProgressMessage = progressMessage,
                            CurrentFile = Path.GetFileName(file) // Only the file name
                        };
                        worker.ReportProgress(0, state); // Report progress with CopyProgressState
                    }
                }

                foreach (string subDir in Directory.GetDirectories(sourceDir))
                {
                    string newDestinationDir = Path.Combine(destinationDir, Path.GetFileName(subDir));
                    Debug.WriteLine("Creating directory " + newDestinationDir);
                    Directory.CreateDirectory(newDestinationDir);
                    CopyDirectoryRecursive(subDir, newDestinationDir, directoriesOnly, progressMessage, worker, e);
                }
            }
            catch (Exception ex)
            {
                e.Result = ex;
                Debug.WriteLine("Exception during recursive copy: " + ex.Message);
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is CopyDirectoryArgs args)
            {
                int totalFiles = DirectoryFileMeasurement(args.SourceDir, args.DirectoriesOnly);
                int filesCopied = 0;

                CopyDirectoryRecursive(args.SourceDir, args.DestinationDir, args.DirectoriesOnly, args.ProgressMessage, sender as BackgroundWorker, e, ref filesCopied, totalFiles);
            }
        }

        private void CopyDirectoryRecursive(string sourceDir, string destinationDir, bool directoriesOnly, string progressMessage, BackgroundWorker worker, DoWorkEventArgs e, ref int filesCopied, int totalFiles)
        {
            try
            {
                Debug.WriteLine("Copying directory from " + sourceDir + " to " + destinationDir);

                if (!directoriesOnly)
                {
                    foreach (string file in Directory.GetFiles(sourceDir))
                    {
                        string targetFilePath = Path.Combine(destinationDir, Path.GetFileName(file));
                        Debug.WriteLine("Copying file " + file + " to " + targetFilePath);
                        File.Copy(file, targetFilePath, true);

                        filesCopied++;
                        int progressPercentage = (int)((float)filesCopied / totalFiles * 100);

                        var state = new CopyProgressState
                        {
                            ProgressMessage = progressMessage,
                            CurrentFile = Path.GetFileName(file)
                        };
                        worker.ReportProgress(progressPercentage, state); // Report progress with percentage and state
                    }
                }

                foreach (string subDir in Directory.GetDirectories(sourceDir))
                {
                    string newDestinationDir = Path.Combine(destinationDir, Path.GetFileName(subDir));
                    Debug.WriteLine("Creating directory " + newDestinationDir);
                    Directory.CreateDirectory(newDestinationDir);
                    CopyDirectoryRecursive(subDir, newDestinationDir, directoriesOnly, progressMessage, worker, e, ref filesCopied, totalFiles);
                }
            }
            catch (Exception ex)
            {
                e.Result = ex;
                Debug.WriteLine("Exception during recursive copy: " + ex.Message);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;

            if (e.UserState is CopyProgressState state)
            {
                UpdateProgressLabel(state.ProgressMessage, state.CurrentFile);
            }
        }

        public class CopyProgressState
        {
            public string ProgressMessage { get; set; }
            public string CurrentFile { get; set; }
        }


        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"Error: {e.Error.Message}");
            }
            else if (e.Cancelled)
            {
                // Handle cancellation if needed
            }
            else
            {
                // Copy completed successfully
            }

            HideProgressControls();
        }

        public class CopyDirectoryArgs
        {
            public string SourceDir { get; set; }
            public string DestinationDir { get; set; }
            public bool DirectoriesOnly { get; set; }
            public string ProgressMessage { get; set; }
            public string OperationType { get; set; } // Added to differentiate between backup and restore

            // Parameterless constructor
            public CopyDirectoryArgs() { }

            // Constructor
            public CopyDirectoryArgs(string sourceDir, string destinationDir, bool directoriesOnly, string progressMessage)
            {
                SourceDir = sourceDir;
                DestinationDir = destinationDir;
                DirectoriesOnly = directoriesOnly;
                ProgressMessage = progressMessage;
            }
        }

        void UpdateProgressLabel(string progressMessage, string fileName)
        {
            LabelProgress.Text = $"{progressMessage}{fileName}";
            LabelProgress.Refresh();
        }

        void HideProgressControls()
        {
            LabelProgress.Visible = false;
            ProgressBar.Visible = false;
        }

        private void CheckGameDir()
        {
            if (!Directory.Exists(gameDir) || !File.Exists(Path.Combine(gameDir, "castle.exe")))
            {
                CNotification.CreateNotif(Color.White, "Please select your game directory!");
                CFileManager.SelectGameDirectory();
                gameDir = Properties.Settings.Default.GameDir;
                dataFolder = Path.Combine(gameDir, "data");
            }
        }

        private void CheckUserDataDir()
        {
            if (!Directory.Exists(userDataFolder))
            {
                CNotification.CreateNotif(Color.White, "Please select your user data directory!");
                CFileManager.SelectUserDataDirectory();
                userDataFolder = Properties.Settings.Default.UserDataDir;
            }
        }
        #endregion

        #region Header buttons
        private void BtnClose_Click(object sender, EventArgs e)
        {
            List<Form> openForms = CFormUtil.GetAllOpenForms();

            foreach (Form form in openForms)
                { CFormUtil.Close(form); }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        { CFormUtil.MinimizeWindow(); }

        private void BtnInfo_Click(object sender, EventArgs e)
        { CFormUtil.ShowForm<MainInfoForm>(); }

        private void BtnUserSettings_Click(object sender, EventArgs e)
        { CFormUtil.ShowForm<UserSettings>(); }
        #endregion

        #region Button functions
        private void BtnLaunchGame_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(gameDir))
            {
                CNotification.CreateNotif(Color.White, "Please set your game directory!");
                CFileManager.SelectGameDirectory();
                gameDir = Properties.Settings.Default.GameDir;
                if (!Directory.Exists(gameDir))
                    return;
            }

            string gameExecutablePath = gameDir + "\\castle.exe";

            if (!File.Exists(gameExecutablePath))
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Failed to find castle.exe");
                return;
            }

            OpenFileOrFolder(gameExecutablePath);
        }

        private void BtnAddMod_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new OpenFileDialog())
            {
                folderBrowserDialog.Title = "Select Folder Truncated";
                folderBrowserDialog.CheckFileExists = false;
                folderBrowserDialog.CheckPathExists = true;
                folderBrowserDialog.FileName = "Select Folder";
                folderBrowserDialog.Filter = "Folders|\n";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(Path.GetDirectoryName(folderBrowserDialog.FileName)))
                {
                    string folderPath = Path.GetDirectoryName(folderBrowserDialog.FileName);
                    string modInfoFilePath = Path.Combine(folderPath, "modinfo.txt");

                    string newModTitle = "Failed";
                    string newModAuthor = "Failed";
                    string newModVersion = "Failed";
                    string newModDescription = "Failed";
                    bool newModToggleable = false;
                    string newModLocation = folderPath;

                    if (File.Exists(modInfoFilePath))
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(modInfoFilePath);
                            foreach (string line in lines)
                            {
                                if (line.StartsWith("ModTitle="))
                                {
                                    string modTitle = line.Substring("ModTitle=".Length);
                                    newModTitle = modTitle;
                                }
                                else if (line.StartsWith("ModAuthor="))
                                {
                                    string modAuthor = line.Substring("ModAuthor=".Length);
                                    newModAuthor = modAuthor;
                                }
                                else if (line.StartsWith("ModVersion="))
                                {
                                    string modVersion = line.Substring("ModVersion=".Length);
                                    newModVersion = modVersion;
                                }
                                else if (line.StartsWith("ModDescription="))
                                {
                                    string modDescription = line.Substring("ModDescription=".Length);
                                    newModDescription = modDescription;
                                }
                                else if (line.StartsWith("ModType=toggle"))
                                {
                                    bool modToggleable = true;
                                    newModToggleable = modToggleable;
                                }
                            }

                            CModListManager.AddNewMod(newModTitle, newModAuthor, newModVersion, newModDescription, newModLocation, newModToggleable);
                        }
                        catch (Exception ex)
                        {
                            CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Error reading modinfo.txt: " + ex.Message);
                        }
                    }
                    else
                    {
                        CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "modinfo.txt not found in the selected folder.");
                        CModListManager.AddNewMod("Unknown Mod", "Unknown", "???", "No mod description.", newModLocation, newModToggleable);
                    }

                    CreateButtonsFromModTitles();
                }
            }
        }

        private void BtnRemoveMod_Click(object sender, EventArgs e)
        {
            const string MsgBoxMessage = "Are you sure you want to remove all mods?\nThis cannot be reversed!";
            DialogResult dgresult = CMessageBox.Show("Remove Mods", MsgBoxMessage, true);
            if (dgresult == DialogResult.Yes)
            {
                CFormUtil.CloseAllOpenModInfoForms();
                CModListManager.RemoveAllMods();
                CreateButtonsFromModTitles();
            }
        }

        private void BtnCreateBackup_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            CheckGameDir();
            if (!Directory.Exists(gameDir) || !File.Exists(Path.Combine(gameDir, "castle.exe")))
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Please select a valid game directory!");
                return;
            }

            string backupMessage = "Are you sure you want to create a backup?\nThis may take a while!";
            DialogResult dialogResult = CMessageBox.Show("Create Backup", backupMessage, true);
            if (dialogResult != DialogResult.Yes)
                return;

            try
            {
                if (Directory.Exists(backupFolder))
                    Directory.Delete(backupFolder, true); // Delete the existing backup folder and its contents

                Directory.CreateDirectory(backupFolder); // Create a new backup folder

                if (Directory.Exists(dataFolder))
                {
                    ProgressBar.Maximum = DirectoryFileMeasurement(dataFolder, false);
                    CopyDirectory(dataFolder, backupFolder, false, "Creating Backup: ");
                    CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "Backup complete!");
                }
                else
                {
                    CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Could not find: " + dataFolder);
                    Debug.WriteLine("Data folder not found: " + dataFolder);
                }
            }
            catch (Exception ex)
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"An error occurred while creating the backup: {ex.Message}");
                Debug.WriteLine("Exception during backup creation: " + ex.Message);
            }
        }


        private void BtnCloseInfo_Click(object sender, EventArgs e)
        { CFormUtil.CloseAllOpenModInfoForms(); }

        private void BtnRestoreBackup_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;

            CheckGameDir();
            if (!Directory.Exists(gameDir) || !File.Exists(Path.Combine(gameDir, "castle.exe")))
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Please select a valid game directory!");
                return;
            }

            string restoreMessage = "Are you sure you want to restore from the backup?\nThis will overwrite existing files!";
            DialogResult dialogResult = CMessageBox.Show("Restore Backup", restoreMessage, true);
            if (dialogResult != DialogResult.Yes)
                return;

            try
            {
                if (Directory.Exists(backupFolder))
                {
                    ProgressBar.Visible = true; // Show the progress bar
                    LabelProgress.Visible = true; // Show the progress label
                    ProgressBar.Maximum = DirectoryFileMeasurement(backupFolder, false);
                    var args = new CopyDirectoryArgs(backupFolder, dataFolder, false, "Restoring Backup: ")
                    {
                        OperationType = "restore" // Indicate that this is a restore operation
                    };
                    bgWorker.RunWorkerAsync(args);
                }
                else
                {
                    CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Could not find backup folder: " + backupFolder);
                    Debug.WriteLine("Backup folder not found: " + backupFolder);
                }
            }
            catch (Exception ex)
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"An error occurred while restoring the backup: {ex.Message}");
                Debug.WriteLine("Exception during backup restore: " + ex.Message);
            }
        }


        private void BtnBackupSave_Click(object sender, EventArgs e)
        {
            CheckUserDataDir();

            string savesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saves");
            if (!Directory.Exists(savesDirectory))
                Directory.CreateDirectory(savesDirectory);

            if (Directory.Exists(userDataFolder))
            {
                bool backedAtLeastOne = false;
                foreach (string userIDDirectory in Directory.GetDirectories(userDataFolder))
                {
                    string ccSavePath = Path.Combine(userIDDirectory, "204360", "remote", "cc_save.dat");
                    if (File.Exists(ccSavePath))
                    {
                        backedAtLeastOne = true;
                        string ccSaveBackupPath = Path.Combine(savesDirectory, $"cc_save.{Path.GetFileName(userIDDirectory)}.dat");
                        File.Copy(ccSavePath, ccSaveBackupPath, true);
                    }
                    else
                        CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Could not locate cc_save.dat in user data!");
                }
                if (backedAtLeastOne)
                    CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, $"Backed save data to: {savesDirectory}");
            }
            else
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"No Directory found at:{Environment.NewLine}{userDataFolder}");
        }

        private void BtnRestoreSave_Click(object sender, EventArgs e)
        {
            CheckUserDataDir();

            string savesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saves");
            if (!Directory.Exists(savesDirectory))
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "No save backups found!");
                return;
            }

            foreach (string backupFile in Directory.GetFiles(savesDirectory))
            {
                string fileName = Path.GetFileName(backupFile);
                if (fileName.StartsWith("cc_save.") && fileName.EndsWith(".dat"))
                {
                    string userID = fileName.Substring(8, fileName.Length - 12);
                    string userSaveDirectory = Path.Combine(userDataFolder, userID, "204360", "remote");
                    if (Directory.Exists(userSaveDirectory))
                    {
                        string userSavePath = Path.Combine(userSaveDirectory, "cc_save.dat");
                        File.Copy(backupFile, userSavePath, true);
                        CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "Save data restored from backup!");
                    }
                    else
                        CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Could not locate cc_save.dat in user data!");
                }
                else
                    CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Backup save file could not be identified!");
            }
        }
        #endregion
    }
}