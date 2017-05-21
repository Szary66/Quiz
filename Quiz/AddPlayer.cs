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
        
        public delegate void ShowFrom1();
        ShowFrom1 showForm1;

        public AddPlayer(ShowFrom1 showForm1) {
            InitializeComponent();
            sqlManager = new SQLiteManager();
            
            this.showForm1 = showForm1;

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
                

                showForm1();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                showForm1();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            showForm1();
            this.Close();
        }
    }
}
