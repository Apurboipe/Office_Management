namespace Office_Management
{
    partial class TeacherView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sessionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deptTextBox
            // 
            this.deptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptTextBox.Location = new System.Drawing.Point(208, 67);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.ReadOnly = true;
            this.deptTextBox.Size = new System.Drawing.Size(423, 35);
            this.deptTextBox.TabIndex = 3;
            this.deptTextBox.Text = "Computer Science & Engineering";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Department";
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
            this.sessionComboBox.Location = new System.Drawing.Point(208, 121);
            this.sessionComboBox.Name = "sessionComboBox";
            this.sessionComboBox.Size = new System.Drawing.Size(423, 37);
            this.sessionComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Session";
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(357, 178);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(274, 43);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teacher View";
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AllowUserToOrderColumns = true;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.roll,
            this.dept,
            this.session,
            this.sex,
            this.note});
            this.teacherDataGridView.Location = new System.Drawing.Point(12, 256);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.RowTemplate.Height = 28;
            this.teacherDataGridView.Size = new System.Drawing.Size(963, 401);
            this.teacherDataGridView.TabIndex = 8;
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
            // viewProfileButton
            // 
            this.viewProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProfileButton.Location = new System.Drawing.Point(676, 178);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(245, 43);
            this.viewProfileButton.TabIndex = 9;
            this.viewProfileButton.Text = "View Profile";
            this.viewProfileButton.UseVisualStyleBackColor = true;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(861, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(114, 46);
            this.logOutButton.TabIndex = 28;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 669);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.viewProfileButton);
            this.Controls.Add(this.teacherDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.sessionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TeacherView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherView";
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deptTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sessionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn session;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.Button viewProfileButton;
        private System.Windows.Forms.Button logOutButton;
    }
}