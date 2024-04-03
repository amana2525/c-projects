namespace PrimeNumber1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CHECKButton = new System.Windows.Forms.Button();
            this.PrimeNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CHECKButton);
            this.panel1.Location = new System.Drawing.Point(449, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // CHECKButton
            // 
            this.CHECKButton.Location = new System.Drawing.Point(0, -5);
            this.CHECKButton.Name = "CHECKButton";
            this.CHECKButton.Size = new System.Drawing.Size(205, 105);
            this.CHECKButton.TabIndex = 1;
            this.CHECKButton.Text = "CHECK";
            this.CHECKButton.UseVisualStyleBackColor = true;
            this.CHECKButton.Click += new System.EventHandler(this.CHECKButton_Click);
            // 
            // PrimeNumberTextBox
            // 
            this.PrimeNumberTextBox.Location = new System.Drawing.Point(439, 229);
            this.PrimeNumberTextBox.Name = "PrimeNumberTextBox";
            this.PrimeNumberTextBox.Size = new System.Drawing.Size(226, 22);
            this.PrimeNumberTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.PrimeNumberTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CHECKButton;
        private System.Windows.Forms.TextBox PrimeNumberTextBox;
    }
}

