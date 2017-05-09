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
    public partial class LoginForm : Form {
        List<Player> players = new List<Player>();
        DataBase db;

        public LoginForm() {
            InitializeComponent();

            db = new DataBase("quiz.mdf");

       //        db.CreateDatabase();
            //if (db.DatabaseExists())
            //{

            //}
            //else
            //{
            //}

        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
