using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Huzur_Vinç
{
    public partial class İletişim : System.Web.UI.Page
    {
        public string backgroundImage3;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandContact = new SqlCommand("Select * from TableContact where ContactID=@p1", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandContact.Parameters.AddWithValue("@p1", 1);

            SqlDataReader dr = commandContact.ExecuteReader();

            while (dr.Read())
            {
               
                LabelPhone.Text = dr[3].ToString();
                LabelMail.Text = dr[1].ToString();
                LabelAdress.Text = dr[2].ToString();
                linkgmaps.HRef = dr[4].ToString();
              
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
                backgroundImage3 = drBack[1].ToString();
            }

            PageBody.Attributes.Add("style", $"background:url({backgroundImage3}) no-repeat; background-size:cover; ");

            drBack.Close();
        }

        protected void btnSendMsg_Click(object sender, EventArgs e)
        {
            SqlCommand commandSendMessage = new SqlCommand("Insert into TableMessages (MessageFName,MessageLName,MessageMail,MessageExp) values (@p1,@p2,@p3,@p4)", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandSendMessage.Parameters.AddWithValue("@p1", fname.Value.ToString());
            commandSendMessage.Parameters.AddWithValue("@p2", lname.Value.ToString());
            commandSendMessage.Parameters.AddWithValue("@p3", lmail.Value.ToString());
            commandSendMessage.Parameters.AddWithValue("@p4", subject.Value.ToString());

            commandSendMessage.ExecuteNonQuery();

        }
    }
}