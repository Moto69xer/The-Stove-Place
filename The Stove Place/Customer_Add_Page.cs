using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace The_Stove_Place
{
    public partial class Customer_Add_Page : Form
    {
        string isActive = "0";
        public Customer_Add_Page()
        {
            InitializeComponent();
            isNonActiveCustomer.Checked = true;
        }

        private void zipTextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(zipTextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                zipTextbox.Text = zipTextbox.Text.Remove(zipTextbox.Text.Length - 1);
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string lastName = lastNameTextbox.Text;
            string address = addressTextbox.Text;
            string city = cityTextbox.Text;
            string state = stateTextbox.Text;
            string zip = zipTextbox.Text;
            string email = emailAddressTextbox.Text;
            isNonActiveCustomer.Checked = true;

            if (firstName == "")
            {
                firstNameLabel.ForeColor = Color.Red;
            }

            if (lastName == "")
            {
                lastNameLabel.ForeColor = Color.Red;
            }

            if (address == "")
            {
                addressLabel.ForeColor = Color.Red;
            }

            if (city == "")
            {
                cityLabel.ForeColor = Color.Red;
            }

            if (state == "")
            {
                stateLabel.ForeColor = Color.Red;
            }

            if (zip == "")
            {
                zipLabel.ForeColor = Color.Red;
            }

            if (email == "")
            {
                emailAddressLabel.ForeColor = Color.Red;
            }

            if (isActive == "1")
            {
                string insertString =
                $"INSERT INTO Customers VALUES(NULL,'{firstName}','{lastName}','{address}','{city}','{state}','{zip}', '{email}', '{isActive}');";
                using (MySqlConnection connection = new MySqlConnection(
                           StringsUsed.connectionString))
                {
                    MySqlCommand command = new MySqlCommand(
                        insertString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    command.Dispose();
                }
                MessageBox.Show("New Customer Added!");
                this.Close();
                //this.Show();
            }
            else
            {
                string insertString =
                $"INSERT INTO Customers VALUES(NULL,'{firstName}','{lastName}','{address}','{city}','{state}','{zip}', '{email}', '{isActive}');";
                using (MySqlConnection connection = new MySqlConnection(
                           StringsUsed.connectionString))
                {
                    MySqlCommand command = new MySqlCommand(
                        insertString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    command.Dispose();
                }
                MessageBox.Show("New Customer Added!");
                this.Close();
                //this.Show();
            }
            MailMessage message;
            SmtpClient smtp;
            try
            {
                message = new MailMessage();
                message.To.Add(email);
                message.Subject = "The Stove Place Account Confirmation";
                message.From = new MailAddress("thestoveplace@gmail.com");
                message.Body = $"Hi {firstName} {lastName}, If you have recieved this email you have joined The Stove Place family. Congratulations! " +
                    "During a recent visit to our store, one of our great sales accociates entered you into our system to make " +
                    "renting and buy from us a warmer breeze (Pun intended) If you think you have recieved this email in error " +
                    "call us at our store 417-555-5555 or find our email on the web at TheStovePlace.com. Thanks!";

                // set smtp details
                smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 25;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("thestoveplace54@gmail.com", "thinbrick54");
                smtp.SendAsync(message, message.Subject);
                smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
        }

        private void isActiveCustomer_CheckedChanged(object sender, EventArgs e)
        {
            isActive = "1";
        }

        private void isNonActiveCustomer_CheckedChanged(object sender, EventArgs e)
        {
            isActive = "0";
        }
    }
}
