﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class TechnicMainForm : Form
    {
        public TechnicMainForm()
        {
            InitializeComponent();
        }

        private void моиЗаявкиToolStripMenuItem1_Click(object sender, EventArgs e)
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
                technicGridView.DataSource = dt;
            }
        }

        private void отклоненныеToolStripMenuItem_Click(object sender, EventArgs e)
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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "' " +
                                                            "AND TS.TicketStatusName = N'Отклонена';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void отмененныеToolStripMenuItem_Click(object sender, EventArgs e)
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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "' " +
                                                            "AND TS.TicketStatusName = N'Отменена';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void выполненныеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "' " +
                                                            "AND TS.TicketStatusName = N'Выполнена';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void новыеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
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
                                                            "WHERE UN.UserLogin = N'" + Observer.currentUserLogin + "' " +
                                                            "AND TS.TicketStatusName = N'Принята в работу';", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                technicGridView.DataSource = dt;
            }
        }

        private void выгрузкаВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelReporter.GetReport(technicGridView);
        }

        private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сменаПароляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.StartPosition = FormStartPosition.CenterScreen;
            changePasswordForm.ShowDialog();
        }

        private void историяЗаявокКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTisketHistorySearchForm historySearchForm = new UserTisketHistorySearchForm();
            historySearchForm.StartPosition = FormStartPosition.CenterScreen;
            historySearchForm.ShowDialog();
        }

        private void technicGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                TicketHandleForm ticketHandleForm = new TicketHandleForm();
                (ticketHandleForm.Controls["ticketDeviceCb"] as ComboBox).Enabled = false;
                (ticketHandleForm.Controls["ticketHandlerFormUsedDeviceLbl"] as Label).Enabled = false;

                ticketHandleForm.Owner = this;

                // Редактировать пользователя обращения запрещено
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).Text = this.technicGridView.CurrentRow.Cells[1].Value.ToString();
                (ticketHandleForm.Controls["ticketUserNameCb"] as ComboBox).Enabled = false;

                // Нельзя менять техника
                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).Text = this.technicGridView.CurrentRow.Cells[3].Value.ToString();
                (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).Enabled = false;

                // Загружаем текст обращения

                (ticketHandleForm.Controls["ticketHandlerFormUserCommentTb"] as TextBox).Text = this.technicGridView.CurrentRow.Cells[2].Value.ToString();


                //SqlCommand command = new SqlCommand("SELECT UserName AS TechnicName FROM Users U " +
                //                                    "INNER JOIN Roles R ON U.UserRoleID = R.RoleID " +
                //                                    "WHERE R.ROleName = N'Техник'", connection);
                //command.ExecuteNonQuery();
                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                //DataTable dt = new DataTable();
                //adapter.Fill(dt);

                //(ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).ValueMember = "TechnicName";
                //(ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).DataSource = dt;
                if (this.technicGridView.CurrentRow.Cells[3].Value.ToString() != "Не назначен")
                {
                    (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).SelectedValue = this.technicGridView.CurrentRow.Cells[3].Value.ToString();
                }

                SqlCommand command = new SqlCommand("SELECT TicketStatusName FROM TicketStatuses WHERE TicketStatusName <> N'Новая'", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).ValueMember = "TicketStatusName";
                (ticketHandleForm.Controls["ticketTicketStatusCb"] as ComboBox).DataSource = dt;

                ticketHandleForm.Tag = this.technicGridView.CurrentRow.Cells[0].Value.ToString();

                if (this.technicGridView.CurrentRow.Cells[3].Value.ToString() == "Не назначен")
                {
                    (ticketHandleForm.Controls["ticketTechnicNameCb"] as ComboBox).SelectedIndex = -1;
                }

                ticketHandleForm.StartPosition = FormStartPosition.CenterParent;
                ticketHandleForm.ShowDialog();
            }
        }
    }
}
