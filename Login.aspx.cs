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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // session
            if(Session["idAkunNasabah"] != null && Session["userLevel"] != null)
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
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // ambil data akun nasabah?
            DataTable DtLogin = new DataTable();
            DtLogin = ClsLogin.DtLogin(txtUser.Text, txtPass.Text);
            
            //cek akun nasabah ada ?
            if (DtLogin.Rows.Count != 0)
            {
                // convert data table ke array
                var DtTable = DtLogin.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
                //add session
                Session["idAkunNasabah"] = DtTable[0];
                Session["idNasabah"] = DtTable[1];
                Session["userLevel"] = DtTable[4];

                //redirect dashboard nasabah
                Response.Redirect("~/DashboardNasabah.aspx");
            }
            else
            {
                LblWarning.Text = "Username / Password salah";
            }

            

        }
    }
}