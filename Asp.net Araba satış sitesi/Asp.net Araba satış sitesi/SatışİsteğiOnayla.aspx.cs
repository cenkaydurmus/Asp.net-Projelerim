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
    public partial class SatışİsteğiOnayla : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                SqlCommand readCars = new SqlCommand("Select *from Cars where Confirmation=0", ConnectionClass.connect);

                if (readCars.Connection.State == ConnectionState.Closed)
                {
                    readCars.Connection.Open();
                }

                SqlDataReader dataReader = readCars.ExecuteReader();
                

                DataList1.DataSource = dataReader;

                DataList1.DataBind();

                dataReader.Close();

            }
           
            
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}