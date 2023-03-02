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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (aTextBox.Text.Length == 0 || bTextBox.Text.Length == 0)
                MessageBox.Show("Chua nhap");
            else
                try
                {
                    //ax +- b = 0
                    double a = Convert.ToDouble(aTextBox.Text);
                    double b = Convert.ToDouble(bTextBox.Text);

                    if (a == 0)
                    {
                        if (b != 0) resultBox.Text = "PTVN";
                        else resultBox.Text = "PTVSN";
                    }
                    else
                    {
                        resultBox.Text = (-b / a) + "";
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
    }
}