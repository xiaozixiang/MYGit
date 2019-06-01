using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41存储过程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int from = Convert.ToInt32(textBox1.Text.Trim());
            int to = Convert.ToInt32(textBox2.Text.Trim());
            int money = Convert.ToInt32(textBox3.Text.Trim());

            //@from int ,
            //@to int,
            //@Mooney money,
            //@result int output  --（1表示转账成功 2表示转账失败 3表示余额不足）

            SqlParameter[] pms ={new SqlParameter("@from",SqlDbType.Int){Value=from},
                                new SqlParameter("@to",SqlDbType.Int){Value=to},
                                new SqlParameter("@mooney",SqlDbType.Money){Value=money},
                                new SqlParameter("@result",SqlDbType.Int){Direction=ParameterDirection.Output}
                               };
            int r=SQLhelper.Sqlhelper.ExecuteNnQuery("uso_blance", CommandType.StoredProcedure, pms);
            string reuslt = pms[3].Value.ToString();

            switch (reuslt)
            {
                case "1": MessageBox.Show("转账成功"); break;
                case "2": MessageBox.Show("转账成功"); break;
                case "3": MessageBox.Show("余额不足"); break;
            }
        }
    }
}
