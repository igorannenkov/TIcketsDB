using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TIckets
{
    public partial class UserHandleForm : Form
    {
        public UserHandleForm()
        {
            InitializeComponent();
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT RoleName AS Роль FROM Roles", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.UserHandlerFormUserRoleCb.ValueMember = "Роль";
                this.UserHandlerFormUserRoleCb.DataSource = ds.Tables[0];
            }
        }

        private void UserHandlerFormEditBtn_Click(object sender, EventArgs e)
        {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT RoleID FROM Roles " +
                                                    "WHERE RoleName = @roleName", connection);

                    cmd.Parameters.AddWithValue("@roleName", UserHandlerFormUserRoleCb.Text);

                    int userRoleID = (int)cmd.ExecuteScalar();
                    int updateID = (int)(this.Owner.Controls["UsersFormGridView"] as DataGridView).CurrentRow.Cells[0].Value;

                    string newPassword = string.Empty;

                    if (UserHandlerFormResetPwdChb.Checked)
                    {
                        newPassword = ", UserPassword = @password ";
                    }

                    cmd = new SqlCommand("UPDATE Users SET " +
                                            "UserName = @userName, " +
                                            "UserRoleID = @userRoleID, " +
                                            "UserLogin = @login " + newPassword +
                                            " WHERE UserID = @updateID", connection);

                    cmd.Parameters.AddWithValue("@userName", UserHandlerFormUserNameTb.Text);
                    cmd.Parameters.AddWithValue("@userRoleID", userRoleID);
                    cmd.Parameters.AddWithValue("@login", UserHandlerFormUserLoginTb.Text);
                    cmd.Parameters.AddWithValue("@password", HashGenerator.GetMD5("1234567890"));
                    cmd.Parameters.AddWithValue("@updateID", updateID);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Не удается обновить данные. Пользователь с логином " + UserHandlerFormUserLoginTb.Text + " уже существует. Используйте другой логин.",
                        "Ошибка обновления данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }
                

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT UserID AS ID, UserName AS ФИО, RoleName AS Роль, UserLogin AS Логин, UserPassword AS [Пароль MD5] " +
                                                                "FROM Users U " +
                                                                "INNER JOIN Roles R ON U.UserRoleID = R.RoleID", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    (this.Owner.Controls["UsersFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                    this.Close();
                }
        }

        private void UserHandlerFormAddBtn_Click(object sender, EventArgs e)
        {
            // Проверка на наличие недопустимых символов
            if (UserHandlerFormUserNameTb.Text.Any(ch => !char.IsLetterOrDigit(ch)) ||
                UserHandlerFormUserLoginTb.Text.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                MessageBox.Show("В ФИО пользователя или логине содержатся недопустимые символы. Проверьте ввод и попробуйте снова.", 
                    "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT RoleID FROM Roles " +
                                                "WHERE RoleName = @roleName", connection);

                cmd.Parameters.AddWithValue("@roleName", UserHandlerFormUserRoleCb.Text);
                int roleID = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO Users (UserName, UserRoleID, UserLogin, UserPassword) " +
                                                "VALUES (@userName, @roleID, @login, @password)", connection);

                cmd.Parameters.AddWithValue("@userName", UserHandlerFormUserNameTb.Text);
                cmd.Parameters.AddWithValue("@roleID", roleID);
                cmd.Parameters.AddWithValue("@login", UserHandlerFormUserLoginTb.Text);
                cmd.Parameters.AddWithValue("@password", HashGenerator.GetMD5("1234567890"));

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Не удается добавить данные. Пользователь с логином " + UserHandlerFormUserLoginTb.Text + " уже существует. Используйте другой логин.",
                        "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }

                string command = "SELECT UserID AS ID, UserName AS ФИО, RoleName AS Роль, UserLogin AS Логин, UserPassword AS [Пароль MD5] " +
                                 "FROM Users U " +
                                 "INNER JOIN Roles R ON U.UserRoleID = R.RoleID";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["UsersFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }   
        }

        private void UserHandlerFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
