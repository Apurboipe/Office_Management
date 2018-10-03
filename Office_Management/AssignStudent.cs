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
    public partial class AssignStudent : Form
    {
        public AssignStudent()
        {
            InitializeComponent();
        }

        private void chairmanButton_Click(object sender, EventArgs e)
        {
            StudentAssignForm studentAssignForm = new StudentAssignForm(2);
            this.Hide();
            studentAssignForm.Show();
        }

        private void administratorButton_Click(object sender, EventArgs e)
        {
            StudentAssignForm studentAssignForm = new StudentAssignForm(3);
            this.Hide();
            studentAssignForm.Show();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            StudentAssignForm studentAssignForm=new StudentAssignForm(1);
            this.Hide();
            studentAssignForm.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
