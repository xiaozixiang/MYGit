using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("肖自翔很帅哟！");
            this.Close();
        }

        private void btnunlove_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width-btnunlove.Width;
            int y = this.ClientSize.Height - btnunlove.Height;
            Random r = new Random();
            btnunlove.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

       
    }
}
