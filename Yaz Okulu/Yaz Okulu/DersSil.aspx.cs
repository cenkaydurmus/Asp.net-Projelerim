using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusniessLogicLayer;

namespace Yaz_Okulu
{
    public partial class DersSil : System.Web.UI.Page
    {
        BllLesson bllLesson = new BllLesson();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["DersID"]);
            bllLesson.BllDeleteLesson(id);
            Response.Redirect("DersListele.aspx");
        }
    }
}