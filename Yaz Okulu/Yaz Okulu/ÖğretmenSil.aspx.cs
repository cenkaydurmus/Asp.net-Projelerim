using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusniessLogicLayer;
using DataAccessLayer;

namespace Yaz_Okulu
{
    public partial class ÖğretmenSil : System.Web.UI.Page
    {
        int id;
        BllTeacher bllTeacher = new BllTeacher();
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["OgrtID"]);

            bllTeacher.BllDeleteTeacher(id);

            Response.Redirect("ÖğretmenListele.aspx");
        }
    }
}