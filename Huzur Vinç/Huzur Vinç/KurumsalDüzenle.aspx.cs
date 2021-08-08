using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Huzur_Vinç
{
    public partial class KurumsalDüzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                SqlCommand commandList = new SqlCommand("Select * from TableKurumsal where KurumsalID=@p1", SqlConnectionClass.con);

                SqlConnectionClass.CheckConnection();

                commandList.Parameters.AddWithValue("@p1", 1);

                SqlDataReader dr = commandList.ExecuteReader();

                while (dr.Read())
                {
                    tboxText.Text = dr[1].ToString();
                }

                dr.Close();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update TableKurumsal set KurumsalMetin=@p1 where KurumsalID=@p2", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandEdit.Parameters.AddWithValue("@p1", tboxText.Text);
            commandEdit.Parameters.AddWithValue("@p2", 1);

            commandEdit.ExecuteNonQuery();

            Response.Write("İşlem başarıyla tamamlandı");
        }
    }
}