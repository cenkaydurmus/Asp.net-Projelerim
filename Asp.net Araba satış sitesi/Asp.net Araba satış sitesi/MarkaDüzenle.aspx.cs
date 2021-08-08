using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Asp.net_Araba_satış_sitesi.classes;

namespace Asp.net_Araba_satış_sitesi
{
    public partial class MarkaDüzenle : System.Web.UI.Page
    {
        int selectedId = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt32(Request.QueryString["BrandID"]);

            if (Page.IsPostBack==false)
            {
                SqlCommand commandRead = new SqlCommand("Select *from Brands where BrandID=@p1 ", ConnectionClass.connect);

                if (commandRead.Connection.State == System.Data.ConnectionState.Closed)
                {
                    commandRead.Connection.Open();
                }

                commandRead.Parameters.AddWithValue("@p1", selectedId);

                SqlDataReader dataReader = commandRead.ExecuteReader();

                while (dataReader.Read())
                {
                    tboxName.Text = dataReader[1].ToString();
                }

                dataReader.Close();
            }
          
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update Brands set BrandName=@pname where BrandID=@pid", ConnectionClass.connect);

            if (commandEdit.Connection.State == System.Data.ConnectionState.Closed)
            {
                commandEdit.Connection.Open();
            }

            commandEdit.Parameters.AddWithValue("@pname", tboxName.Text);

            commandEdit.Parameters.AddWithValue("@pid", selectedId);

            commandEdit.ExecuteNonQuery();

            Response.Redirect("MarkaPanel.aspx");
        }
    }
}