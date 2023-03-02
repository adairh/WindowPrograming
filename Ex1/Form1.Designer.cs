using System.Drawing;
using System.Windows.Forms;

namespace Ex1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.Location = new System.Drawing.Point(242, 12);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(524, 425);
            this.plMain.TabIndex = 0;
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.BackColor = Color.Beige;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Khung CN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hình CN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Đường Eclipse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "Hình Eclipse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bth_line);
            this.Controls.Add(this.plMain);
            this.BackColor = Color.Coral;
            this.Name = "Form1";
            this.Text = "Ve Hinh";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button bth_line;

        private System.Windows.Forms.Panel plMain;

        #endregion
    }
}