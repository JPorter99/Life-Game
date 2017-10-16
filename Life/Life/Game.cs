using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class Game
    {
        public Bank currentBank { get; set; }
        public Time GameTime { get; set; }
        public Person Player { get; set; }
        public String Status { get; set; } = "Active";
        public Game(int Age, String Name)
        {
            Player = new Person(Name);
            GameTime = new Time(Age);
         
        }

        

    }

}
