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
      this.components = new System.ComponentModel.Container();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.dgvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editCellContextMenuItemSep = new System.Windows.Forms.ToolStripSeparator();
      this.editCellContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createListAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createListSelectedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.seperator1MenuItem = new System.Windows.Forms.ToolStripSeparator();
      this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.navigatorToolStrip = new System.Windows.Forms.ToolStrip();
      this.navigatorMoveFirstButton = new System.Windows.Forms.ToolStripButton();
      this.navigatorMovePrevButton = new System.Windows.Forms.ToolStripButton();
      this.navigatorPositionTextBox = new System.Windows.Forms.ToolStripTextBox();
      this.navigatorCountLabel = new System.Windows.Forms.ToolStripLabel();
      this.navigatorMoveNextButton = new System.Windows.Forms.ToolStripButton();
      this.navigatorMoveLastButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.navigatorAddButton = new System.Windows.Forms.ToolStripButton();
      this.navigatorDeleteButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.navigatorFindLabel = new System.Windows.Forms.ToolStripLabel();
      this.navigatorFindTextBox = new System.Windows.Forms.ToolStripTextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.theStovePlaceTitle = new System.Windows.Forms.Label();
      this.custInfoButton = new System.Windows.Forms.Button();
      this.employeeInfoButton = new System.Windows.Forms.Button();
      this.toolRentalButton = new System.Windows.Forms.Button();
      this.logOutLink = new System.Windows.Forms.LinkLabel();
      this.productInfoButton = new System.Windows.Forms.ComboBox();
      this.timer = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.dgvContextMenu.SuspendLayout();
      this.mainMenu.SuspendLayout();
      this.navigatorToolStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView
      // 
      this.dataGridView.AllowUserToAddRows = false;
      this.dataGridView.AllowUserToDeleteRows = false;
      this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.ContextMenuStrip = this.dgvContextMenu;
      this.dataGridView.Location = new System.Drawing.Point(0, 188);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowHeadersWidth = 55;
      this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView.Size = new System.Drawing.Size(1011, 362);
      this.dataGridView.TabIndex = 0;
      // 
      // dgvContextMenu
      // 
      this.dgvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContextMenuItem,
            this.deleteContextMenuItem,
            this.editCellContextMenuItemSep,
            this.editCellContextMenuItem});
      this.dgvContextMenu.Name = "gridViewContextMenu";
      this.dgvContextMenu.Size = new System.Drawing.Size(118, 76);
      // 
      // addContextMenuItem
      // 
      this.addContextMenuItem.Name = "addContextMenuItem";
      this.addContextMenuItem.Size = new System.Drawing.Size(117, 22);
      this.addContextMenuItem.Text = "Add...";
      // 
      // deleteContextMenuItem
      // 
      this.deleteContextMenuItem.Name = "deleteContextMenuItem";
      this.deleteContextMenuItem.Size = new System.Drawing.Size(117, 22);
      this.deleteContextMenuItem.Text = "Delete...";
      // 
      // editCellContextMenuItemSep
      // 
      this.editCellContextMenuItemSep.Name = "editCellContextMenuItemSep";
      this.editCellContextMenuItemSep.Size = new System.Drawing.Size(114, 6);
      // 
      // editCellContextMenuItem
      // 
      this.editCellContextMenuItem.Name = "editCellContextMenuItem";
      this.editCellContextMenuItem.Size = new System.Drawing.Size(117, 22);
      this.editCellContextMenuItem.Text = "Edit Cell";
      // 
      // mainMenu
      // 
      this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
      this.mainMenu.Location = new System.Drawing.Point(9, 118);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
      this.mainMenu.Size = new System.Drawing.Size(85, 24);
      this.mainMenu.TabIndex = 16;
      this.mainMenu.Visible = false;
      // 
      // fileMenuItem
      // 
      this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createListMenuItem,
            this.viewListMenuItem,
            this.seperator1MenuItem,
            this.exitMenuItem});
      this.fileMenuItem.Name = "fileMenuItem";
      this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileMenuItem.Text = "&File";
      // 
      // createListMenuItem
      // 
      this.createListMenuItem.Checked = true;
      this.createListMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.createListMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createListAllMenuItem,
            this.createListSelectedMenuItem});
      this.createListMenuItem.Name = "createListMenuItem";
      this.createListMenuItem.Size = new System.Drawing.Size(134, 22);
      this.createListMenuItem.Text = "&Create List";
      // 
      // createListAllMenuItem
      // 
      this.createListAllMenuItem.Name = "createListAllMenuItem";
      this.createListAllMenuItem.Size = new System.Drawing.Size(118, 22);
      this.createListAllMenuItem.Text = "All";
      // 
      // createListSelectedMenuItem
      // 
      this.createListSelectedMenuItem.Name = "createListSelectedMenuItem";
      this.createListSelectedMenuItem.Size = new System.Drawing.Size(118, 22);
      this.createListSelectedMenuItem.Text = "Selected";
      // 
      // viewListMenuItem
      // 
      this.viewListMenuItem.Name = "viewListMenuItem";
      this.viewListMenuItem.Size = new System.Drawing.Size(134, 22);
      this.viewListMenuItem.Text = "&View List";
      // 
      // seperator1MenuItem
      // 
      this.seperator1MenuItem.Name = "seperator1MenuItem";
      this.seperator1MenuItem.Size = new System.Drawing.Size(131, 6);
      // 
      // exitMenuItem
      // 
      this.exitMenuItem.Name = "exitMenuItem";
      this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.exitMenuItem.Size = new System.Drawing.Size(134, 22);
      this.exitMenuItem.Text = "&Exit";
      // 
      // editMenuItem
      // 
      this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.deleteMenuItem});
      this.editMenuItem.Name = "editMenuItem";
      this.editMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editMenuItem.Text = "&Edit";
      // 
      // addMenuItem
      // 
      this.addMenuItem.Name = "addMenuItem";
      this.addMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.addMenuItem.Size = new System.Drawing.Size(158, 22);
      this.addMenuItem.Text = "&Add...";
      // 
      // deleteMenuItem
      // 
      this.deleteMenuItem.Name = "deleteMenuItem";
      this.deleteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.deleteMenuItem.Size = new System.Drawing.Size(158, 22);
      this.deleteMenuItem.Text = "&Delete...";
      // 
      // navigatorToolStrip
      // 
      this.navigatorToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.navigatorToolStrip.Location = new System.Drawing.Point(0, 140);
      this.navigatorToolStrip.Name = "navigatorToolStrip";
      this.navigatorToolStrip.Size = new System.Drawing.Size(371, 25);
      this.navigatorToolStrip.TabIndex = 23;
      this.navigatorToolStrip.Visible = false;
      // 
      // navigatorMoveFirstButton
      // 
      this.navigatorMoveFirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorMoveFirstButton.Name = "navigatorMoveFirstButton";
      this.navigatorMoveFirstButton.RightToLeftAutoMirrorImage = true;
      this.navigatorMoveFirstButton.Size = new System.Drawing.Size(23, 22);
      this.navigatorMoveFirstButton.Text = "Move first";
      // 
      // navigatorMovePrevButton
      // 
      this.navigatorMovePrevButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorMovePrevButton.Name = "navigatorMovePrevButton";
      this.navigatorMovePrevButton.RightToLeftAutoMirrorImage = true;
      this.navigatorMovePrevButton.Size = new System.Drawing.Size(23, 22);
      this.navigatorMovePrevButton.Text = "Move previous";
      // 
      // navigatorPositionTextBox
      // 
      this.navigatorPositionTextBox.AccessibleName = "Position";
      this.navigatorPositionTextBox.AutoSize = false;
      this.navigatorPositionTextBox.Name = "navigatorPositionTextBox";
      this.navigatorPositionTextBox.Size = new System.Drawing.Size(25, 22);
      this.navigatorPositionTextBox.Text = "0";
      this.navigatorPositionTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.navigatorPositionTextBox.ToolTipText = "Current position";
      // 
      // navigatorCountLabel
      // 
      this.navigatorCountLabel.AutoSize = false;
      this.navigatorCountLabel.Name = "navigatorCountLabel";
      this.navigatorCountLabel.Size = new System.Drawing.Size(35, 22);
      this.navigatorCountLabel.Text = "of {0}";
      this.navigatorCountLabel.ToolTipText = "Total number of items";
      // 
      // navigatorMoveNextButton
      // 
      this.navigatorMoveNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorMoveNextButton.Name = "navigatorMoveNextButton";
      this.navigatorMoveNextButton.RightToLeftAutoMirrorImage = true;
      this.navigatorMoveNextButton.Size = new System.Drawing.Size(23, 22);
      this.navigatorMoveNextButton.Text = "Move next";
      // 
      // navigatorMoveLastButton
      // 
      this.navigatorMoveLastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorMoveLastButton.Name = "navigatorMoveLastButton";
      this.navigatorMoveLastButton.RightToLeftAutoMirrorImage = true;
      this.navigatorMoveLastButton.Size = new System.Drawing.Size(23, 22);
      this.navigatorMoveLastButton.Text = "Move last";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // navigatorAddButton
      // 
      this.navigatorAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorAddButton.Name = "navigatorAddButton";
      this.navigatorAddButton.RightToLeftAutoMirrorImage = true;
      this.navigatorAddButton.Size = new System.Drawing.Size(23, 22);
      this.navigatorAddButton.Text = "Add new";
      // 
      // navigatorDeleteButton
      // 
      this.navigatorDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorDeleteButton.Name = "navigatorDeleteButton";
      this.navigatorDeleteButton.RightToLeftAutoMirrorImage = true;
      this.navigatorDeleteButton.Size = new System.Drawing.Size(23, 22);
      this.navigatorDeleteButton.ToolTipText = "Delete";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // navigatorFindLabel
      // 
      this.navigatorFindLabel.Name = "navigatorFindLabel";
      this.navigatorFindLabel.Size = new System.Drawing.Size(45, 22);
      this.navigatorFindLabel.Text = "Search:";
      this.navigatorFindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // navigatorFindTextBox
      // 
      this.navigatorFindTextBox.Name = "navigatorFindTextBox";
      this.navigatorFindTextBox.Size = new System.Drawing.Size(100, 25);
      this.navigatorFindTextBox.ToolTipText = "Find ID";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBox1.Image = global::The_Stove_Place.Properties.Resources.The_Stove_Place_Logo;
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
      this.theStovePlaceTitle.Location = new System.Drawing.Point(405, 19);
      this.theStovePlaceTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.theStovePlaceTitle.Name = "theStovePlaceTitle";
      this.theStovePlaceTitle.Size = new System.Drawing.Size(249, 37);
      this.theStovePlaceTitle.TabIndex = 1;
      this.theStovePlaceTitle.Text = "The Stove Place";
      this.theStovePlaceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // custInfoButton
      // 
      this.custInfoButton.Location = new System.Drawing.Point(0, 69);
      this.custInfoButton.Margin = new System.Windows.Forms.Padding(2);
      this.custInfoButton.Name = "custInfoButton";
      this.custInfoButton.Size = new System.Drawing.Size(266, 46);
      this.custInfoButton.TabIndex = 5;
      this.custInfoButton.Text = "Customer Information";
      this.custInfoButton.UseVisualStyleBackColor = true;
      this.custInfoButton.Click += new System.EventHandler(this.custInfoButton_Click);
      // 
      // employeeInfoButton
      // 
      this.employeeInfoButton.Location = new System.Drawing.Point(265, 69);
      this.employeeInfoButton.Margin = new System.Windows.Forms.Padding(2);
      this.employeeInfoButton.Name = "employeeInfoButton";
      this.employeeInfoButton.Size = new System.Drawing.Size(266, 46);
      this.employeeInfoButton.TabIndex = 6;
      this.employeeInfoButton.Text = "Employee Information";
      this.employeeInfoButton.UseVisualStyleBackColor = true;
      this.employeeInfoButton.Click += new System.EventHandler(this.employeeInfoButton_Click);
      // 
      // toolRentalButton
      // 
      this.toolRentalButton.Location = new System.Drawing.Point(530, 69);
      this.toolRentalButton.Margin = new System.Windows.Forms.Padding(2);
      this.toolRentalButton.Name = "toolRentalButton";
      this.toolRentalButton.Size = new System.Drawing.Size(266, 46);
      this.toolRentalButton.TabIndex = 7;
      this.toolRentalButton.Text = "Tool Rental";
      this.toolRentalButton.UseVisualStyleBackColor = true;
      this.toolRentalButton.Click += new System.EventHandler(this.toolRentalButton_Click);
      // 
      // logOutLink
      // 
      this.logOutLink.AutoSize = true;
      this.logOutLink.Location = new System.Drawing.Point(995, 37);
      this.logOutLink.Name = "logOutLink";
      this.logOutLink.Size = new System.Drawing.Size(42, 13);
      this.logOutLink.TabIndex = 9;
      this.logOutLink.TabStop = true;
      this.logOutLink.Text = "LogOut";
      this.logOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOut_LinkClicked);
      // 
      // productInfoButton
      // 
      this.productInfoButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.productInfoButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.productInfoButton.FormattingEnabled = true;
      this.productInfoButton.ItemHeight = 13;
      this.productInfoButton.Items.AddRange(new object[] {
            "Replacement Parts Info",
            "Tool Info",
            "Stove Info"});
      this.productInfoButton.Location = new System.Drawing.Point(795, 69);
      this.productInfoButton.Name = "productInfoButton";
      this.productInfoButton.Size = new System.Drawing.Size(253, 19);
      this.productInfoButton.TabIndex = 14;
      this.productInfoButton.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.productInfoButton_DrawItem);
      this.productInfoButton.SelectedIndexChanged += new System.EventHandler(this.productInfoButton_SelectedIndexChanged);
      // 
      // Customer_Information_Page
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1048, 562);
      this.Controls.Add(this.productInfoButton);
      this.Controls.Add(this.logOutLink);
      this.Controls.Add(this.toolRentalButton);
      this.Controls.Add(this.employeeInfoButton);
      this.Controls.Add(this.custInfoButton);
      this.Controls.Add(this.theStovePlaceTitle);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.dataGridView);
      this.Controls.Add(this.navigatorToolStrip);
      this.Controls.Add(this.mainMenu);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MinimumSize = new System.Drawing.Size(1064, 601);
      this.Name = "Customer_Information_Page";
      this.ShowIcon = false;
      this.Text = "The Stove Place";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Cust_Info_Page_Load);
      this.Resize += new System.EventHandler(this.Cust_Info_Page_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.dgvContextMenu.ResumeLayout(false);
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.navigatorToolStrip.ResumeLayout(false);
      this.navigatorToolStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    private System.Windows.Forms.ComboBox productInfoButton;
    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
    private System.Windows.Forms.ToolStripMenuItem createListMenuItem;
    private System.Windows.Forms.ToolStripMenuItem createListAllMenuItem;
    private System.Windows.Forms.ToolStripMenuItem createListSelectedMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewListMenuItem;
    private System.Windows.Forms.ToolStripSeparator seperator1MenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
    private System.Windows.Forms.ContextMenuStrip dgvContextMenu;
    private System.Windows.Forms.ToolStripMenuItem addContextMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteContextMenuItem;
    private System.Windows.Forms.ToolStripSeparator editCellContextMenuItemSep;
    private System.Windows.Forms.ToolStripMenuItem editCellContextMenuItem;
    private System.Windows.Forms.ToolStrip navigatorToolStrip;
    private System.Windows.Forms.ToolStripButton navigatorMoveFirstButton;
    private System.Windows.Forms.ToolStripButton navigatorMovePrevButton;
    private System.Windows.Forms.ToolStripTextBox navigatorPositionTextBox;
    private System.Windows.Forms.ToolStripLabel navigatorCountLabel;
    private System.Windows.Forms.ToolStripButton navigatorMoveNextButton;
    private System.Windows.Forms.ToolStripButton navigatorMoveLastButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton navigatorAddButton;
    private System.Windows.Forms.ToolStripButton navigatorDeleteButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripLabel navigatorFindLabel;
    private System.Windows.Forms.ToolStripTextBox navigatorFindTextBox;
    private System.Windows.Forms.DataGridView dataGridView;
    //private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
    //private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
    //private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoCol;
    //private System.Windows.Forms.DataGridViewTextBoxColumn addressCol;
    //private System.Windows.Forms.DataGridViewTextBoxColumn cityCol;
    //private System.Windows.Forms.DataGridViewTextBoxColumn stateCol;
    //private System.Windows.Forms.DataGridViewTextBoxColumn zipCol;
    private System.Windows.Forms.Timer timer;
    //private bool suppressCellValidating;
    //private int timerListIndex;
  }
}