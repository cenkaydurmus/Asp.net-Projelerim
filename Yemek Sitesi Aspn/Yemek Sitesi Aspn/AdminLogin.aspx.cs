using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yemek_Sitesi_Aspn
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (tboxUsername.Text=="Admin")
            {
                if (tboxPassword.Text=="aynur123")
                {
                    Response.Redirect("AdminMainPage.aspx");
                }
                else
                {
                    Response.Write("Password is wrong !");
                }
            }
            else
            {
                Response.Write("Username is wrong !");
            }
        }
    }
}