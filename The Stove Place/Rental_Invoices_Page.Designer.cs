namespace The_Stove_Place
{
    partial class Add_Rental_Page
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
            this.addRentalInvoicesTitle = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.toolLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.addInvoiceButton = new System.Windows.Forms.Button();
            this.empNameComboBox = new System.Windows.Forms.ComboBox();
            this.priceResultLabel = new System.Windows.Forms.Label();
            this.custNameComboBox = new System.Windows.Forms.ComboBox();
            this.toolComboBox = new System.Windows.Forms.ComboBox();
            this.dateRentedResultLabel = new System.Windows.Forms.Label();
            this.dateRentedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addRentalInvoicesTitle
            // 
            this.addRentalInvoicesTitle.AutoSize = true;
            this.addRentalInvoicesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRentalInvoicesTitle.Location = new System.Drawing.Point(172, 9);
            this.addRentalInvoicesTitle.Name = "addRentalInvoicesTitle";
            this.addRentalInvoicesTitle.Size = new System.Drawing.Size(354, 46);
            this.addRentalInvoicesTitle.TabIndex = 1;
            this.addRentalInvoicesTitle.Text = "Add Rental Invoice";
            this.addRentalInvoicesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(36, 184);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 17);
            this.priceLabel.TabIndex = 25;
            this.priceLabel.Text = "Price:";
            // 
            // toolLabel
            // 
            this.toolLabel.AutoSize = true;
            this.toolLabel.Location = new System.Drawing.Point(36, 151);
            this.toolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(40, 17);
            this.toolLabel.TabIndex = 24;
            this.toolLabel.Text = "Tool:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(36, 117);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(113, 17);
            this.customerNameLabel.TabIndex = 22;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(36, 85);
            this.employeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(115, 17);
            this.employeeNameLabel.TabIndex = 21;
            this.employeeNameLabel.Text = "Employee Name:";
            // 
            // addInvoiceButton
            // 
            this.addInvoiceButton.Location = new System.Drawing.Point(238, 289);
            this.addInvoiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.addInvoiceButton.Name = "addInvoiceButton";
            this.addInvoiceButton.Size = new System.Drawing.Size(216, 28);
            this.addInvoiceButton.TabIndex = 29;
            this.addInvoiceButton.Text = "Add Invoice";
            this.addInvoiceButton.UseVisualStyleBackColor = true;
            this.addInvoiceButton.Click += new System.EventHandler(this.addInvoiceButton_Click);
            // 
            // empNameComboBox
            // 
            this.empNameComboBox.FormattingEnabled = true;
            this.empNameComboBox.Location = new System.Drawing.Point(157, 85);
            this.empNameComboBox.Name = "empNameComboBox";
            this.empNameComboBox.Size = new System.Drawing.Size(451, 24);
            this.empNameComboBox.TabIndex = 30;
            this.empNameComboBox.SelectedIndexChanged += new System.EventHandler(this.empNameComboBox_SelectedIndexChanged);
            // 
            // priceResultLabel
            // 
            this.priceResultLabel.AutoSize = true;
            this.priceResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceResultLabel.Location = new System.Drawing.Point(159, 184);
            this.priceResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceResultLabel.MinimumSize = new System.Drawing.Size(70, 0);
            this.priceResultLabel.Name = "priceResultLabel";
            this.priceResultLabel.Size = new System.Drawing.Size(70, 19);
            this.priceResultLabel.TabIndex = 31;
            this.priceResultLabel.Text = "$";
            // 
            // custNameComboBox
            // 
            this.custNameComboBox.FormattingEnabled = true;
            this.custNameComboBox.Location = new System.Drawing.Point(159, 114);
            this.custNameComboBox.Name = "custNameComboBox";
            this.custNameComboBox.Size = new System.Drawing.Size(449, 24);
            this.custNameComboBox.TabIndex = 32;
            this.custNameComboBox.SelectedIndexChanged += new System.EventHandler(this.custNameComboBox_SelectedIndexChanged);
            // 
            // toolComboBox
            // 
            this.toolComboBox.DropDownHeight = 200;
            this.toolComboBox.FormattingEnabled = true;
            this.toolComboBox.IntegralHeight = false;
            this.toolComboBox.Location = new System.Drawing.Point(90, 144);
            this.toolComboBox.MaxDropDownItems = 100;
            this.toolComboBox.Name = "toolComboBox";
            this.toolComboBox.Size = new System.Drawing.Size(518, 24);
            this.toolComboBox.TabIndex = 33;
            this.toolComboBox.SelectedIndexChanged += new System.EventHandler(this.toolComboBox_SelectedIndexChanged);
            // 
            // dateRentedResultLabel
            // 
            this.dateRentedResultLabel.AutoSize = true;
            this.dateRentedResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateRentedResultLabel.Location = new System.Drawing.Point(157, 218);
            this.dateRentedResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateRentedResultLabel.MinimumSize = new System.Drawing.Size(70, 0);
            this.dateRentedResultLabel.Name = "dateRentedResultLabel";
            this.dateRentedResultLabel.Size = new System.Drawing.Size(70, 19);
            this.dateRentedResultLabel.TabIndex = 35;
            // 
            // dateRentedLabel
            // 
            this.dateRentedLabel.AutoSize = true;
            this.dateRentedLabel.Location = new System.Drawing.Point(36, 218);
            this.dateRentedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateRentedLabel.Name = "dateRentedLabel";
            this.dateRentedLabel.Size = new System.Drawing.Size(92, 17);
            this.dateRentedLabel.TabIndex = 34;
            this.dateRentedLabel.Text = "Date Rented:";
            // 
            // Add_Rental_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 330);
            this.Controls.Add(this.dateRentedResultLabel);
            this.Controls.Add(this.dateRentedLabel);
            this.Controls.Add(this.toolComboBox);
            this.Controls.Add(this.custNameComboBox);
            this.Controls.Add(this.priceResultLabel);
            this.Controls.Add(this.empNameComboBox);
            this.Controls.Add(this.addInvoiceButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.toolLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.addRentalInvoicesTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_Rental_Page";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool Rental Invoice";
            this.Load += new System.EventHandler(this.Rental_Invoices_Page_Load);
            this.Resize += new System.EventHandler(this.Rental_Invoices_Page_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label addRentalInvoicesTitle;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label toolLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Button addInvoiceButton;
        private System.Windows.Forms.ComboBox empNameComboBox;
        private System.Windows.Forms.Label priceResultLabel;
        private System.Windows.Forms.ComboBox custNameComboBox;
        private System.Windows.Forms.ComboBox toolComboBox;
        private System.Windows.Forms.Label dateRentedResultLabel;
        private System.Windows.Forms.Label dateRentedLabel;
    }
}