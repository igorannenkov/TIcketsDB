using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class UserTisketHistorySearchForm : Form
    {
        public UserTisketHistorySearchForm()
        {
            InitializeComponent();
        }

        private void ticketHistoryCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ticketHistorySearchBtn_Click(object sender, EventArgs e)
        {
            if (ticketHistorySearchTb.Text == String.Empty)
            {
             //   return;
            }

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
                                                "WHERE UPPER (U.UserName) LIKE @userNamе " +
                                                "ORDER BY U.UserName, T.TicketStartDateTime", connection);
                // WHERE U.UserName LIKE (N'%ннен%')
                cmd.Parameters.AddWithValue("@userNamе", "%" + ticketHistorySearchTb.Text.ToUpper() + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                historySearchGridView.DataSource = dt;
            }
        }
    }
}
