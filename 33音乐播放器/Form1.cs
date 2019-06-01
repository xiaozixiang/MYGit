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

namespace _33音乐播放器
{
    public partial class Form1 : Form
    {
        bool b = true;

        List<String> listpath = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            musicplayer.settings.autoStart=false;
             musicplayer.URL=@"E:\CloudMusic\林俊杰 - 爱笑的眼睛.mp3";
             label1.Image = Image.FromFile("放音.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicplayer.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicplayer.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musicplayer.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            musicplayer.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (palyorpause.Text == "播放") {
                if (b)
                {
                    musicplayer.URL = listpath[listBox1.SelectedIndex];
                }
                musicplayer.Ctlcontrols.play();
                palyorpause.Text = "暂停";
            }
            else if (palyorpause.Text == "暂停") {
                musicplayer.Ctlcontrols.pause();
                palyorpause.Text = "播放";
                b = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.InitialDirectory = @"E:\CloudMusic";
            ofg.Filter = "音乐文件|*.mp3|所有文件|*.*";
            ofg.Multiselect = true;
            ofg.Title = "请选择音乐文件";
            ofg.ShowDialog();

            String[] path = ofg.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                listpath.Add(path[i]);
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            musicplayer.URL = listpath[listBox1.SelectedIndex];
            musicplayer.Ctlcontrols.play();
            palyorpause.Text = "暂停";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();
            index--;
            if (index < 0) {
                index = listBox1.Items.Count-1;
            }
            listBox1.SelectedIndex = index;
            musicplayer.URL = listpath[index];
            musicplayer.Ctlcontrols.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index=listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();
            index++;
            if(index==listBox1.Items.Count){
                index=0;
            } 
                listBox1.SelectedIndex = index;
            musicplayer.URL = listpath[index];
            musicplayer.Ctlcontrols.play();
        }

        //private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    int count = listBox1.SelectedItems.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        listpath.RemoveAt(listBox1.SelectedIndex);
        //        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        //    }
        //}

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                listpath.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Tag.ToString() == "1") {
                label1.Image = Image.FromFile("静音.jpg");
                musicplayer.settings.mute = true;
                label1.Tag = "2";
            }
            else if (label1.Tag.ToString() == "2") {

                musicplayer.settings.mute = false;
                label1.Image=Image.FromFile("放音.jpg");
                label1.Tag = "1";
            }
        }
    }
}
