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
                                                                "ON T.TicketStatusID = TS.TicketStatusID ", connection);

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
                                                                  "UsedDeviceID = @usedDevice, " +
                                                                  "TicketUserComment = @ticketUserComment, " +
                                                                  "TicketComment = @ticketComment " +
                                                                  "WHERE TicketID = @ticketID", connection);

                        string ticketID = this.Tag.ToString();
                        updateCommand.Parameters.AddWithValue("ticketID", this.Tag.ToString());
                        updateCommand.Parameters.AddWithValue("@ticketUserComment", ticketUserCommentTb.Text);
                        updateCommand.Parameters.AddWithValue("@usedDevice", DBNull.Value);

                        if (ticketTicketStatusCb.Text == "Принята в работу" && ticketTechnicNameCb.Text != "")
                        {
                            this.Close();
                            return;
                        }

                        if (ticketTicketStatusCb.Text == "Отклонена")
                        {
                            if (ticketCommentTb.Text != string.Empty)
                            {
                                updateCommand.Parameters.AddWithValue("@ticketComment", ticketCommentTb.Text + " ("
                                + Observer.currentUserLogin + ")");
                            }
                            else
                            {
                                if (ticketCommentTb.Text == "")
                                {
                                    MessageBox.Show("Необходимо заполнить ответ по обращению. Сохранение невозможно.", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                updateCommand.Parameters.AddWithValue("@ticketComment", ticketUserCommentTb.Text + " ("
                                + Observer.currentUserLogin + ")");
                            }

                            updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);

                            // получаем ID статуса заявки
                            SqlCommand getStatusID = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
                            getStatusID.Parameters.AddWithValue("@ticketStatusName", this.ticketTicketStatusCb.Text);
                            int ticketStatusID = (int)getStatusID.ExecuteScalar();

                            updateCommand.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                        }

                        if (ticketTicketStatusCb.Text == "Выполнена")
                        {
                            // Проверка заполненности ответа по обращению
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

                            if (sparePartChekBox.Checked)
                            {
                                // Получить кол-во элементов на складе, если > 0, списать 1 эл-т и обновить данные, иначе ничего не делать.
                                SqlCommand getDeviceAmountCmd = new SqlCommand("SELECT DeviceAmount FROM Devices " +
                                                                               "INNER JOIN DeviceTypes " +
                                                                               "ON DeviceType = DeviceTypeID " +
                                                                               "WHERE DeviceTypeName = @deviceName", connection);

                                getDeviceAmountCmd.Parameters.AddWithValue("@deviceName", ticketDeviceCb.Text);

                                int deviceAmount = (int)getDeviceAmountCmd.ExecuteScalar();

                                if (deviceAmount > 0)
                                {
                                    deviceAmount--;
                                    SqlCommand getDeviceID = new SqlCommand("SELECT DeviceType FROM Devices " +
                                                                            "INNER JOIN DeviceTypes " +
                                                                            "ON DeviceType = DeviceTypeID " +
                                                                            "WHERE DeviceTypeName = @deviceName", connection);

                                    getDeviceID.Parameters.AddWithValue("@deviceName", ticketDeviceCb.Text);
                                    int devTypeID = (int)getDeviceID.ExecuteScalar();

                                    //обновить склад
                                    SqlCommand updateWarehouse = new SqlCommand("UPDATE DEVICES SET DeviceAmount = @deviceAmount WHERE DeviceType = @devTypeID", connection);
                                    updateWarehouse.Parameters.AddWithValue("@deviceAmount", deviceAmount);
                                    updateWarehouse.Parameters.AddWithValue("@devTypeID", devTypeID);
                                    updateWarehouse.ExecuteNonQuery();

                                    SqlCommand getDeviceIDFromDevicesCmd = new SqlCommand("SELECT DeviceID FROM Devices " +
                                                                                           "INNER JOIN DeviceTypes " +
                                                                                           "ON DeviceType = DeviceTypeID " +
                                                                                           "WHERE DeviceTypeName = @deviceName", connection);

                                    getDeviceIDFromDevicesCmd.Parameters.AddWithValue("@deviceName", ticketDeviceCb.Text);
                                    int deviceIDFromDevices = (int)getDeviceIDFromDevicesCmd.ExecuteScalar();

                                    //  получить ID устройства и добавить в таблицу с заявками
                                    updateCommand.Parameters["@usedDevice"].Value = deviceIDFromDevices;
                                }
                                else
                                {
                                    MessageBox.Show("Невозможно выполнить заявку по причине отсутствия данной техники на складе. " +
                                        "Для продолжения работы необходимо пополнить склад.",
                                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);

                            // получаем ID статуса заявки
                            SqlCommand getStatusID = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
                            getStatusID.Parameters.AddWithValue("@ticketStatusName", this.ticketTicketStatusCb.Text);
                            int ticketStatusID = (int)getStatusID.ExecuteScalar();

                            updateCommand.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);


                        }

                        updateCommand.ExecuteNonQuery();
                        //ПРАВИЛЬНЫЙ ЗАПРОС
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
                (this.Owner.Controls["userMainFormGridView"] as DataGridView).DataSource = dt;
                this.Close();
            }
        }
        private void ticketHandlerFormTicketReopenBtn_Click(object sender, EventArgs e)
        {
            TicketReopenForm reopenTicketForm = new TicketReopenForm();
            reopenTicketForm.Tag = this.Tag;
            reopenTicketForm.StartPosition = FormStartPosition.CenterParent;
            reopenTicketForm.Owner = this;
            reopenTicketForm.ShowDialog();
        }

        private void sparePartChekBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sparePartChekBox.Checked)
            {
                ticketDeviceCb.Enabled = true;
            }
            else
            {
                ticketDeviceCb.Enabled = false;
            }
        }

        private void sparePartChekBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ticketTicketStatusCb.Text != "Выполнена")
            {
                MessageBox.Show("Пользоваться складом можно в случае указания статуса заявки \"Выполнена\".", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                sparePartChekBox.Checked = false;
            }
        }

        private void ticketTicketStatusCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ticketTicketStatusCb.Text != "Выполнена" && sparePartChekBox.Checked)
            {
                MessageBox.Show("Пользоваться складом можно в случае указания статуса заявки \"Выполнена\".", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                sparePartChekBox.Checked = false;
            }
        }
    }
}