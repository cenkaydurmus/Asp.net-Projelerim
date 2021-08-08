using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Huzur_Vinç
{
    public partial class SosyalMedya : System.Web.UI.Page
    {
        public string backgroundImage2 ;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandSM = new SqlCommand("Select * from TableSM where SMID=@p1", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandSM.Parameters.AddWithValue("@p1", 1);

            SqlDataReader dr = commandSM.ExecuteReader();

            while (dr.Read())
            {
                LabelName.Text = dr[1].ToString();
                LabelPhone.Text = dr[5].ToString();
                LabelMail.Text = dr[6].ToString();
                linkfbook.HRef = dr[4].ToString();
                linkinsta.HRef = dr[2].ToString();
                linkpinsta.HRef = dr[3].ToString();
            }

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

            SqlCommand commandBack = new SqlCommand("Select * from TableBack where BackID=@p1", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandBack.Parameters.AddWithValue("@p1", 1);

            SqlDataReader drBack = commandBack.ExecuteReader();

            while (drBack.Read())
            {
                backgroundImage2 = drBack[1].ToString();
            }

            PageBody.Attributes.Add("style", $"background:url({backgroundImage2}) no-repeat; background-size:cover; ");

            drBack.Close();
        }
    }
}