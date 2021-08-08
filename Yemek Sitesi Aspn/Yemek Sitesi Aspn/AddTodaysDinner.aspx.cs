using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yemek_Sitesi_Aspn.Class;

namespace Yemek_Sitesi_Aspn
{
    public partial class AddTodaysDinner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into GününYemeğiTablosu (GYemekAd,GYemekMalzeme,GYemekTarif,GYemekPuan,GYemekResim) values (@p1,@p2,@p3,@p4,@p5)", Connection.con);

            Connection.checkConnection(Connection.con);

            commandAdd.Parameters.AddWithValue("@p1", tboxAd.Text);
            commandAdd.Parameters.AddWithValue("@p2", tboxMalzeme.Text);
            commandAdd.Parameters.AddWithValue("@p3", tboxTarif.Text);
            commandAdd.Parameters.AddWithValue("@p4", tboxPuan.Text);
            commandAdd.Parameters.AddWithValue("@p5", tboxResim.Text);

            commandAdd.ExecuteNonQuery();

            Response.Redirect("AdminMainPage.aspx");
        }
    }
}