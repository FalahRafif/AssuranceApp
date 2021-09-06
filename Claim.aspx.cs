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
    public partial class Claim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // session
            if (Session["idAkunNasabah"] != null && Session["userLevel"] != null)
            {

            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            GetData();
        }
        public void GetData()
        {
            // get data asuransi
            string idPolis = Request.QueryString["idPolis"];
            DataTable Dt = new DataTable();
            Dt = ClsClaim.getPolisByIdPolis(Convert.ToInt32(idPolis));

            // convert data table ke array
            var DtTable = Dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            // show data asuransi
            txtIdPolis.Text = Convert.ToString(DtTable[0]);
            showAssurance.DataSource = Dt;
            showAssurance.DataBind();

            //cek error
            if (Session["error"] != null)
            {
                lblWarning.Text = Convert.ToString(Session["error"]);
                Session["error"] = null;
            }
                
                
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ////////////////////// insert claim
            //gather data
            int idPolis = Convert.ToInt32(txtIdPolis.Text);
            int totalClaim = Convert.ToInt32(txtBanyakClaim.Text);
            string HpName = txtHpName.Text;
            string HpAddress = txtHpAddress.Text;
            int patientNumber = Convert.ToInt32(txtNoPasien.Text);
            string HpPhoneNumber = txtHpNumber.Text;
            int idNasabah = Convert.ToInt32(Session["idNasabah"]);

            // get date
            var time = DateTime.Today;
            string dateClaim = time.ToString("yyyy-MM-dd");

            // cek banyak claim <= benefit
            DataTable Dt = new DataTable();
            Dt = ClsClaim.getPolisByIdPolis(Convert.ToInt32(idPolis));
            var DtTable = Dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            if(totalClaim >= Convert.ToInt32(DtTable[13]))
            {
                Session["error"] = "Banyak Claim telah melebihi Benefit";
                Response.Redirect($"~/Claim.aspx?idPolis={idPolis}");
            }

            // cek sudah brp banyak nasabah claim
            DataTable DtCekClaim = new DataTable();
            DtCekClaim = ClsClaim.getClaimByIdPolis(Convert.ToInt32(idPolis));

            if (DtCekClaim.Rows.Count >= Convert.ToInt32(DtTable[14]))
            {
                Session["error"] = "Claim Sudah mencapai Batas";
                Response.Redirect($"~/Claim.aspx?idPolis={idPolis}");
            }

            // cek apakah nasabah sudah claim hari ini ?
            DataTable DtCekClaimDate = new DataTable();
            DtCekClaimDate = ClsClaim.getClaimByDate(dateClaim);

            if (DtCekClaim.Rows.Count != 0)
            {
                Session["error"] = "Kamu Sudah Melakukan Claim Hari Ini";
                Response.Redirect($"~/Claim.aspx?idPolis={idPolis}");
            }

            

            //insert data
            ClsClaim.InsertClaim(idPolis, totalClaim, dateClaim, HpName, HpAddress, patientNumber, HpPhoneNumber);

            ////////////////////// insert notification
            // gather data

            string notifStatus = "Claim";
            string msg = $"Nasabah telah Mengclaim {DtTable[10]}, Sebesar Rp. {totalClaim} dengan Policy Number {DtTable[1]}";
            string notifDate = dateClaim;

            //insert data 
            ClsCheckout.InsertNotification(idPolis, idNasabah, notifStatus, msg, notifDate);

            Session["info"] = $"Nasabah Berhasil Claim Assuransi {DtTable[10]}, Sebesar Rp. {totalClaim} dengan Policy Number {DtTable[1]}";

            Response.Redirect("~/DashboardNasabah.aspx");
        }
    }
}