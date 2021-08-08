using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Asp.net_Araba_satış_sitesi.classes;

namespace Asp.net_Araba_satış_sitesi
{
    public partial class Satış : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand readBrands = new SqlCommand("Select *from Brands", ConnectionClass.connect);

            if (readBrands.Connection.State == ConnectionState.Closed)
            {
                readBrands.Connection.Open();
            }

            SqlDataReader dataReader = readBrands.ExecuteReader();

            DataList1.DataSource = dataReader;

            DataList1.DataBind();

            dataReader.Close();
        }
    }
}