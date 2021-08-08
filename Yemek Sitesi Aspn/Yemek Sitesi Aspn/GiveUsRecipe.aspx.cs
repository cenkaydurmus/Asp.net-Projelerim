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
    public partial class GiveUsRecipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into TarifVermeTablosu (Ad,Malzeme,TarifYapılış,TarifKişi,TarifResim,TarifKişiMail) values (@p1,@p2,@p3,@p4,@p5,@p6)", Connection.con);

            Connection.checkConnection(Connection.con);

            commandAdd.Parameters.AddWithValue("@p1", tboxAd.Text);

            commandAdd.Parameters.AddWithValue("@p2", tbboxMalzeme.Text);

            commandAdd.Parameters.AddWithValue("@p3", tboxYapılış.Text);

            commandAdd.Parameters.AddWithValue("@p4", tboxKişiAd.Text);

            commandAdd.Parameters.AddWithValue("@p5", tboxLink.Text);

            commandAdd.Parameters.AddWithValue("@p6", tboxMail.Text);

            commandAdd.ExecuteNonQuery();
        }
    }
}