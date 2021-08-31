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
    public class ClsCheckout
    {
        public static DataTable getAssuranceById(int idProduct)
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
                cmd.CommandText = $"select * from TbProductAssurance where IdProductAssurance ={idProduct}";
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
        public static void insertNewPolis(string policyNumber,int idProductAssurance, int idNasabah, string DateStart, string dateExp, string status, string payment, string cardNumber)
        {
            try
            {
                //setup koneksi
                SqlConnection SqlConn = new SqlConnection(ClsModul.Conn.ToString()); 
                SqlCommand cmd = new SqlCommand();


                //query
                SqlConn.Open(); 
                cmd.Connection = SqlConn; 
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into TbPolis values('{policyNumber}','{idProductAssurance}','{idNasabah}','{DateStart}', '{dateExp}','{status}','{payment}','{cardNumber}')"; 
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