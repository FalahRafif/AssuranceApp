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
    public partial class Cancel : System.Web.UI.Page
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
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ///////////////////// cancel polis
            /////get date
            var time = DateTime.Today;
            string dateCancel = time.ToString("yyyy-MM-dd");

            //gather data
            int idPolis = Convert.ToInt32(txtIdPolis.Text);
            string status = "Canceled";

            //insert data
            ClsCancel.CancelPolisByIdPolis(idPolis, status);

            //////////////////// insert notif
            // get data polis
            DataTable Dt = new DataTable();
            Dt = ClsClaim.getPolisByIdPolis(Convert.ToInt32(idPolis));

            // convert data table ke array
            var DtTable = Dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            

            // gather data
            string notifStatus = "Cancel";
            string msg = $"Nasabah telah Mencancel Assuransi : {DtTable[10]}, dengan Policy Number {DtTable[1]}";
            string notifDate = dateCancel;
            int idNasabah = Convert.ToInt32(Session["idNasabah"]);

            //insert data 
            ClsCheckout.InsertNotification(idPolis, idNasabah, notifStatus, msg, notifDate);

            Session["info"] = $"Nasabah telah Mencancel Assuransi : {DtTable[10]}, dengan Policy Number {DtTable[1]}";

            Response.Redirect("~/DashboardNasabah.aspx");

        }
    }
}