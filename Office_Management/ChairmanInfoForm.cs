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
    public partial class ChairmanInfoForm : Form
    {
        officeManager officemanager = new officeManager();
        private string ausername = "";
        private Label label7;
        private ComboBox sexComboBox;
        private Button Save;
        private TextBox noteTextBox;
        private Label label6;
        private Label label4;
        private TextBox deptTextBox;
        private Label label5;
        private TextBox nameTextBox;
        private Button logOutButton;
        private Label label1;

        public ChairmanInfoForm(string username)
        {
            InitializeComponent();
            ausername = username;
        }

        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(252, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 40);
            this.label7.TabIndex = 31;
            this.label7.Text = "Information Form";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(259, 147);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(423, 33);
            this.sexComboBox.TabIndex = 30;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(441, 307);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(241, 43);
            this.Save.TabIndex = 29;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(259, 244);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(423, 40);
            this.noteTextBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gender";
            // 
            // deptTextBox
            // 
            this.deptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptTextBox.Location = new System.Drawing.Point(259, 194);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.ReadOnly = true;
            this.deptTextBox.Size = new System.Drawing.Size(423, 30);
            this.deptTextBox.TabIndex = 27;
            this.deptTextBox.Text = "Computer Science & Engineering";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Department";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(259, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(423, 30);
            this.nameTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(662, 9);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(114, 46);
            this.logOutButton.TabIndex = 32;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // ChairmanInfoForm
            // 
            this.ClientSize = new System.Drawing.Size(788, 445);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ChairmanInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChairmanInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                Chairman chairman = new Chairman()
                {
                    Username = ausername,
                    Name = nameTextBox.Text,
                    Gender = sexComboBox.Text,
                    Dept = deptTextBox.Text,
                    Note = noteTextBox.Text
                };
                message = officemanager.SaveChairmanInfo(chairman);
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (message == "Chairman Insert Successful.")
                {
                    ChairmanView chairmanView = new ChairmanView(chairman.Username);
                    this.Hide();
                    chairmanView.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error." + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChairmanInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
