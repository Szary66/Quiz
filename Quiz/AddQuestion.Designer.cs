namespace Quiz
{
    partial class AddQuestion
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
            this.QuestionText = new System.Windows.Forms.TextBox();
            this.AnswerA = new System.Windows.Forms.TextBox();
            this.AnswerB = new System.Windows.Forms.TextBox();
            this.AnswerC = new System.Windows.Forms.TextBox();
            this.AnswerD = new System.Windows.Forms.TextBox();
            this.CorrectAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionText
            // 
            this.QuestionText.Location = new System.Drawing.Point(12, 35);
            this.QuestionText.Multiline = true;
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(315, 84);
            this.QuestionText.TabIndex = 0;
            // 
            // AnswerA
            // 
            this.AnswerA.Location = new System.Drawing.Point(12, 147);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(315, 20);
            this.AnswerA.TabIndex = 1;
            // 
            // AnswerB
            // 
            this.AnswerB.Location = new System.Drawing.Point(12, 201);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(315, 20);
            this.AnswerB.TabIndex = 2;
            // 
            // AnswerC
            // 
            this.AnswerC.Location = new System.Drawing.Point(12, 248);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(315, 20);
            this.AnswerC.TabIndex = 3;
            // 
            // AnswerD
            // 
            this.AnswerD.Location = new System.Drawing.Point(12, 289);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(315, 20);
            this.AnswerD.TabIndex = 4;
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.Location = new System.Drawing.Point(12, 339);
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.Size = new System.Drawing.Size(25, 20);
            this.CorrectAnswer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Anser A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Anser B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Anser C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Anser D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "corrent anser (A - 0, B - 1, C - 2, D - 3)";
            // 
            // CloseBTN
            // 
            this.CloseBTN.Location = new System.Drawing.Point(12, 383);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 23);
            this.CloseBTN.TabIndex = 12;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(251, 383);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 13;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 418);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorrectAnswer);
            this.Controls.Add(this.AnswerD);
            this.Controls.Add(this.AnswerC);
            this.Controls.Add(this.AnswerB);
            this.Controls.Add(this.AnswerA);
            this.Controls.Add(this.QuestionText);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionText;
        private System.Windows.Forms.TextBox AnswerA;
        private System.Windows.Forms.TextBox AnswerB;
        private System.Windows.Forms.TextBox AnswerC;
        private System.Windows.Forms.TextBox AnswerD;
        private System.Windows.Forms.TextBox CorrectAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Button AddBTN;
    }
}