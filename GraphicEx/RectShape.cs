using System;
using System.Drawing;

namespace GraphicEx
{
    public class RectShape : Shape, IFillable
    {
        private bool fill = false;
        private Brush brush = Brushes.White;
        public RectShape(Graphics graphics) : base(graphics)
        {
        }

        public override void Draw()
        {
            float bigx = started.X < ended.X ? started.X : ended.X;
            float bigy = started.Y < ended.Y ? started.Y : ended.Y;
            if (fill) graphics.FillRectangle(brush, bigx, bigy, Math.Abs(ended.X - started.X), Math.Abs(ended.Y - started.Y));
            graphics.DrawRectangle(pen, bigx, bigy, Math.Abs(ended.X - started.X), Math.Abs(ended.Y - started.Y));
        }
        public void setFill(bool fill, Brush brush)
        {
            this.fill = fill;
            this.brush = brush;
        }
    }
}