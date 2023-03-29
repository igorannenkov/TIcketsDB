using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TIckets.Users;

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
            if (!DeviceTypesHandlerFormTb.Text.IsValid())
            {
                MessageBox.Show("В наименовании устройства содержатся недопустимые символы. Проверьте ввод и попробуйте снова.",
                    "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO DeviceTypes (DeviceTypeName) VALUES (@newDeviceTypeName)", connection);
                    cmd.Parameters.AddWithValue("@newDeviceTypeName", DeviceTypesHandlerFormTb.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show($"Запись с наименованием \"{DeviceTypesHandlerFormTb.Text}\" уже имеется в таблице. Проверьте ввод данных.", 
                            "Некорректный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    return;
                }
                    // Добавим попутно на склад новое устройство с кол-вом = 0. Определяем ИД и вставляем в таблицу.
                    cmd = new SqlCommand("SELECT DeviceTypeID FROM DeviceTypes WHERE DeviceTypeName = @devTypeName", connection);
                    cmd.Parameters.AddWithValue("@devTypeName", DeviceTypesHandlerFormTb.Text);
                    int devTypeID = (int)cmd.ExecuteScalar();

                    cmd = new SqlCommand("INSERT INTO Devices (DeviceType, DeviceAmount) Values (@DeviceType, 0)", connection);
                    cmd.Parameters.AddWithValue("@DeviceType", devTypeID);
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
