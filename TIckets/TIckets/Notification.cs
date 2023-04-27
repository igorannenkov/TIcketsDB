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
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void TechnicNotificatonOkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TechnicNotificationShowBtn_Click(object sender, EventArgs e)
        {
            switch (AuthorizationForm.currentUserRole)
            {
                case "Администратор":
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
                                                                         "LEFT JOIN Devices AS D " +
                                                                         "ON T.UsedDeviceID = D.DeviceID " +
                                                                         "LEFT JOIN TicketStatuses TS " +
                                                                         "ON T.TicketStatusID = TS.TicketStatusID " +
                                                                         "LEFT JOIN DeviceTypes AS DT " +
                                                                         "ON D.DeviceType = DT.DeviceTypeID " +
                                                                         "WHERE TS.TicketStatusName = N'Новая'", connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        (this.Owner.Controls["admGridView"] as DataGridView).DataSource = dt;
                        this.Close();
                    }
                    break;

                case "Техник":
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
                                                                             "WHERE UN.UserLogin = @userLogin " +
                                                                             "AND TS.TicketStatusName = N'Принята в работу';", connection);
                        cmd.Parameters.AddWithValue("@userLogin", Account.currentUserLogin);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        (this.Owner.Controls["technicGridView"] as DataGridView).DataSource = dt;
                        this.Close();
                    }
                    break;

                case "Пользователь":
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
                                                                   "WHERE U.UserLogin = @userLogin " +
                                                                   "AND (TS.TicketStatusName = N'Принята в работу' OR TS.TicketStatusName = N'Новая' OR TS.TicketStatusName = N'Переоткрыта');", connection);
                        cmd.Parameters.AddWithValue("@userLogin", Account.currentUserLogin);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        (this.Owner.Controls["userMainFormGridView"] as DataGridView).DataSource = dt;
                        this.Close();
                    }
                    break;
            }
        }
    }
}