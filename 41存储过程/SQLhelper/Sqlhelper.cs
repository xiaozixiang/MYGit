using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41存储过程.SQLhelper
{
    public class Sqlhelper
    {
        public static String connectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;

        public static int ExecuteNnQuery(String sql, CommandType commandtype, SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))  //sqlhelper
                {
                    if (pms != null)
                    {
                        cmd.CommandType = commandtype;
                        conn.Open();
                        cmd.Parameters.AddRange(pms);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }


        public static object ExecuteScal(string sql, CommandType commandtype, SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pms != null)
                    {
                        cmd.CommandType = commandtype;
                        cmd.Parameters.AddRange(pms);
                        conn.Open();
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string sql, CommandType commandtype, SqlParameter[] pms)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (pms != null)
                {
                    cmd.CommandType = commandtype;
                    cmd.Parameters.AddRange(pms);
                    conn.Open();
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }


        public static DataTable ExecuteDataTable(string sql, CommandType commandtype, SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter sda = new SqlDataAdapter(connectionstring,sql))
            {
                sda.SelectCommand.CommandType = commandtype;
                if(pms!=null)
                {
                    sda.SelectCommand.Parameters.AddRange(pms);
                }
                sda.Fill(dt);
                return dt;
            }
        }
    }
}
