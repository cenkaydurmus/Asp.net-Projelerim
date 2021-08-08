using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Yemek_Sitesi_Aspn.Class
{
    public class Connection
    {

        public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=\"Yemek Sitesi Veritabanı\";Integrated Security=True");
        
        public static void checkConnection(SqlConnection connection)
        {
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
        }
	
    }
}