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
    public partial class DashboardNasabah : System.Web.UI.Page
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
            showDataPolis();
        }
        private void showDataPolis()
        {
            //get id nasabah
            int idNasabah = Convert.ToInt32(Session["idNasabah"]);

            // get data asuransi
            DataTable Dt = new DataTable();
            Dt = ClsDashboardNasabah.getPolisByIdNasabah(idNasabah);

            if(Session["info"] != null)
            {
                lblInfo.Text = Convert.ToString(Session["info"]);
                Session["info"] = null;
            }
            // show data asuransi
            showPolis.DataSource = Dt;
            showPolis.DataBind();
        }
    }
}