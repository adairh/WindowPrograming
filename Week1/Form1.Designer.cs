using System.Drawing;
using System.Windows.Forms;

namespace Week1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button button;

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
            this.button = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.ketQua = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button.Location = new System.Drawing.Point(345, 322);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 100);
            this.button.TabIndex = 0;
            this.button.Text = "Tinh";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(240, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(513, 153);
            this.Title.TabIndex = 1;
            this.Title.Text = "Giai phuong trinh bac 1";
            // 
            // labelA
            // 
            this.labelA.Location = new System.Drawing.Point(54, 152);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(72, 25);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "so A";
            // 
            // labelB
            // 
            this.labelB.Location = new System.Drawing.Point(51, 217);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(74, 20);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "so B";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(160, 149);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(154, 20);
            this.aTextBox.TabIndex = 4;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(160, 214);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(154, 20);
            this.bTextBox.TabIndex = 4;
            // 
            // ketQua
            // 
            this.ketQua.Location = new System.Drawing.Point(52, 272);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(84, 28);
            this.ketQua.TabIndex = 5;
            this.ketQua.Text = "Ket Qua";
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(0, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 23);
            this.resultLabel.TabIndex = 0;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(160, 275);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(153, 20);
            this.resultBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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