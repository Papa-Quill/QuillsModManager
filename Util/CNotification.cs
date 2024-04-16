using QMM.Info_Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QMM.Util
{
    public static class CNotification
    {
        public static void CreateNotif(Color NotifColor, string NotifText)
        {
            Form OriginalForm = Form.ActiveForm;
            if (OriginalForm != null)
            {
                try
                {
                    Properties.Settings.Default.NotifColor = NotifColor;
                    Properties.Settings.Default.TxtNotif = NotifText;
                    FNotification notif = new FNotification();
                    notif.Show();
                    OriginalForm.Focus();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while creating/showing notification: {ex.Message}");
                }
            }
        }
    }
}