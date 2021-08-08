using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yemek_Sitesi_Aspn.Class;

namespace Yemek_Sitesi_Aspn
{
    public partial class RecipesByCategories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(Request.QueryString["KategoriID"]);

            SqlCommand commandList = new SqlCommand("Select * from YemekTablosu where KategoriID=@pid", Connection.con);

            Connection.checkConnection(Connection.con);

            commandList.Parameters.AddWithValue("@pid", categoryID);

            SqlDataReader dataReader = commandList.ExecuteReader();

            DataList1.DataSource = dataReader;

            DataList1.DataBind();

            dataReader.Close();
        }
    }
}