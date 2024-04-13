using QMM.Util;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QMM.Info_Forms
{
    public partial class MainInfoForm : Form
    {
        public MainInfoForm()
        {
            InitializeComponent();
            var controlsToModify = new Control[] { BtnClose, BtnJoinDiscord, BtnOpenRepo };
            CUpdateTheme.Refresh(this, controlsToModify);
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

        private void MoveWindow(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CFormUtil.GrabWindow(this.Handle);
            }
        }
        private void MainInfoForm_MouseHover(object sender, EventArgs e)
        {
            var controlsToModify = new Control[] { BtnClose };
            CUpdateTheme.Refresh(this, controlsToModify);
        }
        #endregion

        #region Hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
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
                Properties.Settings.Default.HotKeyForm = "Simple";
                FHotKeys HotKeys = new FHotKeys(); HotKeys.Show();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Header buttons
        private void BtnClose_Click(object sender, EventArgs e)
        { CFormUtil.Close(this); }
        #endregion

        private void LabelWatermark_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Papa-Quill/");
        }

        private void BtnJoinDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/NdPYPbUncU");
        }
    }
}