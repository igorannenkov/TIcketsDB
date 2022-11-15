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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void ShowAdmBtn_Click(object sender, EventArgs e)
        {
            
            AdminForm admForm = new AdminForm(); 
            admForm.Show();
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ShowTechnicBtn_Click(object sender, EventArgs e)
        {
            TechnicMainForm tmf = new TechnicMainForm();
            tmf.Show();
        }

        private void ShowUserBtn_Click(object sender, EventArgs e)
        {
            UserMainForm umf = new UserMainForm();
            umf.Show();        
        }
    }
}
