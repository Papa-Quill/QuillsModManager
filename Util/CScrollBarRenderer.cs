using System.Windows.Forms;

namespace QMM.Util
{
    public class CustomScrollbarRenderer : ToolStripSystemRenderer
    {
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            base.OnRenderToolStripBackground(e);
            e.ToolStrip.BackColor = Properties.Settings.Default.BGTertiary;
        }
    }
}