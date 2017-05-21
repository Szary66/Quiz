using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class AddQuestion : Form
    {
        public delegate void ShowForm1();
        ShowForm1 showForm1;

        SQLiteManager sqlManager;
        public AddQuestion(ShowForm1 showForm1)
        {
            InitializeComponent();
            this.showForm1 = showForm1;

            sqlManager = new SQLiteManager();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            showForm1();
            Close();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (!TextBoxIsEmpty())
            {
                if (CorrectAnswer.Text == "0" || CorrectAnswer.Text == "1" || CorrectAnswer.Text == "2" || CorrectAnswer.Text == "3")
                {
                    try
                    {
                        List<string> columns = new List<string>();
                        List<string> values = new List<string>();

                        sqlManager.Open();

                        columns.Add("ID");
                        columns.Add("Text");
                        columns.Add("A");
                        columns.Add("B");
                        columns.Add("C");
                        columns.Add("D");
                        columns.Add("Correct");

                        values.Add(sqlManager.CountRowsOfTable("Questions").ToString());
                        values.Add("'" + QuestionText.Text + "'");
                        values.Add("'" + AnswerA.Text + "'");
                        values.Add("'" + AnswerB.Text + "'");
                        values.Add("'" + AnswerC.Text + "'");
                        values.Add("'" + AnswerD.Text + "'");
                        values.Add(CorrectAnswer.Text);

                        sqlManager.InsertRecord("Questions", columns, values);
                        sqlManager.Close();

                        ClearAllTextboxs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        sqlManager.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Zle oznaczona odpowiedz poprawna!");
                }
            }
            else
            {
                MessageBox.Show("Zostawilo niewypelnione pole!");
            }
        }

        //return true if any textbox is empty
        private bool TextBoxIsEmpty()
        {
            if (QuestionText.Text != "" && AnswerA.Text != "" && AnswerB.Text != "" && AnswerC.Text != "" && AnswerD.Text != "" && CorrectAnswer.Text != "")
                return false;
            return true;
        }

        private void ClearAllTextboxs()
        {
            QuestionText.Text = "";
            AnswerA.Text = "";
            AnswerB.Text = "";
            AnswerC.Text = "";
            AnswerD.Text = "";
            CorrectAnswer.Text = "";
        }
    }
}
