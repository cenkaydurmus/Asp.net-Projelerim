using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusniessLogicLayer;

namespace Yaz_Okulu
{
    public partial class ÖğrenciListele : System.Web.UI.Page
    {
        BllStudent bllStudent = new BllStudent();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                Repeater1.DataSource = bllStudent.BllListStudents();
                Repeater1.DataBind();
            }
         
        }
    }
}