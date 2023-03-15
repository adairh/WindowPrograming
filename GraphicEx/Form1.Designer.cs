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
            this.penColor = new System.Windows.Forms.ColorDialog();
            this.brushColorButton = new System.Windows.Forms.Button();
            this.brushColor = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnArc = new System.Windows.Forms.Button();
            this.arcAngleBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.polygonNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.penColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
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
            this.plMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseWheel);
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
            this.rectLineButton.Size = new System.Drawing.Size(85, 34);
            this.rectLineButton.TabIndex = 2;
            this.rectLineButton.Text = "Khung CN";
            this.rectLineButton.UseVisualStyleBackColor = true;
            this.rectLineButton.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // filledRectButton
            // 
            this.filledRectButton.Location = new System.Drawing.Point(119, 52);
            this.filledRectButton.Name = "filledRectButton";
            this.filledRectButton.Size = new System.Drawing.Size(83, 34);
            this.filledRectButton.TabIndex = 2;
            this.filledRectButton.Text = "Hình CN";
            this.filledRectButton.UseVisualStyleBackColor = true;
            this.filledRectButton.Click += new System.EventHandler(this.btnFilledRect_Click);
            // 
            // elipseLineButton
            // 
            this.elipseLineButton.Location = new System.Drawing.Point(28, 92);
            this.elipseLineButton.Name = "elipseLineButton";
            this.elipseLineButton.Size = new System.Drawing.Size(86, 34);
            this.elipseLineButton.TabIndex = 2;
            this.elipseLineButton.Text = "Đường Eclipse";
            this.elipseLineButton.UseVisualStyleBackColor = true;
            this.elipseLineButton.Click += new System.EventHandler(this.btnEclipse_Click);
            // 
            // filledElipButton
            // 
            this.filledElipButton.Location = new System.Drawing.Point(118, 92);
            this.filledElipButton.Name = "filledElipButton";
            this.filledElipButton.Size = new System.Drawing.Size(84, 34);
            this.filledElipButton.TabIndex = 2;
            this.filledElipButton.Text = "Hình Eclipse";
            this.filledElipButton.UseVisualStyleBackColor = true;
            this.filledElipButton.Click += new System.EventHandler(this.btnFilledEclipse_Click);
            // 
            // brushColorButton
            // 
            this.brushColorButton.BackColor = System.Drawing.Color.Black;
            this.brushColorButton.Location = new System.Drawing.Point(156, 257);
            this.brushColorButton.Name = "brushColorButton";
            this.brushColorButton.Size = new System.Drawing.Size(46, 40);
            this.brushColorButton.TabIndex = 3;
            this.brushColorButton.UseVisualStyleBackColor = false;
            this.brushColorButton.Click += new System.EventHandler(this.btnBrushColor);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(29, 403);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(174, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 10;
            // 
            // btnArc
            // 
            this.btnArc.Location = new System.Drawing.Point(29, 135);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(53, 34);
            this.btnArc.TabIndex = 5;
            this.btnArc.Text = "Arc";
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // arcAngleBar
            // 
            this.arcAngleBar.Location = new System.Drawing.Point(88, 135);
            this.arcAngleBar.Maximum = 360;
            this.arcAngleBar.Name = "arcAngleBar";
            this.arcAngleBar.Size = new System.Drawing.Size(115, 45);
            this.arcAngleBar.TabIndex = 4;
            this.arcAngleBar.Value = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Polygon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Filled Polygon";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnFilledPolygon_Click);
            // 
            // polygonNum
            // 
            this.polygonNum.Location = new System.Drawing.Point(87, 203);
            this.polygonNum.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.polygonNum.Name = "polygonNum";
            this.polygonNum.Size = new System.Drawing.Size(115, 20);
            this.polygonNum.TabIndex = 6;
            this.polygonNum.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Vertex";
            // 
            // penColorButton
            // 
            this.penColorButton.BackColor = System.Drawing.Color.Black;
            this.penColorButton.Location = new System.Drawing.Point(70, 257);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(44, 40);
            this.penColorButton.TabIndex = 3;
            this.penColorButton.UseVisualStyleBackColor = false;
            this.penColorButton.Click += new System.EventHandler(this.btnPenColor);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pen Color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(120, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Brush Color";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.ItemHeight = 24;
            this.comboBox.Items.AddRange(new object[] { "Solid", "Dash", "Dot", "DashDot", "DashDotDot" });
            this.comboBox.SelectedIndex = 0;
            this.comboBox.Location = new System.Drawing.Point(30, 325);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(173, 32);
            this.comboBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.polygonNum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnArc);
            this.Controls.Add(this.arcAngleBar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.penColorButton);
            this.Controls.Add(this.brushColorButton);
            this.Controls.Add(this.filledElipButton);
            this.Controls.Add(this.elipseLineButton);
            this.Controls.Add(this.filledRectButton);
            this.Controls.Add(this.rectLineButton);
            this.Controls.Add(this.bth_line);
            this.Controls.Add(this.plMain);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcAngleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ColorDialog penColor;

        private System.Windows.Forms.Button penColorButton;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown polygonNum;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TrackBar arcAngleBar;

        private System.Windows.Forms.Button btnArc;

        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.ColorDialog brushColor;
        private System.Windows.Forms.Button brushColorButton;

        private System.Windows.Forms.Button elipseLineButton;
        private System.Windows.Forms.Button filledElipButton;

        private System.Windows.Forms.Button filledRectButton;

        private System.Windows.Forms.Button rectLineButton;

        private System.Windows.Forms.Button bth_line;

        private System.Windows.Forms.Panel plMain;

        #endregion
    }
}