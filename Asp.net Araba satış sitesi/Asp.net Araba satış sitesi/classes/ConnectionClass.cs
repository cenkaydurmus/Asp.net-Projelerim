using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Asp.net_Araba_satış_sitesi.classes
{
    public class ConnectionClass
    {
       public static SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=CarSelling;Integrated Security=True;MultipleActiveResultSets=True");
    }
}