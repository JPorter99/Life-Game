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
        public DateTime DOB { get; set; }
        public Bank myBank { get; set; }
        public double Cash { get; set; } = 100;

  
        
        public Action currentAction { get; set; }

        public int Health { get;}
        public int Hunger { get; set; }
        public int Sleep { get; set;  }
        public int Happiness { get; set; }
        public Person(string inpName, DateTime dob)
        {
            Name = inpName;
            DOB = dob;
        }

        public int calculateAge(Time GameTime)
        {
            if (GameTime.currentGameTime.DayOfYear < DOB.DayOfYear)
            {
                return (GameTime.currentGameTime.Year - DOB.Year) - 1;
            }
            else
            {
                return (GameTime.currentGameTime.Year - DOB.Year);
            }
        }

        private enum Names
        {
            Joe, Adam, Peter, Phil, Jim, John
        }

    }
}
