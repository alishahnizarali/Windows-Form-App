using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using Panel = System.Windows.Forms.Panel;

namespace AiCashGuard.UserControls
{
    internal class RoundedPanel :  Panel
    {
		
		public int CornerRadius { get; set; } = 20;

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			using (GraphicsPath path = new GraphicsPath())
			{
				int radius = CornerRadius;

				path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
				path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
				path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
				path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner
				path.CloseAllFigures();

				this.Region = new Region(path);
			}
		}

		protected override void OnResize(System.EventArgs e)
		{
			base.OnResize(e);
			Invalidate(); 
		}
	}
}
