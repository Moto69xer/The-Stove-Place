namespace The_Stove_Place
{
    partial class Employee_Add_Page
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
            this.addUserPageName = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.emailAddressTextbox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordCheckTextbox = new System.Windows.Forms.TextBox();
            this.adminPasswordTextbox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.adminPasswordLabel = new System.Windows.Forms.Label();
            this.isAdminRadio = new System.Windows.Forms.RadioButton();
            this.isNotAdmin = new System.Windows.Forms.RadioButton();
            this.addUserButton = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.adminUsernameTextbox = new System.Windows.Forms.TextBox();
            this.adminUsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addUserPageName
            // 
            this.addUserPageName.AutoSize = true;
            this.addUserPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.addUserPageName.Location = new System.Drawing.Point(175, 13);
            this.addUserPageName.Name = "addUserPageName";
            this.addUserPageName.Size = new System.Drawing.Size(135, 31);
            this.addUserPageName.TabIndex = 0;
            this.addUserPageName.Text = "Add User";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(162, 130);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(276, 20);
            this.firstNameTextbox.TabIndex = 1;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(162, 156);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(276, 20);
            this.lastNameTextbox.TabIndex = 2;
            // 
            // emailAddressTextbox
            // 
            this.emailAddressTextbox.Location = new System.Drawing.Point(162, 182);
            this.emailAddressTextbox.Name = "emailAddressTextbox";
            this.emailAddressTextbox.Size = new System.Drawing.Size(276, 20);
            this.emailAddressTextbox.TabIndex = 3;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(162, 208);
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(276, 20);
            this.phoneNumberTextbox.TabIndex = 4;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(162, 260);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(276, 20);
            this.passwordTextbox.TabIndex = 5;
            // 
            // passwordCheckTextbox
            // 
            this.passwordCheckTextbox.Location = new System.Drawing.Point(162, 286);
            this.passwordCheckTextbox.Name = "passwordCheckTextbox";
            this.passwordCheckTextbox.PasswordChar = '*';
            this.passwordCheckTextbox.Size = new System.Drawing.Size(276, 20);
            this.passwordCheckTextbox.TabIndex = 6;
            // 
            // adminPasswordTextbox
            // 
            this.adminPasswordTextbox.Enabled = false;
            this.adminPasswordTextbox.Location = new System.Drawing.Point(161, 367);
            this.adminPasswordTextbox.Name = "adminPasswordTextbox";
            this.adminPasswordTextbox.Size = new System.Drawing.Size(276, 20);
            this.adminPasswordTextbox.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(46, 137);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(46, 163);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(46, 189);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.emailAddressLabel.TabIndex = 10;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(46, 215);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 11;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(46, 267);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.Location = new System.Drawing.Point(46, 293);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(98, 13);
            this.passwordLabel2.TabIndex = 13;
            this.passwordLabel2.Text = "ReEnter Password:";
            // 
            // adminPasswordLabel
            // 
            this.adminPasswordLabel.AutoSize = true;
            this.adminPasswordLabel.Location = new System.Drawing.Point(46, 374);
            this.adminPasswordLabel.Name = "adminPasswordLabel";
            this.adminPasswordLabel.Size = new System.Drawing.Size(88, 13);
            this.adminPasswordLabel.TabIndex = 14;
            this.adminPasswordLabel.Text = "Admin Password:";
            // 
            // isAdminRadio
            // 
            this.isAdminRadio.AutoSize = true;
            this.isAdminRadio.Location = new System.Drawing.Point(162, 319);
            this.isAdminRadio.Name = "isAdminRadio";
            this.isAdminRadio.Size = new System.Drawing.Size(106, 17);
            this.isAdminRadio.TabIndex = 15;
            this.isAdminRadio.TabStop = true;
            this.isAdminRadio.Text = "User Is An Admin";
            this.isAdminRadio.UseVisualStyleBackColor = true;
            this.isAdminRadio.CheckedChanged += new System.EventHandler(this.isAdminRadio_CheckedChanged);
            // 
            // isNotAdmin
            // 
            this.isNotAdmin.AutoSize = true;
            this.isNotAdmin.Location = new System.Drawing.Point(312, 319);
            this.isNotAdmin.Name = "isNotAdmin";
            this.isNotAdmin.Size = new System.Drawing.Size(126, 17);
            this.isNotAdmin.TabIndex = 16;
            this.isNotAdmin.TabStop = true;
            this.isNotAdmin.Text = "User Is Not An Admin";
            this.isNotAdmin.UseVisualStyleBackColor = true;
            this.isNotAdmin.CheckedChanged += new System.EventHandler(this.isNotAdmin_CheckedChanged);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(161, 426);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(162, 23);
            this.addUserButton.TabIndex = 17;
            this.addUserButton.Text = "Confirm and Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(162, 234);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(276, 20);
            this.usernameTextbox.TabIndex = 18;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(46, 241);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 19;
            this.usernameLabel.Text = "Username:";
            // 
            // adminUsernameTextbox
            // 
            this.adminUsernameTextbox.Enabled = false;
            this.adminUsernameTextbox.Location = new System.Drawing.Point(162, 342);
            this.adminUsernameTextbox.Name = "adminUsernameTextbox";
            this.adminUsernameTextbox.Size = new System.Drawing.Size(276, 20);
            this.adminUsernameTextbox.TabIndex = 20;
            // 
            // adminUsernameLabel
            // 
            this.adminUsernameLabel.AutoSize = true;
            this.adminUsernameLabel.Location = new System.Drawing.Point(46, 349);
            this.adminUsernameLabel.Name = "adminUsernameLabel";
            this.adminUsernameLabel.Size = new System.Drawing.Size(90, 13);
            this.adminUsernameLabel.TabIndex = 21;
            this.adminUsernameLabel.Text = "Admin Username:";
            // 
            // Employee_Add_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.adminUsernameLabel);
            this.Controls.Add(this.adminUsernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.isNotAdmin);
            this.Controls.Add(this.isAdminRadio);
            this.Controls.Add(this.adminPasswordLabel);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.adminPasswordTextbox);
            this.Controls.Add(this.passwordCheckTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.phoneNumberTextbox);
            this.Controls.Add(this.emailAddressTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.addUserPageName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Employee_Add_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addUserPageName;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox emailAddressTextbox;
        private System.Windows.Forms.TextBox phoneNumberTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox passwordCheckTextbox;
        private System.Windows.Forms.TextBox adminPasswordTextbox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.Label adminPasswordLabel;
        private System.Windows.Forms.RadioButton isAdminRadio;
        private System.Windows.Forms.RadioButton isNotAdmin;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox adminUsernameTextbox;
        private System.Windows.Forms.Label adminUsernameLabel;
    }
}