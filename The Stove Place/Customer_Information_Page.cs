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

namespace The_Stove_Place
{
    public partial class Customer_Information_Page : Form
    {
        MySqlConnection con = new MySqlConnection(StringsUsed.connectionString);

        public Customer_Information_Page()
        {
            InitializeComponent();
        }

        protected void logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          Application.Restart();
        }

        protected void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        protected void newCustLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Add_Page addCust = new Customer_Add_Page();
            addCust.ShowDialog();
        }

        private void Cust_Info_Page_Load(object sender, EventArgs e)
        {
          logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
          backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
          newCustLink.Location = new Point(this.Width - 200, newCustLink.Location.Y);
          //customerInfoTitle.Location = new Point(this.Width / 2 - 120, customerInfoTitle.Location.Y);
          customerInfoTitle.Location = new Point((this.Width / 2) - (customerInfoTitle.Size.Width / 2), customerInfoTitle.Location.Y);
          GetCustomersList();
        }

        private void Cust_Info_Page_Resize(object sender, EventArgs e)
        {
            // this is to keep the login button near the edge of the screen
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            newCustLink.Location = new Point(this.Width - 200, newCustLink.Location.Y);
            // this is to keep the Title in the center
            customerInfoTitle.Location = new Point((this.Width / 2) - (customerInfoTitle.Size.Width / 2), customerInfoTitle.Location.Y);
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
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
