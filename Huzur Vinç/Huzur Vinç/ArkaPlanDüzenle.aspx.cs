using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Huzur_Vinç
{
    public partial class ArkaPlanDüzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update TableBack set BackLink=@plink where BackID=@pid", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandEdit.Parameters.AddWithValue("@plink", tboxLink.Text);
            commandEdit.Parameters.AddWithValue("@pid", 1);

            commandEdit.ExecuteNonQuery();

            Response.Write("Başarıyla düzenlendi");
        }
    }
}