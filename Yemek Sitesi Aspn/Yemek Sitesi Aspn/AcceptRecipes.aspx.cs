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
    public partial class AcceptRecipes : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandList = new SqlCommand("Select * from TarifVermeTablosu where TarifOnay=0", Connection.con);

            Connection.checkConnection(Connection.con);

            SqlDataReader dataReader = commandList.ExecuteReader();

            DataList1.DataSource = dataReader;
           
            DataList1.DataBind();

            dataReader.Close();
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
          
        }
    }
}