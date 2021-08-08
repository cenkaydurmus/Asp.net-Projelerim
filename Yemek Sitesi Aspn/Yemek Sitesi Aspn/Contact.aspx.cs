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
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into MesajTablosu (MesajMail,Mesajİçerik) values (@p1,@p2)", Connection.con);

            Connection.checkConnection(Connection.con);

            commandAdd.Parameters.AddWithValue("@p1", tboxMail.Text);

            commandAdd.Parameters.AddWithValue("@p2", tboxMessage.Text);

            commandAdd.ExecuteNonQuery();

        }
    }
}