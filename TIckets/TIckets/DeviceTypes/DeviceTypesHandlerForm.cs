using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class DeviceTypesHandlerForm : Form
    {
        public DeviceTypesHandlerForm()
        {
            InitializeComponent();
        }

        private void DeviceTypesHandlerFormAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DeviceTypes (DeviceTypeName) VALUES (@newDeviceTypeName)", connection);
                cmd.Parameters.AddWithValue("@newDeviceTypeName", DeviceTypesHandlerFormTb.Text);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DeviceTypeName AS Категория FROM DeviceTypes", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["DeviceTypesGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void DeviceTypesHandlerFormEditBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                int deviceTypeID = (int)this.Tag;
                SqlCommand cmd = new SqlCommand("UPDATE DeviceTypes " +
                                                "SET DeviceTypeName = (@newDeviceTypeName) " +
                                                "WHERE DeviceTypeID = @deviceTypeID", connection);
                cmd.Parameters.AddWithValue("@newDeviceTypeName", DeviceTypesHandlerFormTb.Text);
                cmd.Parameters.AddWithValue("@deviceTypeID", deviceTypeID);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DeviceTypeName AS Категория FROM DeviceTypes", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["DeviceTypesGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void DeviceTypesHandlerFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
