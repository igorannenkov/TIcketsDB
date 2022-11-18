using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class TechnicHandlerForm : Form
    {
        public TechnicHandlerForm()
        {
            InitializeComponent();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TechnicStatusName AS Status FROM TechnicStatuses", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.TechnicHandlerFormStatusNameCb.ValueMember = "Status";
                this.TechnicHandlerFormStatusNameCb.DataSource = ds.Tables[0];
            }
        }

        private void TechnicHandlerFormEditBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string prevTechnicName = this.Tag.ToString();

                SqlCommand cmd = new SqlCommand("SELECT TechnicStatusID FROM TechnicStatuses " +
                                                "WHERE TechnicStatusName =N'" + TechnicHandlerFormStatusNameCb.Text + "'", connection);
                int techID = (int)cmd.ExecuteScalar();

                int toUpdateID = (int)(this.Owner.Controls["TechnicHandlerFormGridView"] as DataGridView).CurrentRow.Cells[0].Value;

                cmd = new SqlCommand("UPDATE Technics SET " +
                                                "TechnicName = N'" + TechnicHandlerFormStatusNameTb.Text + "', " +
                                                "TechnicStatusID = " + techID +
                                                " WHERE TechnicID =" + toUpdateID, connection);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TechnicID AS ID, TechnicName [ФИО техника], TechnicStatusName AS [Статус] " +
                                                           "FROM Technics T " +
                                                           "INNER JOIN TechnicStatuses TS ON T.TechnicStatusID = TS.TechnicStatusID;", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["TechnicHandlerFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void TechnicHandlerFormAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TechnicStatusID FROM TechnicStatuses " +
                                                "WHERE TechnicStatusName =N'" + TechnicHandlerFormStatusNameCb.Text + "'", connection);
                int techID = (int)cmd.ExecuteScalar();
                cmd = new SqlCommand("INSERT INTO Technics (TechnicName, TechnicStatusID) " +
                                                "VALUES (N'" + TechnicHandlerFormStatusNameTb.Text + "', '" + techID + "')", connection);

                cmd.ExecuteNonQuery();

                string command = "SELECT TechnicID AS ID, TechnicName [ФИО техника], TechnicStatusName AS [Статус] " +
                               "FROM Technics T " +
                               "INNER JOIN TechnicStatuses TS ON T.TechnicStatusID = TS.TechnicStatusID;";

                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["TechnicHandlerFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void TechnicHandlerFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
