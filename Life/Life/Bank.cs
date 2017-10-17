using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class Bank
    {
        public string Name { get; set; }
        public double balance { get; set; } = 0;
        public double interest { get; set; }

        public DateTime startDate { get; set; }

       public DateTime nextInterestDate { get; set; }

        public int[] ColourRGB { get; set; } = new int[3];
        public void GenerateFeatures()
        {
            string[] bankNames = new string[] { "Barclays", "NatWest", "Halifax", "Santander", "Paragon Bank", "RBS", "HSBC", "Lloyds TSB" };
            Random r = new Random();
            this.Name = bankNames[r.Next(0, 8)];

            ColourRGB[0] = r.Next(0, 256);
            ColourRGB[1] = r.Next(0, 256);
            ColourRGB[2] = r.Next(0, 256);

            interest = r.Next(1, 10);
        } 

        public Bank()
        {
            GenerateFeatures();
           
        }

        public void Transaction(TransactType Type, double amount, Game CURRENTgame)
        {
            if (Type == TransactType.Withdraw)
            {
                if (balance - amount >= 0) {
                    balance -= amount;
                    CURRENTgame.Player.Cash += amount;
                } else
                {
                 //FIND A WAY TO SHOW A MESSAGEBOX   
                }
                
            } else if (Type == TransactType.Deposit)
            {
                if (CURRENTgame.Player.Cash - amount >= 0)
                {
                    balance += amount;
                    CURRENTgame.Player.Cash -= amount;
                } else
                {
                    //FIND A WAY TO SHOW A MESSAGEBOX   
                }

            }

        }

        public DateTime calculateNextInterestDate()
        {
            DateTime Placeholder = new DateTime();
            if (nextInterestDate == Placeholder)
            {
                return startDate.AddMonths(3);

            } else
            {
                return nextInterestDate.AddMonths(3);
            }
            

        }

        public enum TransactType
        {
            Withdraw,
            Deposit
        }

        public void applyInterest()
        {
            balance *= (1 + (interest / 100));
            nextInterestDate = calculateNextInterestDate();
        }
    }

    

}
