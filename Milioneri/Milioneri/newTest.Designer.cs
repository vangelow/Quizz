namespace Milioneri
{
    partial class milionaire
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
            this.tbQuestion = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.answerBtn1 = new System.Windows.Forms.Button();
            this.answerBtn2 = new System.Windows.Forms.Button();
            this.answerBtn3 = new System.Windows.Forms.Button();
            this.answerBtn4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQuestion.ForeColor = System.Drawing.Color.White;
            this.tbQuestion.Location = new System.Drawing.Point(77, 136);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(607, 91);
            this.tbQuestion.TabIndex = 9;
            this.tbQuestion.Text = "";
            this.tbQuestion.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Milioneri.Properties.Resources.millionare_questiosn;
            this.pictureBox1.Location = new System.Drawing.Point(1, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // answerBtn1
            // 
            this.answerBtn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.answerBtn1.FlatAppearance.BorderSize = 0;
            this.answerBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn1.ForeColor = System.Drawing.Color.White;
            this.answerBtn1.Location = new System.Drawing.Point(145, 244);
            this.answerBtn1.Name = "answerBtn1";
            this.answerBtn1.Size = new System.Drawing.Size(549, 28);
            this.answerBtn1.TabIndex = 19;
            this.answerBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerBtn1.UseVisualStyleBackColor = false;
            this.answerBtn1.Click += new System.EventHandler(this.answerBtn1_Click);
            this.answerBtn1.MouseEnter += new System.EventHandler(this.answerBtn1_MouseEnter);
            this.answerBtn1.MouseLeave += new System.EventHandler(this.answerBtn1_MouseLeave);
            // 
            // answerBtn2
            // 
            this.answerBtn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.answerBtn2.FlatAppearance.BorderSize = 0;
            this.answerBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn2.ForeColor = System.Drawing.Color.White;
            this.answerBtn2.Location = new System.Drawing.Point(145, 288);
            this.answerBtn2.Name = "answerBtn2";
            this.answerBtn2.Size = new System.Drawing.Size(549, 28);
            this.answerBtn2.TabIndex = 20;
            this.answerBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerBtn2.UseVisualStyleBackColor = false;
            this.answerBtn2.Click += new System.EventHandler(this.answerBtn2_Click);
            this.answerBtn2.MouseEnter += new System.EventHandler(this.answerBtn2_MouseEnter);
            this.answerBtn2.MouseLeave += new System.EventHandler(this.answerBtn2_MouseLeave);
            // 
            // answerBtn3
            // 
            this.answerBtn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.answerBtn3.FlatAppearance.BorderSize = 0;
            this.answerBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn3.ForeColor = System.Drawing.Color.White;
            this.answerBtn3.Location = new System.Drawing.Point(145, 332);
            this.answerBtn3.Name = "answerBtn3";
            this.answerBtn3.Size = new System.Drawing.Size(549, 28);
            this.answerBtn3.TabIndex = 21;
            this.answerBtn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerBtn3.UseVisualStyleBackColor = false;
            this.answerBtn3.Click += new System.EventHandler(this.answerBtn3_Click);
            this.answerBtn3.MouseEnter += new System.EventHandler(this.answerBtn3_MouseEnter);
            this.answerBtn3.MouseLeave += new System.EventHandler(this.answerBtn3_MouseLeave);
            // 
            // answerBtn4
            // 
            this.answerBtn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.answerBtn4.FlatAppearance.BorderSize = 0;
            this.answerBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn4.ForeColor = System.Drawing.Color.White;
            this.answerBtn4.Location = new System.Drawing.Point(145, 376);
            this.answerBtn4.Name = "answerBtn4";
            this.answerBtn4.Size = new System.Drawing.Size(549, 28);
            this.answerBtn4.TabIndex = 22;
            this.answerBtn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerBtn4.UseVisualStyleBackColor = false;
            this.answerBtn4.Click += new System.EventHandler(this.answerBtn4_Click);
            this.answerBtn4.MouseEnter += new System.EventHandler(this.answerBtn4_MouseEnter);
            this.answerBtn4.MouseLeave += new System.EventHandler(this.answerBtn4_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 23;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(12, 67);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(95, 23);
            this.lblScore.TabIndex = 25;
            this.lblScore.Text = "Въпрос: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(187, 23);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Име на участник: ";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLbl.ForeColor = System.Drawing.Color.White;
            this.scoreLbl.Location = new System.Drawing.Point(113, 67);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(0, 23);
            this.scoreLbl.TabIndex = 26;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.White;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(441, 28);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(117, 62);
            this.btnNewGame.TabIndex = 27;
            this.btnNewGame.Text = "Нова Игра";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.White;
            this.btnEndGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndGame.ForeColor = System.Drawing.Color.Black;
            this.btnEndGame.Location = new System.Drawing.Point(591, 28);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(117, 62);
            this.btnEndGame.TabIndex = 28;
            this.btnEndGame.Text = "Край на играта";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // milionaire
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnEndGame;
            this.ClientSize = new System.Drawing.Size(753, 422);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerBtn4);
            this.Controls.Add(this.answerBtn3);
            this.Controls.Add(this.answerBtn2);
            this.Controls.Add(this.answerBtn1);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "milionaire";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milionaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.milionaire_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button answerBtn1;
        private System.Windows.Forms.Button answerBtn2;
        private System.Windows.Forms.Button answerBtn3;
        private System.Windows.Forms.Button answerBtn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnEndGame;
    }
}

