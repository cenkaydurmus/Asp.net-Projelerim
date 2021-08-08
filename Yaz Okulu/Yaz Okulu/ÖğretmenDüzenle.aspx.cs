using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusniessLogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace Yaz_Okulu
{
    public partial class ÖğretmenDüzenle : System.Web.UI.Page
    {
        BllTeacher bllTeacher = new BllTeacher();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["OgrtID"]);
            if (Page.IsPostBack == false)
            {
              
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "DersID";
                DropDownList1.DataSource = bllTeacher.BllListLessons();

                DropDownList1.DataBind();

                SqlCommand commandRead = new SqlCommand("Select *from ÖğretmenTablosu where OgrtID=@pid", SqlConnectionClass.connection);

                SqlConnectionClass.CheckConnection();

                commandRead.Parameters.AddWithValue("@pid", id);

                SqlDataReader dataReader = commandRead.ExecuteReader();

                while (dataReader.Read())
                {
                    tboxAd.Text = dataReader[1].ToString();
                    DropDownList1.SelectedValue =dataReader[2].ToString();
                }

                dataReader.Close();
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            EntityTeacher teacher = new EntityTeacher();
            
            teacher.OgrtAdSoyad = tboxAd.Text;
            teacher.OgrtDersID =Convert.ToInt32( DropDownList1.SelectedValue);

            bllTeacher.BllEditTeacher(teacher,id);


        }
    }
}