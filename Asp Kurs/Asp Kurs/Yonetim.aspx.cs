using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Asp_Kurs
{
    public partial class Yonetim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AspKursDatabase;Integrated Security=True");

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand commandLogin = new SqlCommand("Select * from TableUser where UserName=@pun and UserPassword=@ppass",con);

            commandLogin.Parameters.AddWithValue("@pun", tboxKA.Text);

            commandLogin.Parameters.AddWithValue("@ppass", sha256Converter.ComputeSha256Hash(tboxŞifre.Text));

            SqlDataAdapter da = new SqlDataAdapter(commandLogin);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count>0)
            {
                LoginSecureClass.myLogKey = "emirkascert";
                Response.Redirect("AdminAnaSayfaDeneme.aspx");
               
            }
            else
            {
                Response.Write("Giriş başarısız");
            }
        }
    }
}