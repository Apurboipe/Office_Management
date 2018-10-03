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
    public partial class ChairmanProfileView : Form
    {
        public ChairmanProfileView()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ChairmanView chairmanView = new ChairmanView(usernameTextBox.Text);
            this.Hide();
            chairmanView.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
