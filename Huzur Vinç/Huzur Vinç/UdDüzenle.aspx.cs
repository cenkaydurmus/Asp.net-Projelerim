using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Huzur_Vinç
{
    public partial class UdDüzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand commandList = new SqlCommand("Select * from TableUD where UdID=1", SqlConnectionClass.con);

                SqlConnectionClass.CheckConnection();

                SqlDataReader dr = commandList.ExecuteReader();

                while (dr.Read())
                {
                    tboxAdress.Text = dr[7].ToString();
                    tboxMail.Text = dr[8].ToString();
                    tboxPhone.Text = dr[5].ToString();
                    tboxGMap.Text = dr[4].ToString();
                    tboxInsta.Text = dr[1].ToString();
                    tboxFace.Text = dr[2].ToString();
                    tboxWp.Text = dr[3].ToString();
                    tboxAbout.Text = dr[6].ToString();

                }

                dr.Close();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update TableUD set UdMail=@p1 , UdPhone=@p2 , UdAdressNormal=@p3 , UdAdressLink=@p4, UdInsta=@p5, UdFace=@p6, UdWp=@p7, UdAboutUs=@p8  where UdID=@pid", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandEdit.Parameters.AddWithValue("@p1", tboxMail.Text);
            commandEdit.Parameters.AddWithValue("@p2", tboxPhone.Text);
            commandEdit.Parameters.AddWithValue("@p3", tboxAdress.Text);
            commandEdit.Parameters.AddWithValue("@p4", tboxGMap.Text);
            commandEdit.Parameters.AddWithValue("@p5", tboxInsta.Text);
            commandEdit.Parameters.AddWithValue("@p6", tboxFace.Text);
            commandEdit.Parameters.AddWithValue("@p7", tboxWp.Text);
            commandEdit.Parameters.AddWithValue("@p8", tboxAbout.Text);

            commandEdit.Parameters.AddWithValue("@pid", 1);

            commandEdit.ExecuteNonQuery();

            Response.Write("Alt-Üst taraf başarıyla düzenlendi");
        }
    }
}