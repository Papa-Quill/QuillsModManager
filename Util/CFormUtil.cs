using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using QMM.Info_Forms;
using System.Linq;

namespace QMM.Util
{
    public static class CFormUtil
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void ShowForm<T>() where T : Form, new()
        { T form = new T(); form.Show(); }

        public static void ApplyRoundedForm(Form form, int radius)
        {
            radius *= 3;
            form.FormBorderStyle = FormBorderStyle.None;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(form.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(form.Width - radius, form.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, form.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                form.Region = new Region(path);
            }
        }

        public static void GrabWindow(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        public static void Close(Form form)
        {
            Timer fadeTimer = new Timer
            { Interval = 50 };
            fadeTimer.Tick += (sender, e) =>
            {
                if (form.Opacity <= 0)
                {
                    fadeTimer.Stop();
                    form.Close();
                }
                else
                    form.Opacity -= 0.3;
            };
            fadeTimer.Start();
        }

        public static void MinimizeWindow()
        {
            Form form = Form.ActiveForm;
            if (form != null)
            {
                form.WindowState = FormWindowState.Minimized;
            }
        }

        public static List<Form> GetAllOpenForms()
        {
            List<Form> openForms = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                openForms.Add(form);
            }

            return openForms;
        }

        public static void CloseAllOpenModInfoForms()
        {
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in openForms)
            {
                if (form.GetType() == typeof(FModInfo))
                {
                    CFormUtil.Close(form);
                }
            }
        }
    }
}
