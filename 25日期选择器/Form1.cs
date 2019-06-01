using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i =DateTime.Now.Year; i >=1949; i--)
			{
                cboYear.Items.Add(i+"年");
			}
           
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.Items.Clear();
            for (int i = 1; i <=12; i++)
            {
                cboMonth.Items.Add(i+"月");
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDays.Items.Clear();
            int days = 0;

            String Monthstr = cboMonth.SelectedItem.ToString().Split(new char[]{'月'})[0];
            String Yearstr = cboYear.SelectedItem.ToString().Split(new char[] { '年' })[0];
            int Month = Convert.ToInt32(Monthstr);
            int Year = Convert.ToInt32(Yearstr);
            switch (Month) { 
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: days = 31; break;
                case 2: if ((Year % 400 == 0 || Year % 4 == 0 && Year % 100 != 0))
                    {

                        days = 29;
                    }
                    else {
                        days = 28;
                }
                    break;
                default: days = 30; break;
            }
            for (int i = 0; i <=days; i++)
            {
                cboDays.Items.Add(i + "号");
            }


        }
    }
}
