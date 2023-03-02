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
        private List<Shape> shapes;
        Graphics gp;
        //bool bLine = false;

        private mode m = mode.None;
         
        Brush myBrush;


        private Point tempPoint;
        bool isStart=true;//a flag

        private Shape currentShape;
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
        private void button1_Click(object sender, EventArgs e)
        {
            m = mode.Rect;
            currentShape = new RectShape(gp);
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            m = mode.FilledRect;
            currentShape = new RectShape(gp);
            ((RectShape)currentShape).setFill(true, myBrush);
        }
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            m = mode.Eclipse;
            currentShape = new ElipseShape(gp);
        }
        
        
        private void button4_Click(object sender, EventArgs e)
        {
            m = mode.FilledEclipse;
            currentShape = new ElipseShape(gp);
            ((ElipseShape)currentShape).setFill(true, myBrush);
        }
        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape == null) return;
            if (isStart)//first click
            {
                this.tempPoint.X = e.X;
                this.tempPoint.Y = e.Y;
                this.isStart = false;
                currentShape.pen = new Pen(colorDialog1.Color, trackBar1.Value);
                myBrush = new SolidBrush(colorDialog1.Color);
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
                currentShape = null; 
            }
        }
        
        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isStart == false)
            {
                tempPoint.X = e.X;
                tempPoint.Y = e.Y;
                currentShape.ended = tempPoint;
                foreach (Shape s in shapes)
                {
                    s.Draw();
                }
                currentShape.Drawing(plMain);
                
            }

        }

        enum mode
        {
            Line, Rect, FilledRect, Eclipse, FilledEclipse, None
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}