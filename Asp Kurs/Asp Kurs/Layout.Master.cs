using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace Asp_Kurs
{
    public partial class Layout : System.Web.UI.MasterPage
    {
      public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AspKursDatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandListMain = new SqlCommand("Select * from TableMainCategory",con);

            con.Open();

            SqlDataReader drMain = commandListMain.ExecuteReader();

           

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            while (drMain.Read())
            {
                myDictionary.Add(Convert.ToInt32(drMain[0]), drMain[1].ToString());
            }

            drMain.Close();
            con.Close();



            foreach (KeyValuePair<int,string> entry in myDictionary)
            {
                HtmlGenericControl listItem = new HtmlGenericControl();
                listItem.TagName = "li";
                listItem.Attributes["class"] = "dropdown";

               



                HtmlGenericControl a = new HtmlGenericControl();
                a.TagName = "a";
                a.Attributes["class"] = "dropdown-toggle";
                a.Attributes["data-toggle"] = "dropdown";
                a.Attributes["href"] = "#";



                HtmlGenericControl caretSpan = new HtmlGenericControl();
                caretSpan.TagName = "span";
                caretSpan.Attributes["class"] = "caret";




                HtmlGenericControl myUl = new HtmlGenericControl();
                myUl.TagName = "ul";
                myUl.Attributes["class"] = "dropdown-menu";


                a.Controls.Add(caretSpan);
                listItem.Controls.Add(myUl);
                listItem.Controls.Add(a);
                a.InnerHtml = entry.Value;

                myNavList.Controls.Add(listItem);

                foreach (KeyValuePair<string,string> subs in getSubCategories(entry.Key))
                {
                    HtmlGenericControl subsLi = new HtmlGenericControl();
                    subsLi.TagName = "li";

                    HtmlGenericControl subsA = new HtmlGenericControl();
                    subsA.TagName = "a";
                    subsA.Attributes["href"] = subs.Value;
                    subsA.InnerHtml = subs.Key;


                    subsLi.Controls.Add(subsA);

                    myUl.Controls.Add(subsLi);
                    
                }
            }
        }

        public static Dictionary<string,string> getSubCategories(int id)
        {
            SqlCommand commandListSub = new SqlCommand("Select * from TableSubCategory where MainID=@pid", con);

            commandListSub.Parameters.AddWithValue("@pid", id);

            con.Open();

            SqlDataReader drSubs = commandListSub.ExecuteReader();

            

            Dictionary<string, string> mySubsDict = new Dictionary<string, string>();

            while (drSubs.Read())
            {
                mySubsDict.Add(drSubs[1].ToString(), drSubs[3].ToString());
            }

            con.Close();
            drSubs.Close();

            return mySubsDict;

        }

    }
}