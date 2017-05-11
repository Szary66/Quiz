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

        List<Player> LoadPlayers()
        {
            List<Player> list = new List<Player>();
            try
            {
                string sql = "select * from Player";
                SQLiteCommand command = new SQLiteCommand(sql, SQLConnection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Player p = new Player();

                    // "ID", "Name", "WinPoints", "LostPoints", "Games" 
                    p.ID = Int32.Parse(reader["ID"].ToString());
                    p.Name = reader["Name"].ToString();
                    p.WinPoints = Int32.Parse(reader["WinPoints"].ToString());
                    p.LostPoints = Int32.Parse(reader["Games"].ToString());
                    p.Games = Int32.Parse(reader["LostPoints"].ToString());

                    list.Add(p);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }

        List<Question> LoadQuestions()
        {
            List<Question> list = new List<Question>();
            try
            {
                string sql = "select * from Questions";
                SQLiteCommand command = new SQLiteCommand(sql, SQLConnection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Question q = new Question();
                    //"ID", "Text", "A", "B", "C", "D", "Correct" 

                    q.ID =     Int32.Parse(reader["ID"].ToString());
                    q.A =       reader["A"].ToString();
                    q.B =       reader["B"].ToString();
                    q.C =       reader["C"].ToString();
                    q.D =       reader["D"].ToString();
                    q.Correct = Int32.Parse(reader["Correct"].ToString());

                    list.Add(q);
                }
                return list;
            }
            catch
            {
                return null;
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
