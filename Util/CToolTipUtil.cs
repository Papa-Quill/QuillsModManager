using System;
using System.Windows.Forms;

namespace QMM.Util
{
    public static class CToolTipUtil
    {
        private static CustomToolTip customToolTip;

        public static void SetToolTip(Control control, string tooltipText)
        {
            if (Properties.Settings.Default.ToolTips)
            {
                customToolTip?.Dispose();
                customToolTip = new CustomToolTip();
                customToolTip.SetToolTip(control, tooltipText);
            }
        }

        public static void SetToolTipWithBypass(Control control, string tooltipText)
        {
            customToolTip?.Dispose();
            customToolTip = new CustomToolTip();
            customToolTip.SetToolTip(control, tooltipText);
        }

        public static void ToolTipLeave(object sender, EventArgs e)
        {
            customToolTip?.Dispose();
        }
    }
}