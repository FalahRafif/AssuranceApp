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
    public partial class Checkout : System.Web.UI.Page
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

            cek();
            GetData();
            
        }
        public void GetData()
        {
            // get data asuransi
            string idProduct = Request.QueryString["idProduct"];
            DataTable Dt = new DataTable();
            Dt = ClsCheckout.getAssuranceById(Convert.ToInt32(idProduct));

            // convert data table ke array
            var DtTable = Dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            // show data asuransi
            txtIdProduct.Text = Convert.ToString(DtTable[0]);
            showAssurance.DataSource = Dt;
            showAssurance.DataBind();
        }
        public void cek()
        {
            ///////////////// cek jika product sedang aktif / sudah di beli
            string status = "Inforce";
            string idProduct = Request.QueryString["idProduct"];
            int idNasabah = Convert.ToInt32(Session["idNasabah"]);
            DataTable Dt = new DataTable();
            Dt = ClsCheckout.getPolisByIdStatusIdNasabah(Convert.ToInt32(idProduct), status, idNasabah);
            if (Dt.Rows.Count != 0)
            {
                labelWarning.Text = "Anda Sudah Membeli Product Ini";
                btnBeli.CssClass = "btn btn-secondary";
                btnBeli.Enabled = false;
                ddwnPayment.Enabled = false;
                txtCard.Enabled = false;
            }
        }
        protected void btnBeli_Click(object sender, EventArgs e)
        {
            /////////////////// Insert Polis
            // gather data 
            int idNasabah = Convert.ToInt32(Session["idNasabah"]) ; 
            string cardNumber = txtCard.Text;
            string payment = ddwnPayment.SelectedValue;
            int idProduct = Convert.ToInt32(txtIdProduct.Text);

            //create policy number
            Random rand = new Random();
            string policyNumber = Convert.ToString(rand.Next(100, 999)) + Convert.ToString(rand.Next(100, 999)) + Convert.ToString(rand.Next(100, 999)) + Convert.ToString(rand.Next(100, 999));

            // create Date polis
            var time = DateTime.Today;
            var notifTime = DateTime.Today;
            string dateStart = time.ToString("yyyy-MM-dd");
            string dateExp = time.AddDays(30).ToString("yyyy-MM-dd");
            
            // status polis
            string statusPolis = "Inforce";

            /// insert data
            ClsCheckout.insertNewPolis(policyNumber, idProduct, idNasabah, dateStart, dateExp, statusPolis, payment, cardNumber);

            /////////////////////////// Insert Notification
            // get data polis
            DataTable Dt = new DataTable();
            Dt = ClsCheckout.getPolisByPolicyNumber(policyNumber);

            // convert data table ke array
            var DtPolis = Dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            // gather data
            int idPolis = Convert.ToInt32(DtPolis[0]);
            string notifStatus = "Buy";
            string msg = $"Nasabah Telah Membeli Assuransi : {DtPolis[10]}, dengan Policy Number {policyNumber}";
            string notifDate = notifTime.ToString("yyyy-MM-dd");

            //insert data
            ClsCheckout.InsertNotification(idPolis, idNasabah, notifStatus, msg, notifDate);

            Session["info"] = $"Nasabah Berhasil Membeli Assuransi {DtPolis[10]}, dengan Policy Number {policyNumber}";
            Response.Redirect("~/DashboardNasabah.aspx");
        }
    }
}