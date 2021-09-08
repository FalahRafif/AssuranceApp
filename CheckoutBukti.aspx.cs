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
    public partial class CheckoutBukti : System.Web.UI.Page
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
            
            //cek session error
            if(Session["error"] != null)
            {
                labelWarning.Text = Convert.ToString(Session["error"]);
                Session["error"] = null;
            }
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
            }
        }
        protected void btnBeli_Click(object sender, EventArgs e)
        {
            /////////////////// Insert Polis
            // gather data 
            int idNasabah = Convert.ToInt32(Session["idNasabah"]);
            string cardNumber = null;
            string payment = null;
            int idProduct = Convert.ToInt32(txtIdProduct.Text);
            string imgName = FlUBuktiBayar.FileName;
            string imgPath = "asset/img/bukti_bayar/";
            string buktiBayar = imgName;
            int imgSize = FlUBuktiBayar.PostedFile.ContentLength;

            // set new img name
            var format = imgName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            Random rand = new Random();
            string newImgName = Convert.ToString(rand.Next(100, 999)) + Convert.ToString(rand.Next(100, 999)) + "." + Convert.ToString(format[1]);

            imgPath += newImgName;

            //create policy number

            string policyNumber = Convert.ToString(rand.Next(100, 999)) + Convert.ToString(rand.Next(100, 999)) + Convert.ToString(rand.Next(100, 999)) + Convert.ToString(rand.Next(100, 999));

            // create Date polis
            var time = DateTime.Today;
            var notifTime = DateTime.Today;
            string dateStart = time.ToString("yyyy-MM-dd");
            string dateExp = time.AddDays(30).ToString("yyyy-MM-dd");

            // status polis
            string statusPolis = "Inforce";

            /// insert data
            ClsCheckout.insertNewPolis(policyNumber, idProduct, idNasabah, dateStart, dateExp, statusPolis, payment, cardNumber, buktiBayar);

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

            // upload bukti bayar
            //cek ada file upload
            if (FlUBuktiBayar.PostedFile != null && FlUBuktiBayar.PostedFile.FileName != "")
            {
                // cek ukuran file (file size in byte)
                if (FlUBuktiBayar.PostedFile.ContentLength > 10485760)
                {
                    Session["error"] = "Ukuran File Terlalu Besar";
                    Response.Redirect("~/Store.aspx");
                }
                else
                {
                    // upload file
                    FlUBuktiBayar.SaveAs(Server.MapPath(imgPath));
                }
            }

            //insert data
            ClsCheckout.InsertNotification(idPolis, idNasabah, notifStatus, msg, notifDate);

            Session["info"] = $"Nasabah Berhasil Membeli Assuransi {DtPolis[10]}, dengan Policy Number {policyNumber}";

            Response.Redirect("~/DashboardNasabah.aspx");
        }
    }
}