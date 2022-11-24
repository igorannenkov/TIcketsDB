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
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
        }

        private void новаяЗаявкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAddTicketForm addTicketForm = new UserAddTicketForm();
            addTicketForm.Owner = this;
            addTicketForm.ShowDialog();       
        }

        private void сменаПароляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Owner = this;
            changePasswordForm.ShowDialog();
        }

        private void выгрузкаВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelReporter.GetReport(userMainFormGridView);
        }

        private void выходИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
