namespace The_Stove_Place
{
  partial class Customer_Information_Page
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
            this.customerInfoTitle = new System.Windows.Forms.Label();
            this.logOutLink = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.newCustLink = new System.Windows.Forms.LinkLabel();
            this.searchParamComboBox = new System.Windows.Forms.ComboBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerInfoTitle
            // 
            this.customerInfoTitle.AutoSize = true;
            this.customerInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoTitle.Location = new System.Drawing.Point(540, 23);
            this.customerInfoTitle.Name = "customerInfoTitle";
            this.customerInfoTitle.Size = new System.Drawing.Size(403, 46);
            this.customerInfoTitle.TabIndex = 1;
            this.customerInfoTitle.Text = "Customer Information";
            this.customerInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 354);
            this.dataGridView1.TabIndex = 8;
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
            // newCustLink
            // 
            this.newCustLink.AutoSize = true;
            this.newCustLink.Location = new System.Drawing.Point(944, 87);
            this.newCustLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newCustLink.Name = "newCustLink";
            this.newCustLink.Size = new System.Drawing.Size(128, 17);
            this.newCustLink.TabIndex = 10;
            this.newCustLink.TabStop = true;
            this.newCustLink.Text = "Add New Customer";
            this.newCustLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newCustLink_LinkClicked);
            // 
            // searchParamComboBox
            // 
            this.searchParamComboBox.FormattingEnabled = true;
            this.searchParamComboBox.Items.AddRange(new object[] {
            "Customer Id",
            "First Name",
            "Last Name",
            "Address",
            "City",
            "State",
            "Zip"});
            this.searchParamComboBox.Location = new System.Drawing.Point(395, 84);
            this.searchParamComboBox.Name = "searchParamComboBox";
            this.searchParamComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchParamComboBox.TabIndex = 11;
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(548, 86);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(297, 22);
            this.searchBar.TabIndex = 12;
            this.searchBar.Text = "Search";
            this.searchBar.Click += new System.EventHandler(this.searchBar_Click);
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(920, 86);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(303, 84);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Customer_Information_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 519);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchParamComboBox);
            this.Controls.Add(this.newCustLink);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOutLink);
            this.Controls.Add(this.customerInfoTitle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(814, 507);
            this.Name = "Customer_Information_Page";
            this.ShowIcon = false;
            this.Text = "Customer Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cust_Info_Page_Load);
            this.Resize += new System.EventHandler(this.Cust_Info_Page_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label customerInfoTitle;
    private System.Windows.Forms.LinkLabel logOutLink;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.LinkLabel backLink;
    private System.Windows.Forms.LinkLabel newCustLink;
        private System.Windows.Forms.ComboBox searchParamComboBox;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshButton;
    }
}