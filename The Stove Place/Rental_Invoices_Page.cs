using System;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace The_Stove_Place
{
    public partial class Add_Rental_Page : Form
    {
        MySqlConnection con = new MySqlConnection(StringsUsed.connectionString);
        public Add_Rental_Page()
        {
            InitializeComponent();
            FillempNameComboBox();
            FillcustNameComboBox();
            FilltoolComboBox();

        }
        string employeeId,customerId,toolId,price;
        void FillempNameComboBox()
        {
            string Query = "Select firstName From Employees";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string employeeName = myReader.GetString("firstName");
                    empNameComboBox.Items.Add(employeeName);
                }
                con.Close();
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillcustNameComboBox()
        {
            string Query = "Select firstName From Customers";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();
                
                while (myReader.Read())
                {
                    string customerName = myReader.GetString("firstName");
                    custNameComboBox.Items.Add(customerName);
                }
                con.Close();
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FilltoolComboBox()
        {
            string Query = "SELECT a.rentalToolId, a.partId, b.description From Rentable_Tools AS a LEFT JOIN Parts_and_Tools AS b ON a.partId = b.partId WHERE a.rentalStatus = 0;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();
                
                while (myReader.Read())
                {
                    string tool = myReader.GetString("description");
                    toolComboBox.Items.Add(tool);
                }
                con.Close();
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Rental_Invoices_Page_Load(object sender, EventArgs e)
        {
            addRentalInvoicesTitle.Location = new Point((this.Width / 2) - (addRentalInvoicesTitle.Size.Width / 2), addRentalInvoicesTitle.Location.Y);
            DateTime dateTime = DateTime.UtcNow.Date;
            dateRentedResultLabel.Text = dateTime.ToString("yyyy/MM/dd");
        }

        private void Rental_Invoices_Page_Resize(object sender, EventArgs e)
        {
            // this is to keep the Title in the center
            addRentalInvoicesTitle.Location = new Point((this.Width / 2) - (addRentalInvoicesTitle.Size.Width / 2), addRentalInvoicesTitle.Location.Y);
        }

        private void empNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "Select employeeId From Employees where firstName ='" + empNameComboBox.Text + "';";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    employeeId = myReader.GetString("employeeId");
                }
                con.Close();
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void custNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "Select customerId From Customers where firstName ='" + custNameComboBox.Text + "';";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    customerId = myReader.GetString("customerId");
                }
                con.Close();
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT a.rentalToolId, a.partId, a.rentalCostPerDay, b.description From Rentable_Tools AS a LEFT JOIN Parts_and_Tools AS b ON a.partId = b.partId where b.description ='" + toolComboBox.Text + "';";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    price = myReader.GetString("rentalCostPerDay");
                    priceResultLabel.Text = "$" + price;
                    toolId = myReader.GetString("rentalToolId");
                }
                con.Close();
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string insertString =
                    $"INSERT INTO Tool_Rentals VALUES(NULL,'{employeeId}','{customerId}','{toolId}',CURDATE(),NULL,'{float.Parse(price)}');";
                string updateString =
                    $"UPDATE Rentable_Tools SET rentalStatus = 1 WHERE rentalToolId = '{toolId}';";
                {
                    MySqlCommand command = new MySqlCommand(
                        insertString, con);
                    con.Open();
                    command.ExecuteNonQuery();
                    MySqlCommand commands = new MySqlCommand(
                        updateString, con);
                    commands.ExecuteNonQuery();
                    commands.Dispose();
                    con.Close();
                }
                MessageBox.Show("New Invoice Added!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
