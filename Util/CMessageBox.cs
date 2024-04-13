using System.Windows.Forms;

namespace QMM.Util
{
    internal class CMessageBox
    {
        public static DialogResult Show(string caption, string message, bool dialog = false)
        {
            Properties.Settings.Default.TxtNotif = message;

            using (Info_Forms.FMessageBox NewMessage = new Info_Forms.FMessageBox())
            {
                NewMessage.BoxCaption = caption;
                NewMessage.BoxMessage = message;

                NewMessage.BtnYes.Visible = dialog;
                NewMessage.BtnNo.Visible = dialog;
                NewMessage.BtnClose.Visible = !dialog;

                return NewMessage.ShowDialog();
            }
        }
    }
}