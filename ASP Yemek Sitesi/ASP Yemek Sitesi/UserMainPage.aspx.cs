using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Yemek_Sitesi
{
    public partial class UserMainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandListCategories = new SqlCommand("Select * from KategoriTablosu",SqlConnectionClass.con);

            SqlConnectionClass.con.Open();

            SqlDataReader dr = commandListCategories.ExecuteReader();

            DataList1.DataSource = dr;

            DataList1.DataBind();

            SqlConnectionClass.con.Close();
        }
    }
}