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
        SQLiteConnection SQLConnection;

        List<Player> players = new List<Player>();



        public LoginForm()
        {
            InitializeComponent();
            try
            {
                CreateDB("Quiz.sqlite");
                SQLConnection = new SQLiteConnection("Data Source=Quiz.sqlite;Version=3;");
                SQLConnection.Open();

                CreateTable("Player", new string[] { "ID", "Name", "WinPoints", "LostPoints", "Games" },
                                        new string[] { "int", "string", "int", "int", "int" });

                CreateTable("Questions", new string[] { "ID", "Text", "A", "B", "C", "D", "Correct" },
                                            new string[] { "int", "string", "string", "string", "string", "string", "int" });

                SQLConnection.Close();
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


        void CreateDB(string name)
        {
            try
            {
                SQLiteConnection.CreateFile("Quiz.sqlite");
            }
            catch
            {
                return;
            }
        }

        void CreateTable(string tableName, string[] name, string[] type)
        {
            try
            {
                string sql = "create table " + tableName + "(";
                for (int i = 0; i < name.Length; ++i)
                {
                    sql += name[i] + " " + type[i];

                    if (i < name.Length - 1)
                        sql += ",";
                }
                sql += ")";

                SQLiteCommand command = new SQLiteCommand(sql, SQLConnection);
                command.ExecuteNonQuery();
            }
            catch
            {
                return;
            }
        }

        void InsertRecord(string table, string column, string type)
        {
            try
            {
            }
            catch
            {
                return;
            }
        }

        List<T> LoadAll(string table)
        {
            List<T> list = new List<T>;
            try
            {

            }
            catch
            {
                return list;
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
