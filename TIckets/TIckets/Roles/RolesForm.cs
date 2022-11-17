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
                    string toDelete = RolesFormGridView.CurrentCell.Value.ToString();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ROLES WHERE RoleName = N'" + toDelete + "'", connection);
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
            RoleHandlerForm roleHandleForm = new RoleHandlerForm();
            roleHandleForm.Owner = this;
            string prevRoleName = RolesFormGridView.CurrentCell.Value.ToString();
            (roleHandleForm.Controls["RoleHandlerFormRoleNameTb"] as TextBox).Text = prevRoleName;
            roleHandleForm.Tag = prevRoleName;
            roleHandleForm.StartPosition = FormStartPosition.CenterScreen;
            (roleHandleForm.Controls["RoleHandlerFormAddBtn"] as Button).Enabled = false;
            roleHandleForm.ShowDialog();
        }

        
    }
}
