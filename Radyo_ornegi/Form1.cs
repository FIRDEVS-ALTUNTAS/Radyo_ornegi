using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.ComponentModel;

namespace Radyo_ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";
            pictureBox3.Image = Image.FromFile(@"C:\\Users\\Firdevs\\Desktop\\resim\\c1.gif");
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://turkmedya.radyotvonline.net/alemfmaac";
            pictureBox3.Image = Image.FromFile(@"C:\\Users\\Firdevs\\Desktop\\resim\\c2.gif");
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://live.radyofenomen.com/fenomenpop/128/icecast.audio";
            pictureBox3.Image = Image.FromFile(@"C:\\Users\\Firdevs\\Desktop\\resim\\c3.gif");
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://playerservices.streamtheworld.com/api/livestream-redirect/JOY_JAZZ_SC?/;";
            pictureBox3.Image = Image.FromFile(@"C:\\Users\\Firdevs\\Desktop\\resim\\c4.gif");
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Sol tıklama sırasında ContextMenuStrip'i PictureBox'ın üstünde gösterin
                contextMenuStrip1.Show(pictureBox4, e.Location);
            }
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.DarkKhaki;
            panel1.BackColor = Color.DarkSlateGray;
            pictureBox4.Image = Image.FromFile(@"C:\\Users\\Firdevs\\Desktop\\resim\\B.png");
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Image.FromFile(@"C:\\Users\\Firdevs\\Desktop\\resim\\CZ.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void coloredModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 192, 128);
            this.ForeColor = SystemColors.ControlText;
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            pictureBox4.Image = Image.FromFile(@"C:\\Users\\Firdevs\\Desktop\\resim\\ZX.png");
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Image.FromFile(@"C:\\Users\\Firdevs\\Desktop\\resim\\Z.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
