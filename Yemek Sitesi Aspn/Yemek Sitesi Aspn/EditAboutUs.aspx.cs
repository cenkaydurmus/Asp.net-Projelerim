using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yemek_Sitesi_Aspn.Class;

namespace Yemek_Sitesi_Aspn
{
    public partial class EditAboutUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                SqlCommand commandList = new SqlCommand("Select * from HakkımızdaTablosu where HakkımızdaID=1", Connection.con);

                Connection.checkConnection(Connection.con);

                SqlDataReader dataReader = commandList.ExecuteReader();

                while (dataReader.Read())
                {
                    tboxContent.Text = dataReader[1].ToString();
                    tboxImage.Text = dataReader[2].ToString();
                }

                dataReader.Close();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update HakkımızdaTablosu set Hakkımızda=@p1 , Resim=@p2 where HakkımızdaID=1", Connection.con);

            Connection.checkConnection(Connection.con);

            commandEdit.Parameters.AddWithValue("@p1", tboxContent.Text);

            commandEdit.Parameters.AddWithValue("@p2", tboxImage.Text);

            commandEdit.ExecuteNonQuery();

            Response.Redirect("AdminMainPage.aspx");
        }
    }
}