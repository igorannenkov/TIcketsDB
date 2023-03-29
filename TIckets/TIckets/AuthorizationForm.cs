using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class AuthorizationForm : Form
    {
        public static string currentUserRole;
        public AuthorizationForm()
        {
            InitializeComponent();            
        }

        private void ShowAdmBtn_Click(object sender, EventArgs e)
        {
            AdminForm admForm = new AdminForm();
            admForm.StartPosition = FormStartPosition.CenterScreen;
            admForm.Show();
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowTechnicBtn_Click(object sender, EventArgs e)
        {
            TechnicMainForm tmf = new TechnicMainForm();
            tmf.Show();
        }

        private void ShowUserBtn_Click(object sender, EventArgs e)
        {
            UserMainForm userMainForm = new UserMainForm();
            userMainForm.StartPosition = FormStartPosition.CenterScreen;
            userMainForm.ShowDialog();
        }

        private void authEnterBtn_Click(object sender, EventArgs e)
        {
            if (authUserNameTb.Text != string.Empty && authUserPwdTb.Text != string.Empty)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserLogin = @userLogin AND UserPassword = @userPassword", connection);
                    cmd.Parameters.AddWithValue("@userLogin", authUserNameTb.Text);
                    cmd.Parameters.AddWithValue("@userPassword", HashGenerator.GetMD5(authUserPwdTb.Text));
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        cmd = new SqlCommand("SELECT RoleName FROM Roles R " +
                                             "INNER JOIN Users U " +
                                             "ON R.RoleID = U.UserRoleID " +
                                             "WHERE U.UserLogin = @userLogin ", connection);

                        cmd.Parameters.AddWithValue("@userLogin", authUserNameTb.Text);

                        currentUserRole = (string)cmd.ExecuteScalar();

                        switch (currentUserRole)
                        {
                            case "Заблокирован":
                                if (authUserNameTb.Text == "administrator")
                                {
                                    goto case "Администратор";
                                }
                                MessageBox.Show("Учетная запись пользователя " + authUserNameTb.Text + " заблокирована. Для разблокировки обратитесь к администратору системы.",
                                        "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case "Администратор":
                                authUserPwdTb.Text = String.Empty;
                                AdminForm admForm = new AdminForm();
                                admForm.StartPosition = FormStartPosition.CenterScreen;
                                admForm.Text = "Администратор@" + authUserNameTb.Text;
                                Observer.currentUserLogin = authUserNameTb.Text;
                                admForm.ShowDialog();
                                break;

                            case "Пользователь":
                                authUserPwdTb.Text = String.Empty;
                                UserMainForm userMainForm = new UserMainForm();
                                userMainForm.StartPosition = FormStartPosition.CenterScreen;
                                userMainForm.Text = "Пользователь@" + authUserNameTb.Text;
                                Observer.currentUserLogin = authUserNameTb.Text;
                                userMainForm.ShowDialog();
                                break;
                            case "Техник":
                                authUserPwdTb.Text = String.Empty;
                                TechnicMainForm technicMainForm = new TechnicMainForm();
                                technicMainForm.StartPosition = FormStartPosition.CenterScreen;
                                technicMainForm.Text = "Техник@" + authUserNameTb.Text;
                                Observer.currentUserLogin = authUserNameTb.Text;
                                technicMainForm.ShowDialog();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверное имя пользователя или пароль. Проверьте правильность введенных данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        authUserPwdTb.Text = string.Empty;
                    }
                }
            }
        }

        private void authLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Для выполнения сброса пароля или регистрации новой учетной записи необходимо обратиться к Администратору системы.",
                "Регистрация / сброс пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dbPathLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Master Data Files(*.mdf)|*.mdf|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            { return; }
            string filePath = openFileDialog.FileName;
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + filePath + "; Integrated Security = True";
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Remove("TicketsDB");
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("TicketsDB", connectionString));

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");

            MessageBox.Show("Параметры соединения изменены. Проверьте подключение к БД.",
                               "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void authUserPwdTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.authEnterBtn_Click(sender, e);
            }
        }
    }
}
