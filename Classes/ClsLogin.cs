using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using AssuranceApp.Classes;

namespace AssuranceApp.Classes
{
    public class ClsLogin
    {
        public static DataTable DtLogin(string username, string password)
        {

            // setup koneksi
            DataTable Dt = new DataTable();
            SqlConnection SqlConn = new SqlConnection(ClsModul.Conn.ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            // query 
            SqlConn.Open();
            cmd.Connection = SqlConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from TbNasabahAccount where nasabahusername='{username}' and nasabahpassword='{password}'";
            da.SelectCommand = cmd;
            da.Fill(Dt);
            SqlConn.Close();
            return Dt;
        }
    }
}