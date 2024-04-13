using System.Drawing;
using System.Windows.Forms;

namespace QMM.Util
{
    public class CustomContextMenuStripRenderer : ToolStripProfessionalRenderer
    {
        public CustomContextMenuStripRenderer()
            : base(new CustomProfessionalColors())
        {
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            // Set the background color
            e.ToolStrip.BackColor = Properties.Settings.Default.BGTertiary; // Change to the color you desire

            base.OnRenderToolStripBackground(e);
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            // Set the text color
            e.TextColor = Properties.Settings.Default.TextColor; // Change to the color you desire

            base.OnRenderItemText(e);
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            // Do nothing to remove the image margin
        }
    }

    public class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Properties.Settings.Default.BGTertiary; } // Change to the color you desire
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Properties.Settings.Default.BGTertiary; } // Change to the color you desire
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return Properties.Settings.Default.BGTertiary; } // Change to the color you desire
        }

        public override Color MenuItemBorder
        {
            get { return Properties.Settings.Default.DetailActive; } // Set to Transparent to remove borders
        }
    }
}