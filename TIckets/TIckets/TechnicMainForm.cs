using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class TechnicMainForm : Form
    {
        public TechnicMainForm()
        {
            InitializeComponent();
        }
        private void моиЗаявкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT T.TicketID AS [ID Заявки], " +
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
                                                                    "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void выполненныеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT T.TicketID AS [ID Заявки], " +
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
                                                                     "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "' " +
                                                                     "AND TS.TicketStatusName = N'Выполнена';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void новыеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT T.TicketID AS [ID Заявки], " +
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
                                                                     "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "' " +
                                                                     "AND TS.TicketStatusName = N'Принята в работу';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void выгрузкаВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelReporter.GetReport(technicGridView);
        }

        private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сменаПароляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.StartPosition = FormStartPosition.CenterScreen;
            changePasswordForm.ShowDialog();
        }

        private void историяЗаявокКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTisketHistorySearchForm historySearchForm = new UserTisketHistorySearchForm();
            (historySearchForm.Controls["ticketHistorySearchTb"] as TextBox).AddPlaceHolder("Пользователь");
            historySearchForm.StartPosition = FormStartPosition.CenterScreen;
            historySearchForm.ShowDialog();
        }

        private void technicGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                TicketHandleForm ticketHandleForm = new TicketHandleForm();

                //заполняем комбобокс со списком устройств
                SqlCommand cmd = new SqlCommand("SELECT DeviceTypeName FROM DeviceTypes ORDER BY DeviceTypeName", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (ticketHandleForm.Controls["ticketDeviceCb"] as ComboBox).DataSource = ds.Tables[0];
                (ticketHandleForm.Controls["ticketDeviceCb"] as ComboBox).ValueMember = "DeviceTypeName";
                (ticketHandleForm.Controls["ticketDeviceCb"] as ComboBox).Enabled = true;


                // скрываем кнопку "Отменить обращение"
                (ticketHandleForm.Controls["ticketHandlerFormTicketCnlBtn"] as Button).Visible = false;
                (ticketHandleForm.Controls["ticketHandlerFormTicketReopenBtn"] as Button).Visible = false;

                ticketHandleForm.Owner = this;

                // Редактировать пользователя обращения запрещено
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).Text = this.technicGridView.CurrentRow.Cells[1].Value.ToString();
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).Enabled = false;

                // Нельзя менять техника
                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).Text = this.technicGridView.CurrentRow.Cells[3].Value.ToString();
                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).Enabled = false;

                // Загружаем текст обращения
                (ticketHandleForm.Controls["ticketUserCommentTb"] as TextBox).Text = this.technicGridView.CurrentRow.Cells[2].Value.ToString();

                if (this.technicGridView.CurrentRow.Cells[3].Value.ToString() != "Не назначен")
                {
                    (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).SelectedValue = this.technicGridView.CurrentRow.Cells[3].Value.ToString();
                }

                SqlCommand command = new SqlCommand("SELECT TicketStatusName FROM TicketStatuses " +
                                                    "WHERE TicketStatusName <> N'Новая' " +
                                                    "AND TicketStatusName <> N'Переоткрыта' " +
                                                    "AND TicketStatusName <> N'Отменена' ", connection);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).ValueMember = "TicketStatusName";
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).DataSource = dt;

                ticketHandleForm.Tag = this.technicGridView.CurrentRow.Cells[0].Value.ToString();

                if (this.technicGridView.CurrentRow.Cells[3].Value.ToString() == "Не назначен")
                {
                    (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).SelectedIndex = -1;
                }
                
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).Text = technicGridView.CurrentRow.Cells[4].Value.ToString();

                (ticketHandleForm.Controls["sparePartChekBox"] as CheckBox).Checked = false;
                (ticketHandleForm.Controls["ticketDeviceCb"] as ComboBox).Enabled = false;
                
                ticketHandleForm.Text = "Заявка № " + this.technicGridView.CurrentRow.Cells[0].Value.ToString();

                ticketHandleForm.StartPosition = FormStartPosition.CenterParent;
                ticketHandleForm.ShowDialog();
            }
        }

        private void возобновленныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT T.TicketID AS [ID Заявки], " +
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
                                                            "LEFT JOIN DeviceTypes AS DT " +
                                                            "ON T.UsedDeviceID = DT.DeviceTypeID " +
                                                            "LEFT JOIN TicketStatuses TS " +
                                                            "ON T.TicketStatusID = TS.TicketStatusID " +
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "' " +
                                                            "AND TS.TicketStatusName = N'Переоткрыта';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceForm deviceForm = new DeviceForm();
            deviceForm.StartPosition = FormStartPosition.CenterParent;
            deviceForm.Owner = this;
            deviceForm.ShowDialog();
        }

        private void TechnicMainForm_Load(object sender, EventArgs e)
        {
            int GetAcceptedTicketsCount()
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM (SELECT T.TicketID AS [ID Заявки], " +
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
                                                                         "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "' " +
                                                                         "AND TS.TicketStatusName = N'Принята в работу') AS ticketsCount;", connection);
                    return (int)cmd.ExecuteScalar();
                }
            }

            int acceptedTicketsCount = GetAcceptedTicketsCount();

            if (acceptedTicketsCount > 0)
            {
                NotificationForm tnf = new NotificationForm();               
                tnf.Owner = this;
                tnf.StartPosition = FormStartPosition.CenterParent;
                (tnf.Controls["NotificationLbl"] as Label).Text = $"Вам назначено заявок: {acceptedTicketsCount}";
                tnf.ShowDialog();
            }
        }
    }
}