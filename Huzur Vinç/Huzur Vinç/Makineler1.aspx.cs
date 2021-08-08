using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Huzur_Vinç
{
    public partial class Makineler1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandCategories = new SqlCommand("Select * from TableCategory", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            SqlDataReader drCategories = commandCategories.ExecuteReader();

            DataList1.DataSource = drCategories;

            DataList1.DataBind();

            drCategories.Close();


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