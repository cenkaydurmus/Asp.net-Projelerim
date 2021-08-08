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
    public partial class SatışAraç : System.Web.UI.Page
    {
        int brandID ;

        protected void Page_Load(object sender, EventArgs e)
        {
            brandID =Convert.ToInt32( Request.QueryString["BrandID"]);
            SqlCommand commandListCars = new SqlCommand("Select * from Cars where CarBrand=@p1 and Confirmation=1", ConnectionClass.connect);

            if (commandListCars.Connection.State==ConnectionState.Closed)
            {
                commandListCars.Connection.Open();
            }

            commandListCars.Parameters.AddWithValue("@p1", brandID);

            SqlDataReader dataReader = commandListCars.ExecuteReader();

            DataList1.DataSource = dataReader;

            DataList1.DataBind();
        }
    }
}