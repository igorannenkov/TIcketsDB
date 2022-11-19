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

namespace TIckets
{
    public partial class TicketStatusesForm : Form
    {
        public TicketStatusesForm()
        {
            InitializeComponent();
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TicketStatusName AS [Статус заявки] FROM TicketStatuses", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.TicketStatusesFormGridView.DataSource = ds.Tables[0];
            }
        }

        private void TicketStatusesFormGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                TicketStatusHandlerForm TicketStatusHandleForm = new TicketStatusHandlerForm();
                TicketStatusHandleForm.Owner = this;
                string prevTicketStatusName = TicketStatusesFormGridView.CurrentCell.Value.ToString();
                (TicketStatusHandleForm.Controls["TicketStatusHandlerFormStatusNameTb"] as TextBox).Text = prevTicketStatusName;

                SqlCommand cmd = new SqlCommand("SELECT TicketStatusID FROM TicketStatuses WHERE TicketStatusName = @ticketStatusName", connection);
                cmd.Parameters.AddWithValue("@ticketStatusName", prevTicketStatusName);

                TicketStatusHandleForm.Tag = cmd.ExecuteScalar();
                TicketStatusHandleForm.StartPosition = FormStartPosition.CenterScreen;
                (TicketStatusHandleForm.Controls["TicketStatusHandlerFormAddBtn"] as Button).Enabled = false;
                TicketStatusHandleForm.ShowDialog();
            }
        }

        private void TicketStatusesFormGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TicketStatuses WHERE TIcketStatusName = @ticketStatusToDelete", connection);
                    cmd.Parameters.AddWithValue("@ticketStatusToDelete", TicketStatusesFormGridView.CurrentCell.Value.ToString());
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT TicketStatusName AS Статус FROM TicketStatuses", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.TicketStatusesFormGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketStatusHandlerForm TicketStatusHandleForm = new TicketStatusHandlerForm();
            TicketStatusHandleForm.StartPosition = FormStartPosition.CenterScreen;
            (TicketStatusHandleForm.Controls["TicketStatusHandlerFormEditBtn"] as Button).Enabled = false;
            TicketStatusHandleForm.Owner = this;
            TicketStatusHandleForm.ShowDialog();
        }
    }
}
