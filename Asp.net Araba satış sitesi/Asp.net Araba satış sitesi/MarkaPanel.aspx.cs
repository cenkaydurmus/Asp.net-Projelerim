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
    public partial class MarkaPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlCommand readBrands = new SqlCommand("Select *from Brands", ConnectionClass.connect);

                if (readBrands.Connection.State==ConnectionState.Closed)
                {
                    readBrands.Connection.Open();
                }

                SqlDataReader dataReader = readBrands.ExecuteReader();

                DataList1.DataSource = dataReader;

                DataList1.DataBind();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand addBrand = new SqlCommand("Insert into Brands (BrandName) values (@p1)", ConnectionClass.connect);

            addBrand.Parameters.AddWithValue("@p1", txtboxBrandName.Text);

            if (addBrand.Connection.State==ConnectionState.Closed)
            {
                addBrand.Connection.Open();
            }

            addBrand.ExecuteNonQuery();

            Response.Redirect("MarkaPanel.aspx");
        }
    }
}