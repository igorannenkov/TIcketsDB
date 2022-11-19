using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class TechnicsForm : Form
    {
        public TechnicsForm()
        {
            InitializeComponent();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string command = "SELECT TechnicID AS ID, TechnicName [ФИО техника], TechnicStatusName AS [Статус] " +
                                 "FROM Technics T " +
                                 "INNER JOIN TechnicStatuses TS ON T.TechnicStatusID = TS.TechnicStatusID;";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.TechnicHandlerFormGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьТехникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicHandlerForm technicHandlerForm = new TechnicHandlerForm();
            technicHandlerForm.StartPosition = FormStartPosition.CenterScreen;
            (technicHandlerForm.Controls["TechnicHandlerFormEditBtn"] as Button).Enabled = false;
            technicHandlerForm.Owner = this;
            technicHandlerForm.ShowDialog();
        }

        private void TechnicHandlerFormGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = TechnicHandlerFormGridView.CurrentRow.Cells[0].Value.ToString();
                    string sqlCommandText = "DELETE FROM Technics WHERE TechnicID = @toDelete";

                    SqlCommand cmd = new SqlCommand(sqlCommandText, connection);
                    cmd.Parameters.AddWithValue("@toDelete", toDelete);                
                    cmd.ExecuteNonQuery();

                    string command = "SELECT TechnicID AS ID, TechnicName [ФИО техника], TechnicStatusName AS [Статус] " +
                                     "FROM Technics T " +
                                     "INNER JOIN TechnicStatuses TS ON T.TechnicStatusID = TS.TechnicStatusID;";

                    SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.TechnicHandlerFormGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void TechnicHandlerFormGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                TechnicHandlerForm technicHandleForm = new TechnicHandlerForm();
                technicHandleForm.Owner = this;

                string prevTechnicName = TechnicHandlerFormGridView.CurrentRow.Cells[1].Value.ToString();
                (technicHandleForm.Controls["TechnicHandlerFormTechnicNameTb"] as TextBox).Text = prevTechnicName;
                technicHandleForm.Tag = prevTechnicName;

                SqlCommand cmd = new SqlCommand("SELECT TechnicStatusName AS Status FROM TechnicStatuses", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                (technicHandleForm.Controls["TechnicHandlerFormStatusNameCb"] as ComboBox).ValueMember = "Status";
                (technicHandleForm.Controls["TechnicHandlerFormStatusNameCb"] as ComboBox).DataSource = ds.Tables[0];
                technicHandleForm.StartPosition = FormStartPosition.CenterScreen;
                (technicHandleForm.Controls["TechnicHandlerFormAddBtn"] as Button).Enabled = false;
                technicHandleForm.ShowDialog();
            }
        }
    }
}
