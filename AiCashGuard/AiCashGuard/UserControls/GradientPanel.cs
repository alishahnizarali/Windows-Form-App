
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AiCashGuard.UserControls
{
	public class GradientPanel :  Panel
	{
        public Color RightColor { get; set; }
		public Color LeftColor { get; set; }


		protected override void OnPaint(PaintEventArgs e)
		{
			LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle,this.RightColor,this.LeftColor,45f);
			Graphics g = e.Graphics;
			g.FillRectangle(lgb,this.ClientRectangle);
			base.OnPaint(e);
		}
	}
}
