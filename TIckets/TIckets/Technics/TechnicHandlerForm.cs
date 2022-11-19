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

                SqlCommand cmd = new SqlCommand("SELECT TechnicStatusID FROM TechnicStatuses " +
                                                "WHERE TechnicStatusName = @technicStatusName", connection);

                cmd.Parameters.AddWithValue("@technicStatusName", TechnicHandlerFormStatusNameCb.Text);

                int techStatusID = (int)cmd.ExecuteScalar();
                int updateID = (int)(this.Owner.Controls["TechnicHandlerFormGridView"] as DataGridView).CurrentRow.Cells[0].Value;

                cmd = new SqlCommand("UPDATE Technics SET " +
                                        "TechnicName = @techStatusName, " +
                                        "TechnicStatusID = @techStatusID" +
                                        " WHERE TechnicID = @updateID", connection);

                cmd.Parameters.AddWithValue("@techStatusName", TechnicHandlerFormTechnicNameTb.Text);
                cmd.Parameters.AddWithValue("@techStatusID", techStatusID);
                cmd.Parameters.AddWithValue("@updateID", updateID);

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
                                                "WHERE TechnicStatusName = @technicStatusName", connection);

                cmd.Parameters.AddWithValue("@technicStatusName", TechnicHandlerFormStatusNameCb.Text);
                int technicID = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO Technics (TechnicName, TechnicStatusID) " +
                                                "VALUES (@technicName, @technicID)", connection);

                cmd.Parameters.AddWithValue("@technicName", TechnicHandlerFormTechnicNameTb.Text);
                cmd.Parameters.AddWithValue("@technicID", technicID);

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
