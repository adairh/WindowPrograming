using System.Drawing;
using System.Windows.Forms;

namespace GraphicEx
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
            this.rectLineButton = new System.Windows.Forms.Button();
            this.filledRectButton = new System.Windows.Forms.Button();
            this.elipseLineButton = new System.Windows.Forms.Button();
            this.filledElipButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.Beige;
            this.plMain.Location = new System.Drawing.Point(242, 12);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(524, 425);
            this.plMain.TabIndex = 0;
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
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
            // rectLineButton
            // 
            this.rectLineButton.Location = new System.Drawing.Point(29, 52);
            this.rectLineButton.Name = "rectLineButton";
            this.rectLineButton.Size = new System.Drawing.Size(174, 34);
            this.rectLineButton.TabIndex = 2;
            this.rectLineButton.Text = "Khung CN";
            this.rectLineButton.UseVisualStyleBackColor = true;
            this.rectLineButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // filledRectButton
            // 
            this.filledRectButton.Location = new System.Drawing.Point(29, 92);
            this.filledRectButton.Name = "filledRectButton";
            this.filledRectButton.Size = new System.Drawing.Size(174, 34);
            this.filledRectButton.TabIndex = 2;
            this.filledRectButton.Text = "Hình CN";
            this.filledRectButton.UseVisualStyleBackColor = true;
            this.filledRectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // elipseLineButton
            // 
            this.elipseLineButton.Location = new System.Drawing.Point(29, 132);
            this.elipseLineButton.Name = "elipseLineButton";
            this.elipseLineButton.Size = new System.Drawing.Size(174, 34);
            this.elipseLineButton.TabIndex = 2;
            this.elipseLineButton.Text = "Đường Eclipse";
            this.elipseLineButton.UseVisualStyleBackColor = true;
            this.elipseLineButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // filledElipButton
            // 
            this.filledElipButton.Location = new System.Drawing.Point(29, 172);
            this.filledElipButton.Name = "filledElipButton";
            this.filledElipButton.Size = new System.Drawing.Size(174, 34);
            this.filledElipButton.TabIndex = 2;
            this.filledElipButton.Text = "Hình Eclipse";
            this.filledElipButton.UseVisualStyleBackColor = true;
            this.filledElipButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Chọn màu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(29, 352);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(174, 45);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Maximum = 20;
            this.trackBar1.Value = 10;
            this.trackBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filledElipButton);
            this.Controls.Add(this.elipseLineButton);
            this.Controls.Add(this.filledRectButton);
            this.Controls.Add(this.rectLineButton);
            this.Controls.Add(this.bth_line);
            this.Controls.Add(this.plMain);
            this.Name = "Form1";
            this.Text = "Ve Hinh";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button elipseLineButton;
        private System.Windows.Forms.Button filledElipButton;

        private System.Windows.Forms.Button filledRectButton;

        private System.Windows.Forms.Button rectLineButton;

        private System.Windows.Forms.Button bth_line;

        private System.Windows.Forms.Panel plMain;

        #endregion
    }
}