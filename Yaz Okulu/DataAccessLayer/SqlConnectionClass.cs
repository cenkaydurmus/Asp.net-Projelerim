using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class SqlConnectionClass
    {
       public static SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=YazOkuluVeritabanı;Integrated Security=True");

        public static void CheckConnection()
        {
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}
