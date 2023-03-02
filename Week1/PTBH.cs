using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class PTBH : Form
    {
        public PTBH()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (aTextBox.Text.Length == 0 || bTextBox.Text.Length == 0 || cTextBox.Text.Length == 0)
                MessageBox.Show("Chua nhap");
            else 
                try
                {
                    //ax^2 +- bx +- c = 0
                    double a = Convert.ToDouble(aTextBox.Text);
                    double b = Convert.ToDouble(bTextBox.Text);
                    double c = Convert.ToDouble(cTextBox.Text);
                    
                    if (a == 0)
                    {
                        if (b == 0)
                        {
                            if (c != 0) resultBox.Text = "PTVN";
                            else resultBox.Text = "PTVSN";
                        } else
                        {
                            resultBox.Text = (-c / b) + "";
                        }
                    }
                    else
                    {
                        double delta = b * b - 4 * a * c;
                        if (delta > 0)
                        {
                            resultBox.Text = "";
                            resultBox.AppendText("x1 = " + ((-Math.Sqrt(delta)-b)/(2*a)));
                            resultBox.AppendText(Environment.NewLine);
                            resultBox.AppendText("x2 = " + ((Math.Sqrt(delta)-b)/(2*a)));
                        } else if (delta == 0)
                        {
                            resultBox.Text = "x = " + (-b/(2*a));
                        } else if (delta < 0)
                        {
                            resultBox.Text = "PTVN";
                        }
                    }
                    
                }
                catch (FormatException e1)
                {
                    MessageBox.Show("Nhap sai");
                }
                catch (Exception e3)
                {
                    MessageBox.Show("Loi");
                }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            aTextBox.Text = "";
            bTextBox.Text = "";
            cTextBox.Text = "";
            resultBox.Text = "";
        }

        private void escButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}