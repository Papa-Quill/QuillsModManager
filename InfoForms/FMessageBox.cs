using QMM.Util;
using System;
using System.Windows.Forms;

namespace QMM.Info_Forms
{
    public partial class FMessageBox : Form
    {
        #region Variables
        private bool ExitCode = false;
        private readonly Timer fadeTimer = new Timer();

        public string BoxMessage
        {
            get { return LabelMessage.Text; }
            set { LabelMessage.Text = value; }
        }
        public string BoxCaption
        {
            get { return LabelTitle.Text; }
            set { LabelTitle.Text = value; }
        }
        public int BoxHeight
        {
            get { return LabelMessage.Height; }
            set { LabelMessage.Height = value; }
        }
        #endregion

        public FMessageBox()
        {
            InitializeComponent();
            Properties.Settings.Default.TxtNotif = LabelMessage.Text;
            int NotifHeight = CountLines(LabelMessage.Text);
            Height = NotifHeight * 24 + 98;
            PanelMessageBox.Height = NotifHeight * 24 + 19;
            var controlsToModify = new Control[] {
                BtnYes, BtnNo, BtnClose };
            CUpdateTheme.Refresh(this, controlsToModify);
            InitializeTimers();
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
        #endregion

        #region Hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                BtnNo.PerformClick();
                return true;
            }
            else if (keyData == (Keys.N))
            {
                BtnNo.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Enter))
            {
                BtnYes.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Y))
            {
                BtnYes.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.K))
            {
                Properties.Settings.Default.HotKeyForm = "MessageBox";
                FHotKeys HotKeys = new FHotKeys(); HotKeys.Show();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Functions
        private int CountLines(string text)
        {
            int count = 1; int position = -1;

            while ((position = text.IndexOf('\n', position + 1)) != -1)
            {
                count++;
            }
            return count;
        }

        private void InitializeTimers()
        {
            fadeTimer.Interval = 50;
            fadeTimer.Tick += FadeOut;
        }

        private void FadeClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            fadeTimer.Start();
        }

        private void FadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                fadeTimer.Stop();
                if (!ExitCode) { DialogResult = DialogResult.No; Close(); }
                else { DialogResult = DialogResult.Yes; Close(); }
            }
            else
                Opacity -= 0.3;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (fadeTimer.Enabled)
                e.Cancel = true;
            else
                base.OnFormClosing(e);
        }
        #endregion

        #region Button functions
        private void BtnClose_Click(object sender, EventArgs e)
        { FadeClosing(new FormClosingEventArgs(CloseReason.None, false)); }

        private void BtnYes_Click(object sender, EventArgs e)
        { FadeClosing(new FormClosingEventArgs(CloseReason.None, false)); ExitCode = true; }
        #endregion
    }
}