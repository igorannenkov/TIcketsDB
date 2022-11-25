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
    public partial class DeviceForm : Form
    {
        public DeviceForm()
        {
            InitializeComponent();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT DeviceTypeName AS Устройство, DeviceAmount AS [Колич.] " +
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
                (devHandlerForm.Controls["DeviceHandlerFormAddBtn"] as Button).Enabled = false;
                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).DataSource = ds.Tables[0];
                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).ValueMember = "DeviceTypeName";

                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).Text = this.deviceFormGridView.CurrentRow.Cells[0].Value.ToString();
                (devHandlerForm.Controls["DeviceHandlerFormNud"] as NumericUpDown).Value = (int)this.deviceFormGridView.CurrentRow.Cells[1].Value;

                (devHandlerForm.Controls["DeviceHandlerFormCb"] as ComboBox).Enabled = false;
                devHandlerForm.Owner = this;
                devHandlerForm.StartPosition = FormStartPosition.CenterParent;
                devHandlerForm.ShowDialog();
            }
        }
    }
}
