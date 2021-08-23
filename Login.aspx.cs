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

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable DtLogin = new DataTable();
            DtLogin = ClsLogin.DtLogin(txtUser.Text, txtPass.Text);

            if (DtLogin.Rows.Count != 0)
            {
                Response.Redirect("~/DashboardNasabah.aspx");
            }
            else
            {
                LblWarning.Text = "Username / Password salah";
            }

        }
    }
}