using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class bankReg : Form
    {
        public bankReg()
        {
            InitializeComponent();
        }

        private void bankReg_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            panel1.BackColor = Color.FromArgb(r.Next(0, 256),
         r.Next(0, 256), r.Next(0, 256));

            panel2.BackColor = Color.FromArgb(r.Next(0, 256),
         r.Next(0, 256), r.Next(0, 256));

            panel3.BackColor = Color.FromArgb(r.Next(0, 256),
         r.Next(0, 256), r.Next(0, 256));


            //for (int i = 0; i < Enum.GetNames(typeof(BankNames)).Length - 1; i++)
            



            //label1.Text = Convert.ToString(r.Next(0, 40));

            label1.Text = 

            label2.Text = Convert.ToString(r.Next(0, 40));

            label3.Text = Convert.ToString(r.Next(0, 40));

            Label newLabel = new Label();

            

        }
        
    }

    public enum BankNames : int
    {
        NatWest = 0,
        Barclays = 1,
        Nationwide = 2,
        Santander = 3,
        Paragon_Bank = 4,
        Royal_Bank_Of_Scotland = 5,
        HSBC = 6,
        Lloyds_TSB = 7
       
    }
    

}
