using System.Drawing;
using System.Windows.Forms;

namespace GraphicEx
{
    public abstract class Shape
    {

        public Pen pen;
        public Point started, ended;
        protected Graphics graphics;

        public Shape(Graphics graphics)
        {
            pen = new Pen(Color.Black); 
            this.graphics = graphics;
        }
        
        public abstract void Draw();

        public void Drawing(Panel p)
        {
            p.Refresh();
            Draw();
        }
    }
}