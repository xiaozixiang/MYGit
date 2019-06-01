using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20学生登录或者老师登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (rdostudent.Checked || rdoteacher.Checked)
            {
                String name = txtname.Text.Trim();
                String pwd = txtpwd.Text;
                if (rdostudent.Checked)
                {
                    if (name == "student" && pwd == "student")
                    {
                        MessageBox.Show("学生登录成功");
                    }
                    else
                    {
                        MessageBox.Show("登录失败");
                        txtname.Clear();
                        txtpwd.Clear();
                        txtname.Focus();
                    }
                }
                if (rdoteacher.Checked)
                {

                    if (name.Equals("teacher") && pwd.Equals("teacher"))
                    {
                        MessageBox.Show("老师登录成功");
                    }
                    else
                    {
                        MessageBox.Show("登录失败");
                        txtname.Clear();
                        txtpwd.Clear();
                        txtname.Focus();
                    }
                }
            }
            else {
                MessageBox.Show("请先选择你登录的身份");
            }
        }
    }
}
