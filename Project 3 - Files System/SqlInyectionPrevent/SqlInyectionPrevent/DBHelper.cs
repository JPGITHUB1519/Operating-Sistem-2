using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SqlInyectionPrevent
{
    public class DBHelper
    {
        public static string connection_string = SqlInyectionPrevent.Properties.Settings.Default.cn;
        // normal ejecuta
        public static DataSet ejecuta(string query)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DBHelper.connection_string;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                ds = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return ds;

        }
    }
}
