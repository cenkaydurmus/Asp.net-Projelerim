using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;

namespace Asp_Kurs
{
    public partial class AdminAnaKategoriEkle : System.Web.UI.Page
    {
        public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AspKursDatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LoginSecureClass.myLogKey != "emirkascert")
            {
                LoginSecureClass.myLogKey = " ";
                Response.Redirect("Yonetim.aspx");
            }

            SqlCommand commandGetMyText = new SqlCommand("Select * from TableTextExample where TextExampleID=@pid", con);

            con.Open();

            commandGetMyText.Parameters.AddWithValue("@pid", 1);

            SqlDataReader myDr = commandGetMyText.ExecuteReader();

            while (myDr.Read())
            {
                editor1.InnerText =Base64Decode( myDr[1].ToString());
            }

            myDr.Close();

            con.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into TableMainCategory (MainCategoryName) values (@pcategoryName)", con);

            sqlCommand.Parameters.AddWithValue("@pcategoryName", tboxCategoryName.Text);

            con.Open();

            sqlCommand.ExecuteNonQuery();

            con.Close();

            Response.Redirect("AdminAnaSayfaDeneme.aspx");

            Response.Write("<script>alert('Ana Kategori Başarıyla Eklendi !');</script>");
        }

        public static string Base64Encode(string metin)
        {
            var metinBaytlari = Encoding.UTF8.GetBytes(metin);
            return Convert.ToBase64String(metinBaytlari);
        }



        public static string Base64Decode(string sifreliMetin)
        {
            var sifreliMetinBaytlari = Convert.FromBase64String(sifreliMetin);
            return Encoding.UTF8.GetString(sifreliMetinBaytlari);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {



            SqlCommand commandEdit = new SqlCommand("Update TableTextExample set TextExample = @ptext where TextExampleID=@pid", con);
            con.Open();

            

            commandEdit.Parameters.AddWithValue("@ptext", Base64Encode(editor1.Value));



            commandEdit.Parameters.AddWithValue("@pid", 1);

            commandEdit.ExecuteNonQuery();

            con.Close();

            Response.Redirect("AdminAnaKategoriEkle.aspx");


        }
    }
}