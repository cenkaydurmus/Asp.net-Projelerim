using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Data;

namespace Asp_Kurs
{
    public partial class TabloDeneme : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AspKursDatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
           

            SqlCommand commandListTable = new SqlCommand("Select TableTitle,TableName,TableDay from TableExample",con);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(commandListTable);

            DataTable dt = new DataTable();

            da.Fill(dt);


            GridView1.DataSource = dt;
            GridView1.DataBind();

            con.Close();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Konu";
                e.Row.Cells[1].Text = "İçerik";
                e.Row.Cells[2].Text = "Tamamlanma süresi";
            }
        }
    }
}