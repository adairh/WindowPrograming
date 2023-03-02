using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        Graphics gp;
        //bool bLine = false;

        private mode m = mode.None;
        
        Pen myPen;
        Brush myBrush;
        Color myColor;

        Point beginPoint = new Point();//First endpoint
        bool isStart=true;//a flag
        public Form1()
        {
            InitializeComponent();
            gp = this.plMain.CreateGraphics();
            myColor = Color.Blue;
            myPen = new Pen(myColor, 5);
            myBrush = Brushes.Aqua;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            //this.bLine = true;
            m = mode.Line;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            m = mode.Rect;
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            m = mode.FilledRect;
        }
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            m = mode.Eclipse;
        }
        
        
        private void button4_Click(object sender, EventArgs e)
        {
            m = mode.FilledEclipse;
        }
        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.isStart == true)//first click
            {
                this.beginPoint.X = e.X;
                this.beginPoint.Y = e.Y;
                this.isStart = false;
            }
            else
            {
                Point p1 = new Point();
                Point p2 = new Point();
                p1 = this.beginPoint;
                p2.X = e.X;
                p2.Y = e.Y;
                //Draw a line
                switch (m)
                {
                  case mode.Line:
                  {
                      gp.DrawLine(myPen, p1, p2);
                      break;
                  }
                  case mode.Rect:
                  {
                      float bigx = p1.X < p2.X ? p1.X : p2.X;
                      float bigy = p1.Y < p2.Y ? p1.Y : p2.Y;
                      gp.DrawRectangle(myPen, bigx, bigy, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                      break;
                  }
                  case mode.FilledRect:
                  {
                      float bigx = p1.X < p2.X ? p1.X : p2.X;
                      float bigy = p1.Y < p2.Y ? p1.Y : p2.Y;
                      gp.FillRectangle(myBrush, bigx, bigy, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                      gp.DrawRectangle(myPen, bigx, bigy, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                      break;
                  }
                  case mode.Eclipse:
                  {
                      float bigx = p1.X < p2.X ? p1.X : p2.X;
                      float bigy = p1.Y < p2.Y ? p1.Y : p2.Y;
                      gp.DrawEllipse(myPen, bigx, bigy, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                      break;
                  }
                  case mode.FilledEclipse:
                  {
                      float bigx = p1.X < p2.X ? p1.X : p2.X;
                      float bigy = p1.Y < p2.Y ? p1.Y : p2.Y;
                      gp.FillEllipse(myBrush, bigx, bigy, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                      gp.DrawEllipse(myPen, bigx, bigy, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                      break;
                  }
                }
                this.isStart = true;
                this.m = mode.None;
            }
        }

        


        enum mode
        {
            Line, Rect, FilledRect, Eclipse, FilledEclipse, None
        }

    }
}