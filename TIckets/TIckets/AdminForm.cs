using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIckets
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void ПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usForm = new UsersForm();
            usForm.StartPosition = FormStartPosition.CenterParent;
            usForm.ShowDialog();
        }

        private void ролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm rf = new RolesForm();
            rf.StartPosition = FormStartPosition.CenterParent;
            rf.ShowDialog();
        }

        private void ТипыУстройствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTypesForm dtf = new DeviceTypesForm();
            dtf.StartPosition = FormStartPosition.CenterParent;
            dtf.ShowDialog();
        }

        private void статусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicStatusesForm ts = new TechnicStatusesForm();
            ts.StartPosition = FormStartPosition.CenterParent;
            ts.ShowDialog();
        }

        private void статусыЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketStatusesForm ticketStatusesForm = new TicketStatusesForm();
            ticketStatusesForm.StartPosition = FormStartPosition.CenterScreen;
            ticketStatusesForm.ShowDialog();

        }

        private void техникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicsForm technicsForm = new TechnicsForm();
            technicsForm.StartPosition = FormStartPosition.CenterScreen;
            technicsForm.ShowDialog();
        }
    }
}
