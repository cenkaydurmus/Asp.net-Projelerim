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
    public partial class AdminDeleteMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            SqlCommand commandDelete = new SqlCommand("Delete from MesajTablosu where MesajID=@p1", Connection.con);

            Connection.checkConnection(Connection.con);

            commandDelete.Parameters.AddWithValue("@p1", id);

            commandDelete.ExecuteNonQuery();

            Response.Redirect("AdminSeeAllMessages.aspx");
        }
    }
}