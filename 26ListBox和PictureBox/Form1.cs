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

namespace _26ListBox和PictureBox
{
    public partial class Form1 : Form
    {

        String[] pictures = Directory.GetFiles(@"D:\Picture", "*.jpg");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i < pictures.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(pictures[i]));
                
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = Image.FromFile(pictures[listBox1.SelectedIndex]);
        }
    }
}
