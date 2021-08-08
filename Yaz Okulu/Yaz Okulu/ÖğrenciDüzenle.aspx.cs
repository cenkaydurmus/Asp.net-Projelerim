using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessLayer;
using EntityLayer;
using BusniessLogicLayer;

namespace Yaz_Okulu
{
    public partial class ÖğrenciDüzenle : System.Web.UI.Page
    {
        BllStudent bllStudent = new BllStudent();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
             id = Convert.ToInt32(Request.QueryString["OgrID"]);
            if (Page.IsPostBack==false)
            {
                SqlCommand commandRead = new SqlCommand("Select *from ÖğrenciTablosu where OgrID=@pid", SqlConnectionClass.connection);

                SqlConnectionClass.CheckConnection();

                commandRead.Parameters.AddWithValue("@pid", id);

                SqlDataReader dataReader = commandRead.ExecuteReader();

                while (dataReader.Read())
                {
                    tboxAd.Text = dataReader[1].ToString();
                    tboxSoyad.Text = dataReader[2].ToString();
                    tboxMail.Text = dataReader[3].ToString();
                    tboxPas.Text = dataReader[4].ToString();
                    tboxNo.Text = dataReader[6].ToString();
                }

                dataReader.Close();
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            EntityStudent student = new EntityStudent();
            student.OgrAd = tboxAd.Text;
            student.OgrID=id;
            student.OgrSoyad = tboxSoyad.Text;
            student.OgrMail = tboxMail.Text;
            student.OgrOkulNo = tboxNo.Text;
            student.OgrSifre = tboxPas.Text;

            bllStudent.BllEditStudent(student);
        }
    }
}