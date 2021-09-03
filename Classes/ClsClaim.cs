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
    public class ClsClaim
    {
        public static DataTable getPolisByIdPolis(int idPolis)
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
                cmd.CommandText = $"select * from TbPolis, TbProductAssurance where TbProductAssurance.IdProductAssurance = TbPolis.IdProductAssurance AND idPolis={idPolis} AND statuspolis='Inforce'";
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
        public static void InsertClaim(int idPolis, int totalClaim,string dateClaim, string hpName, string hpAddress, int patientNumber, string hpPhoneNumber)
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
                cmd.CommandText = $"insert into TbClaimAssurance values('{idPolis}','{totalClaim}','{dateClaim}','{hpName}','{hpAddress}', '{patientNumber}','{hpPhoneNumber}')";
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