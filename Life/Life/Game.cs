using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class Game
    {
        public Time GameTime { get; set; }
        public Person Player { get; set; }
        public GameState Status { get; set; } = GameState.Active;
        public Game(DateTime DOB, String Name)
        {
            Player = new Person(Name, DOB);
            GameTime = new Time(DOB);
         
        }

        
        public enum GameState
        {
            Active,
            Paused,
            BankReg
        }
    }

}
