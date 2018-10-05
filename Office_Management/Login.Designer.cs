namespace Office_Management
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginComboBox = new System.Windows.Forms.ComboBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paswordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.signuoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rollnumberlebel = new System.Windows.Forms.Label();
            this.rollNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // loginComboBox
            // 
            this.loginComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loginComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginComboBox.FormattingEnabled = true;
            this.loginComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Chairman",
            "Administrator",
            "Office"});
            this.loginComboBox.Location = new System.Drawing.Point(260, 130);
            this.loginComboBox.Name = "loginComboBox";
            this.loginComboBox.Size = new System.Drawing.Size(423, 37);
            this.loginComboBox.TabIndex = 0;
            this.loginComboBox.SelectedIndexChanged += new System.EventHandler(this.loginComboBox_SelectedIndexChanged);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(260, 191);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(423, 35);
            this.userNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // paswordTextBox
            // 
            this.paswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paswordTextBox.Location = new System.Drawing.Point(260, 250);
            this.paswordTextBox.Name = "paswordTextBox";
            this.paswordTextBox.Size = new System.Drawing.Size(423, 35);
            this.paswordTextBox.TabIndex = 2;
            this.paswordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(521, 374);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(162, 43);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signuoButton
            // 
            this.signuoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuoButton.Location = new System.Drawing.Point(305, 374);
            this.signuoButton.Name = "signuoButton";
            this.signuoButton.Size = new System.Drawing.Size(162, 43);
            this.signuoButton.TabIndex = 5;
            this.signuoButton.Text = "Sign Up";
            this.signuoButton.UseVisualStyleBackColor = true;
            this.signuoButton.Click += new System.EventHandler(this.signuoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 46);
            this.label4.TabIndex = 21;
            this.label4.Text = "LogIn Form";
            // 
            // rollnumberlebel
            // 
            this.rollnumberlebel.AutoSize = true;
            this.rollnumberlebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollnumberlebel.Location = new System.Drawing.Point(45, 316);
            this.rollnumberlebel.Name = "rollnumberlebel";
            this.rollnumberlebel.Size = new System.Drawing.Size(149, 29);
            this.rollnumberlebel.TabIndex = 0;
            this.rollnumberlebel.Text = "Roll Number";
            this.rollnumberlebel.Visible = false;
            // 
            // rollNumberTextBox
            // 
            this.rollNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollNumberTextBox.Location = new System.Drawing.Point(260, 308);
            this.rollNumberTextBox.Name = "rollNumberTextBox";
            this.rollNumberTextBox.Size = new System.Drawing.Size(423, 35);
            this.rollNumberTextBox.TabIndex = 3;
            this.rollNumberTextBox.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signuoButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.paswordTextBox);
            this.Controls.Add(this.rollNumberTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rollnumberlebel);
            this.Controls.Add(this.loginComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signuoButton;
        private System.Windows.Forms.TextBox paswordTextBox;
        private System.Windows.Forms.ComboBox loginComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label rollnumberlebel;
        private System.Windows.Forms.TextBox rollNumberTextBox;
    }
}