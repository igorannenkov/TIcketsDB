using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TIckets
{
    static  class Database
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Проги\\TIcketsDB\\TIckets\\TIckets\\Tickets.mdf;Integrated Security=True";
            return new SqlConnection(connectionString);
        }  
    }
}
