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
    public partial class Satış1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                ddfuel.Items.Insert(0, new ListItem("Benzin", "Benzin"));
                ddfuel.Items.Insert(1, new ListItem("LPG", "LPG"));
                ddfuel.Items.Insert(2, new ListItem("Dizel", "Dizel"));

                SqlCommand readBrands = new SqlCommand("Select *from Brands", ConnectionClass.connect);

                if (readBrands.Connection.State == ConnectionState.Closed)
                {
                    readBrands.Connection.Open();
                }

                SqlDataReader dataReader = readBrands.ExecuteReader();

                ddbrand.DataSource = dataReader;

                ddbrand.DataTextField = "BrandName";

                ddbrand.DataValueField = "BrandID";

                ddbrand.DataBind();

                dataReader.Close();
            }
            
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlCommand addCar = new SqlCommand("Insert into Cars (CarBrand,CarModel,CarFuelType,CarDescription,CarContact,CarSeller,CarPhoto,CarPrice) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", ConnectionClass.connect);

            if (addCar.Connection.State == ConnectionState.Closed)
            {
                addCar.Connection.Open();
            }

            addCar.Parameters.AddWithValue("@p1", ddbrand.SelectedValue);
            addCar.Parameters.AddWithValue("@p2", tboxModel.Text);
            addCar.Parameters.AddWithValue("@p3", ddfuel.SelectedValue);
            addCar.Parameters.AddWithValue("@p4", tboxDescription.Text);
            addCar.Parameters.AddWithValue("@p5", tboxContact.Text);
            addCar.Parameters.AddWithValue("@p6", tboxSeller.Text);
            addCar.Parameters.AddWithValue("@p7", tboxImage.Text);
            addCar.Parameters.AddWithValue("@p8", tboxPrice.Text);

            addCar.ExecuteNonQuery();
        }
    }
}