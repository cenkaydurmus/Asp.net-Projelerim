using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Huzur_Vinç
{
    public partial class İletişimDüzenle1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                SqlCommand commandList = new SqlCommand("Select * from TableContact where ContactID=1", SqlConnectionClass.con);

                SqlConnectionClass.CheckConnection();

                SqlDataReader dr = commandList.ExecuteReader();

                while (dr.Read())
                {
                    tboxAdress.Text = dr[2].ToString();
                    tboxMail.Text = dr[1].ToString();
                    tboxPhone.Text = dr[3].ToString();
                    tboxGMap.Text = dr[4].ToString();

                }

                dr.Close();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update TableContact set ContactMail=@p1 , ContactPhone=@p2 , ContactAdress=@p3 , ContactMapLink=@p4  where ContactID=@pid", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandEdit.Parameters.AddWithValue("@p1", tboxMail.Text);
            commandEdit.Parameters.AddWithValue("@p2", tboxPhone.Text);
            commandEdit.Parameters.AddWithValue("@p3", tboxAdress.Text);
            commandEdit.Parameters.AddWithValue("@p4", tboxGMap.Text);
           
            commandEdit.Parameters.AddWithValue("@pid", 1);

            commandEdit.ExecuteNonQuery();

            Response.Write("İletişim başarıyla düzenlendi");

        }
    }
}