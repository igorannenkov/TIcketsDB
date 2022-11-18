﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIckets
{
    public partial class TicketStatusHandlerForm : Form
    {
        public TicketStatusHandlerForm()
        {
            InitializeComponent();
        }

        private void TicketStatusHandlerFormEditBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string prevRoleName = this.Tag.ToString();
                SqlCommand cmd = new SqlCommand("UPDATE TicketStatuses SET TicketStatusName =  (N'" + TicketStatusHandlerFormStatusNameTb.Text + "') WHERE TicketStatusName = N'" + prevRoleName + "'", connection);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TicketStatusName AS Статус FROM TicketStatuses", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["TicketStatusesFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void TicketStatusHandlerFormAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TicketStatuses (TicketStatusName) VALUES (N'" + TicketStatusHandlerFormStatusNameTb.Text + "')", connection);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TicketStatusName AS Статус FROM TicketStatuses", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["TicketStatusesFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void TicketStatusHandlerFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}