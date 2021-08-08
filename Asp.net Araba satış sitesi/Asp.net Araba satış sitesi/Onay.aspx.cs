using Asp.net_Araba_satış_sitesi.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net_Araba_satış_sitesi
{
    public partial class Onay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                var id = Request.QueryString["CarID"];

                SqlCommand commandApproval = new SqlCommand("Update Cars set Confirmation=1 where CarID=@p1",ConnectionClass.connect);

            commandApproval.Parameters.AddWithValue("@p1", id);

                if (commandApproval.Connection.State == System.Data.ConnectionState.Closed)
                {
                    commandApproval.Connection.Open();
                }

                commandApproval.ExecuteNonQuery();

                Response.Redirect("AdminAnaSayfa.aspx");
           
           
        }
    }
}