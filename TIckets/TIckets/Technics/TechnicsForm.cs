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
using TIckets.Admin.Technics;

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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TechnicID AS ID, TechnicName AS Техник, TechnicStatusID AS Статус FROM Technics", connection);
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Technics WHERE TechnicID = " + toDelete , connection);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT  TechicID AS ID, TechnicName AS Техник, TechnicStatusID AS Статус FROM Technics", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    (this.Owner.Controls["TechnicHandlerFormGridView"] as DataGridView).DataSource = ds.Tables[0];
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
                string prevTechnicName = TechnicHandlerFormGridView.CurrentCell.Value.ToString();
                (technicHandleForm.Controls["TechnicHandlerFormStatusNameTb"] as TextBox).Text = prevTechnicName;
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
