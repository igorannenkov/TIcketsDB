using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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
            RoleHandleForm roleHandleForm = new RoleHandleForm();
            roleHandleForm.StartPosition = FormStartPosition.CenterScreen;
            (roleHandleForm.Controls["RoleHandleFormEditBtn"] as Button).Enabled = false;
            roleHandleForm.Owner = this;
            roleHandleForm.ShowDialog();
        }

        private void RolesFormGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RoleHandleForm roleHandleForm = new RoleHandleForm();
            roleHandleForm.Owner = this;
            string prevRoleName = RolesFormGridView.CurrentCell.Value.ToString();
            (roleHandleForm.Controls["RoleHandleFormRoleNameTb"] as TextBox).Text = prevRoleName;
            roleHandleForm.Tag = prevRoleName;
            roleHandleForm.StartPosition = FormStartPosition.CenterScreen;
            (roleHandleForm.Controls["RoleHandleFormAddBtn"] as Button).Enabled = false;
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
    }
}
