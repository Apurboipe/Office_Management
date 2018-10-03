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
    public partial class Student_View : Form
    {
        StudentManager studentManager=new StudentManager();
        private Button Edit;
        private Label label6;
        private Label label4;
        public TextBox deptTextBox;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label1;
        public TextBox sexTextBox;
        public TextBox sessionTextBox;
        public TextBox rollNoTextBox;
        public TextBox noteTextBox;
        private Label label7;
        private Button sendButton;
        private Button logOutButton;
        public TextBox nameTextBox;

        public Student_View()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Edit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.sessionTextBox = new System.Windows.Forms.TextBox();
            this.rollNoTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(565, 504);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(172, 43);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // deptTextBox
            // 
            this.deptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptTextBox.Location = new System.Drawing.Point(290, 364);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.ReadOnly = true;
            this.deptTextBox.Size = new System.Drawing.Size(423, 35);
            this.deptTextBox.TabIndex = 12;
            this.deptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Roll No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Session";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // sexTextBox
            // 
            this.sexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexTextBox.Location = new System.Drawing.Point(290, 305);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.ReadOnly = true;
            this.sexTextBox.Size = new System.Drawing.Size(423, 35);
            this.sexTextBox.TabIndex = 12;
            this.sexTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sessionTextBox
            // 
            this.sessionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionTextBox.Location = new System.Drawing.Point(290, 244);
            this.sessionTextBox.Name = "sessionTextBox";
            this.sessionTextBox.ReadOnly = true;
            this.sessionTextBox.Size = new System.Drawing.Size(423, 35);
            this.sessionTextBox.TabIndex = 12;
            this.sessionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rollNoTextBox
            // 
            this.rollNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollNoTextBox.Location = new System.Drawing.Point(290, 185);
            this.rollNoTextBox.Name = "rollNoTextBox";
            this.rollNoTextBox.ReadOnly = true;
            this.rollNoTextBox.Size = new System.Drawing.Size(423, 35);
            this.rollNoTextBox.TabIndex = 12;
            this.rollNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(290, 121);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(423, 35);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(290, 421);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ReadOnly = true;
            this.noteTextBox.Size = new System.Drawing.Size(423, 35);
            this.noteTextBox.TabIndex = 12;
            this.noteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 40);
            this.label7.TabIndex = 16;
            this.label7.Text = "Student View Form";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(333, 504);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(179, 43);
            this.sendButton.TabIndex = 21;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(726, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(114, 46);
            this.logOutButton.TabIndex = 29;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // Student_View
            // 
            this.ClientSize = new System.Drawing.Size(843, 592);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.rollNoTextBox);
            this.Controls.Add(this.sessionTextBox);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Student_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Student_Edit studentEdit=new Student_Edit();
            studentEdit.nameTextBox.Text = nameTextBox.Text;
            studentEdit.rollNoTextBox.Text = rollNoTextBox.Text;
            studentEdit.noteTextBox.Text = noteTextBox.Text;
            studentEdit.sexComboBox.Text = sexTextBox.Text;
            studentEdit.sessionComboBox.Text = sessionTextBox.Text;
            studentEdit.Show();
            this.Hide();
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                Student student = new Student()
                {
                    Roll = Convert.ToInt32(rollNoTextBox.Text),
                    Name = nameTextBox.Text,
                    Session = sessionTextBox.Text,
                    Sex = sexTextBox.Text,
                    Dept = deptTextBox.Text,
                    Note = noteTextBox.Text
                };
                message = studentManager.SaveStudentInfoToOffice(student);
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
