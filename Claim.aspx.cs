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
    public partial class Claim : System.Web.UI.Page
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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //gather data
            int idPolis = Convert.ToInt32(txtIdPolis.Text);
            int totalClaim = Convert.ToInt32(txtBanyakClaim.Text);
            string HpName = txtHpName.Text;
            string HpAddress = txtHpAddress.Text;
            int patientNumber = Convert.ToInt32(txtNoPasien.Text);
            int HpPhoneNumber = Convert.ToInt32(txtHpNumber.Text);

        }
    }
}