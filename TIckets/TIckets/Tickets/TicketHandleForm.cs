using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

                switch (this.ticketTicketStatusCb.SelectedValue.ToString())
                {
                    case "Выполнена":
                        cmd.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@ticketComment", "Закрыта администратором.");
                        break;
                    case "Отклонена":
                        cmd.Parameters.AddWithValue("@ticketEndDatetime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@ticketComment", "Отклонена администратором.");
                        break;
                    default:
                        cmd.Parameters.AddWithValue("@ticketEndDatetime", DBNull.Value);
                        cmd.Parameters.AddWithValue("@ticketComment", DBNull.Value);
                        break;
                }

                cmd.ExecuteNonQuery();


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
                                                            "ON T.TicketStatusID = TS.TicketStatusID ", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                (this.Owner.Controls["admGridView"] as DataGridView).DataSource = dt;
                this.Close();
            }
        }

        private void ticketHandlerFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
