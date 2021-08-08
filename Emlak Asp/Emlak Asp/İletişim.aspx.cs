using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Emlak_Asp.Classes;

namespace Emlak_Asp
{
    public partial class İletişim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            tboxMail.Text = " ";
            tboxNameSurname.Text = " ";
            tboxMessage.Value = " ";
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            SqlCommand commandSendMessage = new SqlCommand("Insert into TableContact (ContactMail,ContactNameSurname,ContactMessage) values (@pmail,@pname,@pmessage)", SqlConnectionClass.myConnection);

            SqlConnectionClass.checkMyConnection();

            commandSendMessage.Parameters.AddWithValue("@pmail", tboxMail.Text);
            commandSendMessage.Parameters.AddWithValue("@pname", tboxNameSurname.Text);
            commandSendMessage.Parameters.AddWithValue("@pmessage", tboxMessage.Value.ToString());

            commandSendMessage.ExecuteNonQuery();

            Response.Write("<script>alert('Mesajınız gönderildi !');</script>");

            tboxMail.Text = " ";
            tboxNameSurname.Text = " ";
            tboxMessage.Value = " ";
        }
    }
}