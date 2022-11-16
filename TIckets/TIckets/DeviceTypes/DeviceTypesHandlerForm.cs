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

namespace TIckets
{
    public partial class DeviceTypesHandlerForm : Form
    {
        public DeviceTypesHandlerForm()
        {
            InitializeComponent();
        }

        private void DeviceTypesHandlerFormEditBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string prevDeviceTypeName = this.Tag.ToString();
                SqlCommand cmd = new SqlCommand("UPDATE DeviceTypes SET DeviceTypeName =  (N'" + DeviceTypesHandlerFormTb.Text + "') WHERE DeviceTypeName = N'" + prevDeviceTypeName + "'", connection);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DeviceTypeName AS Категория FROM DeviceTypes", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["DeviceTypesGridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }

        private void DeviceTypesHandlerFormAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DeviceTypes (DeviceTypeName) VALUES (N'" + DeviceTypesHandlerFormTb.Text + "')", connection);
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
