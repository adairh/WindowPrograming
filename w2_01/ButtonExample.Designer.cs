using System.Drawing;

namespace w2_01
{
    partial class ButtonExample
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
            this.btn_Hello = new System.Windows.Forms.Button();
            this.btn_Goodbye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hello
            // 
            this.btn_Hello.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Hello.Location = new System.Drawing.Point(102, 124);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(241, 85);
            this.btn_Hello.TabIndex = 0;
            this.btn_Hello.Text = "Hello!";
            this.btn_Hello.UseVisualStyleBackColor = true;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // btn_Goodbye
            // 
            this.btn_Goodbye.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Goodbye.Location = new System.Drawing.Point(422, 124);
            this.btn_Goodbye.Name = "btn_Goodbye";
            this.btn_Goodbye.Size = new System.Drawing.Size(201, 85);
            this.btn_Goodbye.TabIndex = 0;
            this.btn_Goodbye.Text = "Goodbye!";
            this.btn_Goodbye.UseVisualStyleBackColor = true;
            this.btn_Goodbye.Click += new System.EventHandler(this.btn_Goodbye_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Goodbye);
            this.Controls.Add(this.btn_Hello);
            this.Name = "Form1";
            this.Text = "Button Example";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_Goodbye;

        private System.Windows.Forms.Button btn_Hello;

        #endregion
    }
}