using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Kurs
{
    public partial class AdminAnaSayfaDeneme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LoginSecureClass.myLogKey!="emirkascert")
            {
                LoginSecureClass.myLogKey = " ";
                Response.Redirect("Yonetim.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LoginSecureClass.myLogKey = " ";
            Response.Redirect("Yonetim.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAnaKategoriEkle.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAltKategoriEkle.aspx");
        }
    }
}