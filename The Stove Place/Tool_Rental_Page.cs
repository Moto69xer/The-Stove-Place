using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace The_Stove_Place
{
    public partial class Tool_Rental_Page : Form
    {
        MySqlConnection con = new MySqlConnection(StringsUsed.connectionString);
        public Tool_Rental_Page()
        {
            InitializeComponent();
        }
        string invoicenum,toolId;
        protected void logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        protected void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void Tool_Rental_Page_Load(object sender, EventArgs e)
        {
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            addInvoiceButton.Location = new Point(backLink.Location.X - 118, addInvoiceButton.Location.Y);
            toolRentalTitle.Location = new Point((this.Width / 2) - (toolRentalTitle.Size.Width / 2), toolRentalTitle.Location.Y);
            searchBar.Location = new Point(toolRentalTitle.Location.X + (toolRentalTitle.Width / 4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
            searchParamComboBox.SelectedIndex = 0;
            refreshButton.Location = new Point(searchParamComboBox.Location.X - refreshButton.Width - 15, refreshButton.Location.Y);
            GetRentalList();
        }

        private void Tool_Rental_Page_Resize(object sender, EventArgs e)
        {
            // this is to keep the login button near the edge of the screen
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            addInvoiceButton.Location = new Point(backLink.Location.X - 118, addInvoiceButton.Location.Y);
            // this is to keep the Title in the center
            toolRentalTitle.Location = new Point((this.Width / 2) - (toolRentalTitle.Size.Width / 2), toolRentalTitle.Location.Y);
            searchBar.Location = new Point(toolRentalTitle.Location.X + (toolRentalTitle.Width / 4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
            refreshButton.Location = new Point(searchParamComboBox.Location.X - refreshButton.Width - 15, refreshButton.Location.Y);
        }

        private void GetRentalList()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            string select = "SELECT rentalInvoice, employeeId, customerId, rentalToolId, dateOfRental, dateOfReturn, dayRented, rentalPayment, paymentTotal FROM Tool_Rentals;";
            cmd = new MySqlCommand(select, con);
            adapter.SelectCommand = cmd;

            //FILL DS with Manufacture data
            adapter.Fill(ds, 0, 100, "Parts");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Rental Invoice #";
            dataGridView1.Columns[1].HeaderText = "Employee Id";
            dataGridView1.Columns[2].HeaderText = "Customer Id";
            dataGridView1.Columns[3].HeaderText = "Rental Tool Id";
            dataGridView1.Columns[4].HeaderText = "Rental Date";
            dataGridView1.Columns[5].HeaderText = "Date of Return";
            dataGridView1.Columns[6].HeaderText = "Days Rented";
            dataGridView1.Columns[7].HeaderText = "Cost Per Day";
            dataGridView1.Columns[8].HeaderText = "Total Payment";
            for (int i = 0; i <= 8; i++)
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[7].DefaultCellStyle.Format = "c2";
            this.dataGridView1.Columns[8].DefaultCellStyle.Format = "c2";
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
                    GetRentalList();
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
                    quaryString = $"SELECT * FROM Tool_Rentals WHERE rentalInvoice = '{searchString}';";
                    break;
                case 1:
                    quaryString = $"SELECT * FROM Tool_Rentals WHERE employeeId = '{searchString}';";
                    break;
                case 2:
                    quaryString = $"SELECT * FROM Tool_Rentals WHERE customerId = '{searchString}';";
                    break;
                case 3:
                    quaryString = $"SELECT * FROM Tool_Rentals WHERE rentalToolId = '{searchString}';";
                    break;
                default:
                    quaryString = $"SELECT * FROM Tool_Rentals;";
                    break;
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            cmd = new MySqlCommand(quaryString, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, 0, 100, "Rental");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString = searchBar.Text;
            if (searchString == "")
            {
                GetRentalList();
            }
            else
            {
                Search(searchString);
            }
        }

        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            Add_Rental_Page addEmp = new Add_Rental_Page();
            addEmp.ShowDialog();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contexMenu = new ContextMenuStrip();
                contexMenu.Items.Add("Tool Returned? ");
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[currentMouseOverRow];
                    invoicenum = row.Cells[0].Value.ToString();
                    toolId = row.Cells[3].Value.ToString();
                }
                contexMenu.Show(dataGridView1, new Point(e.X, e.Y));
                contexMenu.ItemClicked += new ToolStripItemClickedEventHandler(
                    contexMenu_ItemClicked);

            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetRentalList();
        }

        void contexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            try
            {
                string updateString =
                    $"UPDATE Rentable_Tools SET rentalStatus = 0 WHERE rentalToolId = '{toolId}';";
                string updateString2 =
                    $"UPDATE Tool_Rentals SET dateOfReturn = CURDATE() WHERE rentalInvoice = '{invoicenum}';";
                {
                    MySqlCommand command = new MySqlCommand(
                        updateString, con);
                    con.Open();
                    command.ExecuteNonQuery();
                    MySqlCommand commands = new MySqlCommand(
                       updateString2, con);
                    commands.ExecuteNonQuery();
                    command.Dispose();
                    con.Close();
                }
                MessageBox.Show("Tool Returned!");
                GetRentalList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
