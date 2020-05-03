namespace The_Stove_Place
{
  partial class Customer_Add_Page
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
            this.addCustomerPageName = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.stateTextbox = new System.Windows.Forms.TextBox();
            this.zipTextbox = new System.Windows.Forms.TextBox();
            this.emailAddressTextbox = new System.Windows.Forms.TextBox();
            this.isActiveCustomer = new System.Windows.Forms.RadioButton();
            this.isNonActiveCustomer = new System.Windows.Forms.RadioButton();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCustomerPageName
            // 
            this.addCustomerPageName.AutoSize = true;
            this.addCustomerPageName.BackColor = System.Drawing.Color.Transparent;
            this.addCustomerPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.addCustomerPageName.ForeColor = System.Drawing.Color.Black;
            this.addCustomerPageName.Location = new System.Drawing.Point(150, 13);
            this.addCustomerPageName.Name = "addCustomerPageName";
            this.addCustomerPageName.Size = new System.Drawing.Size(199, 31);
            this.addCustomerPageName.TabIndex = 0;
            this.addCustomerPageName.Text = "Add Customer";
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
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(162, 182);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(276, 20);
            this.addressTextbox.TabIndex = 3;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(162, 208);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(276, 20);
            this.cityTextbox.TabIndex = 4;
            // 
            // stateTextbox
            // 
            this.stateTextbox.Location = new System.Drawing.Point(162, 234);
            this.stateTextbox.MaxLength = 2;
            this.stateTextbox.Name = "stateTextbox";
            this.stateTextbox.Size = new System.Drawing.Size(276, 20);
            this.stateTextbox.TabIndex = 6;
            // 
            // zipTextbox
            // 
            this.zipTextbox.Location = new System.Drawing.Point(162, 260);
            this.zipTextbox.MaxLength = 5;
            this.zipTextbox.Name = "zipTextbox";
            this.zipTextbox.Size = new System.Drawing.Size(276, 20);
            this.zipTextbox.TabIndex = 7;
            this.zipTextbox.TextChanged += new System.EventHandler(this.zipTextbox_TextChanged);
            // 
            // emailAddressTextbox
            // 
            this.emailAddressTextbox.Location = new System.Drawing.Point(162, 286);
            this.emailAddressTextbox.Name = "emailAddressTextbox";
            this.emailAddressTextbox.Size = new System.Drawing.Size(276, 20);
            this.emailAddressTextbox.TabIndex = 9;
            // 
            // isActiveCustomer
            // 
            this.isActiveCustomer.AutoSize = true;
            this.isActiveCustomer.BackColor = System.Drawing.Color.Transparent;
            this.isActiveCustomer.ForeColor = System.Drawing.Color.Black;
            this.isActiveCustomer.Location = new System.Drawing.Point(162, 312);
            this.isActiveCustomer.Name = "isActiveCustomer";
            this.isActiveCustomer.Size = new System.Drawing.Size(112, 17);
            this.isActiveCustomer.TabIndex = 15;
            this.isActiveCustomer.TabStop = true;
            this.isActiveCustomer.Text = "Customer is Active";
            this.isActiveCustomer.UseVisualStyleBackColor = false;
            this.isActiveCustomer.Click += new System.EventHandler(this.isActiveCustomer_CheckedChanged);
            // 
            // isNonActiveCustomer
            // 
            this.isNonActiveCustomer.AutoSize = true;
            this.isNonActiveCustomer.BackColor = System.Drawing.Color.Transparent;
            this.isNonActiveCustomer.ForeColor = System.Drawing.Color.Black;
            this.isNonActiveCustomer.Location = new System.Drawing.Point(312, 312);
            this.isNonActiveCustomer.Name = "isNonActiveCustomer";
            this.isNonActiveCustomer.Size = new System.Drawing.Size(130, 17);
            this.isNonActiveCustomer.TabIndex = 16;
            this.isNonActiveCustomer.TabStop = true;
            this.isNonActiveCustomer.Text = "Customer is not Active";
            this.isNonActiveCustomer.UseVisualStyleBackColor = false;
            this.isNonActiveCustomer.Click += new System.EventHandler(this.isNonActiveCustomer_CheckedChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.firstNameLabel.ForeColor = System.Drawing.Color.Black;
            this.firstNameLabel.Location = new System.Drawing.Point(46, 137);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.lastNameLabel.ForeColor = System.Drawing.Color.Black;
            this.lastNameLabel.Location = new System.Drawing.Point(46, 163);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.SystemColors.Control;
            this.addressLabel.ForeColor = System.Drawing.Color.Black;
            this.addressLabel.Location = new System.Drawing.Point(46, 189);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.SystemColors.Control;
            this.cityLabel.ForeColor = System.Drawing.Color.Black;
            this.cityLabel.Location = new System.Drawing.Point(46, 215);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 11;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.stateLabel.ForeColor = System.Drawing.Color.Black;
            this.stateLabel.Location = new System.Drawing.Point(46, 241);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 12;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.BackColor = System.Drawing.SystemColors.Control;
            this.zipLabel.ForeColor = System.Drawing.Color.Black;
            this.zipLabel.Location = new System.Drawing.Point(46, 267);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(53, 13);
            this.zipLabel.TabIndex = 13;
            this.zipLabel.Text = "Zip Code:";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.BackColor = System.Drawing.SystemColors.Control;
            this.emailAddressLabel.ForeColor = System.Drawing.Color.Black;
            this.emailAddressLabel.Location = new System.Drawing.Point(46, 293);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.emailAddressLabel.TabIndex = 14;
            this.emailAddressLabel.Text = "E-mail Address:";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(161, 426);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(162, 23);
            this.addCustomerButton.TabIndex = 10;
            this.addCustomerButton.Text = "Confirm and Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // Customer_Add_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Stove_Place.Properties.Resources._415802_forest_fire_flames_tree_disaster_apocalyptic_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailAddressTextbox);
            this.Controls.Add(this.zipTextbox);
            this.Controls.Add(this.stateTextbox);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.isActiveCustomer);
            this.Controls.Add(this.isNonActiveCustomer);
            this.Controls.Add(this.addCustomerPageName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Customer_Add_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label addCustomerPageName;
    private System.Windows.Forms.TextBox firstNameTextbox;
    private System.Windows.Forms.TextBox lastNameTextbox;
    private System.Windows.Forms.TextBox addressTextbox;
    private System.Windows.Forms.TextBox cityTextbox;
    private System.Windows.Forms.TextBox stateTextbox;
    private System.Windows.Forms.TextBox zipTextbox;
    private System.Windows.Forms.TextBox emailAddressTextbox;
    private System.Windows.Forms.RadioButton isNonActiveCustomer;
    private System.Windows.Forms.RadioButton isActiveCustomer;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.Label addressLabel;
    private System.Windows.Forms.Label cityLabel;
    private System.Windows.Forms.Label stateLabel;
    private System.Windows.Forms.Label zipLabel;
    private System.Windows.Forms.Label emailAddressLabel;
    private System.Windows.Forms.Button addCustomerButton;
  }
}