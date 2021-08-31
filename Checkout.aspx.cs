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
                ////get user level
                //int userLevel = Convert.ToInt32(Session["userLevel"]);

                //switch (userLevel)
                //{
                //    //cek user level
                //    case 1:
                //        Response.Redirect("~/DashboardNasabah.aspx");
                //        break;
                //    default:
                //        Response.Redirect("~/DashboardNasabah.aspx");
                //        break;
                //}
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
        protected void btnBeli_Click(object sender, EventArgs e)
        {
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
            string dateStart = time.ToString("yyyy-MM-dd");
            string dateExp = time.AddDays(30).ToString("yyyy-MM-dd");
            
            // status polis
            string statusPolis = "Inforce";

            /// insert data
            ClsCheckout.insertNewPolis(policyNumber, idProduct, idNasabah, dateStart, dateExp, statusPolis, payment, cardNumber);

            Response.Redirect("~/Login.aspx");
        }
    }
}