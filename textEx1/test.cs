using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_t
{
    public partial class Form1 : Form
    {
        Graphics gp;
        bool bLine = false;
        Pen myPen;
        Color myColor;

        Point beginPoint = new Point();//First endpoint
        Point temp = new Point();//First endpoint
        bool isStart=true;//a flag

        private Images drawingImage;

        private List<Images> lim = new List<Images>();
        
        
        public Form1()
        {
            InitializeComponent();
            gp = this.plMain.CreateGraphics();
            myColor = Color.Blue;
            myPen = new Pen(myColor, 5);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            this.bLine = true;
            drawingImage = new Line();
        }
        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("dsad");
            if (this.isStart == true)//first click
            {
                this.beginPoint.X = e.X;
                this.beginPoint.Y = e.Y;
                if (bLine)
                {
                    ((Line)drawingImage).EndPoint = beginPoint;
                    ((Line)drawingImage).StartPoint = beginPoint;
                }

                this.isStart = false;
            }
            
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            if (!isStart)
            {
                Point p2 = new Point();
                p2.X = e.X;
                p2.Y = e.Y;
                //Draw a line
                ((Line)drawingImage).EndPoint = p2;
                this.bLine = false;
                this.isStart = true;
                
                lim.Add(drawingImage);
                foreach (Images i in lim)
                {
                    i.Draw(gp, myPen);
                }
            }
            plMain.Invalidate();
            foreach (Images i in lim)
            {
                i.Draw(gp, myPen);
            }
        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isStart)
            {
                if (bLine)
                {
                    
                    //MessageBox.Show(((Line)drawingImage).StartPoint.ToString() + "\n" + ((Line)drawingImage).EndPoint.ToString());
                    temp.X = e.X;
                    temp.Y = e.Y;
                    ((Line)drawingImage).EndPoint = temp;
                    plMain.Invalidate();
                    foreach (Images i in lim)
                    {
                        i.Draw(gp, myPen);
                    }
                    drawingImage.Draw(gp, myPen);
                }
            }
        }
    }
}