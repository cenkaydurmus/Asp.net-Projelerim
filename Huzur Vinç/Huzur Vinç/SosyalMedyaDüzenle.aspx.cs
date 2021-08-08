using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Huzur_Vinç
{
    public partial class İletişimDüzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                SqlCommand commandList = new SqlCommand("Select * from TableSM where SMId=1",SqlConnectionClass.con);

                SqlConnectionClass.CheckConnection();

                SqlDataReader dr = commandList.ExecuteReader();

                while (dr.Read())
                {
                    tboxFace.Text = dr[4].ToString();
                    tboxInsta1.Text = dr[2].ToString();
                    tboxInsta2.Text = dr[3].ToString();
                    tboxMail.Text = dr[6].ToString();
                    tboxName.Text = dr[1].ToString();
                    tboxPhone.Text = dr[5].ToString();
                   
                }

                dr.Close();
            }
           
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update TableSM set SMName=@p1 , SMInsta1=@p2 , SMInsta2=@p3 , SMFace=@p4, SMTel=@p5 , SMMail=@p6 where SMID=@p7", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandEdit.Parameters.AddWithValue("@p1", tboxName.Text);
            commandEdit.Parameters.AddWithValue("@p2", tboxInsta1.Text);
            commandEdit.Parameters.AddWithValue("@p3", tboxInsta2.Text);
            commandEdit.Parameters.AddWithValue("@p4", tboxFace.Text);
            commandEdit.Parameters.AddWithValue("@p5", tboxPhone.Text);
            commandEdit.Parameters.AddWithValue("@p6", tboxMail.Text);
            commandEdit.Parameters.AddWithValue("@p7", 1);

            commandEdit.ExecuteNonQuery();

            Response.Write("Sosyal Medya başarıyla düzenlendi");
            
        }
    }
}