using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WypozyczalniaSamochodow.Helpers
{
    public static class DBConnection
    {
        private static string strConnnection = ConfigurationManager.ConnectionStrings["CarRentalDB"].ConnectionString.ToString();

        public static DataSet ExecuteQuery(string query)
        {
            SqlConnection conn = new SqlConnection(strConnnection);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            conn.Close();

            return ds;
        }
    }
}