using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz {
    public partial class AddPlayer : Form {
        SQLiteManager sqlManager;

        ListBox playersList;

        public AddPlayer(ListBox players) {
            InitializeComponent();
            sqlManager = new SQLiteManager();
            playersList = players;
        }

        private void button1_Click(object sender, EventArgs e) {
            try
            {
                List<string> colums = new List<string>();
                List<string> values = new List<string>();

                //"ID", "Name", "WinPoints", "LostPoints", "Games" 

                colums.Add("ID");
                colums.Add("Name");
                colums.Add("WinPoints");
                colums.Add("LostPoints");
                colums.Add("Games");

                sqlManager.Open();
                values.Add(sqlManager.CountRowsOfTable("Player").ToString());
                values.Add("'" + textBox1.Text + "'");
                values.Add("0");
                values.Add("0");
                values.Add("0");

                sqlManager.InsertRecord("Player", colums, values);

                playersList.Items.Add(textBox1.Text);

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
