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
    public partial class TeacherProfileView : Form
    {
        public TeacherProfileView()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            TeacherView teacherView=new TeacherView(usernameTextBox.Text);
            this.Hide();
            teacherView.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
