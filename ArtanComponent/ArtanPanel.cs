﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtanComponent
{
	public class ArtanPanel : Panel
	{
		private int borderRadius;
		private float gradientAngle = 90F;
		private Color gradientTopColor = Color.DodgerBlue;
		private Color gradientBottomColor = Color.CadetBlue;

		// Constructor
		public ArtanPanel()
		{
			this.BackColor = Color.White;
			this.ForeColor = Color.Black;
			this.Size = new Size(350, 200);

		}

		// Properties
		public int BorderRadius { get => borderRadius; set { borderRadius = value;this.Invalidate(); } }
		public float GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }
		public Color GradientTopColor { get => gradientTopColor; set { gradientTopColor = value; this.Invalidate(); } }
		public Color GradientBottomColor { get => gradientBottomColor; set { gradientBottomColor = value; this.Invalidate(); } }
		// Methods
		private GraphicsPath GetArtanPath(RectangleF rectangle, float radius)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.StartFigure();
			graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
			graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
			graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
			graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}
		protected override void OnPaint(PaintEventArgs e) { 
			base.OnPaint(e);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			LinearGradientBrush brushArtan = new LinearGradientBrush(this.ClientRectangle,this.GradientTopColor,this.gradientBottomColor,this.gradientAngle);
			Graphics graphicsArtan = e.Graphics;
			graphicsArtan.FillRectangle(brushArtan,ClientRectangle);

			// BorderRadius
			RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
			if (borderRadius > 1)
			{
				using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, borderRadius))
				using (Pen pen = new Pen(this.Parent.BackColor,1))
				{
					this.Region = new Region(graphicsPath);
					e.Graphics.DrawPath(pen, graphicsPath);
				}
			}
			else
			{
				this.Region = new Region(rectangleF);
			}

		}
	}
}
