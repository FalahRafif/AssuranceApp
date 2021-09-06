using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AssuranceApp.Classes;

namespace AssuranceApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // session
            if (Session["idAkunNasabah"] != null && Session["userLevel"] != null)
            {
                //get user level
                int userLevel = Convert.ToInt32(Session["userLevel"]);

                switch (userLevel)
                {
                    //cek user level
                    case 1:
                        Response.Redirect("~/DashboardNasabah.aspx");
                        break;
                    default:
                        Response.Redirect("~/DashboardNasabah.aspx");
                        break;
                }
            }
            cek();
        } 
        public void cek()
        {
            if(Session["error"] != null)
            {
                lblWarning.Text = Convert.ToString(Session["error"]);
                Session["error"] = null;
            }
            else if (Session["info"] != null)
            {
                lblWarning.CssClass = "text-success";
                lblWarning.Text = Convert.ToString(Session["info"]);
                Session["info"] = null;
            }
        }

        protected void btnSumbit_Click(object sender, EventArgs e)
        {
            // gather data
            string nik = txtNIK.Text;
            string namaNasabah = txtNamaLengkap.Text;
            string dob = txtTglLahir.Text;
            string pob = txtTmptLahir.Text;
            string gender = ddwnJK.SelectedValue;
            string maritalStatus = ddwnStatusPernikahan.SelectedValue;
            string phoneNumber = txtNoTelp.Text;
            string housePhoneNumber = txtNoTelpRumah.Text;
            string nasabahAddress = txtAlamat.Text;
            string kelurahan = txtKelurahan.Text;
            string kecamatan = txtKecamatan.Text;
            string kota = txtKota.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int userLevel = 1;

            //cek apakah ada username sama
            DataTable Dt = new DataTable();
            Dt = ClsRegister.getDataAccountNasabahByUsername(username);

            if (Dt.Rows.Count != 0)
            {
                Session["error"] = "username sudah dipakai";
                Response.Redirect("~/Register.aspx");
            }

            // insert to database
            ClsRegister.InsertDataNasabah(nik, namaNasabah, dob, pob, gender, maritalStatus, phoneNumber, housePhoneNumber, nasabahAddress, kelurahan, kecamatan, kota);

            // cari nasabah dengan nik nya 
            DataTable DtCari = new DataTable();
            DtCari = ClsRegister.getDataNasabahByNik(nik);

            //convert datatable
            var DtTable = DtCari.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            //insert akun nasabah
            ClsRegister.insertAccountNasabah(Convert.ToInt32(DtTable[0]), username, password, userLevel  );

            Session["info"] = "Data Berhasil Di tambahkan";
            Response.Redirect("~/Register.aspx");

        }
    }
}