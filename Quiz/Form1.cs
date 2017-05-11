using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Quiz
{
    public partial class LoginForm : Form
    {
        SQLiteManager sqliteManager;
        List<Player> players = new List<Player>();



        public LoginForm()
        {
            InitializeComponent();
            try
            {
                sqliteManager = new SQLiteManager();

                sqliteManager.CreateDB("Quiz.sqlite");
                sqliteManager.Open();

                sqliteManager.CreateTable("Player", new string[] { "ID", "Name", "WinPoints", "LostPoints", "Games" },
                                        new string[] { "int", "string", "int", "int", "int" });

                sqliteManager.CreateTable("Questions", new string[] { "ID", "Text", "A", "B", "C", "D", "Correct" },
                                            new string[] { "int", "string", "string", "string", "string", "string", "int" });

                sqliteManager.Close();
            }
            catch (FieldAccessException e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {

            }
            catch (FieldAccessException e)
            {
                MessageBox.Show(e.Message);
            }
        }



        private void SelectBtn_Click(object sender, EventArgs e)
        {
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
