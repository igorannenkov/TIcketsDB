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
using System.Globalization;

namespace TIckets
{
    public partial class UserAddTicketForm : Form
    {
        public UserAddTicketForm()
        {
            InitializeComponent();
        }

        private void userAddTicketBtn_Click(object sender, EventArgs e)
        {
            if (userAddTicketTb.Text != String.Empty)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT UserID FROM Users WHERE UserLogin = @userLogin", connection);
                    command.Parameters.AddWithValue("@userLogin", Observer.currentUserLogin);
                    int userID = (int)command.ExecuteScalar();

                    command = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = N'Новая'", connection);
                    int ticketStatusID = (int)command.ExecuteScalar();

                    command = new SqlCommand("INSERT INTO Tickets (UserID, TechnicID, TicketStatusID, TicketStartDateTime, TicketEndDateTime, TicketComment, UsedDeviceID, TicketUserComment) " +
                        "VALUES (@userID, NULL, @ticketStatusID, @currentDateTime, NULL, NULL, NULL, @userComment)", connection);

                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@ticketStatusID", ticketStatusID);
                    command.Parameters.AddWithValue("@currentDateTime", DateTime.Now);
                    command.Parameters.AddWithValue("@userComment", userAddTicketTb.Text);

                    command.ExecuteNonQuery();

                    command = new SqlCommand("SELECT MAX(TicketID) FROM Tickets", connection);
                       int insertedID = Convert.ToInt32(command.ExecuteScalar());

                    MessageBox.Show("Ваше обращение зарегистрировано за номером " + insertedID + ".", "Уведомление о регистрации обращения",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
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

        private void userAddTicketCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
