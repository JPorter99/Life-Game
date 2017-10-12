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
    public partial class Game_Menu : Form
    {
        private Game GameATM { get; set; }
        private int previousSpeed { get; set; }
        private Main_Game Main { get; set; }
        public Game_Menu(Game CurrentGame, int previousTimerSpeed, Main_Game main)
        {
            InitializeComponent();
            GameATM = CurrentGame;
            Main = main;
        }

        private void Game_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.WindowState = FormWindowState.Minimized;
            Main.WindowState = FormWindowState.Normal;
            GameATM.Status = "Active";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Main_Game.exitGame() == false)
            {
                Form1 MainMenu = new Form1();
                MainMenu.Show();
                this.Close();
                Main.Close();
            }
            
        } 
        }
    }

