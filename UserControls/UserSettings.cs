using QMM.Util;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QMM
{
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();
            BtnToolTips.Checked = Properties.Settings.Default.ToolTips;
            BtnFormShadows.Checked = Properties.Settings.Default.FormShadows;
            BtnRoundButtons.Checked = Properties.Settings.Default.RoundedControls;
            TxtRoundAmount.Text = Properties.Settings.Default.BorderRadius.ToString();
            RefreshSettingsTheme();
        }

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
            if (e.Button == MouseButtons.Left) { CFormUtil.GrabWindow(this.Handle); }
        }

        private void RefreshSettingsTheme()
        {
            var controlsToModify = new Control[] {
                BtnClose, BtnMinimize, BtnSave, BtnSelectGameDir,
                BtnSave, BtnSelectColor, BtnSetButton, BtnSetDetail,
                BtnSetDetailActive, BtnSetPlaceholder, BtnSetPrimary, BtnSetSecondary,
                BtnSetTertiary, BtnSetText, BtnToolTips, TxtColorInput,
                TxtRoundAmount, TxtColorInput, ComboBoxThemes, BtnFormShadows,
                BtnRoundButtons, BtnResetSettings, BtnOpenAppDir, BtnOpenGameDir,
                BtnOpenSavesDir, BtnSelectUserDataDir };

            CUpdateTheme.Refresh(this, controlsToModify);
        }
        #endregion

        #region Hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                BtnSave.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                BtnClose.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                BtnClose.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.K))
            {
                Properties.Settings.Default.HotKeyForm = "Settings";
                FHotKeys HotKeys = new FHotKeys(); HotKeys.Show();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Functions
        private void InvalidColor()
        {
            CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Invalid Color! Example: #00FFFF or Cyan");
        }

        void CopyDirectory(string sourceDir, string destinationDir, bool directoriesOnly, string progressMessage)
        {
            if (!Directory.Exists(destinationDir)) Directory.CreateDirectory(destinationDir);
            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            if (!directoriesOnly)
            {
                foreach (string file in Directory.GetFiles(sourceDir))
                {
                    string targetFilePath = Path.Combine(destinationDir, Path.GetFileName(file));
                    File.Copy(file, targetFilePath, true);
                }
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
            {
                string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir, false, progressMessage);
            }
        }

        private void TxtNumCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void ResetSettings()
        {
            try
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "Settings reset!");
                RefreshSettingsTheme();
            }
            catch (Exception ex)
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"Failed to reset settings! Error: {ex.Message}");
            }
        }
        #endregion

        #region Header buttons
        private void BtnClose_Click(object sender, EventArgs e)
        { CFormUtil.Close(this); }

        private void BtnMinimize_Click(object sender, EventArgs e)
        { CFormUtil.MinimizeWindow(); }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Save();
                Settings settings = new Settings();
                settings.SaveSettingsToJson();
                CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "Save Successful!");
            }
            catch (Exception ex)
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, $"Save Failed! Error: {ex.Message}");
            }
        }

        private void BtnResetSettings_Click(object sender, EventArgs e)
        {
            const string MsgBoxMessage = "Are you sure you want to reset all settings?\nThis cannot be reversed!";
            DialogResult dgresult = CMessageBox.Show("Reset Settings", MsgBoxMessage, true);
            if (dgresult == DialogResult.Yes)
            {
                ResetSettings();
            }
        }
        #endregion

        #region Button functions
        private void BtnColor_Click(object sender, EventArgs e)
        {
            using (FColorSelector ColorSelector = new FColorSelector())
            {
                DialogResult result = ColorSelector.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string htmlColor = ColorTranslator.ToHtml(Properties.Settings.Default.SelectedColor);
                    TxtColorInput.Text = htmlColor;
                }
            }
        }

        private void SetColor(Action<Color> setColorAction)
        {
            try
            {
                setColorAction(ColorTranslator.FromHtml(TxtColorInput.Text.Trim()));
                MainForm.RefreshQueued = true;
            }
            catch (Exception)
            {
                InvalidColor();
            }
        }

        private void BtnSetPrimary_Click(object sender, EventArgs e)
        {
            SetColor(color => Properties.Settings.Default.BGPrimary = color);
        }

        private void BtnSetSecondary_Click(object sender, EventArgs e)
        {
            SetColor(color => Properties.Settings.Default.BGSecondary = color);
        }

        private void BtnSetTertiary_Click(object sender, EventArgs e)
        {
            SetColor(color => Properties.Settings.Default.BGTertiary = color);
        }

        private void BtnSetDetail_Click(object sender, EventArgs e)
        {
            SetColor(color => Properties.Settings.Default.DetailColor = color);
        }

        private void BtnSetButton_Click(object sender, EventArgs e)
        {
            SetColor(color => Properties.Settings.Default.ButtonColor = color);
        }

        private void BtnSetText_Click(object sender, EventArgs e)
        {
            SetColor(color => Properties.Settings.Default.TextColor = color);
        }

        private void BtnSetDetailActive_Click(object sender, EventArgs e)
        {
            SetColor(color =>
            {
                Properties.Settings.Default.DetailActive = color;
                RefreshSettingsTheme();
            });
        }

        private void BtnSetPlaceholder_Click(object sender, EventArgs e)
        {
            SetColor(color => Properties.Settings.Default.PlaceholderColor = color);
        }

        private void BtnToolTips_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ToolTips = !Properties.Settings.Default.ToolTips;
        }

        private void BtnFormShadows_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormShadows = !Properties.Settings.Default.FormShadows;
        }

        private void BtnRoundControls_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RoundedControls = !Properties.Settings.Default.RoundedControls;
            RefreshSettingsTheme();
        }

        private void BtnOpenGameDir_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Properties.Settings.Default.GameDir))
            {
                CNotification.CreateNotif(Color.White, "Please select your game directory!");
                CFileManager.SelectGameDirectory();
            }
            Process.Start("explorer.exe", Properties.Settings.Default.GameDir);
        }

        private void BtnOpenSavesDir_Click(object sender, EventArgs e)
        {
            foreach (string userID in Directory.GetDirectories(Properties.Settings.Default.UserDataDir))
            {
                if (Directory.Exists(userID + "\\204360\\remote"))
                {
                    Process.Start("explorer.exe", userID + "\\204360\\remote");
                    return;
                }
            }
            CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Could not find Castle Crashers userdata directory!");
        }

        private void BtnSelectGameDir_Click(object sender, EventArgs e)
        {
            CFileManager.SelectGameDirectory();
        }

        private void BtnSelectUserDataDir_Click(object sender, EventArgs e)
        {
            CFileManager.SelectUserDataDirectory();
        }

        private void BtnOpenAppDir_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory);
        }
        #endregion

        #region Other control functions
        private void ComboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxThemes.SelectedIndex)
            {
                case 1: // Simple Dark
                    SetThemeSettings("#1c1c1c", "#222222", "#323232", "#424242", "Red", "#1a1a1a", "White", "#c1c8cf");
                    break;
                case 2: // Simple Light
                    SetThemeSettings("#acacac", "#b2b2b2", "#c2c2c2", "#d2d2d2", "Cyan", "#aaaaaa", "Black", "#606060");
                    break;
                case 3: // GCT v2
                    SetThemeSettings("#101014", "#14141A", "#19191f", "#3c3c42", "Cyan", "#101014", "White", "#c1c8cf");
                    break;
                case 4: // Cosmos
                    SetThemeSettings("#16141C", "#1A1926", "#292246", "#C4B7FF", "#8D50EB", "#16141C", "#F5F4F2", "#C4B7FF");
                    break;
                case 5: // Rosé Pine
                    SetThemeSettings("#191724", "#1f1d2e", "#26233a", "#c4a7e7", "#9ccfd8", "#191724", "#e0def4", "#6e6a86");
                    break;
                case 6: // Rosé Pine Moon
                    SetThemeSettings("#232136", "#2a273f", "#393552", "#c4a7e7", "#9ccfd8", "#232136", "#e0def4", "#6e6a86");
                    break;
                default:
                    break;
            }
            RefreshSettingsTheme();
        }

        private void SetThemeSettings(string primary, string secondary, string tertiary, string detail, string detailActive, string button, string text, string placeholder)
        {
            Properties.Settings.Default.BGPrimary = ColorTranslator.FromHtml(primary);
            Properties.Settings.Default.BGSecondary = ColorTranslator.FromHtml(secondary);
            Properties.Settings.Default.BGTertiary = ColorTranslator.FromHtml(tertiary);
            Properties.Settings.Default.DetailColor = ColorTranslator.FromHtml(detail);
            Properties.Settings.Default.DetailActive = ColorTranslator.FromHtml(detailActive);
            Properties.Settings.Default.ButtonColor = ColorTranslator.FromHtml(button);
            Properties.Settings.Default.TextColor = ColorTranslator.FromHtml(text);
            Properties.Settings.Default.PlaceholderColor = ColorTranslator.FromHtml(placeholder);
        }

        private void TxtRoundAmount_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtRoundAmount.Text, out int value))
            {
                if (value < 0)
                {
                    TxtRoundAmount.Text = "0";
                    value = 0;
                }
                else if (value > 15)
                {
                    TxtRoundAmount.Text = "15";
                    value = 15;
                }

                Properties.Settings.Default.BorderRadius = value;
            }
            else
            {
                TxtRoundAmount.Text = "0";
                Properties.Settings.Default.BorderRadius = 0;
            }

            RefreshSettingsTheme();
        }

        #endregion

        #region ToolTips
        private void BtnToolTips_MouseHover(object sender, EventArgs e)
        { CToolTipUtil.SetToolTipWithBypass(BtnToolTips, "Toggle tool tips (this pop up when you hover over certain things)"); }

        private void BtnSave_MouseHover(object sender, EventArgs e)
        { CToolTipUtil.SetToolTip(BtnSave, "Save Changes"); }

        private void TxtRoundAmount_MouseHover(object sender, EventArgs e)
        { CToolTipUtil.SetToolTip(TxtRoundAmount, "The radius/amount you want components to be rounded by"); }

        private void BtnFormShadows_MouseHover(object sender, EventArgs e)
        { CToolTipUtil.SetToolTip(BtnFormShadows, "Give forms drop shadows | Requires the form to restart"); }

        private void BtnRoundControls_MouseHover(object sender, EventArgs e)
        { CToolTipUtil.SetToolTip(BtnRoundButtons, "Rounded amount set in the text box above"); }
        #endregion
    }
}
