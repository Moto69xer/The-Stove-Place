namespace The_Stove_Place
{
    partial class Main_Menu_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu_Page));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.theStovePlaceTitle = new System.Windows.Forms.Label();
            this.custInfoButton = new System.Windows.Forms.Button();
            this.employeeInfoButton = new System.Windows.Forms.Button();
            this.toolRentalButton = new System.Windows.Forms.Button();
            this.logOutLink = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rental_Invoice_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.manufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recentRentalsLabel = new System.Windows.Forms.Label();
            this.manuContactLabel = new System.Windows.Forms.Label();
            this.productInfoButton = new System.Windows.Forms.ComboBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // theStovePlaceTitle
            // 
            this.theStovePlaceTitle.AutoSize = true;
            this.theStovePlaceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theStovePlaceTitle.Location = new System.Drawing.Point(362, 18);
            this.theStovePlaceTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.theStovePlaceTitle.Name = "theStovePlaceTitle";
            this.theStovePlaceTitle.Size = new System.Drawing.Size(438, 37);
            this.theStovePlaceTitle.TabIndex = 1;
            this.theStovePlaceTitle.Text = "Welcome To The Stove Place\r\n";
            this.theStovePlaceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custInfoButton
            // 
            this.custInfoButton.Location = new System.Drawing.Point(0, 69);
            this.custInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.custInfoButton.Name = "custInfoButton";
            this.custInfoButton.Size = new System.Drawing.Size(219, 46);
            this.custInfoButton.TabIndex = 5;
            this.custInfoButton.Text = "Customer Information";
            this.custInfoButton.UseVisualStyleBackColor = true;
            this.custInfoButton.Click += new System.EventHandler(this.custInfoButton_Click);
            // 
            // employeeInfoButton
            // 
            this.employeeInfoButton.Location = new System.Drawing.Point(218, 69);
            this.employeeInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.employeeInfoButton.Name = "employeeInfoButton";
            this.employeeInfoButton.Size = new System.Drawing.Size(219, 46);
            this.employeeInfoButton.TabIndex = 6;
            this.employeeInfoButton.Text = "Employee Information";
            this.employeeInfoButton.UseVisualStyleBackColor = true;
            this.employeeInfoButton.Click += new System.EventHandler(this.employeeInfoButton_Click);
            // 
            // toolRentalButton
            // 
            this.toolRentalButton.Location = new System.Drawing.Point(435, 69);
            this.toolRentalButton.Margin = new System.Windows.Forms.Padding(2);
            this.toolRentalButton.Name = "toolRentalButton";
            this.toolRentalButton.Size = new System.Drawing.Size(219, 46);
            this.toolRentalButton.TabIndex = 7;
            this.toolRentalButton.Text = "Tool Rental";
            this.toolRentalButton.UseVisualStyleBackColor = true;
            this.toolRentalButton.Click += new System.EventHandler(this.toolRentalButton_Click);
            // 
            // logOutLink
            // 
            this.logOutLink.AutoSize = true;
            this.logOutLink.Location = new System.Drawing.Point(809, 37);
            this.logOutLink.Name = "logOutLink";
            this.logOutLink.Size = new System.Drawing.Size(42, 13);
            this.logOutLink.TabIndex = 9;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_Name,
            this.Rental_Invoice_Number,
            this.Total_Sales});
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 244);
            this.dataGridView1.TabIndex = 10;
            // 
            // Employee_Name
            // 
            this.Employee_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Employee_Name.DefaultCellStyle = dataGridViewCellStyle25;
            this.Employee_Name.DividerWidth = 1;
            this.Employee_Name.HeaderText = "Employee Name";
            this.Employee_Name.Name = "Employee_Name";
            // 
            // Rental_Invoice_Number
            // 
            this.Rental_Invoice_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Rental_Invoice_Number.DefaultCellStyle = dataGridViewCellStyle26;
            this.Rental_Invoice_Number.DividerWidth = 1;
            this.Rental_Invoice_Number.HeaderText = "Invoice #";
            this.Rental_Invoice_Number.Name = "Rental_Invoice_Number";
            // 
            // Total_Sales
            // 
            this.Total_Sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Format = "C2";
            dataGridViewCellStyle27.NullValue = null;
            this.Total_Sales.DefaultCellStyle = dataGridViewCellStyle27;
            this.Total_Sales.DividerWidth = 1;
            this.Total_Sales.HeaderText = "Total_Sales";
            this.Total_Sales.Name = "Total_Sales";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerName,
            this.phoneNumber,
            this.website});
            this.dataGridView2.Location = new System.Drawing.Point(535, 149);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(316, 244);
            this.dataGridView2.TabIndex = 11;
            // 
            // manufacturerName
            // 
            this.manufacturerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.manufacturerName.DefaultCellStyle = dataGridViewCellStyle28;
            this.manufacturerName.HeaderText = "Name";
            this.manufacturerName.Name = "manufacturerName";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.phoneNumber.DefaultCellStyle = dataGridViewCellStyle29;
            this.phoneNumber.HeaderText = "Phone Number #";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // website
            // 
            this.website.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.website.DefaultCellStyle = dataGridViewCellStyle30;
            this.website.HeaderText = "Website";
            this.website.Name = "website";
            // 
            // recentRentalsLabel
            // 
            this.recentRentalsLabel.AutoSize = true;
            this.recentRentalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentRentalsLabel.Location = new System.Drawing.Point(190, 129);
            this.recentRentalsLabel.Name = "recentRentalsLabel";
            this.recentRentalsLabel.Size = new System.Drawing.Size(171, 17);
            this.recentRentalsLabel.TabIndex = 12;
            this.recentRentalsLabel.Text = "Recent Rentals this Week";
            this.recentRentalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manuContactLabel
            // 
            this.manuContactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manuContactLabel.AutoSize = true;
            this.manuContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuContactLabel.Location = new System.Drawing.Point(532, 129);
            this.manuContactLabel.Name = "manuContactLabel";
            this.manuContactLabel.Size = new System.Drawing.Size(186, 17);
            this.manuContactLabel.TabIndex = 13;
            this.manuContactLabel.Text = "Manufacture\'s Contact Page";
            this.manuContactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productInfoButton
            // 
            this.productInfoButton.BackColor = System.Drawing.SystemColors.Control;
            this.productInfoButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.productInfoButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productInfoButton.FormattingEnabled = true;
            this.productInfoButton.ItemHeight = 13;
            this.productInfoButton.Items.AddRange(new object[] {
            "Replacement Parts Info",
            "Tool Info",
            "Stove Info"});
            this.productInfoButton.Location = new System.Drawing.Point(653, 70);
            this.productInfoButton.Name = "productInfoButton";
            this.productInfoButton.Size = new System.Drawing.Size(211, 19);
            this.productInfoButton.TabIndex = 14;
            this.productInfoButton.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.productInfoButton_DrawItem);
            this.productInfoButton.SelectedIndexChanged += new System.EventHandler(this.productInfoButton_SelectedIndexChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(794, 18);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(57, 13);
            this.usernameLabel.TabIndex = 15;
            this.usernameLabel.Text = "UserName";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main_Menu_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 422);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.productInfoButton);
            this.Controls.Add(this.manuContactLabel);
            this.Controls.Add(this.recentRentalsLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOutLink);
            this.Controls.Add(this.toolRentalButton);
            this.Controls.Add(this.employeeInfoButton);
            this.Controls.Add(this.custInfoButton);
            this.Controls.Add(this.theStovePlaceTitle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(615, 421);
            this.Name = "Main_Menu_Page";
            this.ShowIcon = false;
            this.Text = "The Stove Place";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_Page_FormClosed);
            this.Load += new System.EventHandler(this.Main_Menu_Page_Resize);
            this.Resize += new System.EventHandler(this.Main_Menu_Page_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label theStovePlaceTitle;
        private System.Windows.Forms.Button custInfoButton;
        private System.Windows.Forms.Button employeeInfoButton;
        private System.Windows.Forms.Button toolRentalButton;
        private System.Windows.Forms.LinkLabel logOutLink;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label recentRentalsLabel;
        private System.Windows.Forms.Label manuContactLabel;
        private System.Windows.Forms.ComboBox productInfoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rental_Invoice_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn website;
        private System.Windows.Forms.Label usernameLabel;
    }
}