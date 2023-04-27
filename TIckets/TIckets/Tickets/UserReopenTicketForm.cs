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

namespace TIckets.Tickets
{
    public partial class TicketReopenForm : Form
    {
        public TicketReopenForm()
        {
            InitializeComponent();
        }
        private void TicketReopenFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TicketReopenFormBtn_Click(object sender, EventArgs e)
        {
            if (userReopenTicketTb.Text == string.Empty)
            {
                MessageBox.Show("Не заполнено поле с текстом обращения. Переоткрыть заявку невозможно.", "Ошибка переоткрытия заявки", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                // Получаем ID статуса переоткрытой заявки из табл. Статусы заявок.
                SqlCommand command = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = N'Переоткрыта'", connection);
                int ticketStatusID = (int)command.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("UPDATE Tickets " +
                                                "SET TicketStatusID = @ticketStatusID, " +
                                                "TicketStartDateTime = @ticketStartDateTime, " +
                                                "TicketEndDateTime = @ticketEndDatetime, " +
                                                "UsedDeviceID = @usedDeviceID, " +
                                                "TicketUserComment = @ticketUserComment, " +
                                                "TicketComment = @ticketComment " +
                                                "WHERE TicketID = @ticketID", connection);
               
                cmd.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                cmd.Parameters.AddWithValue("@ticketStartDateTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@ticketEndDatetime", DBNull.Value);
                cmd.Parameters.AddWithValue("@usedDeviceID", DBNull.Value);
                cmd.Parameters.AddWithValue("@ticketUserComment", userReopenTicketTb.Text);
                cmd.Parameters.AddWithValue("@ticketComment", string.Empty);
                cmd.Parameters.AddWithValue("@ticketID", this.Tag.ToString());
                cmd.ExecuteNonQuery();

                 cmd = new SqlCommand("SELECT T.TicketID AS [ID Заявки], " +
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

                cmd.Parameters.AddWithValue("@userLogin", Account.currentUserLogin);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                (this.Owner.Owner.Controls["userMainFormGridView"] as DataGridView).DataSource = dt;
                this.Owner.Close();
                this.Close();
            }
        }
    }
}
