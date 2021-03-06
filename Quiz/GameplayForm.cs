﻿using System;
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
    public partial class GameplayForm : Form
    {
        Player player;
        List<Question> questions;
        Question currentQuestion;
        SQLiteManager sqlManager;

        public delegate void ShowForm1();
        ShowForm1 showForm1;

        public GameplayForm(Player player, ShowForm1 showForm1)
        {
            InitializeComponent();

            this.player = player;
            LabelName.Text = this.player.Name;
            UpdateLabelsResults();

            this.showForm1 = showForm1;

            questions = new List<Question>();
            sqlManager = new SQLiteManager();

            sqlManager.Open();
            questions = sqlManager.LoadQuestions();
            sqlManager.Close();

            UpdateQuestion();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            UpdateToDatabase();

            showForm1();
            this.Close();
        }

        private void ABtn_Click(object sender, EventArgs e)
        {
            if (currentQuestion.Correct == 0)
                player.WinPoints++;
            else
                player.LostPoints++;

            player.Games++;
            UpdateLabelsResults();
            UpdateQuestion();
        }

        private void BBtn_Click(object sender, EventArgs e)
        {
            if (currentQuestion.Correct == 1)
                player.WinPoints++;
            else
                player.LostPoints++;

            player.Games++;
            UpdateLabelsResults();
            UpdateQuestion();
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            if (currentQuestion.Correct == 2)
                player.WinPoints++;
            else
                player.LostPoints++;

            player.Games++;
            UpdateLabelsResults();
            UpdateQuestion();
        }

        private void DBtn_Click(object sender, EventArgs e)
        {
            if (currentQuestion.Correct == 3)
                player.WinPoints++;
            else
                player.LostPoints++;

            player.Games++;
            UpdateLabelsResults();
            UpdateQuestion();
        }

        private void UpdateLabelsResults()
        {
            WinPointsLabel.Text = player.WinPoints.ToString();
            LostPointLabel.Text = player.LostPoints.ToString();
            GamesLabel.Text = player.Games.ToString();
        }

        private void UpdateQuestion()
        {
            if (questions.Count == 0)
            {
                sqlManager.Open();
                questions = sqlManager.LoadQuestions();
                sqlManager.Close();
            }

            Random r = new Random();
            currentQuestion = questions[r.Next(0, questions.Count - 1)];
            questions.Remove(currentQuestion);

            ShowQuestionOnLabels();
        }

        private void ShowQuestionOnLabels()
        {
            QuestionLabel.Text = currentQuestion.Text;

            ALabel.Text = currentQuestion.A;
            BLabel.Text = currentQuestion.B;
            CLabel.Text = currentQuestion.C;
            DLabel.Text = currentQuestion.D;
        }

        private void UpdateToDatabase()
        {
            List<string> columns = new List<string>();
            List<string> values = new List<string>();
            
            columns.Add("Name");
            columns.Add("WinPoints");
            columns.Add("LostPoints");
            columns.Add("Games");
            
            values.Add("'"+player.Name+"'");
            values.Add(player.WinPoints.ToString());
            values.Add(player.LostPoints.ToString());
            values.Add(player.Games.ToString());

            sqlManager.Open();
            sqlManager.Update("Player", columns, values, player.ID);
            sqlManager.Close();
        }
    }
}
