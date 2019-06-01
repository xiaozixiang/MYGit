using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23图片和Timer
{
    public partial class Form1 : Form
    {

        String[] pictures = System.IO.Directory.GetFiles(@"D:\Picture\");
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation=@"D:\无线网卡驱动\爱不会绝迹.wav";
            sp.Play();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"D:\Picture\1..jpg");
            pictureBox2.Image = Image.FromFile(@"D:\Picture\2.jpg");
            pictureBox3.Image = Image.FromFile(@"D:\Picture\4.jpg");
            pictureBox4.Image = Image.FromFile(@"D:\Picture\2.jpg");
            pictureBox5.Image = Image.FromFile(@"D:\Picture\5.jpg");
            pictureBox6.Image = Image.FromFile(@"D:\Picture\6.jpg");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(pictures[r.Next(0,pictures.Length)]);
            pictureBox2.Image = Image.FromFile(pictures[r.Next(0, pictures.Length)]);
            pictureBox3.Image = Image.FromFile(pictures[r.Next(0, pictures.Length)]);
            pictureBox4.Image = Image.FromFile(pictures[r.Next(0, pictures.Length)]);
            pictureBox5.Image = Image.FromFile(pictures[r.Next(0, pictures.Length)]);
            pictureBox6.Image = Image.FromFile(pictures[r.Next(0, pictures.Length)]);
        }
    }
}
