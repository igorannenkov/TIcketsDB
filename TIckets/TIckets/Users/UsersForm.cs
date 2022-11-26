using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string command = "SELECT UserID AS ID, UserName AS ФИО, RoleName AS [Роль], UserLogin AS Логин, UserPassword AS [Пароль MD5] " +
                                 "FROM Users U " +
                                 "INNER JOIN Roles R ON U.UserRoleID = R.RoleID";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.UsersFormGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHandleForm userHandleForm = new UserHandleForm();
            userHandleForm.StartPosition = FormStartPosition.CenterScreen;
            (userHandleForm.Controls["UserHandlerFormEditBtn"] as Button).Enabled = false;
            (userHandleForm.Controls["UserHandlerFormResetPwdChb"] as CheckBox).Enabled = false;
            userHandleForm.Owner = this;
            userHandleForm.ShowDialog();
        }

        private void UsersFormGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                UserHandleForm userHandleForm = new UserHandleForm();
                userHandleForm.Owner = this;

                string prevUserName = UsersFormGridView.CurrentRow.Cells[1].Value.ToString();
                (userHandleForm.Controls["UserHandlerFormUserNameTb"] as TextBox).Text = prevUserName;

                string prevUserLogin = UsersFormGridView.CurrentRow.Cells[3].Value.ToString();
                (userHandleForm.Controls["UserHandlerFormUserLoginTb"] as TextBox).Text = prevUserLogin;

                SqlCommand cmd = new SqlCommand("SELECT RoleName AS Роль FROM Roles", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                (userHandleForm.Controls["UserHandlerFormUserRoleCb"] as ComboBox).ValueMember = "Роль";
                (userHandleForm.Controls["UserHandlerFormUserRoleCb"] as ComboBox).DataSource = ds.Tables[0];
                (userHandleForm.Controls["UserHandlerFormUserRoleCb"] as ComboBox).SelectedValue = UsersFormGridView.CurrentRow.Cells[2].Value.ToString();
                (userHandleForm.Controls["UserHandlerFormAddBtn"] as Button).Enabled = false;
                userHandleForm.StartPosition = FormStartPosition.CenterParent;
                userHandleForm.ShowDialog();
            }
        }

        private void UsersFormGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = UsersFormGridView.CurrentRow.Cells[0].Value.ToString();
                    string sqlCommandText = "DELETE FROM Users WHERE UserID = @toDelete";

                    SqlCommand cmd = new SqlCommand(sqlCommandText, connection);
                    cmd.Parameters.AddWithValue("@toDelete", toDelete);
                    cmd.ExecuteNonQuery();

                    string command = "SELECT UserID AS ID, UserName AS ФИО, RoleName AS Роль, UserLogin AS Логин, UserPassword AS [Пароль MD5] " +
                                     "FROM Users U " +
                                     "INNER JOIN Roles R ON U.UserRoleID = R.RoleID";

                    SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.UsersFormGridView.DataSource = ds.Tables[0];
                }
            }
        }
    }
}