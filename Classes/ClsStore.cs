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
    public class ClsStore
    {
        public static DataTable getAssurance()
        {
            try
            {
                //setup koneksi
                DataTable DtAssuransi = new DataTable(); 
                SqlConnection SqlConn = new SqlConnection(ClsModul.Conn.ToString()); 
                SqlCommand cmd = new SqlCommand(); 
                SqlDataAdapter da = new SqlDataAdapter();

                //query
                SqlConn.Open();
                cmd.Connection = SqlConn; 
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from TbProductAssurance"; 
                da.SelectCommand = cmd;
                da.Fill(DtAssuransi); 
                SqlConn.Close(); 
                return DtAssuransi;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}