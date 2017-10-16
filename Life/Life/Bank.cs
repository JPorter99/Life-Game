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
        public BankBalance b01 {get; set;}

        public int[] ColourRGB { get; set; } = new int[3];
        public void GenerateFeatures()
        {
            string[] bankNames = new string[] { "Barclays", "NatWest", "Halifax", "Santander", "Paragon Bank", "RBS", "HSBC", "Lloyds TSB" };
            Random r = new Random();
            this.Name = bankNames[r.Next(0, 8)];

            ColourRGB[0] = r.Next(0, 256);
            ColourRGB[1] = r.Next(0, 256);
            ColourRGB[2] = r.Next(0, 256);
        } 

        public void RandomColour()
        {

        }

        public Bank()
        {
            GenerateFeatures();

        }
    }

    

}
