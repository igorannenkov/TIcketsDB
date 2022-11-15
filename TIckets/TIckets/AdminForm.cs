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
            usForm.Show();
        }

        private void ролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm rf = new RolesForm();
            rf.Show();
        }
    }
}
