using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT RoleName AS Роль FROM Roles", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.RolesFormGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьРольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleHandlerForm roleHandleForm = new RoleHandlerForm();
            roleHandleForm.StartPosition = FormStartPosition.CenterScreen;
            (roleHandleForm.Controls["RoleHandlerFormEditBtn"] as Button).Enabled = false;
            roleHandleForm.Owner = this;
            roleHandleForm.ShowDialog();
        }

        private void RolesFormGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ROLES WHERE RoleName = @roleNameToDelete", connection);
                    cmd.Parameters.AddWithValue("@roleNameToDelete", RolesFormGridView.CurrentCell.Value.ToString());
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT RoleName AS Роль FROM Roles", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.RolesFormGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void RolesFormGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                RoleHandlerForm roleHandleForm = new RoleHandlerForm();
                roleHandleForm.Owner = this;
                string prevRoleName = RolesFormGridView.CurrentCell.Value.ToString();

                (roleHandleForm.Controls["RoleHandlerFormRoleNameTb"] as TextBox).Text = prevRoleName;          
                SqlCommand cmd = new SqlCommand("SELECT RoleID FROM Roles WHERE RoleName = @roleName", connection);
                cmd.Parameters.AddWithValue("@roleName", prevRoleName);

                roleHandleForm.Tag = cmd.ExecuteScalar();
                roleHandleForm.StartPosition = FormStartPosition.CenterScreen;
                (roleHandleForm.Controls["RoleHandlerFormAddBtn"] as Button).Enabled = false;
                roleHandleForm.ShowDialog();
            }
        }      
    }
}
