using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Emlak_Asp.Classes
{
    public class SqlConnectionClass
    {
        public static SqlConnection myConnection = new SqlConnection("Data Source=.;Initial Catalog=EstateDB;Integrated Security=True");

        public static void checkMyConnection()
        {
            if (myConnection.State==System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }
            else
            {

            }
        }
    }
}