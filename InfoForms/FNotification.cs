using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QMM.Info_Forms
{
    public partial class FNotification : Form
    {
        #region Variables
        readonly Timer CloseTimer = new Timer();
        readonly Timer T1 = new Timer();
        private static readonly List<FNotification> activeNotifications = new List<FNotification>();
        #endregion

        public FNotification()
        {
            InitializeComponent();
            Width = GetTextWidth(Properties.Settings.Default.TxtNotif) + 105;
            NotifBox.Width = GetTextWidth(Properties.Settings.Default.TxtNotif) + 80;

            CloseTimer.Interval = 3000; // 3 secs
            CloseTimer.Tick += FadeOut;
            CloseTimer.Start();

            if (activeNotifications.Any())
            {
                FNotification lastNotification = activeNotifications.Last();
                Location = new Point(0, lastNotification.Bottom);
            }
            else
                Location = new Point(0, 0);

            activeNotifications.Add(this);
            FormClosed += Notification_FormClosed;
            TxtNotif.Text = Properties.Settings.Default.TxtNotif;
            PanelNotifColor.FillColor = Properties.Settings.Default.NotifColor;
        }

        #region Hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Functions
        static int GetTextWidth(string text)
        {
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                using (Font font = new Font("Segoe UI", 12))
                {
                    SizeF size = graphics.MeasureString(text, font);
                    return (int)size.Width;
                }
            }
        }

        private void Notification_FormClosed(object sender, FormClosedEventArgs e)
        {
            activeNotifications.Remove(this);
            foreach (var notification in activeNotifications)
                { notification.Top -= Height; }
        }

        void FadeOut(object sender, EventArgs e)
        {
            CloseTimer.Interval = 50;
            if (Opacity <= 0)
            {
                T1.Stop();
                Close();
            }
            else
                Opacity -= 0.3;
        }
        #endregion

        #region Form interactions
        private void NotifBox_Click(object sender, EventArgs e)
        { Close(); }

        private void NotifBox_MouseHover(object sender, EventArgs e)
        { CloseTimer.Enabled = false; Opacity = 1; }

        private void NotifBox_MouseLeave(object sender, EventArgs e)
        { CloseTimer.Enabled = true; }
        #endregion
    }
}
