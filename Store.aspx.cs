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
    public partial class Store : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // session
            if (Session["idAkunNasabah"] != null && Session["userLevel"] != null)
            {
                //get user level
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

            showDataAssurance();

        }
        private void showDataAssurance()
        {
            // get data asuransi
            DataTable Dt = new DataTable(); 
            Dt = ClsStore.getAssurance();

            // show data asuransi
            showAssurance.DataSource = Dt;
            showAssurance.DataBind();
        }
    }
}