using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP_Yemek_Sitesi
{
    public class SqlConnectionClass
    {
       public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=\"Yemek Sitesi Veritabanı\"; Integrated Security=True");
    }
}