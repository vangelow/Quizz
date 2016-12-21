namespace Milioneri
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.RichTextBox();
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "C :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "D : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Въпрос : ";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(121, 153);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(318, 74);
            this.tbQuestion.TabIndex = 9;
            this.tbQuestion.Text = "";
            this.tbQuestion.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(121, 267);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(14, 13);
            this.answer1.TabIndex = 10;
            this.answer1.TabStop = true;
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.CheckedChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            this.answer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.answer1_MouseClick);
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(307, 265);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(14, 13);
            this.answer2.TabIndex = 11;
            this.answer2.TabStop = true;
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(121, 327);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(14, 13);
            this.answer3.TabIndex = 12;
            this.answer3.TabStop = true;
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.Location = new System.Drawing.Point(308, 325);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(14, 13);
            this.answer4.TabIndex = 13;
            this.answer4.TabStop = true;
            this.answer4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(753, 422);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "pic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbQuestion;
        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.RadioButton answer3;
        private System.Windows.Forms.RadioButton answer4;
    }
}

