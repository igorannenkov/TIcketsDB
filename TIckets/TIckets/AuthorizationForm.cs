using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class AuthorizationForm : Form
    {
        public static string currentUserRole;
        public static int passwordAttemptsCount = 3;
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
                    //если логин и пароль одновременно неверны
                    if (result == 0)
                    {
                        //проверяем, есть ли вообще такой логин?
                        SqlCommand getUsersCount = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserLogin = @userLogin", connection);
                        getUsersCount.Parameters.AddWithValue("@userLogin", authUserNameTb.Text);
                        int usersCount = (int)getUsersCount.ExecuteScalar();
                        //логин есть
                        if (usersCount > 0)
                        {
                            SqlCommand getUserPasswordsAttempts = new SqlCommand("SELECT UserPasswordAttemptsCount FROM Users where UserLogin = @userLogin", connection);
                            getUserPasswordsAttempts.Parameters.AddWithValue("@userLogin", authUserNameTb.Text);
                            int userAttempsCount = (int)getUserPasswordsAttempts.ExecuteScalar();
                            // если логин правильный, а пароль - нет то уменьшаем счетчик на 1
                            if (userAttempsCount > 0)
                            {
                                SqlCommand decrementPasswordAttempt = new SqlCommand("UPDATE Users SET UserPasswordAttemptsCount = UserPasswordAttemptsCount -1 WHERE UserLogin = @userLogin", connection);
                                decrementPasswordAttempt.Parameters.AddWithValue("@userLogin", authUserNameTb.Text);
                                decrementPasswordAttempt.ExecuteNonQuery();


                                //уменьшим на 1
                                //не пустим и скажем что неправильно
                            }
                            else if (userAttempsCount == 0)
                            {
                                SqlCommand getRoleID = new SqlCommand("SELECT RoleID FROM Roles " +
                                                    "WHERE RoleName = N\'Заблокирован\'", connection);

                                int userRoleID = (int)getRoleID.ExecuteScalar();

                                SqlCommand banUser = new SqlCommand($"UPDATE Users SET UserRoleID = {userRoleID} WHERE UserLogin = @userLogin", connection);
                                banUser.Parameters.AddWithValue("@userLogin", authUserNameTb.Text);
                                banUser.ExecuteNonQuery();
                                MessageBox.Show("Учетная запись пользователя " + authUserNameTb.Text + " заблокирована. Для разблокировки обратитесь к администратору системы.",
                                          "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;

                            }
                        }
                        //логина нет, ничего не делаем, просто говорим отвали
                        else if(usersCount == 0)
                        {

                            
                            MessageBox.Show("Неверное имя пользователя или пароль. Проверьте правильность введенных данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            authUserPwdTb.Text = string.Empty;
                            return;

           
                        }
                    }


                    if (result > 0)
                    {

                        // если логин и пароль правильный, обновляем кол-во попыток ввода до стандартного значения

                        SqlCommand setPasswordAttemptsByDefault = new SqlCommand($"UPDATE Users SET UserPasswordAttemptsCount = {passwordAttemptsCount} WHERE UserLogin = @userLogin", connection);
                        setPasswordAttemptsByDefault.Parameters.AddWithValue("@userLogin", authUserNameTb.Text);
                        setPasswordAttemptsByDefault.ExecuteNonQuery();





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
    }
}