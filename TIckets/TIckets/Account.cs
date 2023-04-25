using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIckets
{
    static class Account
    {
        public static bool IsLoginAndPasswordCorrect(SqlConnection connection, string login, string password)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) " +
                                            "FROM Users " +
                                            "WHERE UserLogin = @userLogin AND UserPassword = @userPassword", connection);

            cmd.Parameters.AddWithValue("@userLogin", login);
            cmd.Parameters.AddWithValue("@userPassword", HashGenerator.GetMD5(password));
            int result = (int)cmd.ExecuteScalar();
            return result > 0;
        }

        public static bool IsLoginCorrect(SqlConnection connection, string login)
        {
            SqlCommand getUsersCount = new SqlCommand("SELECT COUNT(*) " +
                                                      "FROM Users " +
                                                      "WHERE UserLogin = @userLogin", connection);

            getUsersCount.Parameters.AddWithValue("@userLogin", login);
            int usersCount = (int)getUsersCount.ExecuteScalar();
            return usersCount > 0;
        }

        public static int GetPasswordEntryAttemptsCount(SqlConnection connection, string login)
        {
            SqlCommand getUserPasswordsAttempts = new SqlCommand("SELECT UserPasswordAttemptsCount " +
                                                                 "FROM Users " +
                                                                 "WHERE UserLogin = @userLogin", connection);

            getUserPasswordsAttempts.Parameters.AddWithValue("@userLogin", login);
            return (int)getUserPasswordsAttempts.ExecuteScalar();
        }

        public static void ResetPasswordEntryAttempts(SqlConnection connection, string login, int attempsCount)
        {
            SqlCommand resetPasswordAttempts = new SqlCommand($"UPDATE Users " +
                                                                     $"SET UserPasswordAttemptsCount = {attempsCount} " +
                                                                     $"WHERE UserLogin = @userLogin", connection);

            resetPasswordAttempts.Parameters.AddWithValue("@userLogin", login);
            resetPasswordAttempts.ExecuteNonQuery();
        }

        public static void DecrementPasswordEntryAttempts(SqlConnection connection, string login)
        {
            SqlCommand decrementPasswordAttempts = new SqlCommand("UPDATE Users " +
                                                                    "SET UserPasswordAttemptsCount = UserPasswordAttemptsCount - 1 " +
                                                                    "WHERE UserLogin = @userLogin", connection);

            decrementPasswordAttempts.Parameters.AddWithValue("@userLogin", login);
            decrementPasswordAttempts.ExecuteNonQuery();
        }

        public static string GetCurrentUserRole(SqlConnection connection, string login)
        {
            SqlCommand cmd = new SqlCommand("SELECT RoleName FROM Roles R " +
                                                        "INNER JOIN Users U " +
                                                        "ON R.RoleID = U.UserRoleID " +
                                                        "WHERE U.UserLogin = @userLogin ", connection);

            cmd.Parameters.AddWithValue("@userLogin", login);

            return (string)cmd.ExecuteScalar();
        }
    }
}
