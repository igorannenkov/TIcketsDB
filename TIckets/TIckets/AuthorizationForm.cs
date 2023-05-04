using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class AuthorizationForm : Form
    {
        public static string currentUserRole;
        public static int defaultPasswordEntryAttemptsCount = 3;
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
            string login = authUserNameTb.Text;
            string password = authUserPwdTb.Text;

            if (login != string.Empty && password != string.Empty)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    if (!Account.IsLoginAndPasswordCorrect(connection, login, password))
                    {
                        if (Account.IsLoginCorrect(connection, login))
                        {
                            int passwordEntryAttemptsCount = Account.GetPasswordEntryAttemptsCount(connection, login);
                            if (passwordEntryAttemptsCount > 1)
                            {
                                MessageBox.Show("Неверное имя пользователя или пароль. Проверьте правильность введенных данных.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                if (passwordEntryAttemptsCount == 2)
                                {
                                    MessageBox.Show("У Вас осталась 1 попытка ввода пароля. В случае некорректного ввода учетная запись будет заблокирована.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                Account.DecrementPasswordEntryAttempts(connection, login);
                                authUserPwdTb.Text = string.Empty;
                                return;
                            }
                            else if (passwordEntryAttemptsCount == 1)
                            {
                                Account.DecrementPasswordEntryAttempts(connection, login);

                                SqlCommand getRoleID = new SqlCommand("SELECT RoleID FROM Roles " +
                                                                      "WHERE RoleName = N\'Заблокирован\'", connection);

                                int userRoleID = (int)getRoleID.ExecuteScalar();

                                SqlCommand banUser = new SqlCommand($"UPDATE Users SET UserRoleID = {userRoleID} WHERE UserLogin = @userLogin", connection);
                                banUser.Parameters.AddWithValue("@userLogin", login);
                                banUser.ExecuteNonQuery();
                                MessageBox.Show("Превышено количество попыток ввода пароля. Учетная запись пользователя " + login + " заблокирована и не может использоваться для входа в систему. " +
                                    "Для разблокировки обратитесь к администратору.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                authUserPwdTb.Text = string.Empty;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Учетная запись пользователя " + login + " заблокирована и не может использоваться для входа в систему. " +
                                    "Для разблокировки обратитесь к администратору.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                authUserPwdTb.Text = string.Empty;
                                return;
                            }
                        }
                        //иначе если логин некорректный - отбраковываем вход в систему
                        else
                        {
                            MessageBox.Show("Неверное имя пользователя или пароль. Проверьте правильность введенных данных.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            authUserPwdTb.Text = string.Empty;
                            return;
                        }
                    }
                    else
                    {
                        // если логин и пароль правильный, обновляем кол-во попыток ввода до стандартного значения и авторизуем
                        Account.ResetPasswordEntryAttempts(connection, login, defaultPasswordEntryAttemptsCount);
                        currentUserRole = Account.GetCurrentUserRole(connection, login);

                        switch (currentUserRole)
                        {
                            case "Заблокирован":
                                if (login == "administrator")
                                {
                                    goto case "Администратор";
                                }
                                MessageBox.Show("Учетная запись пользователя " + login + " заблокирована. Для разблокировки обратитесь к администратору системы.",
                                        "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                authUserPwdTb.Text = string.Empty;
                                break;

                            case "Администратор":
                                authUserPwdTb.Text = String.Empty;
                                AdminForm admForm = new AdminForm();
                                admForm.StartPosition = FormStartPosition.CenterScreen;
                                admForm.Text = "Администратор@" + login;
                                Account.currentUserLogin = login;
                                admForm.ShowDialog();
                                break;

                            case "Пользователь":
                                authUserPwdTb.Text = String.Empty;
                                UserMainForm userMainForm = new UserMainForm();
                                userMainForm.StartPosition = FormStartPosition.CenterScreen;
                                userMainForm.Text = "Пользователь@" + login;
                                Account.currentUserLogin = login;
                                userMainForm.ShowDialog();
                                break;

                            case "Техник":
                                authUserPwdTb.Text = String.Empty;
                                TechnicMainForm technicMainForm = new TechnicMainForm();
                                technicMainForm.StartPosition = FormStartPosition.CenterScreen;
                                technicMainForm.Text = "Техник@" + login;
                                Account.currentUserLogin = login;
                                technicMainForm.ShowDialog();
                                break;
                        }
                    }
                }
            }
        }

        private void authLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Для выполнения сброса пароля или регистрации новой учетной записи необходимо обратиться к Администратору системы.",
                "Регистрация / сброс пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
   
        private void authUserPwdTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.authEnterBtn_Click(sender, e);
            }
        }

        private void AuthorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
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
        }

        private void authShowPasswordBtn_MouseDown(object sender, MouseEventArgs e)
        {
            authUserPwdTb.PasswordChar = '\0';
        }

        private void authShowPasswordBtn_MouseUp(object sender, MouseEventArgs e)
        {
            authUserPwdTb.PasswordChar = '*';
        }
    }
}