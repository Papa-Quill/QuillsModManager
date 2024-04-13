using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace QMM.Util
{
    public static class CUpdateTheme
    {
        public static void Refresh(Form form, Control[] controlsToModify)
        {
            if (Properties.Settings.Default.BorderRadius != 0)
            {
                CFormUtil.ApplyRoundedForm(form, Properties.Settings.Default.BorderRadius);
            }
            else
            {
                CFormUtil.ApplyRoundedForm(form, 1);
            }

            foreach (var control in controlsToModify)
            {
                if (control is Guna2Button button)
                {
                    button.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                    button.CheckedState.BorderColor = Properties.Settings.Default.DetailActive;
                    if (Properties.Settings.Default.RoundedControls)
                    {
                        button.BorderRadius = Properties.Settings.Default.BorderRadius;
                    }
                    else
                    {
                        button.BorderRadius = 0;
                    }
                }
                else if (control is Guna2TextBox textBox)
                {
                    textBox.FocusedState.BorderColor = Properties.Settings.Default.DetailActive;
                    textBox.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                    if (Properties.Settings.Default.RoundedControls)
                    {
                        textBox.BorderRadius = Properties.Settings.Default.BorderRadius;
                    }
                    else
                    {
                        textBox.BorderRadius = 0;
                    }
                }
                else if (control is Guna2ComboBox comboBox)
                {
                    comboBox.FocusedState.BorderColor = Properties.Settings.Default.DetailActive;
                    comboBox.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        public static void RefreshUC(UserControl control, Control[] controlsToModify)
        {
            foreach (var ctrl in controlsToModify)
            {
                if (ctrl is Guna2Button button)
                {
                    button.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                    button.CheckedState.BorderColor = Properties.Settings.Default.DetailActive;
                    if (Properties.Settings.Default.RoundedControls)
                    {
                        button.BorderRadius = Properties.Settings.Default.BorderRadius;
                    }
                    else
                    {
                        button.BorderRadius = 0;
                    }
                }
                else if (ctrl is Guna2TextBox textBox)
                {
                    textBox.FocusedState.BorderColor = Properties.Settings.Default.DetailActive;
                    textBox.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                    if (Properties.Settings.Default.RoundedControls)
                    {
                        textBox.BorderRadius = Properties.Settings.Default.BorderRadius;
                    }
                    else
                    {
                        textBox.BorderRadius = 0;
                    }
                }
                else if (ctrl is Guna2ComboBox comboBox)
                {
                    comboBox.FocusedState.BorderColor = Properties.Settings.Default.DetailActive;
                    comboBox.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                }
            }
        }
    }
}
