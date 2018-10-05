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
    public partial class StudentAssignForm : Form
    {
        public ComboBox nameComboBox;
        private ComboBox sexComboBox;
        private Label label4;
        private Label label1;
        private ComboBox rollcomboBox;
        private Button assingButton;
        private TextBox deptTextBox;
        private Label label5;
        private Label label2;
        public Label nameLabel;
        private int aValue = 0;
        private Button backButton;
        private Button logOutButton;
        officeManager officemanager =new officeManager();
        public StudentAssignForm(int value)
        {
            InitializeComponent();
            aValue = value;
            if (aValue==1)
            {
                nameComboBox.DataSource = officemanager.GetTeacherNameList();
            }
            if (aValue==2)
            {
                nameComboBox.DataSource = officemanager.GetChairmanNameList();
            }
            if (aValue==3)
            {
                nameComboBox.DataSource = officemanager.GetAdministrationList();
            }
            sexComboBox.DataSource = officemanager.GetStudentSessionList();
        }

        private void InitializeComponent()
        {
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rollcomboBox = new System.Windows.Forms.ComboBox();
            this.assingButton = new System.Windows.Forms.Button();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameComboBox
            // 
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(312, 105);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(423, 37);
            this.nameComboBox.TabIndex = 6;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(312, 221);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(423, 37);
            this.sexComboBox.TabIndex = 7;
            this.sexComboBox.SelectedIndexChanged += new System.EventHandler(this.sexComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student Session";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(97, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(121, 29);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Assign To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Roll";
            // 
            // rollcomboBox
            // 
            this.rollcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rollcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollcomboBox.FormattingEnabled = true;
            this.rollcomboBox.Location = new System.Drawing.Point(312, 277);
            this.rollcomboBox.Name = "rollcomboBox";
            this.rollcomboBox.Size = new System.Drawing.Size(423, 37);
            this.rollcomboBox.TabIndex = 7;
            // 
            // assingButton
            // 
            this.assingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assingButton.Location = new System.Drawing.Point(500, 352);
            this.assingButton.Name = "assingButton";
            this.assingButton.Size = new System.Drawing.Size(235, 43);
            this.assingButton.TabIndex = 8;
            this.assingButton.Text = "Assign";
            this.assingButton.UseVisualStyleBackColor = true;
            this.assingButton.Click += new System.EventHandler(this.assingButton_Click);
            // 
            // deptTextBox
            // 
            this.deptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptTextBox.Location = new System.Drawing.Point(312, 163);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.ReadOnly = true;
            this.deptTextBox.Size = new System.Drawing.Size(423, 35);
            this.deptTextBox.TabIndex = 10;
            this.deptTextBox.Text = "Computer Science & Engineering";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Assign Form";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(330, 352);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 43);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(717, 14);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(114, 46);
            this.logOutButton.TabIndex = 30;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // StudentAssignForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 476);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.assingButton);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.rollcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameLabel);
            this.Name = "StudentAssignForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void assingButton_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                if (aValue == 1)
                {
                    Assign assign = new Assign()
                    {
                        Session = sexComboBox.Text,
                        Roll = Convert.ToInt32(rollcomboBox.Text),
                        Name = officemanager.GetTeacherUserNameFromName(nameComboBox.Text)
                    };
                    message = officemanager.SetStudentToTeacher(assign);
                }
                else if(aValue == 2)
                {
                    Assign assign = new Assign()
                    {
                        Session = sexComboBox.Text,
                        Roll = Convert.ToInt32(rollcomboBox.Text),
                        Name = officemanager.GetChairmanUserNameFromName(nameComboBox.Text)
                    };
                    message = officemanager.SetStudentToChairman(assign);
                }
                else if (aValue == 3)
                {
                    Assign assign = new Assign()
                    {
                        Session = sexComboBox.Text,
                        Roll = Convert.ToInt32(rollcomboBox.Text),
                        Name = officemanager.GetAdministrationUserNameFromName(nameComboBox.Text)
                    };
                    message = officemanager.SetStudentToAdministration(assign);
                }

                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error." + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> rollList=new List<int>();
            rollList = officemanager.GetStudentRollNumberToOffice(sexComboBox.Text);
            rollcomboBox.DataSource = rollList;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AssignStudent assignStudent=new AssignStudent();
            this.Hide();
            assignStudent.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
