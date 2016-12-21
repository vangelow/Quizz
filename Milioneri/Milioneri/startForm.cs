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
    public partial class startForm : Form
    {
        public static string playName = "";

        public startForm()
        {
            InitializeComponent();
           
        }

        private void startForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playName.Length > 0 && playName.Length<=32) { 
            milionaire loadQuestions = new milionaire();
                loadQuestions.ShowDialog();
                this.Close();
            
            
                
            }
            else if (playName.Length > 32){
                MessageBox.Show("Името е прекалено дълго");
            }
            else
            {
                MessageBox.Show("Моля, въведете име");
            }


        }

        private void playerName_TextChanged(object sender, EventArgs e)
        {
            playName=playerName.Text;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }
    }
}
