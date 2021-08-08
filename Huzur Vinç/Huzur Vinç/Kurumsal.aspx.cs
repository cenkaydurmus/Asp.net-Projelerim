using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace Huzur_Vinç
{
    public partial class Kurumsal : System.Web.UI.Page
    {

       
        public string backgroundImage ;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandListKurumsal = new SqlCommand("Select *from TableKurumsal where KurumsalID=@p1", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandListKurumsal.Parameters.AddWithValue("@p1", 1);

            SqlDataReader dr = commandListKurumsal.ExecuteReader();

            while (dr.Read())
            {
                Label1.Text = dr[1].ToString();
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
                backgroundImage = drBack[1].ToString();
            }

            PageBody.Attributes.Add("style", $"background:url({backgroundImage}) no-repeat; background-size:cover; ");

            drBack.Close();
          
        }

       
    }
}