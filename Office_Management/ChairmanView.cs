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
    public partial class ChairmanView : Form
    {
        private string aUsername = "";
        officeManager officemanager = new officeManager();
        public ChairmanView(string username)
        {
            InitializeComponent();
            chairmanDataGridView.AutoGenerateColumns = false;
            chairmanDataGridView.Columns[0].DataPropertyName = "Name";
            chairmanDataGridView.Columns[1].DataPropertyName = "Roll";
            chairmanDataGridView.Columns[2].DataPropertyName = "Dept";
            chairmanDataGridView.Columns[3].DataPropertyName = "Session";
            chairmanDataGridView.Columns[4].DataPropertyName = "Sex";
            chairmanDataGridView.Columns[5].DataPropertyName = "Note";
            aUsername = username;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (sessionComboBox.Text != "")
            {
                string session = sessionComboBox.Text;
                chairmanDataGridView.DataSource = officemanager.GetStudentListForChairman(session, aUsername);
            }
            else
            {
                string message = "Please select student session.";
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            ChairmanProfileView chairmanProfileView = new ChairmanProfileView();
            Chairman chairman = new Chairman();
            chairman = officemanager.GetChairmanInfo(aUsername);
            chairmanProfileView.nameTextBox.Text = chairman.Name.ToString();
            chairmanProfileView.usernameTextBox.Text = chairman.Username.ToString();
            chairmanProfileView.departmentTextBox.Text = chairman.Dept.ToString();
            chairmanProfileView.genderTextBox.Text = chairman.Gender.ToString();
            chairmanProfileView.noteTextBox.Text = chairman.Note.ToString();
            this.Hide();
            chairmanProfileView.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
