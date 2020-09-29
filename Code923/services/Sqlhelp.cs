using System.Data;
using System.Data.SqlClient;
using System.Web.SessionState;

namespace Code923.services
{
    public class Sqlhelp
    {
        public static int AnModel(string sql,SqlParameter[] param)
        {
            using (SqlConnection con =new SqlConnection("server=.;database=hxsd_Db;uid=sa;pwd=11"))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    if (param != null)
                        cmd.Parameters.AddRange(param);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static int AnModel(string sql)
        {
            using (SqlConnection con = new SqlConnection("server=.;database=hxsd_Db;uid=sa;pwd=11"))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable Query(string sql, SqlParameter[] param)
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(sql, "server=.;database=hxsd_Db;uid=sa;pwd=11"))
            {
                if (param != null)
                    sda.SelectCommand.Parameters.AddRange(param);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }
        public static DataTable Query(string sql)
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(sql, "server=.;database=hxsd_Db;uid=sa;pwd=11"))
            {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
            }
        }



    }
}