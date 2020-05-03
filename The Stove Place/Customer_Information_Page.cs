using System;

using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

using System.Windows.Forms;


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
          searchBar.Location = new Point(customerInfoTitle.Location.X + (customerInfoTitle.Width/4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
            refreshButton.Location = new Point(searchParamComboBox.Location.X - refreshButton.Width - 15, refreshButton.Location.Y);
            newCustLink.Location = new Point(this.Width - 200, newCustLink.Location.Y);
          customerInfoTitle.Location = new Point((this.Width / 2) - (customerInfoTitle.Size.Width / 2), customerInfoTitle.Location.Y);
          searchParamComboBox.SelectedIndex = 0;
          GetCustomersList();
        }

        private void Cust_Info_Page_Resize(object sender, EventArgs e)
        {
            // this is to keep the login button near the edge of the screen
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            searchBar.Location = new Point(customerInfoTitle.Location.X + (customerInfoTitle.Width / 4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            refreshButton.Location = new Point(searchParamComboBox.Location.X - refreshButton.Width - 15, refreshButton.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
            newCustLink.Location = new Point(this.Width - 200, newCustLink.Location.Y);
            // this is to keep the Title in the center
            customerInfoTitle.Location = new Point((this.Width / 2) - (customerInfoTitle.Size.Width / 2), customerInfoTitle.Location.Y);
        }
        
        private void GetCustomersList()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            string select = " SELECT customerId,firstName,lastname,address,city,state,zip FROM Customers;";
            cmd = new MySqlCommand(select, con);
            adapter.SelectCommand = cmd;

            //FILL DS with Manufacture data
            adapter.Fill(ds, 0, 100, "Customers");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Customer Id";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
            dataGridView1.Columns[3].HeaderText = "Address";
            dataGridView1.Columns[4].HeaderText = "City";
            dataGridView1.Columns[5].HeaderText = "State";
            dataGridView1.Columns[6].HeaderText =  "Zip";
            for (int i = 0; i <= 6; i++)
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
                    GetCustomersList();
                }
                else
                {
                    Search(searchString);
                }
            }
        }

        private void Search (string searchString)
        {
            string quaryString;
            
            switch (searchParamComboBox.SelectedIndex)
            {
                case 0:
                    quaryString = $"Select customerId,firstName,lastname,address,city,state,zip FROM Customers WHERE customerId = '{searchString}';";
                    break;
                case 1:
                    quaryString = $"Select customerId,firstName,lastname,address,city,state,zip FROM Customers WHERE firstName = '{searchString}';";
                    break;
                case 2:
                    quaryString = $"Select customerId,firstName,lastname,address,city,state,zip FROM Customers WHERE lastName = '{searchString}';";
                    break;
                case 3:
                    quaryString = $"Select customerId,firstName,lastname,address,city,state,zip FROM Customers WHERE address = '{searchString}';";
                    break;
                case 4:
                    quaryString = $"Select customerId,firstName,lastname,address,city,state,zip FROM Customers WHERE city = '{searchString}';";
                    break;
                case 5:
                    quaryString = $"Select customerId,firstName,lastname,address,city,state,zip FROM Customers WHERE state = '{searchString}';";
                    break;
                case 6:
                    quaryString = $"Select customerId,firstName,lastname,address,city,state,zip FROM Customers WHERE zip = '{searchString}';";
                    break;
                default:
                    quaryString = $"Select * From Customers;";
                    break;
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            cmd = new MySqlCommand(quaryString, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, 0, 100, "Customers");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString = searchBar.Text;
            if (searchString == "")
            {
                GetCustomersList();
            }
            else
            {
                Search(searchString);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetCustomersList();
        }
    }
}
