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
        private Game currentGame { get;  set; }
        private Main_Game gameForm { get; set; }
        private Bank bank01 = new Bank();
        private Bank bank02 = new Bank();
        private Bank bank03 = new Bank();
        public bankReg(Game CurrentGame, Main_Game GameForm)
        {
            InitializeComponent();
            currentGame = CurrentGame;
            gameForm = GameForm;
        }

        private void bankReg_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            


            //for (int i = 0; i < Enum.GetNames(typeof(BankNames)).Length - 1; i++)
            
            do
            {
                bank02 = new Bank();

            } while (bank02.Name == bank01.Name);

            do
            {
                bank03 = new Bank();

            } while (bank02.Name == bank03.Name || bank03.Name == bank01.Name);

            panel1.BackColor = Color.FromArgb(bank01.ColourRGB[0], bank01.ColourRGB[1], bank01.ColourRGB[2]);

            panel2.BackColor = Color.FromArgb(bank02.ColourRGB[0], bank02.ColourRGB[1], bank02.ColourRGB[2]);

            panel3.BackColor = Color.FromArgb(bank03.ColourRGB[0], bank03.ColourRGB[1], bank03.ColourRGB[2]);

            label1.Text = bank01.Name;
            label2.Text = bank02.Name;
            label3.Text = bank03.Name;
            




        }

        private void bankReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameForm.WindowState = FormWindowState.Minimized;
            gameForm.WindowState = FormWindowState.Normal;
            currentGame.Status = Game.GameState.Active;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentGame.Player.myBank = bank01;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentGame.Player.myBank = bank02;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentGame.Player.myBank = bank03;
            this.Close();
            
        }
    }

    /*
    public enum BankNames
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
    */

}
