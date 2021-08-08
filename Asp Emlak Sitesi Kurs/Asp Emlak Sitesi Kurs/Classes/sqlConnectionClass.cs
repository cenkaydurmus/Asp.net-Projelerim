using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Asp_Emlak_Sitesi_Kurs.Classes
{
    public class sqlConnectionClass
    {
       public static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-N542L05B;Initial Catalog=EmlakDB;Integrated Security=True");

        public static void checkConnection()
        {
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {

            }
        }
    }
}