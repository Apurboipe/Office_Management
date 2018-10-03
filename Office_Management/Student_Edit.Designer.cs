namespace Office_Management
{
    partial class Student_Edit
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
            this.label7 = new System.Windows.Forms.Label();
            this.sessionComboBox = new System.Windows.Forms.ComboBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rollNoTextBox = new System.Windows.Forms.TextBox();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = "Student Edit Form";
            // 
            // sessionComboBox
            // 
            this.sessionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionComboBox.FormattingEnabled = true;
            this.sessionComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sessionComboBox.Location = new System.Drawing.Point(290, 308);
            this.sessionComboBox.Name = "sessionComboBox";
            this.sessionComboBox.Size = new System.Drawing.Size(423, 37);
            this.sessionComboBox.TabIndex = 17;
            // 
            // sexComboBox
            // 
            this.sexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(290, 367);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(423, 37);
            this.sexComboBox.TabIndex = 18;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(565, 566);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(162, 43);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(290, 489);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(423, 40);
            this.noteTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sex";
            // 
            // rollNoTextBox
            // 
            this.rollNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollNoTextBox.Location = new System.Drawing.Point(290, 247);
            this.rollNoTextBox.Name = "rollNoTextBox";
            this.rollNoTextBox.Size = new System.Drawing.Size(423, 35);
            this.rollNoTextBox.TabIndex = 12;
            // 
            // deptTextBox
            // 
            this.deptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptTextBox.Location = new System.Drawing.Point(290, 426);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.ReadOnly = true;
            this.deptTextBox.Size = new System.Drawing.Size(423, 35);
            this.deptTextBox.TabIndex = 13;
            this.deptTextBox.Text = "Computer Science & Engineering";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dept";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Roll No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Session";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(290, 183);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(423, 35);
            this.nameTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(717, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(114, 46);
            this.logOutButton.TabIndex = 29;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // Student_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 669);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sessionComboBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rollNoTextBox);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Student_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox sessionComboBox;
        public System.Windows.Forms.ComboBox sexComboBox;
        public System.Windows.Forms.TextBox noteTextBox;
        public System.Windows.Forms.TextBox rollNoTextBox;
        public System.Windows.Forms.TextBox deptTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button logOutButton;
    }
}