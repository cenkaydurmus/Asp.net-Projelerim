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
    public partial class CommentsByRecipes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            SqlCommand commandList = new SqlCommand("Select * from YorumlarTablosu where YemekID=@p1 and YorumOnay=1", Connection.con);

            Connection.checkConnection(Connection.con);

            commandList.Parameters.AddWithValue("@p1", id);

            SqlDataReader dataReader = commandList.ExecuteReader();

            DataList1.DataSource = dataReader;

            DataList1.DataBind();

            dataReader.Close();
        }
    }
}