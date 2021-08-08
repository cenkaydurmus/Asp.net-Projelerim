using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Huzur_Vinç
{
    public partial class TekGelişme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            SqlCommand commandNews = new SqlCommand("Select * from TableNews where NewsID=@p1", SqlConnectionClass.con);

            commandNews.Parameters.AddWithValue("@p1", id);

            SqlConnectionClass.CheckConnection();

            SqlDataReader dr = commandNews.ExecuteReader();

            DataList1.DataSource = dr;

            DataList1.DataBind();

            dr.Close();


            SqlCommand commandUD = new SqlCommand("Select * from TableUD where UdID=@p1", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandUD.Parameters.AddWithValue("@p1", 1);

            SqlDataReader drUD = commandUD.ExecuteReader();

            while (drUD.Read())
            {
                linkudinsta.HRef = drUD[1].ToString();
                linkudface.HRef = drUD[2].ToString();
                linkudwp.HRef = drUD[3].ToString();
                linkudmap.HRef = drUD[4].ToString();
                linkudphone.HRef = drUD[5].ToString();
                pabout.InnerText = drUD[6].ToString();
                padress.InnerText = "Adres:" + drUD[7].ToString();
                pphone.InnerText = drUD[5].ToString();
                pmail.InnerText = "Mail adresi:" + drUD[8].ToString();
                btnphone.HRef = drUD[5].ToString();
            }

            drUD.Close();
        }
    }
}