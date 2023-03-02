using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace w2_01
{
    partial class CheckedListboxExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            this.checkedListBox1.Location = new System.Drawing.Point(58, 84);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(69, 94);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += (this.checkedListBox1_SelectedValueChanged);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(264, 155);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(100, 23);
            this.count.TabIndex = 1;
            this.count.Text = "You pick 0 boxes";
            // 
            // CheckedListboxExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.count);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "CheckedListboxExample";
            this.Text = "CheckedListboxExample";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label count;

        private System.Windows.Forms.CheckedListBox checkedListBox1;

        #endregion
    }
}