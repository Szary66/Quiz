using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public class DataBaseManager
    {
        DataContext db;

        public bool Open(string path)
        {
            try
            {
                db = new DataContext(path);

                if (db.DatabaseExists())
                {
                    //load
                }
                else
                {
                    db.CreateDatabase();
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
