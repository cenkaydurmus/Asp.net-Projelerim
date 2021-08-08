using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusniessLogicLayer;

namespace Yaz_Okulu
{
    public partial class ÖğrenciSil : System.Web.UI.Page
    {
        BllStudent bllStudent = new BllStudent();
        protected void Page_Load(object sender, EventArgs e)
        {
           int id=Convert.ToInt32( Request.QueryString["OgrID"]);

            bllStudent.BllDeleteStudent(id);

            Response.Redirect("ÖğrenciListele.aspx");
        }
    }
}