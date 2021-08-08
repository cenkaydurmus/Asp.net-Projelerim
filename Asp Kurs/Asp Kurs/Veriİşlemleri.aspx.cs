using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Asp_Kurs
{
    public partial class Veriİşlemleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      public  SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AspKursDatabase;Integrated Security=True");

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Tüm verileri çekmek
           

            SqlCommand commandListAll = new SqlCommand("Select * from TableKurumsal", con);

            con.Open();

            SqlDataReader dr = commandListAll.ExecuteReader();

            DataList1.DataSource = dr;

            DataList1.DataBind();

            con.Close();

            dr.Close();


         

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Belirli bir veriyi al

            int selectedID = Convert.ToInt32(tboxID.Text);

            SqlCommand commandListByID = new SqlCommand("Select * from TableKurumsal where KurumsalID=@pid", con);

            commandListByID.Parameters.AddWithValue("@pid", selectedID);

            con.Open();

            SqlDataReader dr2 = commandListByID.ExecuteReader();

            DataList1.DataSource = dr2;

            DataList1.DataBind();

            con.Close();

            dr2.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(tboxID.Text);

            SqlCommand commandDeleteByID = new SqlCommand("Delete from TableKurumsal where KurumsalID=@pid", con);

            commandDeleteByID.Parameters.AddWithValue("@pid", selectedID);

            con.Open();

            commandDeleteByID.ExecuteNonQuery();

            con.Close();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(txtBoxEditID.Text);

            SqlCommand commandEdit = new SqlCommand("Update TableKurumsal set AltKategori1=@palt1 , AltKategori2=@palt2 where KurumsalID=@pid", con);
            commandEdit.Parameters.AddWithValue("@pid", selectedID);
            commandEdit.Parameters.AddWithValue("@palt1", txtBoxEditp1.Text);
            commandEdit.Parameters.AddWithValue("@palt2", txtBoxEditp2.Text);

            con.Open();

            commandEdit.ExecuteNonQuery();

            con.Close();


          

        }

        protected void txtBoxEditID_TextChanged(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(txtBoxEditID.Text);

            SqlCommand commandListByIDEdit = new SqlCommand("Select * from TableKurumsal where KurumsalID=@pid", con);


            commandListByIDEdit.Parameters.AddWithValue("@pid", selectedID);

            con.Open();

            SqlDataReader drEdit = commandListByIDEdit.ExecuteReader();

            while (drEdit.Read())
            {
                txtBoxEditp1.Text = drEdit[1].ToString();
                txtBoxEditp2.Text = drEdit[2].ToString();
            }

            con.Close();
            drEdit.Close();
        }
    }
}