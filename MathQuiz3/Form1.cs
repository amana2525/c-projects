using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MathQuiz3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random randomizer = new Random();
        int addend1;
        int addend2;
        int minuend;
        int subtrahend;
        int multiplicand;
        int multiplier;
        int dividend;
        int divisor;
        int timeLeft;
        private object timer1;

        private void Form1_LOad(object sender, EventArgs e)
        {

        }
        private void startButton_Click(object sender, EventArgs e)
        { StartTheQuiz();
            startButton.Enabled = false;
        }
        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            PlusLeftLabel.Text = addend1.ToString();
            PlusRightLabel.Text = addend2.ToString();
            sum.Value = 0;
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            MinusLeftLabel.Text = minuend.ToString();
            MinusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            TimesLeftLabel.Text = multiplicand.ToString();
            TimesRightLabel.Text = multiplier.ToString();
            product.Value = 0;
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            DividedLeftLabel.Text = dividend.ToString();    
            DividedRightLabel.Text = divisor.ToString();
            temporaryQuotient.Value = 0;
            timeLeft = 30;
            TimeLabel.Text = "30 seconds";
            timer1.Start();
        }
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) && (minuend - subtrahend == difference.Value) && (multiplicand * multiplier == product.Value) && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                DialogResult dialogResult = MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }
    }
}
    }
