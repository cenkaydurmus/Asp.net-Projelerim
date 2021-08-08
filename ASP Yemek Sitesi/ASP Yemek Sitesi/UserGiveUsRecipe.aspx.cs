using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Yemek_Sitesi
{
    public partial class UserGiveUsRecipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into TarifVermeTablosu (Ad,Malzeme,TarifYapılış,TarifKişi,TarifResim,TarifKişiMail,TarifOnay) values (@pad,@pmalzeme,@pyapılış,@pkişi,@presim,@pmail,@ponay)", SqlConnectionClass.con);

            SqlConnectionClass.con.Open();

            commandAdd.Parameters.AddWithValue("@pad", tboxAd.Text);
            commandAdd.Parameters.AddWithValue("@pmalzeme", tboxMalzeme.Text);
            commandAdd.Parameters.AddWithValue("@pyapılış", tboxYapılış.Text);
            commandAdd.Parameters.AddWithValue("@pkişi", tboxKişi.Text);
            commandAdd.Parameters.AddWithValue("@presim", tboxResimLink.Text);
            commandAdd.Parameters.AddWithValue("@pmail", tboxMail.Text);
            commandAdd.Parameters.AddWithValue("@ponay", false);

            commandAdd.ExecuteNonQuery();

            SqlConnectionClass.con.Close();

            Response.Redirect("/UserMainPage.aspx");
        }
    }
}