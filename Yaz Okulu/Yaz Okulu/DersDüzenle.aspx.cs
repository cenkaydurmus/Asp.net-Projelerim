using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BusniessLogicLayer;
using EntityLayer;
using DataAccessLayer;

namespace Yaz_Okulu
{
    public partial class DersDüzenle : System.Web.UI.Page
    {
        BllLesson bllLesson = new BllLesson();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            
             id = Convert.ToInt32(Request.QueryString["DersID"]);
            if (Page.IsPostBack==false)
            {
                SqlCommand commandRead = new SqlCommand("Select *from DersTablosu where DersID=@pid", SqlConnectionClass.connection);

                SqlConnectionClass.CheckConnection();

                commandRead.Parameters.AddWithValue("@pid", id);

                SqlDataReader dataReader = commandRead.ExecuteReader();

                while (dataReader.Read())
                {
                    tboxAd.Text = dataReader[1].ToString();
                    tboxMax.Text = dataReader[2].ToString();
                    tboxMin.Text = dataReader[3].ToString();
                    tboxSayı.Text = dataReader[4].ToString();
                }

                dataReader.Close();
            }
        }

        protected void tboxMin_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            EntityLesson lesson = new EntityLesson();
            lesson.DersAd = tboxAd.Text;
            lesson.MaxKont = Convert.ToInt32(tboxMax.Text);
            lesson.MinKont = Convert.ToInt32(tboxMin.Text);
            lesson.OgrSayısı = Convert.ToInt32(tboxSayı.Text);

            bllLesson.BllEditLesson(lesson, id);

            Response.Redirect("DersListele.aspx");
        }
    }
}