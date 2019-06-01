using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40ADO增删改查
{
    public static class SqlHelper
    {


        //ExecuteNOnQuery ExecuteScanlQuert
        public static int ExecuteQuery(String constring, String QueryString, SqlParameter[] pms)
        {
            int i;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(QueryString, conn))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    i = cmd.ExecuteNonQuery();
                }

            }
            return i;
        }

        //ExecuteScalar
        public static object ExecuteScalar(String constring, String QueryString, SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand(QueryString, conn);

                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                    conn.Open();
                }
                return cmd.ExecuteScalar();
            }
        }

        //ExecuteReader
        public static SqlDataReader ExecuteReader(String constring, String QueryString, SqlParameter[] pms)
        {
            SqlDataReader Reader = null;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(QueryString, conn))
                {

                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                        conn.Open();
                        Reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    }
                }
                return Reader;
            }
        }

    }
}