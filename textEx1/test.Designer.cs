using System.Windows.Forms;

namespace Ex1_t
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.plMain = new System.Windows.Forms.Panel();
            this.bth_line = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.Location = new System.Drawing.Point(242, 12);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(524, 425);
            this.plMain.TabIndex = 0;
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            // 
            // bth_line
            // 
            this.bth_line.Location = new System.Drawing.Point(29, 12);
            this.bth_line.Name = "bth_line";
            this.bth_line.Size = new System.Drawing.Size(174, 34);
            this.bth_line.TabIndex = 1;
            this.bth_line.Text = "Line";
            this.bth_line.UseVisualStyleBackColor = true;
            this.bth_line.Click += new System.EventHandler(this.btnDuongThang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bth_line);
            this.Controls.Add(this.plMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bth_line;

        private System.Windows.Forms.Panel plMain;

        #endregion
    }
}