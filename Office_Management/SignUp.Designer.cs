namespace Office_Management
{
    partial class SignUp
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
            this.signuoButton = new System.Windows.Forms.Button();
            this.paswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginiTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bakeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signuoButton
            // 
            this.signuoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuoButton.Location = new System.Drawing.Point(519, 338);
            this.signuoButton.Name = "signuoButton";
            this.signuoButton.Size = new System.Drawing.Size(221, 43);
            this.signuoButton.TabIndex = 3;
            this.signuoButton.Text = "Sign Up";
            this.signuoButton.UseVisualStyleBackColor = true;
            this.signuoButton.Click += new System.EventHandler(this.signuoButton_Click);
            // 
            // paswordTextBox
            // 
            this.paswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paswordTextBox.Location = new System.Drawing.Point(317, 254);
            this.paswordTextBox.Name = "paswordTextBox";
            this.paswordTextBox.Size = new System.Drawing.Size(423, 35);
            this.paswordTextBox.TabIndex = 2;
            this.paswordTextBox.UseSystemPasswordChar = true;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(317, 195);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(423, 35);
            this.userNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // loginiTypeComboBox
            // 
            this.loginiTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loginiTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginiTypeComboBox.FormattingEnabled = true;
            this.loginiTypeComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Chairman",
            "Administrator",
            "Office"});
            this.loginiTypeComboBox.Location = new System.Drawing.Point(317, 134);
            this.loginiTypeComboBox.Name = "loginiTypeComboBox";
            this.loginiTypeComboBox.Size = new System.Drawing.Size(423, 37);
            this.loginiTypeComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Login Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 46);
            this.label4.TabIndex = 28;
            this.label4.Text = "Sign Up Form";
            // 
            // bakeButton
            // 
            this.bakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakeButton.Location = new System.Drawing.Point(329, 338);
            this.bakeButton.Name = "bakeButton";
            this.bakeButton.Size = new System.Drawing.Size(162, 43);
            this.bakeButton.TabIndex = 29;
            this.bakeButton.Text = "Back";
            this.bakeButton.UseVisualStyleBackColor = true;
            this.bakeButton.Click += new System.EventHandler(this.bakeButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 447);
            this.Controls.Add(this.bakeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signuoButton);
            this.Controls.Add(this.paswordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginiTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signuoButton;
        private System.Windows.Forms.TextBox paswordTextBox;
        public System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox loginiTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bakeButton;
    }
}