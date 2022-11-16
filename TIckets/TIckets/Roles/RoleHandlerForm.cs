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
    public partial class RoleHandlerForm : Form
    {
        public RoleHandlerForm()
        {
            InitializeComponent();
        }

        private void RoleHandleFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoleHandleFormAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Roles (RoleName) VALUES (N'" + RoleHandlerFormRoleNameTb.Text +"')",connection);
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
                string prevRoleName = this.Tag.ToString();
                SqlCommand cmd = new SqlCommand("UPDATE Roles SET RoleName =  (N'" + RoleHandlerFormRoleNameTb.Text + "') WHERE RoleName = N'" + prevRoleName +"'", connection);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT RoleName AS Роль FROM Roles", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["RolesFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }
    }
}
