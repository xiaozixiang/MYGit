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

namespace _30记事本程序
{
    public partial class Form1 : Form
    {

        List<String> list=new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.WordWrap = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
           
            
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择你要打开的文件";
            ofd.Filter = "文本文件|*.txt|多媒体文件|*.wav|所有文件|*.*";
            ofd.InitialDirectory = @"C:\Users\Administrator\Desktop";
            ofd.ShowDialog();
            String path = ofd.FileName;
            listBox1.Items.Add(Path.GetFileName(path));
            list.Add(path);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read)) {
                byte[] buffer = new byte[1024 * 1024 * 5];
                while (true) {
                    int r = fs.Read(buffer, 0, buffer.Length);
                    if (r == 0) {
                        break;
                    }
                    String str = Encoding.Default.GetString(buffer, 0, r);
                    textBox1.Text = str;
                }
            }
        }
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择你要保存的文件";
            sfd.InitialDirectory = @"C:\Users\Administrator\Desktop";
            sfd.Filter = "文本文件|*.txt|多媒体文件|*.wav|所有文件|*.*";
            sfd.ShowDialog();
            String path = sfd.FileName;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)) { 
               byte[] buffer=Encoding.Default.GetBytes(textBox1.Text);
               fs.Write(buffer, 0, buffer.Length);
               MessageBox.Show("保存成功");
            }
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Text == "自动换行") {
                textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "取消自动换行";
            }
            else if (自动换行ToolStripMenuItem.Text == "取消自动换行") {

                textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "自动换行";
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(list[listBox1.SelectedIndex], FileMode.OpenOrCreate, FileAccess.Read)) {
                byte[] buffer = new byte[1024 * 1024 * 5];
                while (true) {
                    int r = fs.Read(buffer, 0, buffer.Length);
                    if (r == 0) {
                        break;
                    }
                    textBox1.Text = Encoding.Default.GetString(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
