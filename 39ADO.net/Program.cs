using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39ADO.net
{
    class Program
    {
        static void Main(string[] args)
        {
            String constr = "Data Source=.;Initial Catalog=exercise;User ID=sa;Password=123456";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from c";
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    Console.WriteLine(reader[0].ToString() +" "+ reader[1]+" "+reader[2]);
                
                }
                //Console.WriteLine("插入成功");
                Console.ReadKey();
                conn.Close();
            }

        }
    }
}
