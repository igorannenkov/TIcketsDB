﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TIckets.Admin.TechnicStatuses;

namespace TIckets
{
    public partial class TechnicStatusesForm : Form
    {
        public TechnicStatusesForm()
        {
            InitializeComponent();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TechnicStatusName AS Статус FROM TechnicStatuses", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.TechnicStatusesFormGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьСтатусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicStatusHandlerForm technicStatusHandlerForm = new TechnicStatusHandlerForm();
            technicStatusHandlerForm.StartPosition = FormStartPosition.CenterScreen;
            (technicStatusHandlerForm.Controls["TechnicStatusHandlerFormEditBtn"] as Button).Enabled = false;
            technicStatusHandlerForm.Owner = this;
            technicStatusHandlerForm.ShowDialog();
        }

        private void TechnicStatusesFormGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = TechnicStatusesFormGridView.CurrentCell.Value.ToString();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TechnicStatuses WHERE TechnicStatusName = N'" + toDelete + "'", connection);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT TechnicStatusName AS Статус FROM TechnicStatuses", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.TechnicStatusesFormGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void TechnicStatusesFormGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TechnicStatusHandlerForm technicStatusHandlerForm = new TechnicStatusHandlerForm();
            technicStatusHandlerForm.Owner = this;
            string prevTechnicStatusName = TechnicStatusesFormGridView.CurrentCell.Value.ToString();
            (technicStatusHandlerForm.Controls["TechnicStatusHandlerFormStatusNameTb"] as TextBox).Text = prevTechnicStatusName;
            technicStatusHandlerForm.Tag = prevTechnicStatusName;
            technicStatusHandlerForm.StartPosition = FormStartPosition.CenterScreen;
            (technicStatusHandlerForm.Controls["TechnicStatusHandlerFormAddBtn"] as Button).Enabled = false;
            technicStatusHandlerForm.ShowDialog();
        }
    }
}