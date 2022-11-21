using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TIckets
{
    static class Database
    {
        public static SqlConnection GetConnection()
        {
            string homeConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\Проги\\TIcketsDB\\TIckets\\TIckets\\Tickets.mdf; Integrated Security = True";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Практика\\TIcketsDB\\TIckets\\TIckets\\Tickets.mdf;Integrated Security=True";
            return new SqlConnection(homeConnectionString);
        }
    }
}
