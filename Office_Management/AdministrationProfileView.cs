using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Office_Management
{
    public partial class AdministrationProfileView : Form
    {
        public AdministrationProfileView()
        {
            InitializeComponent();
        }

        private void AdministrationProfileView_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdministrationView administrationView = new AdministrationView(usernameTextBox.Text);
            this.Hide();
            administrationView.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
