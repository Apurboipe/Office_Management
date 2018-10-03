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
    public partial class AdministrationView : Form
    {
        private Button viewProfileButton;
        private DataGridView administrationDataGridView;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn roll;
        private DataGridViewTextBoxColumn dept;
        private DataGridViewTextBoxColumn session;
        private DataGridViewTextBoxColumn sex;
        private DataGridViewTextBoxColumn note;
        private Label label1;
        private Button findButton;
        private ComboBox sessionComboBox;
        private Label label3;
        private TextBox deptTextBox;
        private Label label5;
        private string ausername = "";
        private Button logOutButton;
        officeManager officemanager =new officeManager();
        public AdministrationView(string username)
        {
            InitializeComponent();
            administrationDataGridView.AutoGenerateColumns = false;
            administrationDataGridView.Columns[0].DataPropertyName = "Name";
            administrationDataGridView.Columns[1].DataPropertyName = "Roll";
            administrationDataGridView.Columns[2].DataPropertyName = "Dept";
            administrationDataGridView.Columns[3].DataPropertyName = "Session";
            administrationDataGridView.Columns[4].DataPropertyName = "Sex";
            administrationDataGridView.Columns[5].DataPropertyName = "Note";
            ausername = username;
        }

        private void InitializeComponent()
        {
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.administrationDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.sessionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.administrationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProfileButton.Location = new System.Drawing.Point(688, 188);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(245, 43);
            this.viewProfileButton.TabIndex = 22;
            this.viewProfileButton.Text = "View Profile";
            this.viewProfileButton.UseVisualStyleBackColor = true;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // administrationDataGridView
            // 
            this.administrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.administrationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.roll,
            this.dept,
            this.session,
            this.sex,
            this.note});
            this.administrationDataGridView.Location = new System.Drawing.Point(13, 257);
            this.administrationDataGridView.Name = "administrationDataGridView";
            this.administrationDataGridView.RowTemplate.Height = 28;
            this.administrationDataGridView.Size = new System.Drawing.Size(963, 401);
            this.administrationDataGridView.TabIndex = 21;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // roll
            // 
            this.roll.HeaderText = "Roll No.";
            this.roll.Name = "roll";
            // 
            // dept
            // 
            this.dept.HeaderText = "Department";
            this.dept.Name = "dept";
            // 
            // session
            // 
            this.session.HeaderText = "Session";
            this.session.Name = "session";
            // 
            // sex
            // 
            this.sex.HeaderText = "Gender";
            this.sex.Name = "sex";
            // 
            // note
            // 
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Administration View";
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(370, 188);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(274, 43);
            this.findButton.TabIndex = 19;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // sessionComboBox
            // 
            this.sessionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sessionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionComboBox.FormattingEnabled = true;
            this.sessionComboBox.Items.AddRange(new object[] {
            "2008-2009",
            "2009-2010",
            "2010-2011",
            "2011-2012",
            "2012-2013",
            "2013-2014",
            "2014-2015",
            "2015-2016",
            "2016-2017",
            "2017-2018"});
            this.sessionComboBox.Location = new System.Drawing.Point(221, 131);
            this.sessionComboBox.Name = "sessionComboBox";
            this.sessionComboBox.Size = new System.Drawing.Size(423, 37);
            this.sessionComboBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Session";
            // 
            // deptTextBox
            // 
            this.deptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptTextBox.Location = new System.Drawing.Point(221, 77);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.ReadOnly = true;
            this.deptTextBox.Size = new System.Drawing.Size(423, 35);
            this.deptTextBox.TabIndex = 16;
            this.deptTextBox.Text = "Computer Science & Engineering";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Department";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(862, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(114, 46);
            this.logOutButton.TabIndex = 29;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // AdministrationView
            // 
            this.ClientSize = new System.Drawing.Size(988, 669);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.viewProfileButton);
            this.Controls.Add(this.administrationDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.sessionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(this.label5);
            this.Name = "AdministrationView";
            ((System.ComponentModel.ISupportInitialize)(this.administrationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            AdministrationProfileView administrationProfileView=new AdministrationProfileView();
            Administration administration=new Administration();
            administration = officemanager.GetAdministrationInfo(ausername);
            administrationProfileView.nameTextBox.Text = administration.Name.ToString();
            administrationProfileView.usernameTextBox.Text = administration.Username.ToString();
            administrationProfileView.accessTypeTextBox.Text = administration.Type.ToString();
            administrationProfileView.genderTextBox.Text = administration.Gender.ToString();
            administrationProfileView.noteTextBox.Text = administration.Note.ToString();
            this.Hide();
            administrationProfileView.Show();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (sessionComboBox.Text != "")
            {
                string session = sessionComboBox.Text;
                administrationDataGridView.DataSource = officemanager.GetStudentListForAdministration(session, ausername);
            }
            else
            {
                string message = "Please select student session.";
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
