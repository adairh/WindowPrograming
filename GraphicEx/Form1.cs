using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEx
{
    public partial class Form1 : Form
    {
        Graphics gp;
        private Bitmap bitmap;
        private List<Shape> shapes;
        private mode m = mode.None;
        private Point tempPoint;
        bool isStart=true;//a flag

        private Shape currentShape;
        
        
        private Shape movingShape;
        private Point clickedMovePoint;
        
        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            gp = this.plMain.CreateGraphics();
            tempPoint = new Point();
        }
        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            //this.bLine = true;
            m = mode.Line;
            currentShape = new LineShape(gp);
        }
        private void btnRect_Click(object sender, EventArgs e)
        {
            m = mode.Rect;
            currentShape = new RectShape(gp);
        }
        
        
        private void btnFilledRect_Click(object sender, EventArgs e)
        {
            m = mode.FilledRect;
            currentShape = new RectShape(gp, true);
        }
        
        
        private void btnEclipse_Click(object sender, EventArgs e)
        {
            m = mode.Eclipse;
            currentShape = new ElipseShape(gp);
        }
        
        
        private void btnFilledEclipse_Click(object sender, EventArgs e)
        {
            m = mode.FilledEclipse;
            currentShape = new ElipseShape(gp, true);
        }
        
        private void btnArc_Click(object sender, EventArgs e)
        {
            m = mode.Arc;
            currentShape = new ArcShape(gp);
            currentShape.tools.data.Add(arcAngleBar.Value);
        }
        
        private void btnPolygon_Click(object sender, EventArgs e)
        {
            m = mode.Polygon;
            currentShape = new PolygonShape(gp);
            currentShape.tools.data.Add((int)polygonNum.Value);
        }
        private void btnFilledPolygon_Click(object sender, EventArgs e)
        {
            m = mode.FilledPolygon;
            currentShape = new PolygonShape(gp, true);
            currentShape.tools.data.Add((int)polygonNum.Value);
        }
        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape == null)
            {
                movingShape = getShapeAt(e.Location);
                if (movingShape != null)
                { 
                    clickedMovePoint = e.Location;
                }
                
                return;
            }
            if (isStart)//first click
            {
                this.tempPoint.X = e.X;
                this.tempPoint.Y = e.Y;
                this.isStart = false;
                currentShape.tools.pen = new Pen(penColor.Color, trackBar1.Value);
                currentShape.tools.brush = new SolidBrush(brushColor.Color);
                currentShape.started = tempPoint;
            }
        }


        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isStart) //first click
            {
                /*Point p1 = new Point();
                Point p2 = new Point();
                p1 = this.beginPoint;
                p2.X = e.X;
                p2.Y = e.Y;
                //Draw a line
                currentShape.ended = p2;*/
                //currentShape.Draw();
                
                this.isStart = true;
                this.m = mode.None;
                shapes.Add(currentShape);
                currentShape.finishDraw();
                currentShape = null;
            }
            else
            {
                clickedMovePoint = new Point();
                movingShape = null;
            }
        }
        
        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isStart == false)
            {
                tempPoint.X = e.X;
                tempPoint.Y = e.Y;
                currentShape.ended = tempPoint;
                currentShape.Drawing(plMain);
                foreach (Shape s in shapes)
                {
                    s.Draw();
                }
            }
            else
            {
                if (movingShape != null)
                {
                    movingShape.started.X += e.X - clickedMovePoint.X;
                    movingShape.started.Y += e.Y - clickedMovePoint.Y;
                    
                    movingShape.ended.X += e.X - clickedMovePoint.X;
                    movingShape.ended.Y += e.Y - clickedMovePoint.Y;
                    
                    clickedMovePoint = e.Location;
                    movingShape.Drawing(plMain);
                    foreach (Shape s in shapes)
                    {
                        s.Draw();
                    }
                }
            }
            

        }

        private int tSX, tSY, tEX, tEY, coX, coY;
        private void plMain_MouseWheel(object sender, MouseEventArgs e)
        {
            Shape alter = getShapeAt(e.Location);
            if (alter == null) return;
            // Get the number of scrolling steps.
            int scrollDelta = e.Delta;
            //
            // MessageBox.Show((alter.ended.X - alter.started.X) / alter.getDistance() * 5 + " " +
            //                 (alter.ended.Y - alter.started.Y) / alter.getDistance() * 5);
            coX = (int)((double)(alter.ended.X - alter.started.X) / alter.getDistance() * 10);
            coY = (int)((double)(alter.ended.Y - alter.started.Y) / alter.getDistance() * 10);
            
            if (scrollDelta > 0)
            {
                tSX = alter.started.X - coX;
                tSY = alter.started.Y - coY;
                    
                tEX = alter.ended.X + coX;
                tEY = alter.ended.Y + coY;
            }
            else
            {
                tSX = alter.started.X + coX;
                tSY = alter.started.Y + coY;
                    
                tEX = alter.ended.X - coX;
                tEY = alter.ended.Y - coY;
            }
            
            if (/*tSX <= 0 
                || tSY <= 0
                || tEX >= plMain.Bounds.Width
                || tEY >= plMain.Bounds.Height
                ||*/ tSX >= tEX 
                || tSY >= tEY)
            {
                //return;
            }

            alter.started.X = tSX;
            alter.started.Y = tSY;

            alter.ended.X = tEX;
            alter.ended.Y = tEY;
            
            alter.Drawing(plMain);
            foreach (Shape s in shapes)
            {
                s.Draw();
            }
        }

        enum mode
        {
            Line, Rect, FilledRect, Eclipse, FilledEclipse, Arc, Polygon, FilledPolygon, None
        }

        private void btnBrushColor(object sender, EventArgs e)
        {
            brushColor.ShowDialog();
        }
        
        private void btnPenColor(object sender, EventArgs e)
        {
            penColor.ShowDialog();
        }

        private Shape getShapeAt(Point p)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.bounds.Contains(p))
                {
                    return shape;
                }
            }

            return null;
        }
    }
}