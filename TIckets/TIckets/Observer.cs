using System.Data.SqlClient;

namespace TIckets
{
    internal class Observer
    {
        public static string currentUserLogin;

        public static string GetCurrentUserRole(string userLogin)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT RoleName FROM Roles R " +
                                                "INNER JOIN Users U " +
                                                "ON R.RoleID = U.UserRoleID " +
                                                "WHERE U.UserLogin = @userLogin ", connection);

                cmd.Parameters.AddWithValue("@userLogin", userLogin);
                string currentUserRole = (string)cmd.ExecuteScalar();
                return currentUserRole;
            }
        }
    }
}