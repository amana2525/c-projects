﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace PrimeNumber1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PrimeNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // Resetăm culoarea de fundal la implicit
            this.BackColor = SystemColors.Control;
        }

        private void CHECKButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isNumber = Int32.TryParse(PrimeNumberTextBox.Text, out result);
            if (isNumber)
            {
                if (result > 1)
                {
                    bool isPrime = true;
                    for (int i = 2; i <= result / 2; i++)
                    {
                        if (result % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        isPrime = true;
                        this.BackColor = Color.Green;
                    }
                    else
                    {
                        isPrime = false;
                        this.BackColor = Color.Red;
                    }
                }

            }
            else
            {
               
                this.BackColor = Color.Yellow;
                MessageBox.Show("Nu s-a introdus un număr întreg.");
            }
        }
    }
}
