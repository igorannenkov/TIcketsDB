using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIckets
{
    public partial class DeviceForm : Form
    {
        public DeviceForm()
        {
            InitializeComponent();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT DeviceTypeName AS Устройство, " +
                                                "CASE DeviceAmount " +
                                                "WHEN 0 THEN N'Нет в наличии' " +
                                                "ELSE Convert(nvarchar, DeviceAmount) " +
                                                "END AS [На складе] " +
                                                "FROM Devices D " +
                                                "INNER JOIN DeviceTypes DT " +
                                                "ON D.DeviceType = DT.DeviceTypeID  ORDER BY DeviceTypeName", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                deviceFormGridView.DataSource = dt;
            }
        }

        private void добавитьУстройствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT DeviceTypeName FROM DeviceTypes ORDER BY DeviceTypeName", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DeviceHandlerForm devHandlerForm = new DeviceHandlerForm();
                (devHandlerForm.Controls["DeviceHandlerFormEditBtn"] as Button).Enabled = false;
                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).DataSource = ds.Tables[0];
                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).ValueMember = "DeviceTypeName";
                devHandlerForm.Owner = this;
                devHandlerForm.StartPosition = FormStartPosition.CenterParent;
                devHandlerForm.ShowDialog();
            }
        }

        private void deviceFormGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT DeviceTypeName FROM DeviceTypes ORDER BY DeviceTypeName", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DeviceHandlerForm devHandlerForm = new DeviceHandlerForm();
                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).DataSource = ds.Tables[0];
                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).ValueMember = "DeviceTypeName";

                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).Text = this.deviceFormGridView.CurrentRow.Cells[0].Value.ToString();
                int deviceAmount;

                if (this.deviceFormGridView.CurrentRow.Cells[1].Value.ToString() == "Нет в наличии")
                {
                    deviceAmount = 0;
                }
                else
                { 
                    deviceAmount = Convert.ToInt32(this.deviceFormGridView.CurrentRow.Cells[1].Value); 
                }

                (devHandlerForm.Controls["DeviceHandlerFormNud"] as NumericUpDown).Value = deviceAmount;               
                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).Enabled = false;
                devHandlerForm.Owner = this;
                devHandlerForm.StartPosition = FormStartPosition.CenterParent;
                devHandlerForm.ShowDialog();
            }
        }

        private void выгрузкаВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelReporter.GetReport(deviceFormGridView);
        }
    }
}