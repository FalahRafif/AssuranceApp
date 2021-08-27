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