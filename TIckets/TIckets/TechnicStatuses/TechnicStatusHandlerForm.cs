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
                SqlCommand cmd = new SqlCommand("INSERT INTO TechnicStatuses (TechnicStatusName) VALUES (N'" + TechnicStatusHandlerFormStatusNameTb.Text + "')", connection);
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
                string prevTechStatusName = this.Tag.ToString();
                SqlCommand cmd = new SqlCommand("UPDATE TechnicStatuses SET TechnicStatusName =  (N'" + TechnicStatusHandlerFormStatusNameTb.Text + "') WHERE TechnicStatusName = N'" + prevTechStatusName + "'", connection);
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
