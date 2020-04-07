using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using LibCustomer;
using LibDate;
using LibEnums;
using LibGArrayList;
using LibValidator;

namespace The_Stove_Place
{
    public partial class Customer_Information_Page : Form
    {
        private String[] arr;
        private Font myFont;
        static string connString = "Server=209.106.201.103;Database=group5;uid=dbstudent7;pwd=smartpage45";
        MySqlConnection con = new MySqlConnection(connString);

        public Customer_Information_Page()
        {
            InitializeComponent();
            myFont = new System.Drawing.Font("Microsoft Sans Serif", 8);
            arr = new String[4];
            arr[0] = "Replacement Parts Info";
            arr[1] = "Tool Info";
            arr[2] = "Stove Info";

            this.productInfoButton.DataSource = arr;
        }

        private void Cust_Info_Page_Load(object sender, EventArgs e)
        {
          logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
          theStovePlaceTitle.Location = new Point(this.Width / 2 - 120, theStovePlaceTitle.Location.Y);
          GetCustomersList();
        }

        private void Cust_Info_Page_Resize(object sender, EventArgs e)
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
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            // this is to keep the Title in the center
            theStovePlaceTitle.Location = new Point(this.Width / 2 - 120, theStovePlaceTitle.Location.Y);
        }

        //function to get the button width 
        private int getNewButtonWidth()
        {
            return this.Width / 4;
        }
        // this is for a button clicked to change screens{
        protected void logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Page page = new Login_Page();
            page.Show();
            this.Hide();
            //Application.Restart();
        }

        private void custInfoButton_Click(object sender, EventArgs e)
        {
            Customer_Information_Page page = new Customer_Information_Page();
            page.Show();
            this.Hide();
        }

        private void employeeInfoButton_Click(object sender, EventArgs e)
        {
            Employee_Information_Page page = new Employee_Information_Page();
            page.Show();
            this.Hide();
        }

        private void toolRentalButton_Click(object sender, EventArgs e)
        {
            Rental_Invoices_Page page = new Rental_Invoices_Page();
            page.Show();
            this.Hide();
        }
        
        private void GetCustomersList()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            string select = " SELECT firstName,lastname,address,city,state,zip FROM Customers;";
            cmd = new MySqlCommand(select, con);
            adapter.SelectCommand = cmd;

            //FILL DS with Manufacture data
            adapter.Fill(ds, 0, 100, "Customers");
            dataGridView.DataSource = ds.Tables[0];
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
                Parts_Info_Page page = new Parts_Info_Page();
                page.Show();
                this.Hide();
            }
            else if (productInfoButton.Text == "Tool Info")
            {
                Tools_Info_Page page = new Tools_Info_Page();
                page.Show();
                this.Hide();
            }
            else if (productInfoButton.Text == "Stove Info")
            {
                Stoves_Info_Page page = new Stoves_Info_Page();
                page.Show();
                this.Hide();
            }
        }
    }
}
