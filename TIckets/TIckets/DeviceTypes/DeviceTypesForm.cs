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

        private void добавитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTypesHandlerForm devTypeHandlerForm = new DeviceTypesHandlerForm();
            devTypeHandlerForm.StartPosition = FormStartPosition.CenterScreen;
            (devTypeHandlerForm.Controls["DeviceTypesHandlerFormEditBtn"] as Button).Enabled = false;
            devTypeHandlerForm.Owner = this;
            devTypeHandlerForm.ShowDialog();
        }

        private void DeviceTypesGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DeviceTypesHandlerForm devTypeHandlerForm = new DeviceTypesHandlerForm();
            devTypeHandlerForm.Owner = this;
            string prevDeviceTypeName = DeviceTypesGridView.CurrentCell.Value.ToString();
            (devTypeHandlerForm.Controls["DeviceTypesHandlerFormTb"] as TextBox).Text = prevDeviceTypeName;
            devTypeHandlerForm.Tag = prevDeviceTypeName;
            devTypeHandlerForm.StartPosition = FormStartPosition.CenterScreen;
            (devTypeHandlerForm.Controls["DeviceTypesHandlerFormAddBtn"] as Button).Enabled = false;
            devTypeHandlerForm.ShowDialog();
        }

        private void DeviceTypesGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = DeviceTypesGridView.CurrentCell.Value.ToString();
                    SqlCommand cmd = new SqlCommand("DELETE FROM DeviceTypes WHERE DeviceTypeName = N'" + toDelete + "'", connection);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT DeviceTypeName AS Категория FROM DeviceTypes", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    this.DeviceTypesGridView.DataSource = ds.Tables[0];




                }
            }
        }
    }
}
