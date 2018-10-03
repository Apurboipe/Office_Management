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
    public partial class SignUp : Form
    {
        AccountManager accountManager=new AccountManager();
        public SignUp()
        {
            InitializeComponent();
        }

        private void signuoButton_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                Account account = new Account()
                {
                    AccountType = loginiTypeComboBox.Text,
                    Username = userNameTextBox.Text,
                    Password = paswordTextBox.Text
                };
                message = accountManager.SaveAccountInfo(account);
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login=new Login();
                this.Hide();
                login.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error." + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
