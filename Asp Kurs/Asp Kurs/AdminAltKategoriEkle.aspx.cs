using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Asp_Kurs
{
    public partial class AdminAltKategoriEkle : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AspKursDatabase;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (LoginSecureClass.myLogKey != "emirkascert")
            {
                LoginSecureClass.myLogKey = " ";
                Response.Redirect("Yonetim.aspx");
            }

            if (Page.IsPostBack==false)
            {
                SqlCommand commandDropdown = new SqlCommand("Select * from TableMainCategory",con);

                DropDownList1.DataTextField = "MainCategoryName";
                DropDownList1.DataValueField = "MainCategoryID";

                con.Open();

                SqlDataReader drDropdown = commandDropdown.ExecuteReader();

                DropDownList1.DataSource = drDropdown;
                DropDownList1.DataBind();

                drDropdown.Close();
                con.Close();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedValue==null)
            {
                Response.Redirect("AdminAltKategoriEkle.aspx");
            }
            else
            {
                SqlCommand commandAdd = new SqlCommand("Insert into TableSubCategory (SubCategoryName,MainID,SubCategoryLink) values (@p1,@p2,@p3)", con);

                con.Open();

                commandAdd.Parameters.AddWithValue("@p1", tboxAltCategoryName.Text);
                commandAdd.Parameters.AddWithValue("@p2", DropDownList1.SelectedValue);
                commandAdd.Parameters.AddWithValue("@p3", tboxAltLink.Text);

                commandAdd.ExecuteNonQuery();

                Response.Write("<script>alert('Alt Kategori Başarıyla Eklendi !');</script>");

                con.Close();
            }


           

          
        }
    }
}