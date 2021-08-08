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
    public partial class TodaysDinner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandRead = new SqlCommand("Select *from GününYemeğiTablosu where GYemekTarih=@pdate", Connection.con);

            Connection.checkConnection(Connection.con);

            commandRead.Parameters.AddWithValue("@pdate", DateTime.Now.Date);

            SqlDataReader dataReader = commandRead.ExecuteReader();

            DataList1.DataSource = dataReader;

            DataList1.DataBind();

            dataReader.Close();
        }
    }
}