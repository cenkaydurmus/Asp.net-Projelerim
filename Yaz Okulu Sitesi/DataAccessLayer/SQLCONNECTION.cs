using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class SQLCONNECTION
    {
       public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=YazOkuluVeritabanı;Integrated Security=True");
    }
}
