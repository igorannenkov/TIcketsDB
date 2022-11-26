using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class RoleHandlerForm : Form
    {
        public RoleHandlerForm()
        {
            InitializeComponent();
        }
        private void RoleHandleFormAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Roles (RoleName) VALUES (@roleName)", connection);
                cmd.Parameters.AddWithValue("@roleName", RoleHandlerFormRoleNameTb.Text);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT RoleName AS Роль FROM Roles", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["RolesFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void RoleHandleFormEditBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                int prevRoleID = (int)this.Tag;

                SqlCommand cmd = new SqlCommand("UPDATE Roles SET RoleName =  @newRoleName WHERE RoleID = @prevRoleID", connection);
                cmd.Parameters.AddWithValue("@newRoleName", RoleHandlerFormRoleNameTb.Text);
                cmd.Parameters.AddWithValue("@prevRoleID", prevRoleID);               
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT RoleName AS Роль FROM Roles", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["RolesFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void RoleHandleFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}