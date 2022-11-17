using System.Data.SqlClient;

namespace TIckets
{
    static class Database
    {
        public static SqlConnection GetConnection()
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Практика\\TIcketsDB\\TIckets\\TIckets\\Tickets.mdf;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
