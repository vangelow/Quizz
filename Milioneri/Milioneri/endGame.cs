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
    public partial class endGame : Form
    {
        public endGame()
        {
            InitializeComponent();
            
            if(milionaire.level == 1)
            {
                NikiKunchev.Text = startForm.playName + ", твоята оценка е : " + (milionaire.level + 1);

            }
            else
            {
                NikiKunchev.Text = startForm.playName + ", твоята оценка е : " + (milionaire.level);
            }
               
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
