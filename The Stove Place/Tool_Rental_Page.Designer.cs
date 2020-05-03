namespace The_Stove_Place
{
    partial class Tool_Rental_Page
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolRentalTitle = new System.Windows.Forms.Label();
            this.logOutLink = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchParamComboBox = new System.Windows.Forms.ComboBox();
            this.addInvoiceButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolRentalTitle
            // 
            this.toolRentalTitle.AutoSize = true;
            this.toolRentalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolRentalTitle.Location = new System.Drawing.Point(540, 23);
            this.toolRentalTitle.Name = "toolRentalTitle";
            this.toolRentalTitle.Size = new System.Drawing.Size(362, 46);
            this.toolRentalTitle.TabIndex = 1;
            this.toolRentalTitle.Text = "Tool Rental Invoice";
            this.toolRentalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutLink
            // 
            this.logOutLink.AutoSize = true;
            this.logOutLink.Location = new System.Drawing.Point(1079, 46);
            this.logOutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logOutLink.Name = "logOutLink";
            this.logOutLink.Size = new System.Drawing.Size(55, 17);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(780, 247);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // backLink
            // 
            this.backLink.AutoSize = true;
            this.backLink.Location = new System.Drawing.Point(1077, 87);
            this.backLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(51, 17);
            this.backLink.TabIndex = 9;
            this.backLink.TabStop = true;
            this.backLink.Text = "< Back";
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(911, 83);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(548, 84);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(297, 22);
            this.searchBar.TabIndex = 24;
            this.searchBar.Text = "Search";
            this.searchBar.Click += new System.EventHandler(this.searchBar_Click);
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyDown);
            // 
            // searchParamComboBox
            // 
            this.searchParamComboBox.FormattingEnabled = true;
            this.searchParamComboBox.Items.AddRange(new object[] {
            "Invoice Number",
            "Employee Id",
            "Customer Id",
            "Rental Tool Id"});
            this.searchParamComboBox.Location = new System.Drawing.Point(397, 84);
            this.searchParamComboBox.Name = "searchParamComboBox";
            this.searchParamComboBox.Size = new System.Drawing.Size(145, 24);
            this.searchParamComboBox.TabIndex = 23;
            // 
            // addInvoiceButton
            // 
            this.addInvoiceButton.AutoSize = true;
            this.addInvoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvoiceButton.ForeColor = System.Drawing.Color.Blue;
            this.addInvoiceButton.Location = new System.Drawing.Point(929, 88);
            this.addInvoiceButton.Name = "addInvoiceButton";
            this.addInvoiceButton.Size = new System.Drawing.Size(121, 18);
            this.addInvoiceButton.TabIndex = 26;
            this.addInvoiceButton.Text = "Add  New Invoice";
            this.addInvoiceButton.Click += new System.EventHandler(this.addInvoiceButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::The_Stove_Place.Properties.Resources.The_Stove_Place_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 121);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(270, 83);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 27;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Tool_Rental_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 519);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addInvoiceButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchParamComboBox);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOutLink);
            this.Controls.Add(this.toolRentalTitle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(813, 505);
            this.Name = "Tool_Rental_Page";
            this.ShowIcon = false;
            this.Text = "Tool Rental Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tool_Rental_Page_Load);
            this.Resize += new System.EventHandler(this.Tool_Rental_Page_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label toolRentalTitle;
        private System.Windows.Forms.LinkLabel logOutLink;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel backLink;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ComboBox searchParamComboBox;
        private System.Windows.Forms.Label addInvoiceButton;
        private System.Windows.Forms.Button refreshButton;
    }
}