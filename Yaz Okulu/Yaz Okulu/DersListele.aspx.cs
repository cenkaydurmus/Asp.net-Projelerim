using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusniessLogicLayer;

namespace Yaz_Okulu
{
    public partial class DersListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BllLesson bllLesson = new BllLesson();
            if (Page.IsPostBack==false)
            {
                Repeater1.DataSource = bllLesson.BllListLesson();
                Repeater1.DataBind();
            }
        }
    }
}