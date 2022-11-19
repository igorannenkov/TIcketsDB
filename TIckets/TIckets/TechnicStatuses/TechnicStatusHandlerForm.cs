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

namespace TIckets.Admin.TechnicStatuses
{
    public partial class TechnicStatusHandlerForm : Form
    {
        public TechnicStatusHandlerForm()
        {
            InitializeComponent();
        }

        private void TechnicStatusHandlerFormAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TechnicStatuses (TechnicStatusName) VALUES (@newTechStatusName)", connection);
                cmd.Parameters.AddWithValue("@newTechStatusName", TechnicStatusHandlerFormStatusNameTb.Text);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TechnicStatusName AS Статус FROM TechnicStatuses", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["TechnicStatusesFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void TechnicStatusHandlerFormEditBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                int prevTechStatusID = (int)this.Tag;
                SqlCommand cmd = new SqlCommand("UPDATE TechnicStatuses SET TechnicStatusName =  (@newTechStatusName) WHERE TechnicStatusID = @techStatusID", connection);
                cmd.Parameters.AddWithValue("@newTechStatusName", TechnicStatusHandlerFormStatusNameTb.Text);
                cmd.Parameters.AddWithValue("@techStatusID", prevTechStatusID);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TechnicStatusName AS Статус FROM TechnicStatuses", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["TechnicStatusesFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }      

        private void TechnicStatusHandlerFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
