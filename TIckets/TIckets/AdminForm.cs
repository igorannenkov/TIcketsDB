using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TIckets
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void ПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usForm = new UsersForm();
            usForm.StartPosition = FormStartPosition.CenterParent;
            usForm.ShowDialog();
        }
        private void ролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm rf = new RolesForm();
            rf.StartPosition = FormStartPosition.CenterParent;
            rf.ShowDialog();
        }
        private void ТипыУстройствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTypesForm dtf = new DeviceTypesForm();
            dtf.StartPosition = FormStartPosition.CenterParent;
            dtf.ShowDialog();
        }
        private void статусыЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketStatusesForm ticketStatusesForm = new TicketStatusesForm();
            ticketStatusesForm.StartPosition = FormStartPosition.CenterScreen;
            ticketStatusesForm.ShowDialog();
        }
        private void всеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
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
                                                            "ON T.TicketStatusID = TS.TicketStatusID ", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                admGridView.DataSource = dt;
            }
        }
        private void новыеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
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
                                                            "WHERE TS.TicketStatusName = N'Новая'", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                admGridView.DataSource = dt;
            }
        }

        private void admGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                             
                TicketHandleForm ticketHandleForm = new TicketHandleForm();

                // скрываем кнопку "Отменить обращение"
                (ticketHandleForm.Controls["ticketHandlerFormTicketCnlBtn"] as Button).Visible = false;
                (ticketHandleForm.Controls["ticketHandlerFormTicketReopenBtn"] as Button).Visible = false;
                (ticketHandleForm.Controls["ticketDeviceCb"] as ComboBox).Enabled = false;
                (ticketHandleForm.Controls["ticketHandlerFormUsedDeviceLbl"] as Label).Enabled = false;
                (ticketHandleForm.Controls["ticketUserCommentTb"] as TextBox).Text = this.admGridView.CurrentRow.Cells[2].Value.ToString();                
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
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).SelectedValue = this.admGridView.CurrentRow.Cells[1].Value.ToString();
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).Enabled = false;

                command = new SqlCommand("SELECT UserName AS TechnicName FROM Users U " +
                                                    "INNER JOIN Roles R ON U.UserRoleID = R.RoleID " +
                                                    "WHERE R.ROleName = N'Техник'", connection);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);

                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).ValueMember = "TechnicName";
                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).DataSource = dt;
                if (this.admGridView.CurrentRow.Cells[3].Value.ToString() != "Не назначен")
                {
                    (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).SelectedValue = this.admGridView.CurrentRow.Cells[3].Value.ToString();
                }

                command = new SqlCommand("SELECT TicketStatusName FROM TicketStatuses " +
                                         "WHERE TicketStatusName <> N'Новая' " +
                                         "AND TicketStatusName <> N'Переоткрыта' " +
                                         "AND TicketStatusName <> N'Отменена'" , connection);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).ValueMember = "TicketStatusName";
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).DataSource = dt;

                ticketHandleForm.Tag = this.admGridView.CurrentRow.Cells[0].Value.ToString();

                if (this.admGridView.CurrentRow.Cells[3].Value.ToString() == "Не назначен")
                {
                    (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).SelectedIndex = -1;
                }

                ticketHandleForm.StartPosition = FormStartPosition.CenterParent;              
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).Text = admGridView.CurrentRow.Cells[4].Value.ToString();               
                ticketHandleForm.ShowDialog();
            }
        }

        private void выгрузкаВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelReporter.GetReport(admGridView);
        }

        private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void заявкиВРазрезеТехниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
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
                                                            "WHERE TS.TicketStatusName = (N'Принята в работу') " +
                                                            "ORDER BY TS.TicketStatusName", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                admGridView.DataSource = dt;
            }
        }

        private void выполненныеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
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
                                                            "WHERE TS.TicketStatusName = N'Выполнена'", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                admGridView.DataSource = dt;
            }
        }

        private void выходИзСистемыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сменаПароляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.StartPosition = FormStartPosition.CenterScreen;
            changePasswordForm.ShowDialog();
        }

        private void отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
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
                                                            "WHERE T.TechnicID IS NOT NULL " +
                                                            "AND TS.TicketStatusName = N'Отменена'" +
                                                            "OR TS.TicketStatusName = N'Отклонена'", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                admGridView.DataSource = dt;
            }
        }
    }
}
