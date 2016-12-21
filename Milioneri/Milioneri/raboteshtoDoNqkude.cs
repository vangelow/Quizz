using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milioneri
{
    public partial class Form1 : Form
    {
        int score = 0;
        int questions = 0;
        string rightAnswer = "";
        int level = 1;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (level == 1) { 
            string[] question1 = new string[] { "Колко е 0011 в десетична бройна система ?", "Колко е 1010 в десетична бройна система ?", "Колко е 1001 в десетична бройна система ?" };
            Random rd = new Random();
            int randomIndex = rd.Next(0, question1.Length);
            string randomQuestion = question1[randomIndex];
            tbQuestion.AppendText(randomQuestion);
                if (randomIndex==0)
                {
                    questions = 1;
                    rightAnswer = "3";
                    string[] ArrayAnswer1 = new string[] { "4", "1", "3", "2" };
                    var ListAnswer = ArrayAnswer1.ToList();
                    Random rnd = new Random();
                    int randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    string randomAnswer = ListAnswer[randomAnswerIndex];
                    
                    answer1.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);
                    answer1.Text = randomAnswer;

                    randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    randomAnswer = ListAnswer[randomAnswerIndex];
                    answer2.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);

                    randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    randomAnswer = ListAnswer[randomAnswerIndex];
                    answer3.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);

                    randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    randomAnswer = ListAnswer[randomAnswerIndex];
                    answer4.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);
                }
                else if (randomIndex == 1)
                {
                    questions = 2;
                    rightAnswer = "10";
                    string[] ArrayAnswer1 = new string[] { "10", "6", "8", "16" };
                    var ListAnswer = ArrayAnswer1.ToList();
                    Random rnd = new Random();
                    int randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    string randomAnswer = ListAnswer[randomAnswerIndex];
                    answer1.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);
                    answer1.Text = randomAnswer;

                    randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    randomAnswer = ListAnswer[randomAnswerIndex];
                    answer2.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);

                    randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    randomAnswer = ListAnswer[randomAnswerIndex];
                    answer3.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);

                    randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    randomAnswer = ListAnswer[randomAnswerIndex];
                    answer4.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);
                }
                else if (randomIndex == 2)
                {
                    questions = 3;
                    rightAnswer = "9";
                    string[] ArrayAnswer1 = new string[] { "12", "9", "8", "6" };
                    var ListAnswer = ArrayAnswer1.ToList();
                    Random rnd = new Random();
                    int randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    string randomAnswer = ListAnswer[randomAnswerIndex];
                    answer1.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);
                    answer1.Text = randomAnswer;

                    randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    randomAnswer = ListAnswer[randomAnswerIndex];
                    answer2.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);

                    randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    randomAnswer = ListAnswer[randomAnswerIndex];
                    answer3.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);

                    randomAnswerIndex = rnd.Next(0, ListAnswer.Count);
                    randomAnswer = ListAnswer[randomAnswerIndex];
                    answer4.Text = randomAnswer;
                    ListAnswer.Remove(randomAnswer);
                }
               
            }

          
         
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer1_MouseClick(object sender, MouseEventArgs e)
        {
            if (level == 1 && questions == 1 && rightAnswer == answer1.Text)
            {
                answer1.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            if (level == 1 && questions == 2 && rightAnswer == answer2.Text)
            {
                answer2.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            if (level == 1 && questions == 3 && rightAnswer == answer1.Text)
            {
                answer1.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            else
                {
                    wrongAnswerLabel.Text = "Грешен отговор";
                }

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void answer2_Click(object sender, EventArgs e)
        {
            if (level == 1 && questions == 1 && rightAnswer == answer2.Text)
            {
                answer2.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            if (level == 1 && questions == 2 && rightAnswer == answer2.Text)
            {
                answer2.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            if (level == 1 && questions == 3 && rightAnswer == answer2.Text)
            {
                answer2.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            else
            {
                wrongAnswerLabel.Text = "Грешен отговор";
            }

        
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            if (level == 1 && questions == 1 && rightAnswer == answer3.Text)
            {
                answer3.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            if (level == 1 && questions == 2 && rightAnswer == answer3.Text)
            {
                answer3.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            if (level == 1 && questions == 3 && rightAnswer == answer3.Text)
            {
                answer3.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            else
            {
                wrongAnswerLabel.Text = "Грешен отговор";
            }

        }
        

        private void answer4_Click(object sender, EventArgs e)
        {
            if (level == 1 && questions == 1 && rightAnswer == answer4.Text)
            {
                answer4.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            if (level == 1 && questions == 2 && rightAnswer == answer4.Text)
            {
                answer4.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            if (level == 1 && questions == 3 && rightAnswer == answer4.Text)
            {
                answer4.Checked = false;
                wrongAnswerLabel.Text = "Верен отговор";

            }
            else
            {
                wrongAnswerLabel.Text = "Грешен отговор";
            }
        }
    }
}
