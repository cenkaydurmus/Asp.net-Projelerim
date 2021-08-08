using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Huzur_Vinç
{
    public partial class AraçEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                SqlCommand commandCategories = new SqlCommand("Select * from TableCategory", SqlConnectionClass.con);

                SqlConnectionClass.CheckConnection();

                SqlDataReader dr = commandCategories.ExecuteReader();

                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "CategoryID";

                DropDownList1.DataSource = dr;

                DropDownList1.DataBind();

                dr.Close();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand commandAddVehicle = new SqlCommand("Insert into TableVehicle (VehicleName,VehicleExp,VehicleCategory,VehiclePhoto) values (@p1,@p2,@p3,@p4)", SqlConnectionClass.con);

            SqlConnectionClass.CheckConnection();

            commandAddVehicle.Parameters.AddWithValue("@p1", tboxAd.Text);
            commandAddVehicle.Parameters.AddWithValue("@p2", tboxExp.Text);
            commandAddVehicle.Parameters.AddWithValue("@p3", Convert.ToInt32(DropDownList1.SelectedValue));
            commandAddVehicle.Parameters.AddWithValue("@p4", tboxPhoto.Text);

            commandAddVehicle.ExecuteNonQuery();

            Response.Write("Araç başarıyla eklendi");
        }
    }
}