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
    public partial class Login : Form
    {
        AccountManager accountManager = new AccountManager();
        StudentManager studentManager=new StudentManager();
        officeManager officemanager=new officeManager();
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                Account account = new Account()
                {
                    AccountType = loginComboBox.Text,
                    Username = userNameTextBox.Text,
                    Password = paswordTextBox.Text
                };
                message = accountManager.CheckAccountInfo(account);
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (message== "LogIn Successful")
                {
                    if (account.AccountType== "Student")
                    {
                        if (studentManager.GetStudentRollNumber(Convert.ToInt32(rollNumberTextBox.Text))== Convert.ToInt32(rollNumberTextBox.Text))
                        {
                            Student_View studentView = new Student_View();
                            this.Hide();
                            Student aStudent=new Student();
                            aStudent = studentManager.GetStudentInfo(Convert.ToInt32(rollNumberTextBox.Text));
                            studentView.nameTextBox.Text = aStudent.Name.ToString();
                            studentView.noteTextBox.Text = aStudent.Note.ToString();
                            studentView.rollNoTextBox.Text = aStudent.Roll.ToString();
                            studentView.sessionTextBox.Text = aStudent.Session.ToString();
                            studentView.sexTextBox.Text = aStudent.Sex.ToString();
                            studentView.deptTextBox.Text = aStudent.Dept.ToString();
                            studentView.Show();
                        }
                        else
                        {
                            Form1 form1=new Form1();
                            this.Hide();
                            form1.Show();
                        }
                    }
                    else if(account.AccountType == "Teacher")
                    {
                        if (officemanager.GetTeacherUsername(account.Username)!=account.Username)
                        {
                            TeacherInfoForm teacherInfoForm=new TeacherInfoForm(account.Username);
                            this.Hide();
                            teacherInfoForm.Show();
                        }
                        else
                        {
                            TeacherView teacherView = new TeacherView(account.Username);
                            this.Hide();
                            teacherView.Show();
                        }

                    }
                    else if (account.AccountType == "Chairman")
                    {
                        if (officemanager.GetChairmanUsername(account.Username) != account.Username)
                        {
                            ChairmanInfoForm chairmanInfoForm = new ChairmanInfoForm(account.Username);
                            this.Hide();
                            chairmanInfoForm.Show();
                        }
                        else
                        {
                            ChairmanView chairmanView = new ChairmanView(account.Username);
                            this.Hide();
                            chairmanView.Show();
                        }
                    }
                    else if (account.AccountType == "Office")
                    {
                        AssignStudent assignStudent=new AssignStudent();
                        this.Hide();
                        assignStudent.Show();
                    }
                    else if (account.AccountType == "Administrator")
                    {
                        if (officemanager.GetAdministrationUsername(account.Username) != account.Username)
                        {
                            AdministrationInfo administrationInfo = new AdministrationInfo(account.Username);
                            this.Hide();
                            administrationInfo.Show();
                        }
                        else
                        {
                            AdministrationView administrationView = new AdministrationView(account.Username);
                            this.Hide();
                            administrationView.Show();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error." + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signuoButton_Click(object sender, EventArgs e)
        {
            SignUp sign=new SignUp();
            this.Hide();
            sign.Show();
        }

        private void loginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loginComboBox.Text=="Student")
            {
                rollnumberlebel.Visible = true;
                rollNumberTextBox.Visible = true;
            }
            else
            {
                rollnumberlebel.Visible = false;
                rollNumberTextBox.Visible = false;
            }
        }
    }
}
