using Guna.UI2.WinForms;
using Newtonsoft.Json;
using QMM.Info_Forms;
using QMM.Util;
using System;
using System.Collections.Generic;
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

            var controlsToModify = new Control[] {
                BtnClose, BtnMinimize, BtnInfo, BtnUserSettings,
                BtnAddMod, BtnRefreshModList, BtnRemoveMod, BtnLaunchGame,
                BtnCloseInfo, BtnCreateBackup, BtnRestoreBackup, BtnBackupSave,
                BtnRestoreSave };
            CUpdateTheme.Refresh(this, controlsToModify);
            CreateButtonsFromModTitles();

            RefreshTimer = new Timer();
            RefreshTimer.Interval = 1000;
            RefreshTimer.Tick += Timer_Tick;
            RefreshTimer.Start();
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
                CreateParams ShadowParams = base.CreateParams;
                if (Properties.Settings.Default.FormShadows)
                {
                    ShadowParams.ExStyle |= 0x02000000;
                    ShadowParams.ClassStyle |= 0x00020000;
                }
                return ShadowParams;
            }
        }

        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { CFormUtil.GrabWindow(Handle); }
        }

        private void PanelSEEBackground_MouseHover(object sender, EventArgs e)
        {
            var controlsToModify = new Control[] {
                BtnClose, BtnMinimize, BtnInfo, BtnUserSettings,
                BtnAddMod };
            CUpdateTheme.Refresh(this, controlsToModify);
        }
        #endregion

        #region Functions
        private void OpenModInfoForm(object sender, EventArgs e)
        {
            CFormUtil.CloseAllOpenModInfoForms();
            fModInfo = new FModInfo(this, "ModTitle", "ModAuthor", "ModVersion", "ModDescription", "ModLocation"); fModInfo.Show();
            fModInfo.SetLocationRelativeToForm1();
        }

        static int DirectoryFileMeasurement(string dir, bool directoriesOnly)
        {
            int count = 0;
            if (!directoriesOnly) count += Directory.GetFiles(dir).Length;
            foreach (string subDir in Directory.GetDirectories(dir))
            {
                count += DirectoryFileMeasurement(subDir, false);
            }
            return count;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (RefreshQueued)
            {
                var controlsToModify = new Control[] {
                    BtnClose, BtnMinimize, BtnInfo, BtnUserSettings,
                    BtnAddMod, BtnRefreshModList, BtnRemoveMod, BtnLaunchGame,
                    BtnCloseInfo, BtnCreateBackup, BtnRestoreBackup, BtnBackupSave,
                    BtnRestoreSave };
                CUpdateTheme.Refresh(this, controlsToModify);
                CreateButtonsFromModTitles();
                RefreshQueued = false;
            }
        }

        private void BtnCreateButtons_Click(object sender, EventArgs e)
        {
            CreateButtonsFromModTitles();
        }

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

        public void CreateButtonsFromModTitles()
        {
            CFormUtil.CloseAllOpenModInfoForms();
            PanelModList.Controls.Clear();
            currentY = 10;
            if (File.Exists(CModListManager.ModListFilePath))
            {
                string json = File.ReadAllText(CModListManager.ModListFilePath);
                List<Mod> modList = JsonConvert.DeserializeObject<List<Mod>>(json);
                foreach (Mod mod in modList)
                {
                    Guna2Button button = new Guna2Button();
                    button.Name = "Btn" + mod.ModTitle.Replace(" .", "");
                    button.Text = $"{mod.ModTitle} | v{mod.ModVersion}";
                    button.Width = ButtonWidth;
                    button.Height = ButtonHeight;
                    button.Location = new Point(10, currentY);
                    button.Animated = true;
                    button.BorderColor = Properties.Settings.Default.DetailColor;
                    button.BorderThickness = 1;
                    button.CheckedState.CustomBorderColor = Color.White;
                    button.CheckedState.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    button.Cursor = Cursors.Hand;
                    button.DataBindings.Add(new Binding("FillColor", Properties.Settings.Default, "ButtonColor", true, DataSourceUpdateMode.OnPropertyChanged));
                    button.DataBindings.Add(new Binding("ForeColor", Properties.Settings.Default, "TextColor", true, DataSourceUpdateMode.OnPropertyChanged));
                    button.Font = new Font("Gadugi", 10F);
                    button.PressedColor = Color.FromArgb(30, 30, 36);
                    button.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                    button.CheckedState.BorderColor = Properties.Settings.Default.DetailActive;
                    if (Properties.Settings.Default.RoundedControls)
                    { button.BorderRadius = Properties.Settings.Default.BorderRadius; }
                    else
                    { button.BorderRadius = 0; }
                    button.Click += Button_Click;

                    CustomContextMenuStripRenderer customRenderer = new CustomContextMenuStripRenderer();

                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    ToolStripMenuItem moveUpMenuItem = new ToolStripMenuItem("Move Up");
                    moveUpMenuItem.Click += (sender, e) => MoveModItem(mod.ModTitle, -1);
                    contextMenu.Items.Add(moveUpMenuItem);
                    ToolStripMenuItem moveDownMenuItem = new ToolStripMenuItem("Move Down");
                    moveDownMenuItem.Click += (sender, e) => MoveModItem(mod.ModTitle, 1);
                    contextMenu.Items.Add(moveDownMenuItem);

                    ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
                    deleteMenuItem.Click += (sender, e) => DeleteModItem(mod.ModTitle, mod.ModVersion);
                    contextMenu.Items.Add(deleteMenuItem);

                    button.ContextMenuStrip = contextMenu;
                    contextMenu.Renderer = customRenderer;
                    contextMenu.ShowImageMargin = false;
                    contextMenu.BackColor = Properties.Settings.Default.BGTertiary;
                    contextMenu.ForeColor = Properties.Settings.Default.TextColor;

                    currentY += ButtonHeight + VerticalSpacing;
                    PanelModList.Controls.Add(button);
                    AdjustButtonWidths();
                }
            }
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
            // Normal click event
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
                }
                else
                {
                    CNotification.CreateNotif(Color.Red, "Mod not found.");
                }
            }
            else
            {
                CNotification.CreateNotif(Color.Red, "Invalid button text format.");
            }
        }

        private Mod GetModByTitle(string modTitle)
        {
            string json = File.ReadAllText(CModListManager.ModListFilePath);
            List<Mod> modList = JsonConvert.DeserializeObject<List<Mod>>(json);
            Mod clickedMod = modList.Find(mod => mod.ModTitle == modTitle);
            return clickedMod;
        }

        void OpenFileOrFolder(string path)
        {
            var process = new Process();
            try
            {
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = path
                };
                process.Start();
            }
            catch { }
            process.Dispose();
        }


        private void LabelMadeBy_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Papa-Quill/");
        }

        void CopyDirectory(string sourceDir, string destinationDir, bool directoriesOnly, string ProgressMessage)
        {
            ProgressBar.Value = 0;
            LabelProgress.Visible = true; ProgressBar.Visible = true;
            if (!Directory.Exists(destinationDir)) Directory.CreateDirectory(destinationDir);
            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            if (!directoriesOnly)
            {
                foreach (string file in Directory.GetFiles(sourceDir))
                {
                    string targetFilePath = Path.Combine(destinationDir, Path.GetFileName(file));
                    LabelProgress.Text = $"{ProgressMessage}{Path.GetFileName(file)}";
                    File.Copy(file, targetFilePath, true);
                    ProgressBar.Value++;
                    LabelProgress.Refresh();
                }
                LabelProgress.Visible = false; ProgressBar.Visible = false;
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
            {
                string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir, false, ProgressMessage);
            }
        }

        private void CheckGameDir()
        {
            if (!Directory.Exists(Properties.Settings.Default.GameDir))
            {
                CNotification.CreateNotif(Color.White, "Please select your game directory!");
                CFileManager.SelectGameDirectory();
                gameDir = Properties.Settings.Default.GameDir;
                dataFolder = Properties.Settings.Default.GameDir + "\\data";
            }
        }
        #endregion

        #region Header buttons
        private void BtnClose_Click(object sender, EventArgs e)
        {
            List<Form> openForms = CFormUtil.GetAllOpenForms();

            foreach (Form form in openForms)
            {
                CFormUtil.Close(form);
            }
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
            if (!Directory.Exists(gameDir))
                return;
            string backupMessage = "Are you sure you want to create a backup?\nThis may take a while!";
            DialogResult dialogResult = CMessageBox.Show("Create Backup", backupMessage, true);
            if (dialogResult != DialogResult.Yes)
                return;

            try
            {
                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }
                if (Directory.Exists(dataFolder))
                {
                    CNotification.CreateNotif(Color.White, "Backing up data folder: " + dataFolder);
                    ProgressBar.Maximum = DirectoryFileMeasurement(dataFolder, false);
                    CopyDirectory(dataFolder, backupFolder, false, "Restoring Backup: ");
                }
                else
                {
                    CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Could not find: " + dataFolder);
                }
            }
            catch (Exception ex)
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"An error occurred while creating the backup: {ex.Message}");
            }
        }

        private void BtnCloseInfo_Click(object sender, EventArgs e)
        { CFormUtil.CloseAllOpenModInfoForms(); }

        private void BtnRestoreBackup_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            CheckGameDir();
            if (!Directory.Exists(gameDir))
                return;
            if (!Directory.Exists(backupFolder))
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Could not locate a backup!");
                return;
            }
            string backupMessage = "Are you sure you want to restore your backup?\nThis may take a while!";
            DialogResult dialogResult = CMessageBox.Show("Restore Backup", backupMessage, true);
            if (dialogResult != DialogResult.Yes)
                return;

            try
            {
                CNotification.CreateNotif(Color.White, gameDir);
                if (Directory.Exists(dataFolder))
                {
                    Directory.Delete(dataFolder, true);
                    Directory.CreateDirectory(dataFolder);
                    ProgressBar.Maximum = DirectoryFileMeasurement(backupFolder, false);
                    CopyDirectory(backupFolder, dataFolder, false, "Restoring Backup: ");
                }
                else
                {
                    Directory.CreateDirectory(dataFolder);
                    ProgressBar.Maximum = DirectoryFileMeasurement(backupFolder, false);
                    CopyDirectory(backupFolder, dataFolder, false, "Restoring Backup: ");
                }
            }
            catch (Exception ex)
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"An error occurred while restoring the backup: {ex.Message}");
            }
        }

        private void BtnBackupSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "//saves"))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "//saves");
            if (Directory.Exists(userDataFolder))
            {
                bool backedAtLeastOne = false;
                foreach (string userID in Directory.GetDirectories(userDataFolder))
                {
                    if (File.Exists(userID + "\\204360\\remote\\cc_save.dat"))
                    {
                        backedAtLeastOne = true;
                        File.Copy
                            (
                            userID + "\\204360\\remote\\cc_save.dat",
                            AppDomain.CurrentDomain.BaseDirectory + $"\\saves\\cc_save.{Path.GetFileName(userID)}.dat", true
                            );
                    }
                }
                if (backedAtLeastOne) CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, $"Backed saves to: {AppDomain.CurrentDomain.BaseDirectory}saves");
            }
            else CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"No Directory found at:{Environment.NewLine}{userDataFolder}");
        }

        private void BtnRestoreSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\saves"))
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "No save back ups found!");
                return;
            }
            string a = AppDomain.CurrentDomain.BaseDirectory + "\\saves";
            foreach (string file in Directory.GetFiles(a))
            {
                string fileName = Path.GetFileName(file);
                if (fileName.StartsWith("cc_save.") && fileName.EndsWith(".dat"))
                {
                    string userID = fileName.Substring(8, fileName.Length - 12);
                    if (Directory.Exists(userDataFolder + $"\\{userID}\\204360\\remote"))
                    {
                        File.Copy(file, userDataFolder + $"\\{userID}\\204360\\remote\\cc_save.dat", true);
                        CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "Save restored from backup!");
                    }
                }
            }
        }
        #endregion
    }
}