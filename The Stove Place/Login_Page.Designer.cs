namespace The_Stove_Place
{
    partial class Login_Page
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInputTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInputTextbox = new System.Windows.Forms.TextBox();
            this.loginInputControls = new System.Windows.Forms.GroupBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.addUserButton = new System.Windows.Forms.Label();
            this.loginInputControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(6, 16);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // usernameInputTextbox
            // 
            this.usernameInputTextbox.Location = new System.Drawing.Point(9, 32);
            this.usernameInputTextbox.Name = "usernameInputTextbox";
            this.usernameInputTextbox.Size = new System.Drawing.Size(220, 20);
            this.usernameInputTextbox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(9, 97);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(220, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 55);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // passwordInputTextbox
            // 
            this.passwordInputTextbox.Location = new System.Drawing.Point(9, 71);
            this.passwordInputTextbox.Name = "passwordInputTextbox";
            this.passwordInputTextbox.PasswordChar = '*';
            this.passwordInputTextbox.Size = new System.Drawing.Size(220, 20);
            this.passwordInputTextbox.TabIndex = 2;
            // 
            // loginInputControls
            // 
            this.loginInputControls.Controls.Add(this.passwordInputTextbox);
            this.loginInputControls.Controls.Add(this.passwordLabel);
            this.loginInputControls.Controls.Add(this.loginButton);
            this.loginInputControls.Controls.Add(this.usernameInputTextbox);
            this.loginInputControls.Controls.Add(this.usernameLabel);
            this.loginInputControls.Location = new System.Drawing.Point(125, 296);
            this.loginInputControls.Name = "loginInputControls";
            this.loginInputControls.Size = new System.Drawing.Size(235, 131);
            this.loginInputControls.TabIndex = 5;
            this.loginInputControls.TabStop = false;
            this.loginInputControls.Text = "Please Enter Credentials";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.logoPictureBox.Location = new System.Drawing.Point(114, 34);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(256, 256);
            this.logoPictureBox.TabIndex = 5;
            this.logoPictureBox.TabStop = false;
            // 
            // addUserButton
            // 
            this.addUserButton.AutoSize = true;
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.addUserButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addUserButton.Location = new System.Drawing.Point(272, 435);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(200, 17);
            this.addUserButton.TabIndex = 6;
            this.addUserButton.Text = "Click Here To Add A New User";
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.loginInputControls);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login_Page";
            this.Text = "User Login";
            this.loginInputControls.ResumeLayout(false);
            this.loginInputControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameInputTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInputTextbox;
        private System.Windows.Forms.GroupBox loginInputControls;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label addUserButton;
    }
}

