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

namespace _28Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opg = new OpenFileDialog();
            opg.Title = "请选择你要打开的文件";
            opg.InitialDirectory = @"C:\Users\Administrator\Desktop";
            opg.Multiselect = true;
            opg.Filter = "文件文件|*.txt|多媒体文件|*.wav|图片文件|*.jpg|所有文件|*.*";
            opg.ShowDialog();

           String path= opg.FileName;
           if (path != "") {
               using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read)) {
                   byte[] buffer = new byte[1024*1024*5];
                   while (true) {
                       int r = fs.Read(buffer, 0, buffer.Length);
                       if (r == 0) {
                           break;
                       }
                       textBox1.Text += Encoding.Default.GetString(buffer, 0, r);
                   }
                   
               }
           }

        }

        //调用47WebApi生成的 http://localhost:58653/api/UserInfo/CheckUserName?_userName=xiaozixiang 的接口
        private void button2_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:58653/api/UserInfo/CheckUserName";
            string str = ApiHelper.ApiHelper.httpApi(url, "_userName", "Post");
            textBox1.Text = str;
        }
    }
}
