using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    class SQLiteManager
    {
        SQLiteConnection SQLConnection;

        public SQLiteManager()
        {
            SQLConnection = new SQLiteConnection("Data Source=Quiz.sqlite;Version=3;");
        }

        public void Open()
        {
            try
            {
                SQLConnection.Open();
            }
            catch
            {

            }
        }

        public void Close()
        {
            SQLConnection.Close();
        }

        public void CreateDB(string name)
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

        public void CreateTable(string tableName, string[] name, string[] type)
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

        public void InsertRecord(string table, string[] column, string[] value)
        {
            try
            {
                //string sql = "insert into highscores (name, score) values ('Me', 9001)";
                string sql = "insert into" + table + "(";
                for (int i = 0; i < column.Length; ++i)
                {
                    sql += column[i];

                    if (i < column.Length - 1)
                        sql += ",";
                    else
                        sql += ")";
                }

                sql += "values (";

                for (int i = 0; i < value.Length; ++i)
                {
                    sql += value[i];

                    if (i < value.Length - 1)
                        sql += ",";
                    else
                        sql += ")";
                }

                SQLiteCommand command = new SQLiteCommand(sql, SQLConnection);
                command.ExecuteNonQuery();
            }
            catch (FieldAccessException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        public List<Player> LoadPlayers()
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

        public List<Question> LoadQuestions()
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

                    q.ID = Int32.Parse(reader["ID"].ToString());
                    q.A = reader["A"].ToString();
                    q.B = reader["B"].ToString();
                    q.C = reader["C"].ToString();
                    q.D = reader["D"].ToString();
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
    }
}
