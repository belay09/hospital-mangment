using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HospitalManagement
{
    internal class connectionCls
    {
        public static SqlConnection openConnection()
        {

            string connectionString = @"Data Source=DESKTOP-A9E7P23\ADAGN;Initial Catalog=hospital;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString.ToString());
            return conn;
        }
    }
}
