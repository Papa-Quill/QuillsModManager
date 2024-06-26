﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QMM.Util
{
    public partial class FHotKeys : Form
    {
        #region Variables
        private readonly Timer closeTimer = new Timer();
        private readonly Timer fadeTimer = new Timer();
        #endregion

        public FHotKeys()
        {
            InitializeComponent();
            InitializeHotKeyForm();
            InitializeTimers();
        }

        #region Hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape || (keyData == (Keys.Control | Keys.W)))
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Functions
        private void InitializeHotKeyForm()
        {
            var settingsMapping = new Dictionary<string, (int interval, int width, int height, string title, string notification)>
            {
                ["Simple"] = (4000, 232, 102, "Hotkeys - Simple", "Escape = Close Window\r\nCtrl + W = Close Window"),
                ["Main"] = (10000, 285, 190, "Hotkeys - Main", "Escape (x2) = Close Application\r\nCtrl + W (x2) = Close Application\r\nCtrl + A = Add Mod\r\nCtrl + R = Refresh Modlist\r\nCtrl + L = Launch Game\r\nCtrl + E = User Settings"),
                ["Settings"] = (5000, 232, 124, "Hotkeys - Settings", "Escape = Close Window\r\nCtrl + W = Close Window\r\nCtrl + S = Save Settings"),
                ["Color"] = (5000, 232, 124, "Hotkeys - Color", "Escape = Close Window\r\nCtrl + W = Close Window\r\nEnter = Select Color"),
                ["MessageBox"] = (5000, 232, 102, "Hotkeys - Message Box", "Enter or Y = Yes\r\nEscape or N = No")
            };

            if (settingsMapping.TryGetValue(Properties.Settings.Default.HotKeyForm, out var settings))
            {
                (int interval, int width, int height, string title, string notification) = settings;

                closeTimer.Interval = interval;
                Width = width;
                Height = height;
                LabelTitle.Text = title;
                TxtNotif.Text = notification;

                NotifBox.Width = Width - 25;
                NotifBox.Height = Height - 20;
                Location = new Point(0, Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2);

                closeTimer.Tick += CloseTimer_Tick;
                closeTimer.Start();
            }

            if (Properties.Settings.Default.BorderRadius != 0)
                CFormUtil.ApplyRoundedForm(this, Properties.Settings.Default.BorderRadius);
        }

        private void InitializeTimers()
        {
            fadeTimer.Interval = 50;
            fadeTimer.Tick += FadeTimer_Tick;
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Interval = 50;
            if (Opacity <= 0)
            {
                fadeTimer.Stop();
                Close();
            }
            else
                Opacity -= 0.3;
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Interval = 50;
            fadeTimer.Start();
        }
        #endregion

        #region Form Interactions
        private void NotifBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NotifBox_MouseHover(object sender, EventArgs e)
        {
            closeTimer.Enabled = false;
            Opacity = 1;
        }

        private void NotifBox_MouseLeave(object sender, EventArgs e)
        {
            closeTimer.Enabled = true;
        }
        #endregion
    }
}