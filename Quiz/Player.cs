using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Quiz
{
    public class Player
    {
        public Player()
        {
            ID = -1;
        }
        public Player(int ID)
        {
            this.ID = ID;
        }
        int id;

        public string Name { get; set; }
        public int WinPoints { get; set; }
        public int LostPoints { get; set; }
        public int Games { get; set; }

        public int ID { get; set; }
    }


}
