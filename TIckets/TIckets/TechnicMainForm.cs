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
                                                            "T.TicketComment AS [Комментарий техника], " +
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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserName + "';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void отклоненныеToolStripMenuItem_Click(object sender, EventArgs e)
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
                                                            "T.TicketComment AS [Комментарий техника], " +
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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserName + "' " +
                                                            "AND TS.TicketStatusName = N'Отклонена';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void отмененныеToolStripMenuItem_Click(object sender, EventArgs e)
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
                                                            "T.TicketComment AS [Комментарий техника], " +
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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserName + "' " +
                                                            "AND TS.TicketStatusName = N'Отменена';", connection);
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
                                                            "T.TicketComment AS [Комментарий техника], " +
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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserName + "' " +
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
                                                            "T.TicketComment AS [Комментарий техника], " +
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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserName + "' " +
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
    }
}
