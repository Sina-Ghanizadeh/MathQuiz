using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();

        private int addNum1;
        private int addNum2;

        private int minusNum1;
        private int minusNum2;

        private int multiNum1;
        private int multiNum2;

        private int divNum1;
        private int divNum2;

        private int clock;

        private BoolAnswers boolAnswers;

        int CorrectCount;

        private int WinCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetCorrectAnswers();
            StartQuiz();
            btnEnd.Enabled = true;
            btnStart.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock > 0)
            {
                clock = clock - 1;
                timeLabel.Text = $"{clock} seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("Time's up!");

                if (CheckAnswers())
                {
                    MessageBox.Show("You win!");
                    WinCount += 1;
                    

                }
                else
                {
                    MessageBox.Show("You lose!");
                }

                FillCorrectAnswer();
                lblScore.Text = CorrectCount.ToString();
                btnStart.Enabled = true;
                btnEnd.Enabled = false;

            }

        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            if (CheckAnswers())
            {
                MessageBox.Show("You win!");

            }
            else
            {
                MessageBox.Show("You lose!");
            }

            FillCorrectAnswer();
            lblScore.Text = CorrectCount.ToString();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
        }
        public void StartQuiz()

        {
            addNum1 = _random.Next(1, 100);
            addNum2 = _random.Next(1, 100);
            LeftPlus.Text = addNum1.ToString();
            rightPlus.Text = addNum2.ToString();
            sum.Value = 0;

            minusNum1 = _random.Next(1, 100);
            minusNum2 = _random.Next(1, minusNum1);
            leftMinus.Text = minusNum1.ToString();
            rightMinus.Text = minusNum2.ToString();
            minus.Value = 0;

            multiNum1 = _random.Next(2, 11);
            multiNum2 = _random.Next(2, 11);
            leftMultiple.Text = multiNum1.ToString();
            rightMultiple.Text = multiNum2.ToString();
            multiple.Value = 0;

            divNum2 = _random.Next(2, 12);
            //مضرب رندوم پیدا کردیم
            int temp = _random.Next(2, 12);
            divNum1 = temp * divNum2;
            leftDiv.Text = divNum1.ToString();
            rightDiv.Text = divNum2.ToString();
            div.Value = 0;

            clock = 20;
            timeLabel.Text = "20 seconds";
            timer1.Start();

        }

        public bool CheckAnswers()
        {
            boolAnswers = new BoolAnswers();
            boolAnswers.SumAnswer = addNum1 + addNum2 == sum.Value;
            boolAnswers.MinusAnswer = minusNum1 - minusNum2 == minus.Value;
            boolAnswers.MultiAnswer = multiNum1 * multiNum2 == multiple.Value;
            boolAnswers.DivAnswer = divNum1 / divNum2 == div.Value;

            CorrectCount += boolAnswers.CorrectAnswersCount();
            return boolAnswers.Check();
        }

        public void FillCorrectAnswer()
        {

            sumLabel.ForeColor = (boolAnswers.SumAnswer) ? Color.Green : Color.Red;
            minusLabel.ForeColor = (boolAnswers.MinusAnswer) ? Color.Green : Color.Red;
            multilabel.ForeColor = (boolAnswers.MultiAnswer) ? Color.Green : Color.Red;
            divLabel.ForeColor = (boolAnswers.DivAnswer) ? Color.Green : Color.Red;

            sumLabel.Text = (addNum1 + addNum2).ToString();
            minusLabel.Text = (minusNum1 - minusNum2).ToString();
            multilabel.Text = (multiNum1 * multiNum2).ToString();
            divLabel.Text = (divNum1 / divNum2).ToString();

        }

        public void ResetCorrectAnswers()
        {
            sumLabel.Text = "";
            minusLabel.Text = "";
            multilabel.Text = "";
            divLabel.Text = "";
        }
    }
}
