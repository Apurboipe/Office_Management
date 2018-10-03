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
    public partial class Form1 : Form
    {
        StudentManager studentManager=new StudentManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            nameTextBox.Text = "";
            rollNoTextBox.Text = "";
            noteTextBox.Text = "";
            sessionComboBox.Text = "";
            sexComboBox.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                Student student = new Student()
                {
                    Roll = Convert.ToInt32(rollNoTextBox.Text),
                    Name = nameTextBox.Text,
                    Session = sessionComboBox.Text,
                    Sex = sexComboBox.Text,
                    Dept = deptTextBox.Text,
                    Note = noteTextBox.Text
                };
                message = studentManager.SaveStudentInfo(student);
                clear();
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
