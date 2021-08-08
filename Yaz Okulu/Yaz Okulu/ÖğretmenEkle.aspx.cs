using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusniessLogicLayer;
using EntityLayer;


namespace Yaz_Okulu
{
    public partial class ÖğretmenEkle : System.Web.UI.Page
    {
        BllTeacher bllTeacher = new BllTeacher();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "DersID";
               DropDownList1.DataSource= bllTeacher.BllListLessons();
                
               DropDownList1.DataBind();
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            EntityTeacher teacher = new EntityTeacher();

            teacher.OgrtAdSoyad = tboxAd.Text;
            teacher.OgrtDersID = Convert.ToInt32(DropDownList1.SelectedValue);

            bllTeacher.BllAddTeacher(teacher);

            Response.Redirect("ÖğretmenListele.aspx");
        }
    }
}