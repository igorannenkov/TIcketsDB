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
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                if (this.ticketTechnicNameCb.SelectedValue == null)
                {
                    cmd = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
                    cmd.Parameters.AddWithValue("@ticketStatusName", this.ticketTicketStatusCb.SelectedValue.ToString());
                    int ticketStatusID = (int)cmd.ExecuteScalar();

                    cmd = new SqlCommand("UPDATE Tickets " +
                                         "SET TicketStatusID = @ticketStatusID, " +
                                              "TicketEndDateTime = @ticketEndDatetime, " +
                                              "TicketComment = @ticketComment " +
                                              "WHERE TicketID = @ticketID", connection);

                    cmd.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                    cmd.Parameters.AddWithValue("@ticketID", this.Tag.ToString());
                }
                else
                {
                    cmd = new SqlCommand("SELECT UserID FROM USERS WHERE UserName = @technicID", connection);
                    cmd.Parameters.AddWithValue("@technicID", this.ticketTechnicNameCb.SelectedValue.ToString());
                    int technicID = (int)cmd.ExecuteScalar();
                    cmd = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
                    cmd.Parameters.AddWithValue("@ticketStatusName", this.ticketTicketStatusCb.SelectedValue.ToString());
                    int ticketStatusID = (int)cmd.ExecuteScalar();
                    cmd = new SqlCommand("UPDATE Tickets " +
                                         "SET TechnicID = @technicID, " +
                                              "TicketStatusID = @ticketStatusID, " +
                                              "TicketEndDateTime = @ticketEndDatetime, " +
                                              "TicketComment = @ticketComment " +
                                              "WHERE TicketID = @ticketID", connection);

                    cmd.Parameters.AddWithValue("@technicID", technicID);
                    cmd.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                    cmd.Parameters.AddWithValue("@ticketID", this.Tag.ToString());
                }


                SqlCommand command = new SqlCommand("SELECT RoleName FROM Roles R " +
                                             "INNER JOIN Users U " +
                                             "ON R.RoleID = U.UserRoleID " +
                                             "WHERE U.UserLogin = @userLogin ", connection);

                command.Parameters.AddWithValue("@userLogin", Observer.currentUserLogin);

                string currentUserRole = (string)command.ExecuteScalar();

                if (currentUserRole == "Администратор")
                {
                    switch (this.ticketTicketStatusCb.SelectedValue.ToString())
                    {
                        case "Выполнена":
                            if (ticketCommentCb.Text == string.Empty)
                            {
                                cmd.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
                                cmd.Parameters.AddWithValue("@ticketComment", "Закрыта администратором");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
                                cmd.Parameters.AddWithValue("@ticketComment", ticketCommentCb.Text);
                            }
                            break;
                        case "Отклонена":
                            if (ticketCommentCb.Text == string.Empty)
                            {
                                cmd.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
                                cmd.Parameters.AddWithValue("@ticketComment", "Отклонена администратором");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
                                cmd.Parameters.AddWithValue("@ticketComment", ticketCommentCb.Text);
                            }
                            break;
                        default:
                            cmd.Parameters.AddWithValue("@ticketEndDatetime", DBNull.Value);
                            cmd.Parameters.AddWithValue("@ticketComment", DBNull.Value);
                            break;
                    }
                }
                else
                {
                    switch (this.ticketTicketStatusCb.SelectedValue.ToString())
                    {
                        case "Выполнена":
                            cmd.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
                            cmd.Parameters.AddWithValue("@ticketComment", ticketCommentCb.Text);
                            break;
                        case "Отклонена":
                            cmd.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
                            cmd.Parameters.AddWithValue("@ticketComment", ticketCommentCb.Text);
                            break;
                        default:
                            cmd.Parameters.AddWithValue("@ticketEndDatetime", DBNull.Value);
                            cmd.Parameters.AddWithValue("@ticketComment", DBNull.Value);
                            break;
                    }
                }

                cmd.ExecuteNonQuery();

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
                if (currentUserRole == "Администратор")
                {
                    (this.Owner.Controls["admGridView"] as DataGridView).DataSource = dt;
                }
                if (currentUserRole == "Техник")
                {
                    (this.Owner.Controls["technicGridView"] as DataGridView).DataSource = dt;
                }
                this.Close();
            }
        }

        private void ticketHandlerFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

