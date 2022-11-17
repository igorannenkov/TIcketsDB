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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TicketStatusName AS Статус FROM TicketStatuses", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.TicketStatusesFormGridView.DataSource = ds.Tables[0];
            }
        }

        private void TicketStatusesFormGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TicketStatusHandlerForm TicketStatusHandleForm = new TicketStatusHandlerForm();
            TicketStatusHandleForm.Owner = this;
            string prevTicketStatusName = TicketStatusesFormGridView.CurrentCell.Value.ToString();
            (TicketStatusHandleForm.Controls["TicketStatusHandlerFormStatusNameTb"] as TextBox).Text = prevTicketStatusName;
            TicketStatusHandleForm.Tag = prevTicketStatusName;
            TicketStatusHandleForm.StartPosition = FormStartPosition.CenterScreen;
            (TicketStatusHandleForm.Controls["TicketStatusHandlerFormAddBtn"] as Button).Enabled = false;
            TicketStatusHandleForm.ShowDialog();
        }

        private void TicketStatusesFormGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = TicketStatusesFormGridView.CurrentCell.Value.ToString();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TicketStatuses WHERE TIcketStatusName = N'" + toDelete + "'", connection);
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
