using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System;

namespace TIckets
{
    static class Database
    {
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["TicketsDB"].ConnectionString;
            return new SqlConnection(connString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
