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

namespace The_Stove_Place
{
    public partial class Employee_Information_Page : Form
    {
       
        MySqlConnection con = new MySqlConnection(StringsUsed.connectionString);

        public Employee_Information_Page()
        {
            InitializeComponent();
            MessageBox.Show("Hello fellow students on this page you can sign up to be part of The Stove Place. If you would like to enter your school email while adding a customer we can show you our account confirmation email system.");
        }

        protected void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        protected void logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void Employee_Information_Page_Load(object sender, EventArgs e)
        {
            theStovePlaceTitle.Location = new Point((this.Width / 2) - (theStovePlaceTitle.Size.Width /2) , theStovePlaceTitle.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            GetManufacturesList();
        }

        private void Employee_Information_Page_Resize(object sender, EventArgs e)
        {
           logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            theStovePlaceTitle.Location = new Point((this.Width / 2) - (theStovePlaceTitle.Size.Width / 2), theStovePlaceTitle.Location.Y);
        }
        private void GetManufacturesList()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            string select = " SELECT employeeId,firstName,lastName,email,phoneNumber FROM Employees;";
            cmd = new MySqlCommand(select, con);
            adapter.SelectCommand = cmd;

            //FILL DS with Manufacture data
            adapter.Fill(ds, 0, 100, "Employees");
            dataGridView1.DataSource = ds.Tables[0];
        }

    }
}
