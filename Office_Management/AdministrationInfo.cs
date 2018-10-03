using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Office_Management.BLL.Manager;
using Office_Management.DLA.DAO;

namespace Office_Management
{
    public partial class AdministrationInfo : Form
    {
        private string ausername = "";
        officeManager officemanager =new officeManager();
        public AdministrationInfo(string username)
        {
            InitializeComponent();
            ausername = username;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                Administration administration = new Administration()
                {
                    Username = ausername,
                    Name = nameTextBox.Text,
                    Gender = sexComboBox.Text,
                    Type = typeComboBox.Text,
                    Note = noteTextBox.Text
                };
                message = officemanager.SaveAdministrationInfo(administration);
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (message == "Administration Insert Successful.")
                {
                    AdministrationView administrationView = new AdministrationView(administration.Username);
                    this.Hide();
                    administrationView.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error." + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
