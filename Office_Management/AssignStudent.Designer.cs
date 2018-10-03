namespace Office_Management
{
    partial class AssignStudent
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
            this.chairmanButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.administratorButton = new System.Windows.Forms.Button();
            this.Office = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chairmanButton
            // 
            this.chairmanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chairmanButton.Location = new System.Drawing.Point(11, 155);
            this.chairmanButton.Name = "chairmanButton";
            this.chairmanButton.Size = new System.Drawing.Size(236, 141);
            this.chairmanButton.TabIndex = 0;
            this.chairmanButton.Text = "Chairman";
            this.chairmanButton.UseVisualStyleBackColor = true;
            this.chairmanButton.Click += new System.EventHandler(this.chairmanButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherButton.Location = new System.Drawing.Point(576, 155);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(236, 141);
            this.teacherButton.TabIndex = 0;
            this.teacherButton.Text = "Teacher";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // administratorButton
            // 
            this.administratorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorButton.Location = new System.Drawing.Point(284, 155);
            this.administratorButton.Name = "administratorButton";
            this.administratorButton.Size = new System.Drawing.Size(260, 141);
            this.administratorButton.TabIndex = 0;
            this.administratorButton.Text = "Administrator";
            this.administratorButton.UseVisualStyleBackColor = true;
            this.administratorButton.Click += new System.EventHandler(this.administratorButton_Click);
            // 
            // Office
            // 
            this.Office.AutoSize = true;
            this.Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office.Location = new System.Drawing.Point(229, 9);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(331, 40);
            this.Office.TabIndex = 1;
            this.Office.Text = "Office Management";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(698, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(114, 46);
            this.logOutButton.TabIndex = 29;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // AssignStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 525);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.Office);
            this.Controls.Add(this.administratorButton);
            this.Controls.Add(this.teacherButton);
            this.Controls.Add(this.chairmanButton);
            this.Name = "AssignStudent";
            this.Text = "AssignStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chairmanButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button administratorButton;
        private System.Windows.Forms.Label Office;
        private System.Windows.Forms.Button logOutButton;
    }
}