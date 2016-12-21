using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Milioneri
{
    
    public partial class milionaire : Form
    {
        
        string playaName = startForm.playName;
        
        string rightAnswer = "";
    
        public static int level = 1;
            
        List<string[]> QuestionAnswer1 = new List<string[]> { };
        List<string[]> QuestionAnswer2 = new List<string[]> { };
        List<string[]> QuestionAnswer3 = new List<string[]> { };
        List<string[]> QuestionAnswer4 = new List<string[]> { };
        List<string[]> QuestionAnswer5 = new List<string[]> { };
        public void fillAnswers(List<string[]> filler)
        {
            // разменя отговорите при всяко изпълнение;
            Random rd = new Random();
                int randomIndexOfQuestion = rd.Next(0, filler.Count-1); 
                int randomIndex = 2;
                rightAnswer = filler[randomIndexOfQuestion][1];
                string randomQuestion = filler[randomIndexOfQuestion][randomIndex]; 
                tbQuestion.Text = randomQuestion;

                var listQuestion = filler[randomIndexOfQuestion].ToList();
                
                int randomAnswerIndex = rd.Next(3, listQuestion.Count-1);
                string randomAnswer = listQuestion[randomAnswerIndex];

                answerBtn1.Text = randomAnswer;
                listQuestion.RemoveAt(randomAnswerIndex);
                randomAnswerIndex = rd.Next(3, listQuestion.Count-1);
                randomAnswer = listQuestion[randomAnswerIndex];
                answerBtn2.Text = randomAnswer;
                listQuestion.RemoveAt(randomAnswerIndex);
                
                randomAnswerIndex =  rd.Next(3, listQuestion.Count-1);
                randomAnswer = listQuestion[randomAnswerIndex];
                answerBtn3.Text = randomAnswer;
                listQuestion.RemoveAt(randomAnswerIndex);
                
                randomAnswerIndex = rd.Next(3, listQuestion.Count-1);
                randomAnswer = listQuestion[randomAnswerIndex];
                answerBtn4.Text = randomAnswer;
                listQuestion.RemoveAt(randomAnswerIndex);
                //done
        }
      
        public void FillQustionsAndAnswers()

        {
            // пълни въпросите според нивата и прави избор на произволен въпрос от всяко ниво
            //Взима въпросите от файла
            scoreLbl.Text = "" + level;
            string dbFile;
            dbFile = Application.StartupPath;
            
            if (dbFile.Substring(dbFile.Length - 1) == "\\")
                dbFile = dbFile.Remove(dbFile.Length - 1);

            dbFile = dbFile + "\\dbFile.txt";
            StreamReader tr = new StreamReader(dbFile, System.Text.Encoding.GetEncoding(0));
            string textLines = "";

            while ((textLines = tr.ReadLine()) != null)
            {
                if (textLines[0] == '1') { 
                QuestionAnswer1.Add(textLines.Split('|'));
                }

                if (textLines[0] == '2')
                {
                    QuestionAnswer2.Add(textLines.Split('|'));
                }
                if (textLines[0] == '3')
                {
                    QuestionAnswer3.Add(textLines.Split('|'));
                }
                if (textLines[0] == '4')
                {
                    QuestionAnswer4.Add(textLines.Split('|'));
                }
                if (textLines[0] == '5')
                {
                    QuestionAnswer5.Add(textLines.Split('|'));
                }


            }
            if (level == 1)

            {
                fillAnswers(QuestionAnswer1);
            }
            if (level == 2)
            {
                fillAnswers(QuestionAnswer2);
            }
            if (level == 3)
            {
                fillAnswers(QuestionAnswer3);
            }
            if (level == 4)
            {
                fillAnswers(QuestionAnswer4);
            }
            if (level == 5)
            {
                fillAnswers(QuestionAnswer5);
            }
            if (level > 5)
            {
                endGame loadEnd = new endGame();
                loadEnd.ShowDialog();
            }
        }

        public milionaire()
        {
            InitializeComponent();
            FillQustionsAndAnswers();
        }
        
        public void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = playaName;
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void milionaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)27)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void answerBtn1_Click(object sender, EventArgs e)
        {
            if (answerBtn1.Text == rightAnswer)
            {
                MessageBox.Show("Верен отговор !");
                level++;
                FillQustionsAndAnswers();
                // пълни текста на бутоните. Същото се отнася и за другите клик бутони
            }
            else
            {
                
                MessageBox.Show("Грешен отговор !");
                endGame loadEnd = new endGame();
                loadEnd.ShowDialog();
                // препраща към формата за край на програмата. Същото се отнася и за другите клик бутони.
            }
        }
        private void answerBtn1_MouseEnter(object sender, EventArgs e)
        {
            answerBtn1.BackColor = Color.Orange;
        }

        private void answerBtn1_MouseLeave(object sender, EventArgs e)
        {
            answerBtn1.BackColor = Color.Black;
        }
        

        private void answerBtn2_Click(object sender, EventArgs e)
        {
            if (answerBtn2.Text == rightAnswer)
            {
                MessageBox.Show("Верен отговор !");
                level++;
                FillQustionsAndAnswers();

            }
            else
            {

                MessageBox.Show("Грешен отговор !");
                endGame loadEnd = new endGame();
                loadEnd.ShowDialog();
            }
        }

        private void answerBtn2_MouseEnter(object sender, EventArgs e)
        {
            answerBtn2.BackColor = Color.Orange;
        }

        private void answerBtn2_MouseLeave(object sender, EventArgs e)
        {
            answerBtn2.BackColor = Color.Black;
        }

        private void answerBtn3_Click(object sender, EventArgs e)
        {
            if (answerBtn3.Text == rightAnswer)
            {
                MessageBox.Show("Верен отговор !");
                level++;
                FillQustionsAndAnswers();

            }
            else
            {

                MessageBox.Show("Грешен отговор !");
                endGame loadEnd = new endGame();
                loadEnd.ShowDialog();

            }
        }

        private void answerBtn3_MouseEnter(object sender, EventArgs e)
        {
            answerBtn3.BackColor = Color.Orange;
        }

        private void answerBtn3_MouseLeave(object sender, EventArgs e)
        {
            answerBtn3.BackColor = Color.Black;
        }
        private void answerBtn4_Click(object sender, EventArgs e)
        {
            if (answerBtn4.Text == rightAnswer)
            {
                MessageBox.Show("Верен отговор !");
                level++;
                FillQustionsAndAnswers();

            }
            else
            {

                MessageBox.Show("Грешен отговор !");
                endGame loadEnd = new endGame();
                loadEnd.ShowDialog();
            }
        }

        private void answerBtn4_MouseEnter(object sender, EventArgs e)
        {
            answerBtn4.BackColor = Color.Orange;
        }

        private void answerBtn4_MouseLeave(object sender, EventArgs e)
        {
            answerBtn4.BackColor = Color.Black;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
