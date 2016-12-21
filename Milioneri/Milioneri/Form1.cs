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
            string[] question1 = new string[] { "Kolko e 2+2 ?", "Kolko 4+4 ", "Kolko 6+6" };
            Random rd = new Random();
            int randomIndex = rd.Next(0, question1.Length);
            string randomQuestion = question1[randomIndex];
            tbQuestion.AppendText(randomQuestion);
                if (randomIndex==0)
                {
                    questions = 1;
                    rightAnswer = "4";
                    string[] ArrayAnswer1 = new string[] { "4", "1", "2", "6" };
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
                    string[] ArrayAnswer1 = new string[] { "4", "1", "8", "6" };
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

            else if (level == 2)
            {
                
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
            if (level == 1 && questions == 1)
            {
                if (rightAnswer == answer1.Text)
                {
                    tbQuestion.AppendText("");
                    level++;
                    string[] question2 = new string[] { "Kakvo e C#", "Kolko jivotni ima v UNIBIT", "OLIVER OT KUDE E " };

                    Random rd = new Random();
                    int randomIndex = rd.Next(0, question2.Length);
                    string randomQuestion = question2[randomIndex];
                    tbQuestion.AppendText(randomQuestion);
                }

            }
        }
    }
}
