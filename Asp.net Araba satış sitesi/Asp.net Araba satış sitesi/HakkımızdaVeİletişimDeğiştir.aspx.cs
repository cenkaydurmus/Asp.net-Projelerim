using Asp.net_Araba_satış_sitesi.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net_Araba_satış_sitesi
{
    public partial class HakkımızdaVeİletişimDeğiştir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand editAbout = new SqlCommand("Update AboutAndContact set AboutDescription=@p1 , ContactMail=@p2 , ContactNumber=@p3 where AboutID=1", ConnectionClass.connect);

            if (editAbout.Connection.State == System.Data.ConnectionState.Closed)
            {
                editAbout.Connection.Open();
            }

            editAbout.Parameters.AddWithValue("@p1", tboxabout.Text);

            editAbout.Parameters.AddWithValue("@p2", tboxcontactmail.Text);

            editAbout.Parameters.AddWithValue("@p3", tboxcontactnum.Text);

            editAbout.ExecuteNonQuery();
        }
    }
}