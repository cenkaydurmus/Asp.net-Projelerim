using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusniessLogicLayer;
using EntityLayer;

namespace Yaz_Okulu
{
    public partial class ÖğretmenListele : System.Web.UI.Page
    {
        BllTeacher bllTeacher = new BllTeacher();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = bllTeacher.BllListTeacher();
            Repeater1.DataBind();
        }
    }
}