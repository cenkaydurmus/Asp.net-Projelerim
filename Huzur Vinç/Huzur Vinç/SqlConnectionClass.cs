using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Huzur_Vinç
{
    public class SqlConnectionClass
    {
       public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HuzurVinçDB;Integrated Security=True");

        public static void CheckConnection()
        {
            if (con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {

            }
        }
    }
}