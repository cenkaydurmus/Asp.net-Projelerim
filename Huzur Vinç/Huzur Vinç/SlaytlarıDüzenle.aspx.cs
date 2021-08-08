using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Huzur_Vinç
{
    public partial class SlaytlarıDüzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand commandList = new SqlCommand("Select * from TableSlide where SlaytID=1", SqlConnectionClass.con);

                SqlConnectionClass.CheckConnection();

                SqlDataReader dr = commandList.ExecuteReader();

                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox3.Text = dr[3].ToString();
                    TextBox4.Text = dr[4].ToString();
                    TextBox5.Text = dr[5].ToString();
                    TextBox6.Text = dr[6].ToString();
                    TextBox7.Text = dr[7].ToString();

                }

                dr.Close();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update TableSlide set Slayt1=@p1 , Slayt2=@p2 , Slayt3=@p3 , Slayt4=@p4, Slayt5=@p5  , Slayt6=@p6 , Slayt7=@p7   where SlaytID=@pid", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandEdit.Parameters.AddWithValue("@p1", TextBox1.Text);
            commandEdit.Parameters.AddWithValue("@p2", TextBox2.Text);
            commandEdit.Parameters.AddWithValue("@p3", TextBox3.Text);
            commandEdit.Parameters.AddWithValue("@p4", TextBox4.Text);
            commandEdit.Parameters.AddWithValue("@p5", TextBox5.Text);
            commandEdit.Parameters.AddWithValue("@p6", TextBox6.Text);
            commandEdit.Parameters.AddWithValue("@p7", TextBox7.Text);

            commandEdit.Parameters.AddWithValue("@pid", 1);

            commandEdit.ExecuteNonQuery();

            Response.Write("Slaytlar başarıyla düzenlendi");
        }
    }
}