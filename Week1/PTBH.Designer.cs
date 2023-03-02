using System.Drawing;
using System.Windows.Forms;

namespace Week1
{
    partial class PTBH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button nextButton;

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
            this.nextButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.ketQua = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.escButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.nextButton.Location = new System.Drawing.Point(213, 322);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 100);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Tiep tuc";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Violet;
            this.Title.Location = new System.Drawing.Point(240, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(513, 153);
            this.Title.TabIndex = 4;
            this.Title.Text = "Giai phuong trinh bac 1";
            // 
            // labelA
            // 
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelA.ForeColor = System.Drawing.Color.IndianRed;
            this.labelA.Location = new System.Drawing.Point(54, 114);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(72, 25);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "so A";
            // 
            // labelB
            // 
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelB.ForeColor = System.Drawing.Color.IndianRed;
            this.labelB.Location = new System.Drawing.Point(52, 145);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(74, 20);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "so B";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(160, 119);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(154, 20);
            this.aTextBox.TabIndex = 0;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(160, 145);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(154, 20);
            this.bTextBox.TabIndex = 1;
            // 
            // ketQua
            // 
            this.ketQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ketQua.ForeColor = System.Drawing.Color.IndianRed;
            this.ketQua.Location = new System.Drawing.Point(52, 241);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(84, 28);
            this.ketQua.TabIndex = 6;
            this.ketQua.Text = "Ket Qua";
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(0, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 23);
            this.resultLabel.TabIndex = 9;
            // 
            // resultBox
            // 
            this.resultBox.Enabled = false;
            this.resultBox.Location = new System.Drawing.Point(160, 243);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(153, 50);
            this.resultBox.TabIndex = 8;
            // 
            // labelC
            // 
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelC.ForeColor = System.Drawing.Color.IndianRed;
            this.labelC.Location = new System.Drawing.Point(52, 171);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(74, 20);
            this.labelC.TabIndex = 7;
            this.labelC.Text = "so C";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(160, 171);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(154, 20);
            this.cTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(360, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tinh nghiem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // escButton
            // 
            this.escButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.escButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.escButton.Location = new System.Drawing.Point(507, 322);
            this.escButton.Name = "escButton";
            this.escButton.Size = new System.Drawing.Size(100, 100);
            this.escButton.TabIndex = 10;
            this.escButton.Text = "Thoat";
            this.escButton.UseVisualStyleBackColor = true;
            this.escButton.Click += new System.EventHandler(this.escButton_Click);
            // 
            // PTBH
            // 
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.escButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextButton);
            this.Name = "PTBH";
            this.Text = "Giai phuong trinh bac 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button escButton;

        private System.Windows.Forms.TextBox resultBox;

        private System.Windows.Forms.Label ketQua;
        private System.Windows.Forms.Label resultLabel;

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;

        #endregion
    }
}