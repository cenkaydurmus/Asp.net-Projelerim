using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Huzur_Vinç
{
    public partial class Giriş : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand commandLogin = new SqlCommand("Select * from TableUser where UserName=@p1 and UserPass=@p2", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandLogin.Parameters.AddWithValue("@p1", tboxKa.Value.ToString());
            commandLogin.Parameters.AddWithValue("@p2", tboxPass.Value.ToString());

            SqlDataAdapter da = new SqlDataAdapter(commandLogin);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count>0)
            {
                Response.Write("Giriş başarılı");
                Response.Redirect("AdminAnaSayfa.aspx");
            }
            else
            {
                Response.Write("Giriş başarısız");
            }
        }
    }
}