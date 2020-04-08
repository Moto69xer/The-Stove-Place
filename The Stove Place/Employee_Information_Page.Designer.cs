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
            this.theStovePlaceTitle = new System.Windows.Forms.Label();
            this.logOutLink = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // theStovePlaceTitle
            // 
            this.theStovePlaceTitle.AllowDrop = true;
            this.theStovePlaceTitle.AutoSize = true;
            this.theStovePlaceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theStovePlaceTitle.Location = new System.Drawing.Point(309, 31);
            this.theStovePlaceTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.theStovePlaceTitle.Name = "theStovePlaceTitle";
            this.theStovePlaceTitle.Size = new System.Drawing.Size(327, 37);
            this.theStovePlaceTitle.TabIndex = 1;
            this.theStovePlaceTitle.Text = "Employee Information";
            this.theStovePlaceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutLink
            // 
            this.logOutLink.AutoSize = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(838, 288);
            this.dataGridView1.TabIndex = 8;
            // 
            // backLink
            // 
            this.backLink.AutoSize = true;
            this.backLink.Location = new System.Drawing.Point(808, 71);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(41, 13);
            this.backLink.TabIndex = 9;
            this.backLink.TabStop = true;
            this.backLink.Text = "< Back";
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::The_Stove_Place.Properties.Resources.The_Stove_Place_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Employee_Information_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 422);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOutLink);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.theStovePlaceTitle);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(615, 421);
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
        private System.Windows.Forms.Label theStovePlaceTitle;
        private System.Windows.Forms.LinkLabel logOutLink;
        private System.Windows.Forms.LinkLabel backLink;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}