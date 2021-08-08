using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Yemek_Sitesi
{
    public partial class FoodDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["foodID"]);

            SqlCommand commandList = new SqlCommand("Select * from YemekTablosu where YemekID=@pid", SqlConnectionClass.con);

            SqlConnectionClass.con.Open();

            commandList.Parameters.AddWithValue("@pid", id);

            SqlDataReader dr = commandList.ExecuteReader();

            DataList1.DataSource = dr;

            DataList1.DataBind();

            SqlConnectionClass.con.Close();
        }
    }
}