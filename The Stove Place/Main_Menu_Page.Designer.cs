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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.theStovePlaceTitle = new System.Windows.Forms.Label();
            this.custInfoButton = new System.Windows.Forms.Button();
            this.employeeInfoButton = new System.Windows.Forms.Button();
            this.toolRentalButton = new System.Windows.Forms.Button();
            this.logOutLink = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.recentRentalsLabel = new System.Windows.Forms.Label();
            this.manuContactLabel = new System.Windows.Forms.Label();
            this.productInfoButton = new System.Windows.Forms.ComboBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // theStovePlaceTitle
            // 
            this.theStovePlaceTitle.AutoSize = true;
            this.theStovePlaceTitle.BackColor = System.Drawing.Color.Transparent;
            this.theStovePlaceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theStovePlaceTitle.Location = new System.Drawing.Point(483, 22);
            this.theStovePlaceTitle.Name = "theStovePlaceTitle";
            this.theStovePlaceTitle.Size = new System.Drawing.Size(550, 46);
            this.theStovePlaceTitle.TabIndex = 1;
            this.theStovePlaceTitle.Text = "Welcome To The Stove Place\r\n";
            this.theStovePlaceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custInfoButton
            // 
            this.custInfoButton.Location = new System.Drawing.Point(0, 85);
            this.custInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.custInfoButton.Name = "custInfoButton";
            this.custInfoButton.Size = new System.Drawing.Size(292, 57);
            this.custInfoButton.TabIndex = 5;
            this.custInfoButton.Text = "Customer Information";
            this.custInfoButton.UseVisualStyleBackColor = true;
            this.custInfoButton.Click += new System.EventHandler(this.custInfoButton_Click);
            // 
            // employeeInfoButton
            // 
            this.employeeInfoButton.Location = new System.Drawing.Point(291, 85);
            this.employeeInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeInfoButton.Name = "employeeInfoButton";
            this.employeeInfoButton.Size = new System.Drawing.Size(292, 57);
            this.employeeInfoButton.TabIndex = 6;
            this.employeeInfoButton.Text = "Employee Information";
            this.employeeInfoButton.UseVisualStyleBackColor = true;
            this.employeeInfoButton.Click += new System.EventHandler(this.employeeInfoButton_Click);
            // 
            // toolRentalButton
            // 
            this.toolRentalButton.Location = new System.Drawing.Point(580, 85);
            this.toolRentalButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolRentalButton.Name = "toolRentalButton";
            this.toolRentalButton.Size = new System.Drawing.Size(292, 57);
            this.toolRentalButton.TabIndex = 7;
            this.toolRentalButton.Text = "Tool Rental";
            this.toolRentalButton.UseVisualStyleBackColor = true;
            this.toolRentalButton.Click += new System.EventHandler(this.toolRentalButton_Click);
            // 
            // logOutLink
            // 
            this.logOutLink.AutoSize = true;
            this.logOutLink.BackColor = System.Drawing.Color.Transparent;
            this.logOutLink.Location = new System.Drawing.Point(1079, 46);
            this.logOutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logOutLink.Name = "logOutLink";
            this.logOutLink.Size = new System.Drawing.Size(55, 17);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(659, 300);
            this.dataGridView1.TabIndex = 10;
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
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(951, 225);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(561, 369);
            this.dataGridView2.TabIndex = 11;
            // 
            // recentRentalsLabel
            // 
            this.recentRentalsLabel.AutoSize = true;
            this.recentRentalsLabel.BackColor = System.Drawing.Color.Transparent;
            this.recentRentalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentRentalsLabel.Location = new System.Drawing.Point(253, 159);
            this.recentRentalsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recentRentalsLabel.Name = "recentRentalsLabel";
            this.recentRentalsLabel.Size = new System.Drawing.Size(203, 20);
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
            this.manuContactLabel.BackColor = System.Drawing.Color.Transparent;
            this.manuContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuContactLabel.Location = new System.Drawing.Point(709, 159);
            this.manuContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manuContactLabel.Name = "manuContactLabel";
            this.manuContactLabel.Size = new System.Drawing.Size(221, 20);
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
            this.productInfoButton.Location = new System.Drawing.Point(871, 86);
            this.productInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productInfoButton.Name = "productInfoButton";
            this.productInfoButton.Size = new System.Drawing.Size(280, 19);
            this.productInfoButton.TabIndex = 14;
            this.productInfoButton.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.productInfoButton_DrawItem);
            this.productInfoButton.SelectedIndexChanged += new System.EventHandler(this.productInfoButton_SelectedIndexChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Location = new System.Drawing.Point(1059, 22);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 17);
            this.usernameLabel.TabIndex = 15;
            this.usernameLabel.Text = "UserName";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(171, 156);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Main_Menu_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Stove_Place.Properties.Resources._415802_forest_fire_flames_tree_disaster_apocalyptic_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 519);
            this.Controls.Add(this.refreshButton);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(813, 505);
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


        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button refreshButton;
    }
}