using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphicEx
{
    public abstract class Shape
    {

        public static int ii = 0;
        public int id = 0;
        public RectangleF bounds;
        public Tools tools;
        public Point started, ended;
        protected Graphics graphics;
        protected GraphicsPath path;
        public Shape(Graphics graphics)
        {
            id = ii;
            ii++;
            tools = new Tools();
            path = new GraphicsPath();
            this.graphics = graphics;
            bounds = new RectangleF();
        }
        
        public abstract void Draw();

        public void Drawing(Panel p)
        {
            bounds.X = started.X < ended.X ? started.X : ended.X;
            bounds.Y = started.Y < ended.Y ? started.Y : ended.Y;
            bounds.Width = Math.Abs(ended.X - started.X);
            bounds.Height = Math.Abs(ended.Y - started.Y);
            p.Refresh();
            Draw();
        }


        public double getDistance()
        {
            return (Math.Sqrt((started.X - ended.X) * (started.X - ended.X) +
                       (started.Y - ended.Y) * (started.Y - ended.Y)));
        }
        public abstract void finishDraw();

        public GraphicsPath getPath()
        {
            return path;
        }

        public int getID()
        {
            return id;
        }
    }
}