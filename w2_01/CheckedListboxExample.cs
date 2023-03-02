using System;
using System.Windows.Forms;

namespace w2_01
{
    public partial class CheckedListboxExample : Form
    {
        
        public CheckedListboxExample()
        {
            InitializeComponent();
        }

        //private String[] listOfItems = { "A", "B", "C", "D", "E" };

        private int i = 0;
        
        private void checkedListBox1_SelectedValueChanged(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                i++;
            }
            else
            {
                i--;
            }
            
            
            count.Text = "You pick " + i + (i == 1 ? " box" : " boxes");
        }
    }
}