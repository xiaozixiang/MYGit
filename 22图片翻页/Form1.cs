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
namespace _22图片翻页
{
    public partial class Form1 : Form
    {

        String[] pictures = Directory.GetFiles(@"D:\Picture");
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"D:\Picture\1..jpg");
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i == pictures.Length) {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(pictures[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0) {
                i = pictures.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(pictures[i]);
        }
    }
}
