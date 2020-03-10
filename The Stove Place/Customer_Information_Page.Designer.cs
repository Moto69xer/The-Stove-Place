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
            this.mainMenuReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuReturn
            // 
            this.mainMenuReturn.Location = new System.Drawing.Point(12, 12);
            this.mainMenuReturn.Name = "mainMenuReturn";
            this.mainMenuReturn.Size = new System.Drawing.Size(120, 30);
            this.mainMenuReturn.TabIndex = 0;
            this.mainMenuReturn.Text = "Back to home";
            this.mainMenuReturn.UseVisualStyleBackColor = true;
            this.mainMenuReturn.Click += new System.EventHandler(this.mainMenuReturn_Click);
            // 
            // Customer_Information_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuReturn);
            this.Name = "Customer_Information_Page";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenuReturn;
    }
}