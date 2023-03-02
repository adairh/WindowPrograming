using System;
using System.Windows.Forms;

namespace w2_01
{
    public partial class CheckBoxExample : Form
    {
        public CheckBoxExample()
        {
            InitializeComponent();
        }

        public void check(object sender, EventArgs e)
        {
            bool c = checkBox1.Checked;
            MessageBox.Show("You " + (c ? "" : "un") + "checked the box");
            checkBox1.Text = (c ? "un" : "") + "check me!";
        }
    }
}