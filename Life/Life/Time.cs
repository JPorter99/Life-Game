using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class Time
    {
        public DateTime currentGameTime { get; set; }
        public int gameSpeed { get; set; } = 1;
        public Time(int Age)
        {
            currentGameTime = generateTime(Age);
        }

        private DateTime generateTime(int age) //Change this to timespan eventually?
        {
            Random rnd = new Random();
            return DateTime.Now.AddDays(0 - rnd.Next(0,age * 365));

        }

        public void progressTime()
        {
            currentGameTime = currentGameTime.AddMinutes(gameSpeed);
        }

    }
}
