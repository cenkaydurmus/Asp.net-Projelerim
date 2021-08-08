using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Huzur_Vinç
{
    public partial class GelişmeEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand commandSendMessage = new SqlCommand("Insert into TableNews (NewsExp,NewsPhoto,NewsHeader) values (@p1,@p2,@p3)", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandSendMessage.Parameters.AddWithValue("@p1", tboxEXP.Text);
            commandSendMessage.Parameters.AddWithValue("@p2", tboxPhoto.Text);
            commandSendMessage.Parameters.AddWithValue("@p3", tboxHead.Text);
            

            commandSendMessage.ExecuteNonQuery();

            Response.Write("Gelişme başarıyla eklendi");
        }
    }
}