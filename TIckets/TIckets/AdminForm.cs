using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace TIckets
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void ПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usForm = new UsersForm();
            usForm.StartPosition = FormStartPosition.CenterParent;
            usForm.ShowDialog();
        }
        private void ролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm rf = new RolesForm();
            rf.StartPosition = FormStartPosition.CenterParent;
            rf.ShowDialog();
        }
        private void ТипыУстройствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTypesForm dtf = new DeviceTypesForm();
            dtf.StartPosition = FormStartPosition.CenterParent;
            dtf.ShowDialog();
        }
        private void статусыЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketStatusesForm ticketStatusesForm = new TicketStatusesForm();
            ticketStatusesForm.StartPosition = FormStartPosition.CenterScreen;
            ticketStatusesForm.ShowDialog();

        }
        private void всеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
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
                                                            "ON T.TicketStatusID = TS.TicketStatusID ", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                admGridView.DataSource = dt;

            }
        }
        private void новыеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
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
                                                            "WHERE TS.TicketStatusName = N'Новая'", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                admGridView.DataSource = dt;
            }
        }

        private void admGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

               

                TicketHandleForm ticketHandleForm = new TicketHandleForm();
                (ticketHandleForm.Controls["ticketDeviceCb"] as ComboBox).Enabled = false;
                (ticketHandleForm.Controls["ticketHandlerFormUsedDeviceLbl"] as Label).Enabled = false;

                ticketHandleForm.Owner = this;

                // Редактировать пользователя обращения запрещено


                SqlCommand command = new SqlCommand("SELECT UserName as UserName FROM Users U " +
                                                    "INNER JOIN Roles R ON U.UserRoleID = R.RoleID " +
                                                    "WHERE R.ROleName = N'Пользователь'", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).ValueMember = "UserName";
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).DataSource = dt;
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).SelectedValue = this.admGridView.CurrentRow.Cells[1].Value.ToString();
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).Enabled = false;

                command = new SqlCommand("SELECT UserName AS TechnicName FROM Users U " +
                                                    "INNER JOIN Roles R ON U.UserRoleID = R.RoleID " +
                                                    "WHERE R.ROleName = N'Техник'", connection);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);

               


                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).ValueMember = "TechnicName";
                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).DataSource = dt;
                if (this.admGridView.CurrentRow.Cells[3].Value.ToString() != "Не назначен")
                {
                    (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).SelectedValue = this.admGridView.CurrentRow.Cells[3].Value.ToString();
                }

                command = new SqlCommand("SELECT TicketStatusName FROM TicketStatuses WHERE TicketStatusName <> N'Новая'", connection);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).ValueMember = "TicketStatusName";
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).DataSource = dt;

                ticketHandleForm.Tag = this.admGridView.CurrentRow.Cells[0].Value.ToString();

                if (this.admGridView.CurrentRow.Cells[3].Value.ToString() == "Не назначен")
                {
                    (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).SelectedIndex = -1;
                }

                ticketHandleForm.StartPosition = FormStartPosition.CenterParent;
                ticketHandleForm.ShowDialog();



            }
        }

        private void выгрузкаВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // добавить сборку Excel
                _Application app = new Microsoft.Office.Interop.Excel.Application();
                _Workbook workbook = app.Workbooks.Add(Type.Missing);
                _Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Лист1"];
                worksheet = workbook.ActiveSheet;
                // Устанавливаем текстовый формат ячеек.
                Range cells = workbook.Worksheets[1].Cells;
                cells.NumberFormat = "@";
                // Вынужденная мера. Удаляем вхождение 0:00:00 в датах, пока не разобрался.
                char[] toTrim = { '0', ':', '0', '0', ':', '0', '0' };

                for (int i = 1; i < admGridView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = admGridView.Columns[i - 1].HeaderText;
                    app.ActiveCell.EntireRow.Font.Bold = true;
                }
                for (int i = 0; i < admGridView.Rows.Count; i++)// GridView.Rows.Count-1 было неверно.
                {
                    for (int j = 0; j < admGridView.Columns.Count; j++)
                    {
                        if (admGridView.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = admGridView.Rows[i].Cells[j].Value.ToString().Replace("0:00:00", "");
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                app.Columns.AutoFit();
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("Ошибка выгрузки данных. Вероятно в системе не установлен MS Office. \r\n\r\n" + ex.Message,
                                "Ошибка выгрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка выгрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
