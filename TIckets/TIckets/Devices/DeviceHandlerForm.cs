using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class DeviceHandlerForm : Form
    {
        public DeviceHandlerForm()
        {
            InitializeComponent();
        }

        private void DeviceHandlerFormCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeviceHandlerFormAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                //получить ID устрйоства
                SqlCommand cmd = new SqlCommand("SELECT DeviceTypeID FROM DeviceTypes WHERE DeviceTypeName = @devTypeName", connection);
                cmd.Parameters.AddWithValue("@devTypeName", DeviceHandlerFormCb.Text);
                int devTypeID = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO Devices (DeviceType, DeviceAmount) VALUES (@devTypeID, @devAmount)", connection);
                cmd.Parameters.AddWithValue("@devTypeID", devTypeID);
                cmd.Parameters.AddWithValue("@devAmount", DeviceHandlerFormNud.Value.ToString());
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT DeviceTypeName AS Устройство, DeviceAmount AS [Колич.] " +
                                     "FROM Devices D " +
                                     "INNER JOIN DeviceTypes DT " +
                                     "ON D.DeviceType = DT.DeviceTypeID  ORDER BY DeviceTypeName", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                (this.Owner.Controls["deviceFormGridView"] as DataGridView).DataSource = dt;

                this.Close();
            }
        }

        private void DeviceHandlerFormEditBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                //получить ID устрйоства
                SqlCommand cmd = new SqlCommand("SELECT DeviceTypeID FROM DeviceTypes WHERE DeviceTypeName = @devTypeName", connection);
                cmd.Parameters.AddWithValue("@devTypeName", DeviceHandlerFormCb.Text);
                int devTypeID = (int)cmd.ExecuteScalar();
                int amount = (int)DeviceHandlerFormNud.Value;

                cmd = new SqlCommand("UPDATE Devices SET DeviceAmount = @amount WHERE DeviceType = @devType", connection);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@devType", devTypeID);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT DeviceTypeName AS Устройство, DeviceAmount AS [Колич.] " +
                                    "FROM Devices D " +
                                    "INNER JOIN DeviceTypes DT " +
                                    "ON D.DeviceType = DT.DeviceTypeID ORDER BY DeviceTypeName", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                (this.Owner.Controls["deviceFormGridView"] as DataGridView).DataSource = dt;

                this.Close();
            }
        }
    }
}
