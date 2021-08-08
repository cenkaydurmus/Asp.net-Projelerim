using Asp.net_Araba_satış_sitesi.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net_Araba_satış_sitesi
{
    public partial class MarkaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id =Convert.ToInt32( Request.QueryString["BrandID"]);

            SqlCommand deleteBrand = new SqlCommand("Delete from Brands where BrandID=@p1", ConnectionClass.connect);

            if (deleteBrand.Connection.State==ConnectionState.Closed)
            {
                deleteBrand.Connection.Open();
            }

            deleteBrand.Parameters.AddWithValue("@p1", id);

            deleteBrand.ExecuteNonQuery();

            Response.Redirect("MarkaPanel.aspx");
        }
    }
}