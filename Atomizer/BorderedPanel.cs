using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Atomizer
{
    public class BorderedPanel : Panel
    {
        private Color borderColor = Color.Black;
        private int borderThickness = 1;
		
		public Color BorderColor
		{
			get
			{
				return borderColor;
			}
			set
			{
				borderColor = value;
				Invalidate();
			}
		}
		public int BorderThickness
		{
			get
			{
				return borderThickness;
			}
			set
			{
                borderThickness = value;
				Invalidate();
			}
		}
		
        public BorderedPanel()
            : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rc = this.ClientRectangle;
            rc.X += borderThickness - 1;
            rc.Y += borderThickness - 1;
            rc.Width -= borderThickness;
            rc.Height -= borderThickness;
            e.Graphics.DrawRectangle(
                new Pen(
                    new SolidBrush(borderColor), borderThickness),
                    rc);
        }
    }
}
