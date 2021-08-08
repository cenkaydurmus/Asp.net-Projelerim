using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Kurs
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AspKursDatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update TableTextExample set TextExample = @ptext where TextExampleID=@pid", con);
            con.Open();


            commandEdit.Parameters.AddWithValue("@ptext", myEditorText.myText);



            commandEdit.Parameters.AddWithValue("@pid", 1);

            commandEdit.ExecuteNonQuery();

            con.Close();

            Response.Redirect("AdminAnaKategoriEkle.aspx");

        }
    }
}