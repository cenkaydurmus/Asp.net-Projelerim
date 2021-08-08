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
    public partial class AcceptRecipes2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            SqlCommand commandAccept = new SqlCommand("Update TarifVermeTablosu set TarifOnay=1 where TarifID=@p1", Connection.con);

            commandAccept.Parameters.AddWithValue("@p1", id);

            Connection.checkConnection(Connection.con);

            commandAccept.ExecuteNonQuery();

            Response.Redirect("AdminMainPage.aspx");
        }
    }
}