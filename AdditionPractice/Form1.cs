using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionPractice
{
    public partial class Form1 : Form
    {
        private readonly Random num1 = new Random(DateTime.Now.Millisecond);
        private readonly Random num2 = new Random(DateTime.Now.Second);

        public Form1()
        {
            InitializeComponent();
            
        }

        int answer; 
        int input;
        bool isCorrect;
        int correctAnswers = 0;

        private void Problem()
        {
            int first = num1.Next(0, 100);
            int second = num2.Next(0, 100);
            answer = first + second;

            problemTB.Text = "what is " + first + " + " + second + " ?";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Problem();
        }
   
        private void startBtn_Click(object sender, EventArgs e)
        {
            problemTB.Visible = true;
            inputTB.Visible = true;
            submitBtn.Visible = true;
            startBtn.Visible = false;
            label1.Visible = true;
            correctAnswersTB.Visible = true;
            correctAnswersTB.Text = correctAnswers.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {          

            if (int.TryParse(inputTB.Text, out input))
                
            {
                submitBtn.Visible = false;
                if (input == answer)
                {
                    isCorrect = true;
                    
                }
                else
                {
                    isCorrect = false;
                }
            }

            else
            {
                MessageBox.Show("enter an integer");
                return;
            }
            
            if (isCorrect == true)
            {
                resultTB.Text = "correct";
                correctAnswers += 1;
                correctAnswersTB.Text = correctAnswers.ToString(); 
            }

            if (isCorrect == false)
            {
                resultTB.Text = "incorrect, the answer is " + answer;
            }

            resultTB.Visible = true;
            nextBtn.Visible = true;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            submitBtn.Visible = true;
            nextBtn.Visible = false;
            resultTB.Visible = false;
            inputTB.Text = "";
            Problem();
        }

    }
}
