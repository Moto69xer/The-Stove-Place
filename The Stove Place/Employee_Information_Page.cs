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
            employeeInfoTitle.Location = new Point((this.Width / 2) - (employeeInfoTitle.Size.Width /2) , employeeInfoTitle.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            addUserButton.Location = new Point(backLink.Location.X - 118, addUserButton.Location.Y);
            searchBar.Location = new Point(employeeInfoTitle.Location.X + (employeeInfoTitle.Width / 4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            refreshButton.Location = new Point(searchParamComboBox.Location.X - refreshButton.Width - 15, refreshButton.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
            GetEmployeeList();
            searchParamComboBox.SelectedIndex = 0;
        }

        private void Employee_Information_Page_Resize(object sender, EventArgs e)
        {
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            addUserButton.Location = new Point(backLink.Location.X - 90, addUserButton.Location.Y);
            employeeInfoTitle.Location = new Point((this.Width / 2) - (employeeInfoTitle.Size.Width / 2), employeeInfoTitle.Location.Y);
            searchBar.Location = new Point(employeeInfoTitle.Location.X + (employeeInfoTitle.Width / 4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            refreshButton.Location = new Point(searchParamComboBox.Location.X - refreshButton.Width - 15, refreshButton.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
        }
        private void GetEmployeeList()
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
            dataGridView1.Columns[0].HeaderText = "Employee ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Phone Number";

            for (int i = 0; i <= 4; i++)
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void searchBar_Click(object sender, EventArgs e)
        {
            searchBar.SelectionStart = 0;
            searchBar.SelectionLength = searchBar.Text.Length;
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            string searchString = searchBar.Text;
            if (e.KeyData == Keys.Enter)
            {
                if (searchString == "" || searchString == "Search")
                {
                    GetEmployeeList();
                }
                else
                {
                    Search(searchString);
                }
            }
        }

        private void Search(string searchString)
        {
            string quaryString;

            switch (searchParamComboBox.SelectedIndex)
            {
                case 0:
                    quaryString = $"Select employeeId,firstName,lastname,email,phoneNumber FROM Employees WHERE employeeId = '{searchString}';";
                    break;
                case 1:
                    quaryString = $"Select employeeId,firstName,lastname,email,phoneNumber FROM Employees WHERE firstName = '{searchString}';";
                    break;
                case 2:
                    quaryString = $"Select employeeId,firstName,lastname,email,phoneNumber FROM Employees WHERE lastName = '{searchString}';";
                    break;
                case 3:
                    quaryString = $"Select employeeId,firstName,lastname,email,phoneNumber FROM Employees WHERE email = '{searchString}';";
                    break;
                case 4:
                    quaryString = $"Select employeeId,firstName,lastname,email,phoneNumber FROM Employees WHERE phoneNumber = '{searchString}';";
                    break;
                default:
                    quaryString = $"Select * From Employees;";
                    break;
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            cmd = new MySqlCommand(quaryString, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, 0, 100, "Employees");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString = searchBar.Text;
            if (searchString == "")
            {
                GetEmployeeList();
            }
            else
            {
                Search(searchString);
            }
        }private void addUserButton_Click(object sender, EventArgs e)
        {
            Employee_Add_Page addEmp = new Employee_Add_Page();
            addEmp.ShowDialog();
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetEmployeeList();
        }
    }
}
