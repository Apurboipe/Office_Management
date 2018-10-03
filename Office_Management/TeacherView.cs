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
    public partial class TeacherView : Form
    {
        private string aUsername = "";
        officeManager officemanager=new officeManager();
        public TeacherView(string username)
        {
            InitializeComponent();
            teacherDataGridView.AutoGenerateColumns = false;
            teacherDataGridView.Columns[0].DataPropertyName = "Name";
            teacherDataGridView.Columns[1].DataPropertyName = "Roll";
            teacherDataGridView.Columns[2].DataPropertyName = "Dept";
            teacherDataGridView.Columns[3].DataPropertyName = "Session";
            teacherDataGridView.Columns[4].DataPropertyName = "Sex";
            teacherDataGridView.Columns[5].DataPropertyName = "Note";
            aUsername = username;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (sessionComboBox.Text!="")
            {
                string session = sessionComboBox.Text;
                teacherDataGridView.DataSource = officemanager.GetStudentListForTeacher(session,aUsername);
            }
            else
            {
                string message = "Please select student session.";
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            TeacherProfileView teacherProfileView=new TeacherProfileView();
            Teacher teacher=new Teacher();
            teacher = officemanager.GetTeacherInfo(aUsername);
            teacherProfileView.nameTextBox.Text = teacher.Name.ToString();
            teacherProfileView.usernameTextBox.Text = teacher.Username.ToString();
            teacherProfileView.departmentTextBox.Text = teacher.Dept.ToString();
            teacherProfileView.designationTextBox.Text = teacher.Designation.ToString();
            teacherProfileView.genderTextBox.Text = teacher.Gender.ToString();
            teacherProfileView.noteTextBox.Text = teacher.Note.ToString();
            this.Hide();
            teacherProfileView.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login=new Login();
            this.Hide();
            login.Show();
        }
    }
}
