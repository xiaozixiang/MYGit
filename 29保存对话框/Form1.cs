using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29保存对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择要保存文件的路径";
            sfd.Filter = "文本文件|*.txt|多媒体文件|*.wav|图片文件|*.jpg";
            sfd.InitialDirectory = @"C:\Users\Administrator\Desktop";
            sfd.ShowDialog();
            String path = sfd.FileName;
            if (path != "") {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)) {

                    byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                    fs.Write(buffer, 0, buffer.Length);
                }
                MessageBox.Show("保存文件成功");
            }
            
        }
    }
}
