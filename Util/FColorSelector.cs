using QMM.Info_Forms;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QMM.Util
{
    public partial class FColorSelector : Form
    {
        #region Variables
        private bool ExitCode = false;
        private readonly Timer fadeTimer = new Timer();
        public static Color SelectedColor;
        #endregion

        public FColorSelector()
        {
            InitializeComponent();
            PanelColorPreview.BorderRadius = Properties.Settings.Default.BorderRadius > 0 ? Properties.Settings.Default.BorderRadius : 1;
            CFormUtil.ApplyRoundedForm(this, PanelColorPreview.BorderRadius);
            var controlsToModify = new Control[] {
                BtnClose, BtnColorPicker, BtnFinishSelection,
                TxtHexColor, TxtRGBColor, PanelColorPreview };
            CUpdateTheme.Refresh(this, controlsToModify);
            PanelColorPreview.MouseClick += PanelColorPreview_MouseClick;   
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

        private void MoveWindow(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { CFormUtil.GrabWindow(this.Handle); }
        }
        #endregion

        #region Hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                BtnFinishSelection.PerformClick();
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
                Properties.Settings.Default.HotKeyForm = "Color";
                FHotKeys HotKeys = new FHotKeys(); HotKeys.Show();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Functions
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
                else { DialogResult = DialogResult.OK; Close(); }
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

        private void Slider_Scroll(object sender, EventArgs e)
        {
            SelectedColor = Color.FromArgb(SliderRed.Value, SliderGreen.Value, SliderBlue.Value);
            PanelColorPreview.FillColor = SelectedColor;
            TxtHexColor.Text = ColorTranslator.ToHtml(SelectedColor);
            TxtRGBColor.Text = SelectedColor.R.ToString() + ", " + SelectedColor.G.ToString() + ", " + SelectedColor.B.ToString();
        }

        private void TxtHexColor_Leave(object sender, EventArgs e)
        {
            if (TxtHexColor.Text == "")
            {
                return;
            }
            try
            {
                SelectedColor = ColorTranslator.FromHtml(TxtHexColor.Text);
                TxtRGBColor.Text = SelectedColor.R.ToString() + ", " + SelectedColor.G.ToString() + ", " + SelectedColor.B.ToString();
                SliderRed.Value = SelectedColor.R; SliderGreen.Value = SelectedColor.G; SliderBlue.Value = SelectedColor.B;
                PanelColorPreview.FillColor = SelectedColor;
                Properties.Settings.Default.SelectedColor = ColorTranslator.FromHtml(TxtHexColor.Text);
            }
            catch (Exception)
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Invalid Hex Color!");
            }
        }

        static bool IsValidRGBColor(string input)
        {
            string pattern = @"^\s*(\d{1,3})\s*,\s*(\d{1,3})\s*,\s*(\d{1,3})\s*$";
            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                int r = int.Parse(match.Groups[1].Value);
                int g = int.Parse(match.Groups[2].Value);
                int b = int.Parse(match.Groups[3].Value);

                if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                {
                    return true;
                }
            }

            return false;
        }

        static Color ConvertToColor(string input)
        {
            string pattern = @"^\s*(\d{1,3})\s*,\s*(\d{1,3})\s*,\s*(\d{1,3})\s*$";
            var match = System.Text.RegularExpressions.Regex.Match(input, pattern);

            if (match.Success)
            {
                int r = int.Parse(match.Groups[1].Value);
                int g = int.Parse(match.Groups[2].Value);
                int b = int.Parse(match.Groups[3].Value);

                if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                {
                    return Color.FromArgb(r, g, b);
                }
            }
            CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Invalid RGB Color!");
            return Color.Black;
        }

        private void TxtRGBColor_Leave(object sender, EventArgs e)
        {
            if (TxtRGBColor.Text == "")
            {
                return;
            }
            if (IsValidRGBColor(TxtRGBColor.Text))
            {
                SelectedColor = ConvertToColor(TxtRGBColor.Text);
                TxtHexColor.Text = ColorTranslator.ToHtml(SelectedColor);
                SliderRed.Value = SelectedColor.R; SliderGreen.Value = SelectedColor.G; SliderBlue.Value = SelectedColor.B;
                PanelColorPreview.FillColor = SelectedColor;
                Properties.Settings.Default.SelectedColor = SelectedColor;
            }
            else
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Invalid RGB Color!");
            }
        }

        private Color GetColorAtCursor()
        {
            Point cursorPos = Cursor.Position;
            Bitmap screenPixel = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(screenPixel))
            {
                g.CopyFromScreen(cursorPos, Point.Empty, new Size(1, 1));
            }

            return screenPixel.GetPixel(0, 0);
        }
        #endregion

        #region Button functions
        private void BtnClose_Click(object sender, EventArgs e)
        { FadeClosing(new FormClosingEventArgs(CloseReason.None, false)); }

        private void BtnFinishSelection_Click(object sender, EventArgs e)
        { Properties.Settings.Default.SelectedColor = SelectedColor; FadeClosing(new FormClosingEventArgs(CloseReason.None, false)); ExitCode = true; }

        private void BtnColorPicker_MouseDown(object sender, MouseEventArgs e)
        { BtnColorPicker.MouseMove += BtnColorPicker_MouseMove; Cursor = Cursors.Cross; }

        private void BtnColorPicker_MouseUp(object sender, MouseEventArgs e)
        { BtnColorPicker.MouseMove -= BtnColorPicker_MouseMove; Cursor = Cursors.Default; }

        private void BtnColorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = GetColorAtCursor();
            SelectedColor = color;
            PanelColorPreview.FillColor = SelectedColor;
            TxtHexColor.Text = ColorTranslator.ToHtml(SelectedColor);
            TxtRGBColor.Text = SelectedColor.R.ToString() + ", " + SelectedColor.G.ToString() + ", " + SelectedColor.B.ToString();
            SliderRed.Value = SelectedColor.R; SliderGreen.Value = SelectedColor.G; SliderBlue.Value = SelectedColor.B;
        }

        private void PanelColorPreview_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtHexColor.Text == "") { CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "No color selected!"); return; }
            if (ModifierKeys == Keys.Control)
            {
                Clipboard.SetText($"RGB: {TxtRGBColor.Text}\nHex: {TxtHexColor.Text}");
                CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "Full color copied to clipboard!");
            }
            else if (e.Button == MouseButtons.Left)
            {
                Clipboard.SetText(ColorTranslator.ToHtml(SelectedColor));
                CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "Hex color copied to clipboard!");
            }
            else if (e.Button == MouseButtons.Right)
            {
                Clipboard.SetText(TxtRGBColor.Text);
                CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "RGB color copied to clipboard!");
            }
        }
        #endregion

        #region Tooltips
        private void BtnColorPicker_MouseHover(object sender, EventArgs e)
        { CToolTipUtil.SetToolTip(BtnColorPicker, "Hold left click on this button then drag your mouse to the color you want on your screen"); }

        private void BtnFinishSelection_MouseHover(object sender, EventArgs e)
        { CToolTipUtil.SetToolTip(BtnFinishSelection, "Apply selected color to input"); }
        #endregion
    }
}