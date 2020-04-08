using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace The_Stove_Place
{
    public partial class Main_Menu_Page : Form
    {
        private String[] arr;
        private Font myFont;
        MySqlConnection con = new MySqlConnection(StringsUsed.connectionString);
        public Main_Menu_Page()
        {
            InitializeComponent();
            usernameLabel.Text = Login_Page.username.Trim();
            myFont = new System.Drawing.Font("Microsoft Sans Serif", 8);
            arr = new String[4];
            arr[0] = "Replacement Parts Info";
            arr[1] = "Tool Info";
            arr[2] = "Stove Info";
            GetManufacturesList();

            this.productInfoButton.DataSource = arr;

        }

        private void Main_Menu_Page_Resize(object sender, EventArgs e)
        {
            //this is for the buttons to be resized and fix its location{
            custInfoButton.Width = getNewButtonWidth();
            employeeInfoButton.Width = getNewButtonWidth();
            toolRentalButton.Width = getNewButtonWidth();
            productInfoButton.Width = getNewButtonWidth() - 15;
            employeeInfoButton.Location = new Point(custInfoButton.Width, employeeInfoButton.Location.Y);
            toolRentalButton.Location = new Point(custInfoButton.Width + employeeInfoButton.Width, toolRentalButton.Location.Y);
            productInfoButton.Location = new Point(custInfoButton.Width + employeeInfoButton.Width + toolRentalButton.Width, toolRentalButton.Location.Y);
            //}
            // this is to keep the login button near the edge of the screen
            usernameLabel.Location = new Point(this.Width - 90, usernameLabel.Location.Y);
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            // this is to keep the Title in the center
            theStovePlaceTitle.Location = new Point(this.Width / 2 - 200, theStovePlaceTitle.Location.Y);
            //this keeps the the data grid view {
            dataGridView1.Width = (int)((this.Width -30 ) * 0.60);
            dataGridView2.Width = (int)(0.385*(this.Width - 30));
            dataGridView1.Height = this.Height - 203;
            dataGridView2.Height = this.Height - 203;
            dataGridView1.Location = new Point(10, dataGridView1.Location.Y);
            dataGridView2.Location = new Point(dataGridView1.Width + 20, dataGridView1.Location.Y);
            //}
            //this is for the labes {
            recentRentalsLabel.Location = new Point(dataGridView1.Width / 2 - 60, recentRentalsLabel.Location.Y);
            manuContactLabel.Location = new Point(dataGridView2.Location.X, manuContactLabel.Location.Y);
            //}
        }

        //function to get the button width 
        private int getNewButtonWidth()
        {
            return this.Width / 4;
        }
        // this is for a button clicked to change screens{
        protected void logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void custInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello fellow students on this page you can sign up to be part of The Stove Place. If you would like to enter your school email while adding a customer we can show you our account confirmation email system.");
            Customer_Information_Page custInfo = new Customer_Information_Page();
            custInfo.ShowDialog();
        }

        private void employeeInfoButton_Click(object sender, EventArgs e)
        {
            Employee_Information_Page empInfo = new Employee_Information_Page();
            empInfo.ShowDialog();
        }

        private void toolRentalButton_Click(object sender, EventArgs e)
        {
            Rental_Invoices_Page rentInv = new Rental_Invoices_Page();
            rentInv.ShowDialog();
        }
        //}
        //This is for the combo box button{
        private void productInfoButton_DrawItem(object sender, DrawItemEventArgs e)
        {
            productInfoButton.ItemHeight = 38;
            if (e.Index == -1)
                e.Graphics.DrawString("Product Information", myFont, Brushes.Black, e.Bounds.X + 20, e.Bounds.Y + 14);
            if (e.Index > -1)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
                e.Graphics.DrawString(arr[e.Index], myFont, Brushes.Black, e.Bounds.X + 20, e.Bounds.Y + 14);
                if ((e.State & DrawItemState.Focus) == 0)
                {
                    e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
                    e.Graphics.DrawString(arr[e.Index], myFont, Brushes.Black, e.Bounds.X + 20, e.Bounds.Y + 14);
                }
            }
        }
    //}
        //this is for the combo box selected  to change pages 
        private void productInfoButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productInfoButton.Text == "Replacement Parts Info")
            {
                Parts_Info_Page proInfo = new Parts_Info_Page();
                proInfo.ShowDialog();
            }
            else if (productInfoButton.Text == "Tool Info")
            {
                Tools_Info_Page toolInfo = new Tools_Info_Page();
                toolInfo.ShowDialog();
            }
            else if (productInfoButton.Text == "Stove Info")
            {
                Stoves_Info_Page stoveInfo = new Stoves_Info_Page();
                stoveInfo.ShowDialog();
            }
        }

        private void GetManufacturesList()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            string select = " SELECT manufactureName,websiteLink,phoneNumber FROM Manufactures ORDER BY manufactureName;";
            cmd = new MySqlCommand(select, con);
            adapter.SelectCommand = cmd;

            //FILL DS with Manufacture data
            adapter.Fill(ds, 0, 50, "Manufactures");
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void Main_Menu_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
