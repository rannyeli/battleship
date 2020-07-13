using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BattleShip
{
    public partial class Form1 : Form
    {
        Graphics g;
        SoundPlayer sndBG = new SoundPlayer(BattleShip.Properties.Resources.צליל_רקע);

        public Form1()
        {
            InitializeComponent();
            sndBG.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            musicOn.BringToFront();
        }

        private void start_MouseClick(object sender, MouseEventArgs e)
        {
            Game a = new Game();
            a.Show();
        }

        private void instructions_MouseClick(object sender, MouseEventArgs e)
        {
            Instructions a = new Instructions();
            a.Show();
        }

        private void exit_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("האם אתה בטוח שברצונך לצאת מהמשחק?", "יציאה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void musicOff_Click(object sender, EventArgs e)
        {
            sndBG.PlayLooping();
            musicOff.Hide();
            musicOn.Show();
        }

        private void musicOn_Click(object sender, EventArgs e)
        {
            sndBG.Stop();
            musicOn.Hide();
            musicOff.Show();
        }
   
    }
}
