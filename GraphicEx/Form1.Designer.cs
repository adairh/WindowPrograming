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
            this.btnArc = new System.Windows.Forms.Button();
            this.arcAngleBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.polygonNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcAngleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonNum)).BeginInit();
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
            this.plMain.MouseWheel += new MouseEventHandler(this.plMain_MouseWheel);
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
            this.rectLineButton.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // filledRectButton
            // 
            this.filledRectButton.Location = new System.Drawing.Point(29, 92);
            this.filledRectButton.Name = "filledRectButton";
            this.filledRectButton.Size = new System.Drawing.Size(174, 34);
            this.filledRectButton.TabIndex = 2;
            this.filledRectButton.Text = "Hình CN";
            this.filledRectButton.UseVisualStyleBackColor = true;
            this.filledRectButton.Click += new System.EventHandler(this.btnFilledRect_Click);
            // 
            // elipseLineButton
            // 
            this.elipseLineButton.Location = new System.Drawing.Point(29, 132);
            this.elipseLineButton.Name = "elipseLineButton";
            this.elipseLineButton.Size = new System.Drawing.Size(174, 34);
            this.elipseLineButton.TabIndex = 2;
            this.elipseLineButton.Text = "Đường Eclipse";
            this.elipseLineButton.UseVisualStyleBackColor = true;
            this.elipseLineButton.Click += new System.EventHandler(this.btnEclipse_Click);
            // 
            // filledElipButton
            // 
            this.filledElipButton.Location = new System.Drawing.Point(29, 172);
            this.filledElipButton.Name = "filledElipButton";
            this.filledElipButton.Size = new System.Drawing.Size(174, 34);
            this.filledElipButton.TabIndex = 2;
            this.filledElipButton.Text = "Hình Eclipse";
            this.filledElipButton.UseVisualStyleBackColor = true;
            this.filledElipButton.Click += new System.EventHandler(this.btnFilledEclipse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Chọn màu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(29, 392);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(174, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 10;
            // 
            // btnArc
            // 
            this.btnArc.Location = new System.Drawing.Point(29, 212);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(53, 34);
            this.btnArc.TabIndex = 5;
            this.btnArc.Text = "Arc";
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // arcAngleBar
            // 
            this.arcAngleBar.Location = new System.Drawing.Point(88, 212);
            this.arcAngleBar.Maximum = 360;
            this.arcAngleBar.Name = "arcAngleBar";
            this.arcAngleBar.Size = new System.Drawing.Size(115, 45);
            this.arcAngleBar.TabIndex = 4;
            this.arcAngleBar.Value = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Polygon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Filled Polygon";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnFilledPolygon_Click);
            // 
            // polygonNum
            // 
            this.polygonNum.Location = new System.Drawing.Point(87, 280);
            this.polygonNum.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.polygonNum.Name = "polygonNum";
            this.polygonNum.Size = new System.Drawing.Size(115, 20);
            this.polygonNum.TabIndex = 6;
            this.polygonNum.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Vertex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.polygonNum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnArc);
            this.Controls.Add(this.arcAngleBar);
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
            ((System.ComponentModel.ISupportInitialize)(this.arcAngleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown polygonNum;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TrackBar arcAngleBar;

        private System.Windows.Forms.Button btnArc;

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