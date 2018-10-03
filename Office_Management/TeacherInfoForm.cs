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
    public partial class TeacherInfoForm : Form
    {
        private string ausername = "";
        officeManager officemanager=new officeManager();
        public TeacherInfoForm(string username)
        {
            InitializeComponent();
            ausername = username;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                Teacher teacher = new Teacher()
                {
                    Username = ausername,
                    Name = nameTextBox.Text,
                    Designation = designationTextBox.Text,
                    Gender = sexComboBox.Text,
                    Dept = deptTextBox.Text,
                    Note = noteTextBox.Text
                };
                message = officemanager.SaveTeacherInfo(teacher);
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (message== "Teacher Insert Successful.")
                {
                    TeacherView teacherView=new TeacherView(teacher.Username);
                    this.Hide();
                    teacherView.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error." + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            nameTextBox.Text = "";
            designationTextBox.Text = "";
            noteTextBox.Text = "";
            sexComboBox.Text = "";
            deptTextBox.Text = "";
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
