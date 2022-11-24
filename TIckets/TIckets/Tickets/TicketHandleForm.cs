using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

                case "Техник": break;
                case "Пользователь": break;
            }




            //using (SqlConnection connection = Database.GetConnection())
            //{



            //    if (this.ticketTechnicNameCb.Text == null && this.ticketTicketStatusCb.Text == "Принята в работу")
            //    // || this.ticketTechnicNameCb.Text == String.Empty)
            //    {
            //        MessageBox.Show("Необходимо назначить техника на заявку. Информация не сохранена.", "Ошибка назначения заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (this.ticketTechnicNameCb.SelectedValue == null || this.ticketTechnicNameCb.Text == String.Empty)
            //    {
            //        cmd = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
            //        cmd.Parameters.AddWithValue("@ticketStatusName", this.ticketTicketStatusCb.Text.ToString());
            //        int ticketStatusID = (int)cmd.ExecuteScalar();
            //        updateCommand.Parameters.AddWithValue("@technicID", DBNull.Value);
            //        updateCommand.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
            //        updateCommand.Parameters.AddWithValue("@ticketID", this.Tag.ToString());
            //    }
            //    else
            //    {
            //        cmd = new SqlCommand("SELECT UserID FROM USERS WHERE UserName = @technicID", connection);
            //        cmd.Parameters.AddWithValue("@technicID", this.ticketTechnicNameCb.SelectedValue.ToString());
            //        int technicID = (int)cmd.ExecuteScalar();
            //        cmd = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
            //        cmd.Parameters.AddWithValue("@ticketStatusName", this.ticketTicketStatusCb.Text.ToString());
            //        int ticketStatusID = (int)cmd.ExecuteScalar();

            //        updateCommand.Parameters.AddWithValue("@technicID", technicID);
            //        updateCommand.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
            //        updateCommand.Parameters.AddWithValue("@ticketID", this.Tag.ToString());
            //    }


            //    SqlCommand command = new SqlCommand("SELECT RoleName FROM Roles R " +
            //                                 "INNER JOIN Users U " +
            //                                 "ON R.RoleID = U.UserRoleID " +
            //                                 "WHERE U.UserLogin = @userLogin ", connection);

            //    command.Parameters.AddWithValue("@userLogin", Observer.currentUserLogin);

            //    string currentUserRole = (string)command.ExecuteScalar();

            //    if (currentUserRole == "Администратор")
            //    {

            //        switch (this.ticketTicketStatusCb.SelectedValue.ToString())
            //        {
            //            case "Выполнена":
            //                if (ticketCommentTb.Text == string.Empty)
            //                {
            //                    updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
            //                    updateCommand.Parameters.AddWithValue("@ticketComment", "Закрыта администратором (" + Observer.currentUserLogin + ")");
            //                }
            //                else
            //                {
            //                    updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
            //                    updateCommand.Parameters.AddWithValue("@ticketComment", ticketCommentTb.Text + " (" + Observer.currentUserLogin + ")");
            //                }
            //                break;
            //            case "Отклонена":
            //                if (ticketCommentTb.Text == string.Empty)
            //                {
            //                    updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
            //                    updateCommand.Parameters.AddWithValue("@ticketComment", "Отклонена администратором (" + Observer.currentUserLogin + ")");
            //                }
            //                else
            //                {
            //                    updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
            //                    updateCommand.Parameters.AddWithValue("@ticketComment", ticketCommentTb.Text + " (" + Observer.currentUserLogin + ")");
            //                }
            //                break;
            //            default:
            //                updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DBNull.Value);
            //                updateCommand.Parameters.AddWithValue("@ticketComment", DBNull.Value);
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        switch (this.ticketTicketStatusCb.Text.ToString())
            //        {
            //            case "Выполнена":
            //                updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
            //                updateCommand.Parameters.AddWithValue("@ticketComment", ticketCommentTb.Text + " (" + Observer.currentUserLogin + ")");
            //                break;
            //            case "Отклонена":
            //                updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
            //                updateCommand.Parameters.AddWithValue("@ticketComment", ticketCommentTb.Text + " (" + Observer.currentUserLogin + ")");
            //                break;
            //            default:
            //                updateCommand.Parameters.AddWithValue("@ticketEndDatetime", DBNull.Value);
            //                updateCommand.Parameters.AddWithValue("@ticketComment", DBNull.Value);
            //                break;
            //        }
            //    }

            //    updateCommand.ExecuteNonQuery();



            //    //SqlCommand RefreshCmd = new SqlCommand("SELECT T.TicketID AS [ID Заявки], " +
            //    //                     "U.UserName AS Пользователь, " +
            //    //                     "T.TicketUserComment AS [Текст обращения], " +
            //    //                     "COALESCE(UN.UserName, N'Не назначен') AS [Назначенный техник], " +
            //    //                     "TS.TicketStatusName AS [Статус заявки], " +
            //    //                     "T.TicketStartDateTime AS [Время регистрации], " +
            //    //                     "T.TicketEndDateTime AS [Время выполнения], " +
            //    //                     "T.TicketComment AS [Ответ по обращению], " +
            //    //                     "DT.DeviceTypeName AS [Используемые материалы] " +
            //    //                     "FROM Tickets AS T " +
            //    //                     "LEFT JOIN Users AS U " +
            //    //                     "ON T.UserID = U.UserID " +
            //    //                     "LEFT JOIN  Users AS UN " +
            //    //                     "ON T.TechnicID = UN.UserID " +
            //    //                     "LEFT JOIN DeviceTypes AS DT " +
            //    //                     "ON T.UsedDeviceID = DT.DeviceTypeID " +
            //    //                     "LEFT JOIN TicketStatuses TS " +
            //    //                     "ON T.TicketStatusID = TS.TicketStatusID " +
            //    //                     "WHERE U.UserLogin = N'" + Observer.currentUserLogin + "';", connection);

            //    string filter = "";

            //    switch (currentUserRole)
            //    {
            //        case "Администратор": filter = ""; break;
            //        case "Техник": filter = "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "';"; break;
            //        case "Пользователь": filter = "WHERE U.UserLogin = N'" + Observer.currentUserLogin + "';"; break;
            //    }

            //    SqlCommand RefreshCmd = new SqlCommand("SELECT T.TicketID AS [ID Заявки], " +
            //                                            "U.UserName AS Пользователь, " +
            //                                            "T.TicketUserComment AS [Текст обращения], " +
            //                                            "COALESCE(UN.UserName, N'Не назначен') AS [Назначенный техник], " +
            //                                            "TS.TicketStatusName AS [Статус заявки], " +
            //                                            "T.TicketStartDateTime AS [Время регистрации], " +
            //                                            "T.TicketEndDateTime AS [Время выполнения], " +
            //                                            "T.TicketComment AS [Ответ по обращению], " +
            //                                            "DT.DeviceTypeName AS [Используемые материалы] " +
            //                                            "FROM Tickets AS T " +
            //                                            "LEFT JOIN Users AS U " +
            //                                            "ON T.UserID = U.UserID " +
            //                                            "LEFT JOIN  Users AS UN " +
            //                                            "ON T.TechnicID = UN.UserID " +
            //                                            "LEFT JOIN DeviceTypes AS DT " +
            //                                            "ON T.UsedDeviceID = DT.DeviceTypeID " +
            //                                            "LEFT JOIN TicketStatuses TS " +
            //                                            "ON T.TicketStatusID = TS.TicketStatusID " +
            //                                            filter, connection);




            //    SqlDataAdapter adapter = new SqlDataAdapter(RefreshCmd);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);


            //    // (this.Owner.Controls["userMainFormGridView"] as DataGridView).DataSource = dt;




            //    switch (currentUserRole)
            //    {
            //        case "Администратор": (this.Owner.Controls["admGridView"] as DataGridView).DataSource = dt; break;
            //        case "Техник": (this.Owner.Controls["technicGridView"] as DataGridView).DataSource = dt; break;
            //        case "Пользователь": (this.Owner.Controls["userMainFormGridView"] as DataGridView).DataSource = dt; break;
            //    }

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
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                // Получаем ID статуса заявки из табл. Статусы заявок.
                SqlCommand command = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = N'Переоткрыта'", connection);
                int ticketStatusID = (int)command.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("UPDATE Tickets " +
                                                "SET TicketStatusID = @ticketStatusID, " +
                                                "TicketStartDateTime = @ticketStartDateTime, " +
                                                "TicketEndDateTime = @ticketEndDatetime, " +
                                                "TicketUserComment = @ticketUserComment, " +
                                                "TicketComment = @ticketComment " +
                                                "WHERE TicketID = @ticketID", connection);

                cmd.Parameters.AddWithValue("@ticketUserComment", ticketUserCommentTb.Text);
                cmd.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                cmd.Parameters.AddWithValue("@ticketStartDateTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@ticketEndDatetime", DBNull.Value);
                cmd.Parameters.AddWithValue("@ticketComment", "");
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
    }
}

