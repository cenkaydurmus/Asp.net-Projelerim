using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Yemek_Sitesi
{
    public partial class ContactPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            SqlCommand commandSendMessage = new SqlCommand("Insert into MesajTablosu (MesajMail,Mesajİçerik) values (@pmail,@pcontent)", SqlConnectionClass.con);

            SqlConnectionClass.con.Open();

            commandSendMessage.Parameters.AddWithValue("@pmail", tboxMail.Text);
            commandSendMessage.Parameters.AddWithValue("pcontent", tboxContent.Text);

            commandSendMessage.ExecuteNonQuery();

            SqlConnectionClass.con.Close();


            Response.Redirect("/UserMainPage.aspx");
        }
    }
}