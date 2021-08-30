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

            // show data asuransi
            showAssurance.DataSource = Dt;
            showAssurance.DataBind();
        }
    }
}