using QMM.Util;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QMM.Info_Forms
{
    public partial class FModInfo : Form
    {
        #region Variables
        private readonly MainForm mainFormInstance;
        private string modTitle, modAuthor, modVersion, modDescription, modLocation;
        #endregion
        
        public FModInfo(MainForm mainFormInstance, string modTitle, string modAuthor, string modVersion, string modDescription, string modLocation)
        {
            InitializeComponent();
            this.mainFormInstance = mainFormInstance;
            this.modTitle = modTitle;
            this.modAuthor = modAuthor;
            this.modVersion = modVersion;
            this.modDescription = modDescription;
            this.modLocation = modLocation;
            var controlsToModify = new Control[] { BtnLaunchMod, TxtModDescription, TxtModTitle };
            CUpdateTheme.Refresh(this, controlsToModify);
            LoadModData();
            InitializeTimer();
        }

        #region Form Base
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
        #endregion

        #region Functions
        private void LoadModData()
        {
            TxtModTitle.Text = modTitle;
            TxtModDescription.Text = modDescription;
            LabelModAuthor.Text = modAuthor;
            LabelModVersion.Text = "v" + modVersion;
            string modIconPath = Path.Combine(modLocation, "modicon.png");
            ImgIcon.Image = File.Exists(modIconPath) ? Image.FromFile(modIconPath) : Properties.Resources.NoImage;
        }

        private void InitializeTimer()
        {
            Timer locationUpdateTimer = new Timer();
            locationUpdateTimer.Interval = 10;
            locationUpdateTimer.Tick += LocationUpdateTimer_Tick;
            locationUpdateTimer.Start();
        }

        public void SetLocationRelativeToForm1()
        {
            Location = new Point(mainFormInstance.Location.X + 648, mainFormInstance.Location.Y);
        }

        private void LocationUpdateTimer_Tick(object sender, EventArgs e)
        {
            SetLocationRelativeToForm1();
        }
        #endregion

        #region Button Functions
        private void BtnInstallMod_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(modLocation))
            {
                if (Directory.Exists(modLocation))
                {
                    string sourceDir = Path.Combine(modLocation, "data");
                    string destinationDir = Path.Combine(mainFormInstance.gameDir, "data");
                    try
                    {
                        CFileManager.CopyDirectory(sourceDir, destinationDir, false);
                        CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "Mod data copied successfully!");
                    }
                    catch (Exception ex)
                    {
                        CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"An error occurred while copying the data folder: {ex.Message}");
                    }
                }
                else
                {
                    CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "The specified mod location does not exist.");
                }
            }
        }
        #endregion
    }
}