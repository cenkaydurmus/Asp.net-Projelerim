using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Asp.net_Araba_satış_sitesi.classes;
using System.Data;

namespace Asp.net_Araba_satış_sitesi
{
    public partial class HakkımızdaVeİletişim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandData = new SqlCommand("Select * from AboutAndContact where AboutID=1", ConnectionClass.connect);

            if (commandData.Connection.State==ConnectionState.Closed)
            {
                commandData.Connection.Open();
            }

            SqlDataReader dataReader = commandData.ExecuteReader();

            DataList1.DataSource = dataReader;

            DataList1.DataBind();
        }
    }
}