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
    public partial class ÖğrenciEkle : System.Web.UI.Page
    {

        BllStudent bllStudent = new BllStudent();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            EntityStudent student = new EntityStudent();
            student.OgrAd = tboxAd.Text;
            student.OgrSoyad = tboxSoyad.Text;
            student.OgrMail = tboxMail.Text;
            student.OgrSifre = tboxPas.Text;
            student.OgrOkulNo = tboxNo.Text;

            bllStudent.BllAddStudent(student);
        }
    }
}