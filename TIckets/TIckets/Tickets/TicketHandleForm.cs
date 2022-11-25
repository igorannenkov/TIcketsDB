using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TIckets.Tickets;

namespace TIckets
{
    public partial class TicketHandleForm : Form
    {
        public TicketHandleForm()
        {
            InitializeComponent();
        }

        private void ticketHandlerFormEditBtn_Click(object sender, EventArgs e)
        {
            string currentRole = Observer.GetCurrentUserRole(Observer.currentUserLogin);

            switch (currentRole)
            {
                case "Администратор":
                    using (SqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        SqlCommand updateCommand = new SqlCommand("UPDATE Tickets " +
                                                                  "SET TechnicID = @technicID, " +
                                                                  "TicketStatusID = @ticketStatusID, " +
                                                                  "TicketEndDateTime = @ticketEndDatetime, " +
                                                                  "TicketUserComment = @ticketUserComment, " +
                                                                  "TicketComment = @ticketComment " +
                                                                  "WHERE TicketID = @ticketID", connection);
                        
                        string ticketID = this.Tag.ToString();
                        updateCommand.Parameters.AddWithValue("ticketID", this.Tag.ToString());
                        updateCommand.Parameters.AddWithValue("@ticketUserComment", ticketUserCommentTb.Text);

                        if (ticketTicketStatusCb.Text == "Принята в работу" && ticketTechnicNameCb.Text == "")
                        {
                            MessageBox.Show("При принятии заявки в работу необходимо назначить техника. Информация не сохранена.",
                                "Ошибка назначения заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (ticketTicketStatusCb.Text == "Принята в работу" && ticketTechnicNameCb.Text != "")
                        {
                            // получаем ID техника
                            SqlCommand cmd = new SqlCommand("SELECT UserID FROM USERS WHERE UserName = @technicID", connection);
                            cmd.Parameters.AddWithValue("@technicID", this.ticketTechnicNameCb.Text);
                            int technicID = (int)cmd.ExecuteScalar();

                            // получаем ID статуса заявки
                            cmd = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
                            cmd.Parameters.AddWithValue("@ticketStatusName", this.ticketTicketStatusCb.Text);
                            int ticketStatusID = (int)cmd.ExecuteScalar();

                            updateCommand.Parameters.AddWithValue("@technicID", technicID);
                            updateCommand.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                            updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DBNull.Value);
                            updateCommand.Parameters.AddWithValue("@ticketComment", DBNull.Value);
                        }
                        if (ticketTicketStatusCb.Text == "Выполнена" || ticketTicketStatusCb.Text == "Отклонена") 
                        {

                            updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);

                            // получаем ID статуса заявки
                            SqlCommand getStatusID = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
                            getStatusID.Parameters.AddWithValue("@ticketStatusName", this.ticketTicketStatusCb.Text);
                            int ticketStatusID = (int)getStatusID.ExecuteScalar();

                            // если если выполнена/отклонена и техник НЕ пустой
                            if (ticketTechnicNameCb.Text != "")
                            {
                                // получаем ID техника
                                SqlCommand cmd = new SqlCommand("SELECT UserID FROM USERS WHERE UserName = @technicID", connection);
                                cmd.Parameters.AddWithValue("@technicID", this.ticketTechnicNameCb.Text);
                                int technicID = (int)cmd.ExecuteScalar();

                                updateCommand.Parameters.AddWithValue("@technicID", technicID);
                                updateCommand.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                            }
                            else // если выполнена/отклонена и техник пустой
                            {
                                updateCommand.Parameters.AddWithValue("@technicID", DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                            }

                            if (ticketCommentTb.Text != string.Empty)
                            {
                                updateCommand.Parameters.AddWithValue("@ticketComment", ticketCommentTb.Text + " ("
                                + Observer.currentUserLogin + ")");
                            }
                            else
                            {
                                updateCommand.Parameters.AddWithValue("@ticketComment", ticketTicketStatusCb.Text + " администратором ("
                                + Observer.currentUserLogin + ")");
                            }                       
                        }
                     
                        updateCommand.ExecuteNonQuery();
                        // обновленный результат выводим на экран
                        SqlCommand RefreshCmd = new SqlCommand("SELECT T.TicketID AS [ID Заявки], " +
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
                                                                "ON T.TicketStatusID = TS.TicketStatusID " , connection);

                            SqlDataAdapter adapter = new SqlDataAdapter(RefreshCmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            (this.Owner.Controls["admGridView"] as DataGridView).DataSource = dt;
                    }
                    break;

                case "Техник":
                    using (SqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        SqlCommand updateCommand = new SqlCommand("UPDATE Tickets SET " +
                                                                  "TicketStatusID = @ticketStatusID, " +
                                                                  "TicketEndDateTime = @ticketEndDatetime, " +
                                                                  "TicketUserComment = @ticketUserComment, " +
                                                                  "TicketComment = @ticketComment " +
                                                                  "WHERE TicketID = @ticketID", connection);

                        string ticketID = this.Tag.ToString();
                        updateCommand.Parameters.AddWithValue("ticketID", this.Tag.ToString());
                        updateCommand.Parameters.AddWithValue("@ticketUserComment", ticketUserCommentTb.Text);

                        if (ticketTicketStatusCb.Text == "Принята в работу" && ticketTechnicNameCb.Text != "")
                        {
                            this.Close();
                            return;
                        }
                        if (ticketTicketStatusCb.Text == "Выполнена" || ticketTicketStatusCb.Text == "Отклонена")
                        {
                            updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);

                            // получаем ID статуса заявки
                            SqlCommand getStatusID = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
                            getStatusID.Parameters.AddWithValue("@ticketStatusName", this.ticketTicketStatusCb.Text);
                            int ticketStatusID = (int)getStatusID.ExecuteScalar();

                            updateCommand.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);

                            if (ticketCommentTb.Text != string.Empty)
                            {
                                updateCommand.Parameters.AddWithValue("@ticketComment", ticketCommentTb.Text + " ("
                                + Observer.currentUserLogin + ")");
                            }
                            else
                            {
                                if (ticketCommentTb.Text == "")
                                {
                                    MessageBox.Show("Необходимо заполнить ответ по обращению. Сохранение невозможно.", "Не заполнен ответ по обращению",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                updateCommand.Parameters.AddWithValue("@ticketComment", ticketUserCommentTb.Text + " ("
                                + Observer.currentUserLogin + ")");
                            }
                        }

                        updateCommand.ExecuteNonQuery();

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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "';", connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        (this.Owner.Controls["technicGridView"] as DataGridView).DataSource = dt;
                    }
                    break;

                case "Пользователь":                   
                    // пользователь не может редактировать обращение, ему разрешено только переоткрыть его с новым комментарием
                    break;
            }

            this.Close();
        }


        private void ticketHandlerFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ticketHandlerFormTicketCnlBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = N'Отменена'", connection);
                int ticketStatusID = (int)command.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("UPDATE Tickets " +
                                                "SET TicketStatusID = @ticketStatusID, " +
                                                "TicketEndDateTime = @ticketEndDatetime, " +
                                                "TicketUserComment = @ticketUserComment, " +
                                                "TicketComment = @ticketComment " +
                                                "WHERE TicketID = @ticketID", connection);

                cmd.Parameters.AddWithValue("@ticketUserComment", ticketUserCommentTb.Text);
                cmd.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                cmd.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
                cmd.Parameters.AddWithValue("@ticketComment", "Отменена пользователем " + Observer.currentUserLogin);
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
                                     "LEFT JOIN DeviceTypes AS DT " +
                                     "ON T.UsedDeviceID = DT.DeviceTypeID " +
                                     "LEFT JOIN TicketStatuses TS " +
                                     "ON T.TicketStatusID = TS.TicketStatusID " +
                                     "WHERE U.UserLogin = @userLogin", connection);

                cmd.Parameters.AddWithValue("@userLogin", Observer.currentUserLogin);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                (this.Owner.Controls["userMainFormGridView"] as DataGridView).DataSource = dt;

                this.Close();
            }
        }
        private void ticketHandlerFormTicketReopenBtn_Click(object sender, EventArgs e)
        {
            UserReopenTicketForm reopenTicketForm = new UserReopenTicketForm();
            reopenTicketForm.Tag = this.Tag;
            reopenTicketForm.StartPosition = FormStartPosition.CenterParent;
            reopenTicketForm.Owner = this;
            reopenTicketForm.ShowDialog();
        }
    }
}

