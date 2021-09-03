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
    public class ClsRegister
    {
        public static DataTable getDataAccountNasabahByUsername(string username)
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
                cmd.CommandText = $"select * from TbNasabahAccount where NasabahUsername= '{username}'";
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
        public static void InsertDataNasabah(string nik, string namaNasabah, string dob, string pob, string gender, string maritalStatus, string phoneNumber, string housePhoneNumber, string nasabahAddress, string kelurahan, string kecamatan, string kota)
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
                cmd.CommandText = $"insert into TbDataNasabah values('{nik}','{namaNasabah}','{dob}','{pob}','{gender}','{maritalStatus}','{phoneNumber}','{housePhoneNumber}','{nasabahAddress}','{kelurahan}','{kecamatan}', '{kota}')";
                cmd.ExecuteNonQuery();
                SqlConn.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getDataNasabahByNik(string nik)
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
                cmd.CommandText = $"select * from TbDataNasabah where nik ={nik}";
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
        public static void insertAccountNasabah(int idNasabah, string nasabahUsername, string nasabahPassword, int userLevel)
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
                cmd.CommandText = $"insert into TbNasabahAccount values('{idNasabah}','{nasabahUsername}','{nasabahPassword}','{userLevel}')";
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