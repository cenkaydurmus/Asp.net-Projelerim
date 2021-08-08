using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Emlak_Asp.Classes;

namespace Emlak_Asp
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                SqlCommand getRooms = new SqlCommand("Select * from TableHomeType", SqlConnectionClass.myConnection);
                SqlConnectionClass.checkMyConnection();

                SqlDataReader drRooms = getRooms.ExecuteReader();

                DropDownListRoom.DataTextField = "HomeType";
                DropDownListRoom.DataValueField = "HomeTypeID";

                DropDownListRoom.DataSource = drRooms;

                DropDownListRoom.DataBind();


                drRooms.Close();


                getCitiesAndValues();

            }

            SqlCommand commandSlides = new SqlCommand("Select * from TableSlide", SqlConnectionClass.myConnection);

            SqlConnectionClass.checkMyConnection();

            SqlDataReader drSlides = commandSlides.ExecuteReader();

            List<string> myList = new List<string>();
            while (drSlides.Read())
            {
                myList.Add(drSlides[2].ToString());
            }

            drSlides.Close();

            foreach (var photo in myList)
            {
                Image newImg = new Image();
                newImg.ImageUrl = photo;
                newImg.AlternateText = "Test image";
                newImg.CssClass = "mySlides";
                newImg.Style.Add("width", "100%");
                mydiv.Controls.Add(newImg);
            }



        }

        public  void getCitiesAndValues()
        {
            SqlCommand getCities = new SqlCommand("Select * from TableCity", SqlConnectionClass.myConnection);
            SqlConnectionClass.checkMyConnection();

            SqlDataReader drCities = getCities.ExecuteReader();

            DropDownListCities.DataTextField = "CityName";
            DropDownListCities.DataValueField = "CityID";

            DropDownListCities.DataSource = drCities;

            DropDownListCities.DataBind();


            drCities.Close();


            SqlCommand getDistricts = new SqlCommand("Select * from TableDistrict where DistrictCityID=@pid", SqlConnectionClass.myConnection);
            SqlConnectionClass.checkMyConnection();

            getDistricts.Parameters.AddWithValue("@pid", DropDownListCities.SelectedValue);

            SqlDataReader drDistricts = getDistricts.ExecuteReader();

            DropDownDistricts.DataTextField = "DistrictName";
            DropDownDistricts.DataValueField = "DistrictID";

            DropDownDistricts.DataSource = drDistricts;

            DropDownDistricts.DataBind();

            drDistricts.Close();



            SqlCommand getNeigh = new SqlCommand("Select * from TableNeighborhood where NeighborhoodDistrictID=@pidneigh", SqlConnectionClass.myConnection);
            SqlConnectionClass.checkMyConnection();

            getNeigh.Parameters.AddWithValue("@pidneigh", DropDownDistricts.SelectedValue);

            SqlDataReader drNeigh = getNeigh.ExecuteReader();

            DropDownNeigh.DataTextField = "NeighborhoodName";
            DropDownNeigh.DataValueField = "NeighborhoodID";

            DropDownNeigh.DataSource = drNeigh;

            DropDownNeigh.DataBind();

            drNeigh.Close();
        }

        public void getDistricts()
        {
            


            SqlCommand getDistricts = new SqlCommand("Select * from TableDistrict where DistrictCityID=@pid", SqlConnectionClass.myConnection);
            SqlConnectionClass.checkMyConnection();

            getDistricts.Parameters.AddWithValue("@pid", DropDownListCities.SelectedValue);

            SqlDataReader drDistricts = getDistricts.ExecuteReader();

            DropDownDistricts.DataTextField = "DistrictName";
            DropDownDistricts.DataValueField = "DistrictID";

            DropDownDistricts.DataSource = drDistricts;

            DropDownDistricts.DataBind();

            drDistricts.Close();



          
        }


        public void getNeighbor()
        {
          


            SqlCommand getNeigh = new SqlCommand("Select * from TableNeighborhood where NeighborhoodDistrictID=@pidneigh", SqlConnectionClass.myConnection);
            SqlConnectionClass.checkMyConnection();

            getNeigh.Parameters.AddWithValue("@pidneigh", DropDownDistricts.SelectedValue);

            SqlDataReader drNeigh = getNeigh.ExecuteReader();

            DropDownNeigh.DataTextField = "NeighborhoodName";
            DropDownNeigh.DataValueField = "NeighborhoodID";

            DropDownNeigh.DataSource = drNeigh;

            DropDownNeigh.DataBind();

            drNeigh.Close();
        }

        protected void DropDownListCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDistricts();
        }

        protected void DropDownDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNeighbor();
        }
    }
}