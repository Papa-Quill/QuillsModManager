using Guna.UI2.WinForms;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace QMM.Util
{
    public static class CUpdateTheme
    {
        public static void Refresh(Form form, Control[] controlsToModify)
        {
            int borderRadius = Properties.Settings.Default.BorderRadius;
            Color detailActiveColor = Properties.Settings.Default.DetailActive;
            bool roundedControls = Properties.Settings.Default.RoundedControls;

            CFormUtil.ApplyRoundedForm(form, borderRadius > 0 ? borderRadius : 1);

            foreach (var control in controlsToModify)
            {
                if (control is Guna2Button button)
                {
                    button.HoverState.BorderColor = detailActiveColor;
                    button.CheckedState.BorderColor = detailActiveColor;
                    button.CustomBorderColor = detailActiveColor;
                    button.BorderRadius = roundedControls ? borderRadius : 0;
                    button.HoverState.FillColor = AdjustBrightness(button.FillColor, 1.2f);
                    button.CheckedState.FillColor = AdjustBrightness(button.FillColor, 1.5f);
                }
                else if (control is Guna2TextBox textBox)
                {
                    textBox.FocusedState.BorderColor = detailActiveColor;
                    textBox.HoverState.BorderColor = detailActiveColor;
                    textBox.BorderRadius = roundedControls ? borderRadius : 0;
                    textBox.HoverState.FillColor = AdjustBrightness(textBox.FillColor, 1.2f);
                    textBox.FocusedState.FillColor = AdjustBrightness(textBox.FillColor, 1.5f);
                }
                else if (control is Guna2ComboBox comboBox)
                {
                    comboBox.FocusedState.BorderColor = detailActiveColor;
                    comboBox.HoverState.BorderColor = detailActiveColor;
                    comboBox.HoverState.FillColor = AdjustBrightness(comboBox.FillColor, 1.2f);
                    comboBox.FocusedState.FillColor = AdjustBrightness(comboBox.FillColor, 1.5f);
                }
            }
        }

        static Color AdjustBrightness(Color color, float factor)
        {
            // Clamp the factor to be within a reasonable range
            factor = Math.Max(0, factor);

            int r = (int)Math.Min(255, color.R * factor);
            int g = (int)Math.Min(255, color.G * factor);
            int b = (int)Math.Min(255, color.B * factor);

            return Color.FromArgb(color.A, r, g, b);
        }
    }
}
