using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startNewGame("Custom");
            
            
        }

        private void startNewGame(string gameType){
            if (gameType == "Custom")
            {
                Main_Game NewGameForm = new Main_Game(textBox1.Text, Convert.ToInt16(textBox2.Text));
                NewGameForm.Show();
            } else
            {
                Main_Game NewGameForm = new Main_Game(textBox3.Text);
                NewGameForm.Show();
            }
            this.Close();

    }

        private void button2_Click(object sender, EventArgs e)
        {
            startNewGame("Normal");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Image = new OpenFileDialog();
            //Image.Filter = "PNG Image|*.png|Text File|*.txt";
            if (Image.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                MessageBox.Show(Image.SafeFileName);

            }
        }
    }
}
