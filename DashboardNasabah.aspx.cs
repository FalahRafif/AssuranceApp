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
               
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            CheckExpAssurance();
            ShowDataPolis();
        }

        public void CheckExpAssurance()
        {
            //get id nasabah
            int idNasabah = Convert.ToInt32(Session["idNasabah"]);

            // get data asuransi
            DataTable DtPolis = new DataTable();
            DtPolis = ClsDashboardNasabah.getPolisByIdNasabah(idNasabah);

            // cek nasabah punya polis aktif ?
            if(DtPolis.Rows.Count != null)
            {
                
                // cek banyak polis aktif
                if(DtPolis.Rows.Count == 1)
                {
                    // convert data table ke array
                    var DtPolisCnvrt1 = DtPolis.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

                    //get date
                    var dateNow1 = DateTime.Today;
                    var dateCheck1 = Convert.ToDateTime(DtPolisCnvrt1[4]);

                    //check exp
                    for(int i = 0; i < 30; i++)
                    {
                        if (dateNow1 == dateCheck1.AddDays(i)) ;
                    }

                    dateCheck1 = Convert.ToDateTime(DtPolisCnvrt1[4]);

                    for (int i = 30; i >= 30 && i < 365; i++)
                    {
                        if(dateNow1 == dateCheck1.AddDays(i))
                        {
                            // update status polis
                            int idPolis1 = Convert.ToInt32(DtPolisCnvrt1[0]);
                            string status1 = "Expired";

                            ClsExpired.setExpiredPolisByIdPolis(idPolis1, status1);

                            //////////////////// insert notif
                            // get data polis
                            DataTable DtNotif1 = new DataTable();
                            DtNotif1 = ClsClaim.getPolisByIdPolis(Convert.ToInt32(idPolis1));

                            // convert data table ke array
                            var DtNotifCnvrt1 = DtNotif1.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();



                            // gather data
                            string notifStatus = "Expired";
                            string msg = $"Assuransi : {DtNotifCnvrt1[10]},Telah Expired dengan Policy Number {DtNotifCnvrt1[1]}";
                            string notifDate = dateNow1.ToString("yyyy-MM-dd");

                            //insert data 
                            ClsCheckout.InsertNotification(idPolis1, idNasabah, notifStatus, msg, notifDate);

                            Session["info"] = $"Assuransi : {DtNotifCnvrt1[10]},Telah Expired dengan Policy Number {DtNotifCnvrt1[1]}";
                        }
                    }
                }
            }
            if(DtPolis.Rows.Count > 1)
            {
                // convert data table ke array
                var DtPolisCnvrt2 = DtPolis.Rows[1].ItemArray.Select(x => x.ToString()).ToArray();

                //get date
                var dateNow2 = DateTime.Today;
                var dateCheck2 = Convert.ToDateTime(DtPolisCnvrt2[4]);

                //check exp
                for (int i = 0; i < 30; i++)
                {
                    if (dateNow2 == dateCheck2.AddDays(i)) ;
                }

                dateCheck2 = Convert.ToDateTime(DtPolisCnvrt2[4]);

                for (int i = 30; i >= 30; i++)
                {
                    if (dateNow2 == dateCheck2.AddDays(i))
                    {
                        // update status polis
                        int idPolis2 = Convert.ToInt32(DtPolisCnvrt2[0]);
                        string status2 = "Expired";

                        ClsExpired.setExpiredPolisByIdPolis(idPolis2, status2);

                        //////////////////// insert notif
                        // get data polis
                        DataTable DtNotif2 = new DataTable();
                        DtNotif2 = ClsClaim.getPolisByIdPolis(Convert.ToInt32(idPolis2));

                        // convert data table ke array
                        var DtNotifCnvrt2 = DtNotif2.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();



                        // gather data
                        string notifStatus = "Expired";
                        string msg = $"Assuransi : {DtNotifCnvrt2[10]},Telah Expired dengan Policy Number {DtNotifCnvrt2[1]}";
                        string notifDate = dateNow2.ToString("yyyy-MM-dd");

                        //insert data 
                        ClsCheckout.InsertNotification(idPolis2, idNasabah, notifStatus, msg, notifDate);

                        Session["info"] = $"Assuransi : {DtNotifCnvrt2[10]},Telah Expired dengan Policy Number {DtNotifCnvrt2[1]}";
                    }
                }
            }
        }
        private void ShowDataPolis()
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