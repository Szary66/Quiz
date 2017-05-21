using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz {
    public partial class LoginForm : Form {
        SQLiteManager sqliteManager;
        List<Player> players = new List<Player>();



        public LoginForm() {
            InitializeComponent();
            try {
                sqliteManager = new SQLiteManager();
                if (File.Exists("Quiz.sqlite")) {
                    sqliteManager.Open();

                    players = sqliteManager.LoadPlayers();

                    foreach (Player player in players)
                        PlayersList.Items.Add(player.Name);

                } else {
                    sqliteManager.CreateDB("Quiz.sqlite");
                    sqliteManager.Open();

                    sqliteManager.CreateTable("Player", new List<string>() { "ID", "Name", "WinPoints", "LostPoints", "Games" },
                                            new List<string>() { "int", "string", "int", "int", "int" });

                    sqliteManager.CreateTable("Questions", new List<string>() { "ID", "Text", "A", "B", "C", "D", "Correct" },
                                                new List<string>() { "int", "string", "string", "string", "string", "string", "int" });

                    sqliteManager.Close();
                }
            } catch (FieldAccessException e) {
                MessageBox.Show(e.Message);
            }

            try {

            } catch (FieldAccessException e) {
                MessageBox.Show(e.Message);
            }
        }
        private void SelectBtn_Click(object sender, EventArgs e) {
            if(PlayersList.SelectedIndex != -1)
            {
                GameplayForm gameplay = new GameplayForm(players[PlayersList.SelectedIndex], ShowMe);
                gameplay.Show();
                this.Hide();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e) {
            AddPlayer addPlayer = new Quiz.AddPlayer(PlayersList, ShowMe);
            addPlayer.Show();
            Hide();
        }

        private void ShowMe()
        {
            this.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            AddQuestion addQuestion = new AddQuestion(ShowMe);
            addQuestion.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
