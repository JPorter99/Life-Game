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
        public DateTime startDate { get; set; }
        public int gameSpeed { get; set; } = 1;
        public Time(DateTime DOB)
        {
            currentGameTime = generateTime(DOB);
            startDate = currentGameTime;
        }

        private DateTime generateTime(DateTime DOB) //Change this to timespan eventually?
        {
            Random rnd = new Random();
            return DateTime.Now.AddDays(0 - rnd.Next(0,(Convert.ToInt32(DateTime.Now.Subtract(DOB).TotalDays)))); //FIX THIS

        }

        public void progressTime()
        {
            currentGameTime = currentGameTime.AddMinutes(gameSpeed);
        }

    }
}
