using System;

namespace MathQuiz3
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
            this.TimeLeft = new System.Windows.Forms.Label();
            this.PlusLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlusRightLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinusRightLabel = new System.Windows.Forms.Label();
            this.MinusLeftLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TimesRightLabel = new System.Windows.Forms.Label();
            this.TimesLeftLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DividedRightLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DividedLeftLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotinent = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotinent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeLeft.Location = new System.Drawing.Point(428, 21);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(132, 32);
            this.TimeLeft.TabIndex = 0;
            this.TimeLeft.Text = "Time Left";
            // 
            // PlusLeftLabel
            // 
            this.PlusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlusLeftLabel.Location = new System.Drawing.Point(65, 93);
            this.PlusLeftLabel.Name = "PlusLeftLabel";
            this.PlusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusLeftLabel.TabIndex = 1;
            this.PlusLeftLabel.Text = "?";
            this.PlusLeftLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(578, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 2;
            // 
            // PlusRightLabel
            // 
            this.PlusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlusRightLabel.Location = new System.Drawing.Point(201, 93);
            this.PlusRightLabel.Name = "PlusRightLabel";
            this.PlusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusRightLabel.TabIndex = 3;
            this.PlusRightLabel.Text = "?";
            this.PlusRightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(267, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(267, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // MinusRightLabel
            // 
            this.MinusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinusRightLabel.Location = new System.Drawing.Point(201, 143);
            this.MinusRightLabel.Name = "MinusRightLabel";
            this.MinusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusRightLabel.TabIndex = 6;
            this.MinusRightLabel.Text = "?";
            // 
            // MinusLeftLabel
            // 
            this.MinusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinusLeftLabel.Location = new System.Drawing.Point(65, 143);
            this.MinusLeftLabel.Name = "MinusLeftLabel";
            this.MinusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusLeftLabel.TabIndex = 7;
            this.MinusLeftLabel.Text = "?";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(267, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 8;
            this.label7.Text = "=";
            // 
            // TimesRightLabel
            // 
            this.TimesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimesRightLabel.Location = new System.Drawing.Point(201, 193);
            this.TimesRightLabel.Name = "TimesRightLabel";
            this.TimesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.TimesRightLabel.TabIndex = 9;
            this.TimesRightLabel.Text = "?";
            // 
            // TimesLeftLabel
            // 
            this.TimesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimesLeftLabel.Location = new System.Drawing.Point(65, 193);
            this.TimesLeftLabel.Name = "TimesLeftLabel";
            this.TimesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.TimesLeftLabel.TabIndex = 10;
            this.TimesLeftLabel.Text = "?";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(131, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 11;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(131, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 12;
            this.label11.Text = "+";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(131, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 13;
            this.label12.Text = "*";
            // 
            // DividedRightLabel
            // 
            this.DividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DividedRightLabel.Location = new System.Drawing.Point(201, 243);
            this.DividedRightLabel.Name = "DividedRightLabel";
            this.DividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.DividedRightLabel.TabIndex = 14;
            this.DividedRightLabel.Text = "?";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(131, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 15;
            this.label14.Text = ":";
            // 
            // DividedLeftLabel
            // 
            this.DividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DividedLeftLabel.Location = new System.Drawing.Point(65, 243);
            this.DividedLeftLabel.Name = "DividedLeftLabel";
            this.DividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.DividedLeftLabel.TabIndex = 16;
            this.DividedLeftLabel.Text = "?";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(267, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 50);
            this.label16.TabIndex = 17;
            this.label16.Text = "=";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum.Location = new System.Drawing.Point(333, 93);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 41);
            this.sum.TabIndex = 1;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.product.Location = new System.Drawing.Point(333, 193);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 41);
            this.product.TabIndex = 3;
            // 
            // quotinent
            // 
            this.quotinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quotinent.Location = new System.Drawing.Point(333, 243);
            this.quotinent.Name = "quotinent";
            this.quotinent.Size = new System.Drawing.Size(100, 41);
            this.quotinent.TabIndex = 4;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difference.Location = new System.Drawing.Point(333, 143);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 41);
            this.difference.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(333, 355);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(161, 39);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.quotinent);
            this.Controls.Add(this.product);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DividedLeftLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DividedRightLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TimesLeftLabel);
            this.Controls.Add(this.TimesRightLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinusLeftLabel);
            this.Controls.Add(this.MinusRightLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlusLeftLabel);
            this.Controls.Add(this.TimeLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotinent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Label PlusLeftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PlusRightLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MinusRightLabel;
        private System.Windows.Forms.Label MinusLeftLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TimesRightLabel;
        private System.Windows.Forms.Label TimesLeftLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DividedRightLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label DividedLeftLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown quotinent;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Button startButton;
    }
}

