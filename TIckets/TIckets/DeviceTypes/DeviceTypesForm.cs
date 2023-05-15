using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class DeviceTypesForm : Form
    {
        public DeviceTypesForm()
        {
            InitializeComponent();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DeviceTypeName AS Категория FROM DeviceTypes", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
               this.DeviceTypesGridView.DataSource = ds.Tables[0];
            }
        }



        private void DeviceTypesGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                DeviceTypesHandlerForm devTypeHandlerForm = new DeviceTypesHandlerForm();
                devTypeHandlerForm.Owner = this;
                string prevDeviceTypeName = DeviceTypesGridView.CurrentCell.Value.ToString();
                (devTypeHandlerForm.Controls["DeviceTypesHandlerFormTb"] as TextBox).Text = prevDeviceTypeName;

                SqlCommand cmd = new SqlCommand("SELECT DeviceTypeID FROM DeviceTypes WHERE DeviceTypeName = @devTypeName", connection);
                cmd.Parameters.AddWithValue("@devTypeName", prevDeviceTypeName);
                
                devTypeHandlerForm.Tag = cmd.ExecuteScalar();              
                devTypeHandlerForm.StartPosition = FormStartPosition.CenterScreen;
                (devTypeHandlerForm.Controls["DeviceTypesHandlerFormAddBtn"] as Button).Enabled = false;
                devTypeHandlerForm.ShowDialog();
            }
        }

        private void DeviceTypesGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM DeviceTypes WHERE DeviceTypeName = @deviceTypeToDelete", connection);
                    cmd.Parameters.AddWithValue("@deviceTypeToDelete", DeviceTypesGridView.CurrentCell.Value.ToString());
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT DeviceTypeName AS Категория FROM DeviceTypes", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.DeviceTypesGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTypesHandlerForm devTypeHandlerForm = new DeviceTypesHandlerForm();
            devTypeHandlerForm.StartPosition = FormStartPosition.CenterScreen;
            (devTypeHandlerForm.Controls["DeviceTypesHandlerFormEditBtn"] as Button).Enabled = false;
            devTypeHandlerForm.Owner = this;
            devTypeHandlerForm.ShowDialog();
        }
    }
}