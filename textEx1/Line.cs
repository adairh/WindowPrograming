using System.Drawing;

namespace Ex1_t
{
    public class Line : Images
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public Line()
        {
        }

        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, StartPoint, EndPoint);
        }
    }
}