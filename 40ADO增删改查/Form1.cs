using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace _40ADO增删改查
{
    public partial class Form1 : Form
    {
        public string constring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        List<c> list = new List<c>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSource();
        }

        private void DataSource()
        {
            using (SqlConnection conn = new SqlConnection(constring)) 
            {
                string str = "select * from c";
                using (SqlCommand cmd = new SqlCommand(str, conn)) 
                {
                    conn.Open();
                    SqlDataReader reader=cmd.ExecuteReader();
                    while (reader.Read())
                    { 
                        c cp=new c();
                        cp.id = reader[0].ToString().Trim();
                        cp.name = reader[1].ToString();
                        cp.credit = float.Parse(reader[2].ToString());
                        list.Add(cp);
                    }
                }
            }
          this.dgvdate.DataSource = list;
        }

        //插入
        private void button1_Click(object sender, EventArgs e)
        {
            String id = txtcno.Text.Trim();
            String name = txtname.Text.Trim();
            float score= float.Parse(txtscore.Text);
            string str = "insert into c values(@id,@name,@score)";
            //SqlParameter[] pms=new SqlParameter[]{new SqlParameter("@id",id)};
         //   SqlHelper.ExecuteQuery(constring,str,)
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Float).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 30).Value = name;
                    cmd.Parameters.Add("@score", SqlDbType.NVarChar,20).Value = score;
                    cmd.ExecuteNonQuery();
                    DataSource();
                }
            }
        }

        private void dgvdate_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = this.dgvdate.Rows[e.RowIndex];
            c  cp=  currentRow.DataBoundItem as c;
            if (cp != null) {
                txteditname.Text = cp.name;
                txteditscore.Text = cp.credit.ToString();
                lbleditcno.Text = cp.id;
            }
        }


        //删除
        private void button3_Click(object sender, EventArgs e)
        {
            string id = lbleditcno.Text.Trim();
            using (SqlConnection conn = new SqlConnection(constring))
            {
                string str = "delete from c where Cno =@id";
                using (SqlCommand cmd = new SqlCommand(str, conn)) 
                {
                    conn.Open();
                    cmd.Parameters.Add("@id", SqlDbType.NVarChar, 20).Value = id;
                    cmd.ExecuteNonQuery();
                    DataSource();
                }
            }
        }

        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            String id = lbleditcno.Text.Trim();
            string name = txteditname.Text.Trim();
            float score = float.Parse(txteditscore.Text);
            using (SqlConnection conn = new SqlConnection(constring))
            {
                string str = "update c set Cname=@name,Ccredit=@score where Cno=@id";
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 20).Value = name;
                    cmd.Parameters.Add("@score", SqlDbType.NVarChar, 20).Value = score;
                    cmd.Parameters.Add("@id", SqlDbType.Float).Value = id;
                    cmd.ExecuteNonQuery();
                    DataSource();
                }
            }
        }

      
    }
}
