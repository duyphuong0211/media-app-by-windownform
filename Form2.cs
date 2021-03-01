using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form2 : Form
    {
        Music music;
        System.Media.SoundPlayer player;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Music music)
        {
            InitializeComponent();
            this.music = music;
            lblMusicName.Text = music.NameM1 + " - " + music.NameS1.Name;
            player = new System.Media.SoundPlayer(music.Link);
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxPlay_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void PictureBoxPause_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
