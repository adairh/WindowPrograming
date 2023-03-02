using System.Drawing;

namespace GraphicEx
{
    public class LineShape : Shape
    {
        public LineShape(Graphics graphics) : base(graphics)
        { 
        }
        public override void Draw()
        {
            graphics.DrawLine(pen, started, ended);
        }
    }
}