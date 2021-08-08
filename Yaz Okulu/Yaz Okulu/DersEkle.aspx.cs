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
    public partial class DersEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BllLesson bllLesson = new BllLesson();

        protected void btn_Click(object sender, EventArgs e)
        {
            EntityLesson lesson = new EntityLesson();

            lesson.DersAd = tboxAd.Text;
            lesson.MaxKont = Convert.ToInt32(tboxMax.Text);
            lesson.MinKont = Convert.ToInt32(tboxMin.Text);
            lesson.OgrSayısı = Convert.ToInt32(tboxSayı.Text);

            bllLesson.BllAddLesson(lesson);

            Response.Redirect("ÖğrenciListele.aspx");
        }
    }
}