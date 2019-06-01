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

namespace _19Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("中病毒了！");
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();

            if (DateTime.Now.Hour == 15 && DateTime.Now.Minute ==10 && DateTime.Now.Second == 10) {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"D:\无线网卡驱动\爱不会绝迹.wav";
              
                sp.Play();
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
