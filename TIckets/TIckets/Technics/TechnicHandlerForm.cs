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

namespace TIckets.Admin.Technics
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
                string prevTechnicID = this.Tag.ToString();
                SqlCommand cmd = new SqlCommand("UPDATE Technics SET TechnicName = N'" + TechnicHandlerFormStatusNameLblFIO.Text + "'," +
                    "TechnicStatusID = N'" + TechnicHandlerFormStatusNameCb + "'" +
                    " WHERE TechnicStatusID =" + prevTechnicID, connection);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TechicID AS ID, TechnicName AS Техник, TechnicStatusID AS Статус FROM TechnicStatuses", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["TechnicHandlerFormGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        // ОБЪЕДИНЕНИЕ ТАБЛИЦ

        private void TechnicHandlerFormAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Technics (TechnicName, TechnicStatusID) VALUES (N'" + TechnicHandlerFormStatusNameTb.Text + "', N'" + TechnicHandlerFormStatusNameCb.Text +  "')", connection);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TechicID AS ID, TechnicName AS Техник, TechnicStatusName AS Статус FROM TechnicStatuses, Technics WHERE Technics.TechnicStatusID = TechnicStatuses.TechnicStatusID", connection);
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
