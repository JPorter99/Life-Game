using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class Person
    {
        public string Name { get;}
        public int Age { get; set; }
        public Bank myBank { get; set; }
        
        public Action currentAction { get; set; }

        public int Health { get;}
        public int Hunger { get; set; }
        public int Sleep { get; set;  }
        public int Happiness { get; set; }
        public Person(string inpName)
        {
            Name = inpName;
        }

        private enum Names
        {
            Joe, Adam, Peter, Phil, Jim, John
        }

    }
}
