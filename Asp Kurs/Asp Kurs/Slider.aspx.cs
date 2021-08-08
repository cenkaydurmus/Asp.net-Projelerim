using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Asp_Kurs
{
    public partial class Slider : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AspKursDatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandListImages = new SqlCommand("Select * from TableResim where ResimGörünürlük=@pg",con);
            commandListImages.Parameters.AddWithValue("@pg", true);

            con.Open();

            SqlDataReader dr = commandListImages.ExecuteReader();

            List<string> myList = new List<string>();
            while (dr.Read())
            {
               
                myList.Add(dr[1].ToString());
            }


            foreach (var photo in myList)
            {
                Image img = new Image();
                img.ImageUrl = photo;
                img.AlternateText = "Test image";
                mydiv.Controls.Add(img);
                img.CssClass = "mySlides";
                img.Style.Add("width", "100%");
            }
            
        }
    }
}