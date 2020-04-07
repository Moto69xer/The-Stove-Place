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

namespace The_Stove_Place
{
    public partial class Employee_Add_Page : Form
    {
        string adminPasswordFound;
        string isAdminFound;
        string isAdmin = "0";
        public Employee_Add_Page()
        {
            InitializeComponent();
            isNotAdmin.Checked = true;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string lastName = lastNameTextbox.Text;
            string email = emailAddressTextbox.Text;
            string phone = phoneNumberTextbox.Text;
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            string passwordConfirm = passwordCheckTextbox.Text;
            string adminUsername = adminUsernameTextbox.Text;
            string adminPassword = adminPasswordTextbox.Text;
            isNotAdmin.Checked = true;

            if (firstName == "")
            {
                firstNameLabel.ForeColor = Color.Red;
            }

            if (lastName == "")
            {
                lastNameLabel.ForeColor = Color.Red;
            }

            if (email == "")
            {
                emailAddressLabel.ForeColor = Color.Red;
            }

            if (phone == "")
            {
                phoneNumberLabel.ForeColor = Color.Red;
            }

            if (username == "")
            {
                usernameLabel.ForeColor = Color.Red;
            }

            if (password != passwordConfirm || passwordConfirm == "")
            {
                passwordLabel.ForeColor = Color.Red;
                passwordLabel2.ForeColor = Color.Red;
                MessageBox.Show("Passwords are blank or do not match!\nPlease try again.");
                passwordCheckTextbox.Clear();
            }

            else
            {
                if (isAdmin == "1")
                {
                    if (adminPassword != "" || adminUsername != "")
                    {
                        CheckAdminPassword(StringsUsed.connectionString, adminUsername);
                        if (adminPasswordFound != adminPassword)
                        {
                            MessageBox.Show("Admin info incorrect.");
                            adminPasswordTextbox.Clear();
                        }
                        else
                        {
                            string insertString =
                            $"INSERT INTO Employees VALUES(NULL,'{firstName}','{lastName}','{email}','{phone}','{username}','{password}', '{isAdmin}');";
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
                            MessageBox.Show("Welcome to The Stove Place family!");
                            this.Close();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Admin Username or Password Blank!\nPlease try Again");
                    }
                }
                else
                {
                    string insertString =
                    $"INSERT INTO Employees VALUES(NULL,'{firstName}','{lastName}','{email}','{phone}','{username}','{password}', '{isAdmin}');";
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
                    MessageBox.Show("Welcome to The Stove Place family!");
                    this.Close();
                    this.Show();
                }
            }
        }
        private void CheckAdminPassword(string connectionString, string adminUsername)
        {

                string queryString = $"Select userPassword, isAdmin FROM Employees WHERE userName = '{adminUsername}' AND isAdmin = 1";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand getAdminInfo = new MySqlCommand(queryString, connection);
                    connection.Open();
                    using (MySqlDataReader reader = getAdminInfo.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            adminPasswordFound = (String.Format("{0}", reader[0]));
                            isAdminFound = (String.Format("{0}", reader[1]));
                        }
                    }
                    connection.Close();
                    getAdminInfo.Dispose();
                }
        }

        private void isAdminRadio_CheckedChanged(object sender, EventArgs e)
        {
            isAdmin = "1";
            adminUsernameTextbox.Enabled = true;
            adminPasswordTextbox.Enabled = true;
        }

        private void isNotAdmin_CheckedChanged(object sender, EventArgs e)
        {
            isAdmin = "0";
            adminUsernameTextbox.Enabled = false;
            adminPasswordTextbox.Enabled = false;
        }
    }
}
