using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
        }
        private void новаяЗаявкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketAddForm addTicketForm = new TicketAddForm();
            addTicketForm.Owner = this;
            addTicketForm.StartPosition = FormStartPosition.CenterParent;
            addTicketForm.ShowDialog();
        }

        private void сменаПароляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Owner = this;
            changePasswordForm.ShowDialog();
        }

        private void выгрузкаВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelReporter.GetReport(userMainFormGridView);
        }

        private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void userMainFormGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((this.Controls["userMainFormGridView"] as DataGridView).CurrentRow.Cells[4].Value.ToString() == "Отменена"
                || (this.Controls["userMainFormGridView"] as DataGridView).CurrentRow.Cells[4].Value.ToString() == "Отклонена")
            {
                MessageBox.Show("Отмененные и отклоненные заявки не подлежат редактированию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                TicketHandleForm ticketHandleForm = new TicketHandleForm();
                (ticketHandleForm.Controls["ticketDeviceCb"] as ComboBox).Enabled = false;
                (ticketHandleForm.Controls["ticketUserCommentTb"] as TextBox).Text = this.userMainFormGridView.CurrentRow.Cells[2].Value.ToString();
                (ticketHandleForm.Controls["ticketUserCommentTb"] as TextBox).Enabled = true;
                (ticketHandleForm.Controls["ticketUserCommentTb"] as TextBox).ReadOnly = false;
                ticketHandleForm.Owner = this;

                // Редактировать пользователя обращения запрещено
                SqlCommand command = new SqlCommand("SELECT UserName as UserName FROM Users U " +
                                                    "INNER JOIN Roles R ON U.UserRoleID = R.RoleID " +
                                                    "WHERE R.ROleName = N'Пользователь'", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).ValueMember = "UserName";
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).DataSource = dt;
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).SelectedValue = this.userMainFormGridView.CurrentRow.Cells[1].Value.ToString();
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).Enabled = false;

                // Имя техника пользователю редактировать запрещено
                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).Text = this.userMainFormGridView.CurrentRow.Cells[3].Value.ToString();
                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).Enabled = false;

                // Статус обращения пользователю редактировать запрещено кроме закрытых заявок
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).Text = this.userMainFormGridView.CurrentRow.Cells[4].Value.ToString();
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).Enabled = false;

                // Комментарий можно только посмотреть
                (ticketHandleForm.Controls["ticketCommentTb"] as TextBox).ReadOnly = true;
                (ticketHandleForm.Controls["ticketUserCommentTb"] as TextBox).ReadOnly = true;

                ticketHandleForm.Tag = this.userMainFormGridView.CurrentRow.Cells[0].Value.ToString();

                if (this.userMainFormGridView.CurrentRow.Cells[3].Value.ToString() == "Не назначен")
                {
                    (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).SelectedIndex = -1;
                }

                (ticketHandleForm.Controls["ticketCommentTb"] as TextBox).Text = userMainFormGridView.CurrentRow.Cells[7].Value.ToString();
                (ticketHandleForm.Controls["sparePartChekBox"] as CheckBox).Enabled = false;
                ticketHandleForm.Text = "Заявка № " + this.userMainFormGridView.CurrentRow.Cells[0].Value.ToString();
                ticketHandleForm.StartPosition = FormStartPosition.CenterParent;
                ticketHandleForm.ShowDialog();
            }
        }

        private void всеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT T.TicketID AS [ID Заявки], " +
                                                                   "U.UserName AS Пользователь, " +
                                                                   "T.TicketUserComment AS [Текст обращения], " +
                                                                   "COALESCE(UN.UserName, N'Не назначен') AS [Назначенный техник], " +
                                                                   "TS.TicketStatusName AS [Статус заявки], " +
                                                                   "T.TicketStartDateTime AS [Время регистрации], " +
                                                                   "T.TicketEndDateTime AS [Время выполнения], " +
                                                                   "T.TicketComment AS [Ответ по обращению], " +
                                                                   "DT.DeviceTypeName AS [Используемые материалы] " +
                                                                   "FROM Tickets AS T " +
                                                                   "LEFT JOIN Users AS U " +
                                                                   "ON T.UserID = U.UserID " +
                                                                   "LEFT JOIN  Users AS UN " +
                                                                   "ON T.TechnicID = UN.UserID " +
                                                                   "LEFT JOIN Devices AS D " +
                                                                   "ON T.UsedDeviceID = D.DeviceID " +
                                                                   "LEFT JOIN TicketStatuses TS " +
                                                                   "ON T.TicketStatusID = TS.TicketStatusID " +
                                                                   "LEFT JOIN DeviceTypes AS DT " +
                                                                   "ON D.DeviceType = DT.DeviceTypeID " +
                                                                   "WHERE U.UserLogin = @userLogin", connection);


                cmd.Parameters.AddWithValue("@userLogin", Observer.currentUserLogin);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                userMainFormGridView.DataSource = dt;
            }
        }

        private void новыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT T.TicketID AS [ID Заявки], " +
                                                                   "U.UserName AS Пользователь, " +
                                                                   "T.TicketUserComment AS [Текст обращения], " +
                                                                   "COALESCE(UN.UserName, N'Не назначен') AS [Назначенный техник], " +
                                                                   "TS.TicketStatusName AS [Статус заявки], " +
                                                                   "T.TicketStartDateTime AS [Время регистрации], " +
                                                                   "T.TicketEndDateTime AS [Время выполнения], " +
                                                                   "T.TicketComment AS [Ответ по обращению], " +
                                                                   "DT.DeviceTypeName AS [Используемые материалы] " +
                                                                   "FROM Tickets AS T " +
                                                                   "LEFT JOIN Users AS U " +
                                                                   "ON T.UserID = U.UserID " +
                                                                   "LEFT JOIN  Users AS UN " +
                                                                   "ON T.TechnicID = UN.UserID " +
                                                                   "LEFT JOIN Devices AS D " +
                                                                   "ON T.UsedDeviceID = D.DeviceID " +
                                                                   "LEFT JOIN TicketStatuses TS " +
                                                                   "ON T.TicketStatusID = TS.TicketStatusID " +
                                                                   "LEFT JOIN DeviceTypes AS DT " +
                                                                   "ON D.DeviceType = DT.DeviceTypeID " +
                                                                   "WHERE U.UserLogin = @userLogin AND TS.TicketStatusName = N'Новая'", connection);


                cmd.Parameters.AddWithValue("@userLogin", Observer.currentUserLogin);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                userMainFormGridView.DataSource = dt;
            }
        }

        private void выполненныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT T.TicketID AS [ID Заявки], " +
                                                                   "U.UserName AS Пользователь, " +
                                                                   "T.TicketUserComment AS [Текст обращения], " +
                                                                   "COALESCE(UN.UserName, N'Не назначен') AS [Назначенный техник], " +
                                                                   "TS.TicketStatusName AS [Статус заявки], " +
                                                                   "T.TicketStartDateTime AS [Время регистрации], " +
                                                                   "T.TicketEndDateTime AS [Время выполнения], " +
                                                                   "T.TicketComment AS [Ответ по обращению], " +
                                                                   "DT.DeviceTypeName AS [Используемые материалы] " +
                                                                   "FROM Tickets AS T " +
                                                                   "LEFT JOIN Users AS U " +
                                                                   "ON T.UserID = U.UserID " +
                                                                   "LEFT JOIN  Users AS UN " +
                                                                   "ON T.TechnicID = UN.UserID " +
                                                                   "LEFT JOIN Devices AS D " +
                                                                   "ON T.UsedDeviceID = D.DeviceID " +
                                                                   "LEFT JOIN TicketStatuses TS " +
                                                                   "ON T.TicketStatusID = TS.TicketStatusID " +
                                                                   "LEFT JOIN DeviceTypes AS DT " +
                                                                   "ON D.DeviceType = DT.DeviceTypeID " +
                                                                   "WHERE U.UserLogin = @userLogin AND TS.TicketStatusName = N'Выполнена'", connection);


                cmd.Parameters.AddWithValue("@userLogin", Observer.currentUserLogin);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                userMainFormGridView.DataSource = dt;
            }
        }
    }
}