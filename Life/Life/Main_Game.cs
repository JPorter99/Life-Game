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
    public partial class Main_Game : Form
    {
        Game CurrentGame { get; set; }
        public Main_Game(string ParseName, int Age) //TEMPORARY UNTIL PERSON CLASS BECOMES AVAILABLE
        {

            CurrentGame = new Game(Age, ParseName);
            InitializeComponent();
        }

        public Main_Game(string ParseName)
        {
            Random rnd = new Random();
            CurrentGame = new Game(rnd.Next(0,100), ParseName);
            InitializeComponent();
        }

        private void Main_Game_Load(object sender, EventArgs e)
        {
            startupUI();
            updateUI();
            timer1.Start();
            MsgBoxCheckTimer.Start();
        }

        //MAIN TIMER 
        private void updateUI()
        {
            label1.Text = CurrentGame.GameTime.currentGameTime.ToLongDateString();
            label2.Text = CurrentGame.GameTime.currentGameTime.ToShortTimeString();
            label3.Text = CurrentGame.Player.Name;

            if (CurrentGame.Status == Game.GameState.Active)
            {
                this.Enabled = true;
            } else if (CurrentGame.Status == Game.GameState.Paused || CurrentGame.Status == Game.GameState.BankReg)
            {
                this.Enabled = false;
                x05timeSpeed();
            }
            
            
            changeBankUI();
            
        }

        private void changeBankUI()
        {
            //Checks Bank UI
            if (CurrentGame.Player.myBank == null)
            {
                panel1.Hide();
                panel3.Hide();
                panel4.Hide();
                button3.Show();
                label15.Show();
            }
            else
            {
                panel1.Show();
                panel3.Show();
                panel4.Show();
                button3.Hide();
                label15.Hide();
                label10.Text = CurrentGame.Player.myBank.Name;
                panel1.BackColor = Color.FromArgb(CurrentGame.Player.myBank.ColourRGB[0], CurrentGame.Player.myBank.ColourRGB[1], CurrentGame.Player.myBank.ColourRGB[2]);
            }


            if (panel1.BackColor.GetBrightness() > 0.4)
            {
                setBankColour(Color.Black);
            }
            else
            {
                setBankColour(Color.White);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateUI();
            CurrentGame.GameTime.progressTime();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            x5timeSpeed();
        }

        private void x1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1timeSpeed();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x2timeSpeed();
        }

        private void x05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x05timeSpeed();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentGame.Status == Game.GameState.Active)
            {
                CurrentGame.Status = Game.GameState.Paused;
                Game_Menu MenuForm = new Game_Menu(CurrentGame, timer1.Interval,this);
                MenuForm.Show();
            }
            
        }

        private void x05timeSpeed()
        {
            CurrentGame.GameTime.gameSpeed = 1;
            timer1.Interval = 200;
            x05ToolStripMenuItem.Font = new Font(x05ToolStripMenuItem.Font, FontStyle.Bold);
            toolStripMenuItem1.Font = new Font(toolStripMenuItem1.Font, FontStyle.Regular);
            toolStripMenuItem2.Font = new Font(toolStripMenuItem2.Font, FontStyle.Regular);
            x1ToolStripMenuItem.Font = new Font(x1ToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void x1timeSpeed()
        {
            CurrentGame.GameTime.gameSpeed = 1;
            timer1.Interval = 1;
            x1ToolStripMenuItem.Font = new Font(x1ToolStripMenuItem.Font, FontStyle.Bold);
            toolStripMenuItem1.Font = new Font(toolStripMenuItem1.Font, FontStyle.Regular);
            toolStripMenuItem2.Font = new Font(toolStripMenuItem2.Font, FontStyle.Regular);
            x05ToolStripMenuItem.Font = new Font(x05ToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void x2timeSpeed()
        {
            toolStripMenuItem1.Font = new Font(toolStripMenuItem1.Font, FontStyle.Bold);
            toolStripMenuItem2.Font = new Font(toolStripMenuItem2.Font, FontStyle.Regular);
            x1ToolStripMenuItem.Font = new Font(x1ToolStripMenuItem.Font, FontStyle.Regular);
            x05ToolStripMenuItem.Font = new Font(x05ToolStripMenuItem.Font, FontStyle.Regular);
            CurrentGame.GameTime.gameSpeed = 2;
            timer1.Interval = 1;
        }

        private void x5timeSpeed()
        {
            toolStripMenuItem2.Font = new Font(toolStripMenuItem2.Font, FontStyle.Bold);
            toolStripMenuItem1.Font = new Font(toolStripMenuItem1.Font, FontStyle.Regular);
            x1ToolStripMenuItem.Font = new Font(x1ToolStripMenuItem.Font, FontStyle.Regular);
            x05ToolStripMenuItem.Font = new Font(x05ToolStripMenuItem.Font, FontStyle.Regular);

            CurrentGame.GameTime.gameSpeed = 5;
            timer1.Interval = 1;
        }

        private void Main_Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CurrentGame.Status == Game.GameState.Paused) {

            }
            else
            {
                timer1.Stop();
                if (exitGame() == true) e.Cancel = true;
                timer1.Start();
            }
        }

        public static bool exitGame()
        {
            if (MessageBox.Show("Are you sure you want to exit the game and lose all unsaved progress?", "Exiting the game", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                
                return true;   
            } else
            {
                return false;
            }

        }

        public void startupUI()
        {
            panel1.Hide();
            panel3.Hide();
            panel4.Hide();
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            progressBar3.Value = 100;
            progressBar4.Value = 100;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void MsgBoxCheckTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bankReg currentBankReg = new bankReg(CurrentGame, this);
            CurrentGame.Status = Game.GameState.BankReg;
            currentBankReg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void setBankColour(Color Colour)
        {
            label5.ForeColor = Colour;
                label9.ForeColor = Colour;
            label10.ForeColor = Colour;
            label6.ForeColor = Colour;
            label7.ForeColor = Colour;
            label8.ForeColor = Colour;
            radioButton1.ForeColor = Colour;
            radioButton2.ForeColor = Colour;
        }

   
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close your account with " + CurrentGame.Player.myBank.Name + "? \nThe remainder of your account will be withdrawn", "Leaving Bank", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                CurrentGame.Player.myBank = null;
            }
            else
            {
                
            }
            
        }
    }
}
