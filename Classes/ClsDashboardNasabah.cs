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
    public class ClsDashboardNasabah
    {
        public static DataTable getPolisByIdNasabah(int idNasabah)
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
                cmd.CommandText = $"select * from TbPolis, TbProductAssurance where TbProductAssurance.IdProductAssurance = TbPolis.IdProductAssurance AND idNasabah={idNasabah} AND statuspolis='Inforce'";
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