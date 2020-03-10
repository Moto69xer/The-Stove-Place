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
        static string connString = "Server=209.106.201.103;Database=group5;uid=dbstudent7;pwd=smartpage45";
        MySqlConnection con = new MySqlConnection(connString);

        public Employee_Information_Page()
        {
            InitializeComponent();
        }

        protected void logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void Employee_Information_Page_Load(object sender, EventArgs e)
        {
            theStovePlaceTitle.Location = new Point((this.Width / 2) - (theStovePlaceTitle.Size.Width /2) , theStovePlaceTitle.Location.Y);
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            GetManufacturesList();
        }

        private void Employee_Information_Page_Resize(object sender, EventArgs e)
        {
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
