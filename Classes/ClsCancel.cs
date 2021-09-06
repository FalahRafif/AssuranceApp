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
    public class ClsCancel
    {
        public static void CancelPolisByIdPolis(int idPolis, string status)
        {

            try
            {
                // setup query
                SqlConnection SqlConn = new SqlConnection(ClsModul.Conn.ToString()); 
                SqlCommand cmd = new SqlCommand();

                //query
                SqlConn.Open(); 
                cmd.Connection = SqlConn; 
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update TbPolis set StatusPolis='{status}' where IdPolis='{idPolis}'"; 
                cmd.ExecuteNonQuery(); 
                SqlConn.Close(); 

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}