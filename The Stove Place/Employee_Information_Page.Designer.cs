namespace The_Stove_Place
{
    partial class Employee_Information_Page
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
            this.employeeInfoTitle = new System.Windows.Forms.Label();
            this.logOutLink = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchParamComboBox = new System.Windows.Forms.ComboBox();
            this.addUserButton = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeInfoTitle
            // 
            this.employeeInfoTitle.AllowDrop = true;
            this.employeeInfoTitle.AutoSize = true;
            this.employeeInfoTitle.BackColor = System.Drawing.Color.Transparent;
            this.employeeInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeInfoTitle.Location = new System.Drawing.Point(324, 18);
            this.employeeInfoTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeInfoTitle.Name = "employeeInfoTitle";
            this.employeeInfoTitle.Size = new System.Drawing.Size(327, 37);
            this.employeeInfoTitle.TabIndex = 1;
            this.employeeInfoTitle.Text = "Employee Information";
            this.employeeInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutLink
            // 
            this.logOutLink.AutoSize = true;
            this.logOutLink.BackColor = System.Drawing.Color.Transparent;
            this.logOutLink.Location = new System.Drawing.Point(809, 37);
            this.logOutLink.Name = "logOutLink";
            this.logOutLink.Size = new System.Drawing.Size(42, 13);
            this.logOutLink.TabIndex = 2;
            this.logOutLink.TabStop = true;
            this.logOutLink.Text = "LogOut";
            this.logOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOut_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(838, 288);
            this.dataGridView1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::The_Stove_Place.Properties.Resources.The_Stove_Place_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backLink
            // 
            this.backLink.AutoSize = true;
            this.backLink.BackColor = System.Drawing.Color.Transparent;
            this.backLink.Location = new System.Drawing.Point(808, 71);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(41, 13);
            this.backLink.TabIndex = 9;
            this.backLink.TabStop = true;
            this.backLink.Text = "< Back";
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(634, 68);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 19);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(356, 68);
            this.searchBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(224, 20);
            this.searchBar.TabIndex = 15;
            this.searchBar.Text = "Search";
            this.searchBar.Click += new System.EventHandler(this.searchBar_Click);
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyDown);
            // 
            // searchParamComboBox
            // 
            this.searchParamComboBox.FormattingEnabled = true;
            this.searchParamComboBox.Items.AddRange(new object[] {
            "Employee Id",
            "First Name",
            "Last Name",
            "Email",
            "Phone Number"});
            this.searchParamComboBox.Location = new System.Drawing.Point(241, 67);
            this.searchParamComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchParamComboBox.Name = "searchParamComboBox";
            this.searchParamComboBox.Size = new System.Drawing.Size(92, 21);
            this.searchParamComboBox.TabIndex = 14;
            // 
            // addUserButton
            // 
            this.addUserButton.AutoSize = true;
            this.addUserButton.BackColor = System.Drawing.Color.Transparent;
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.ForeColor = System.Drawing.Color.Blue;
            this.addUserButton.Location = new System.Drawing.Point(697, 69);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(117, 15);
            this.addUserButton.TabIndex = 17;
            this.addUserButton.Text = "Add  New Employee";
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(154, 67);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(56, 19);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Employee_Information_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::The_Stove_Place.Properties.Resources._415802_forest_fire_flames_tree_disaster_apocalyptic_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 422);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchParamComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOutLink);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.employeeInfoTitle);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(614, 419);
            this.Name = "Employee_Information_Page";
            this.ShowIcon = false;
            this.Text = "Employee Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_Information_Page_Load);
            this.Resize += new System.EventHandler(this.Employee_Information_Page_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label employeeInfoTitle;
        private System.Windows.Forms.LinkLabel logOutLink;
        private System.Windows.Forms.LinkLabel backLink;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ComboBox searchParamComboBox;
        private System.Windows.Forms.Label addUserButton;
        private System.Windows.Forms.Button refreshButton;
    }
}