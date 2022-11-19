using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                cmd = new SqlCommand("UPDATE Users SET " +
                                        "UserName = @userName, " +
                                        "UserRoleID = @userRoleID" +
                                        " WHERE UserID = @updateID", connection);

                cmd.Parameters.AddWithValue("@userName", UserHandlerFormUserNameTb.Text);
                cmd.Parameters.AddWithValue("@userRoleID", userRoleID);
                cmd.Parameters.AddWithValue("@updateID", updateID);

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT UserID AS ID, UserName AS ФИО, RoleName AS Роль " +
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
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT RoleID FROM Roles " +
                                                "WHERE RoleName = @roleName", connection);

                cmd.Parameters.AddWithValue("@roleName", UserHandlerFormUserRoleCb.Text);
                int roleID = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO Users (UserName, UserRoleID) " +
                                                "VALUES (@userName, @roleID)", connection);

                cmd.Parameters.AddWithValue("@userName", UserHandlerFormUserNameTb.Text);
                cmd.Parameters.AddWithValue("@roleID", roleID);

                cmd.ExecuteNonQuery();

                string command = "SELECT UserID AS ID, UserName AS ФИО, RoleName AS Роль " +
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
