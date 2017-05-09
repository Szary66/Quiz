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
        public Player() { }
        public Player(int ID)
        {
            this.ID = ID;
        }

        public string Name { get; set; }
        public int WinPoints { get; set; }
        public int LostPoints { get; set; }
        public int Games { get; set; }

        public int ID { get; }
    }


    public class DataBase : DataContext
    {
        public DataBase(string path) : base(path) { }

        public Table<PlayerT> Player;
        public Table<Question> Question;
}

    [Table(Name = "Player")]
    public class PlayerT
    {
        [Column(IsPrimaryKey = true)]
        public int ID;
        [Column]
        public string Name;
        [Column]
        public int WinPoints;
        [Column]
        public int LostPoints;
        [Column]
        public int Games;
    }

    [Table(Name = "Question")]
    public class Question
    {
        [Column(IsPrimaryKey = true)]
        public int ID;


        [Column]
        public string Text;
        [Column]
        public string A;
        [Column]
        public string B;
        [Column]
        public string C;
        [Column]
        public string D;
        [Column]
        public int Correct;
    }
}
