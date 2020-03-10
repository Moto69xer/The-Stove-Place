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
        string isAdmin = "0";
        public string connectionString = "Server=209.106.201.103;Database=group5;uid=dbstudent21;pwd=thinbrick54";
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
            string adminPassword = adminPasswordTextbox.Text;
            isNotAdmin.Checked = true;

            if (password != passwordConfirm || passwordConfirm == "")
            {
                MessageBox.Show("Passwords are blank or do not match!\nPlease try again.");
                passwordCheckTextbox.Clear();
            }

            else
            {
                if (adminPassword != "")
                {

                    CheckAdminPassword(connectionString);
                    if (adminPasswordFound != adminPassword)
                    {
                        MessageBox.Show("Admin info incorrect.");
                        adminUsernameTextbox.Clear();
                        adminPasswordTextbox.Clear();
                    }

                    else
                    {
                        /*string insertString =
                        $"INSERT INTO Employees VALUES(NULL,'{firstName}','{lastName}','{email}','{phone}','{username}','{password}', '{isAdmin}');";
                        using (MySqlConnection connection = new MySqlConnection(
                                   connectionString))
                        {
                            MySqlCommand command = new MySqlCommand(
                                insertString, connection);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            command.Dispose();
                        }*/
                        MessageBox.Show("Welcome to The Stove Place familiy!");
                        this.Close();
                        this.Show();
                    }
                }
                else
                {
                    /*string insertString =
                        $"INSERT INTO Employees VALUES(NULL,'{firstName}','{lastName}','{email}','{phone}','{username}','{password}', '{isAdmin}');";
                    using (MySqlConnection connection = new MySqlConnection(
                               connectionString))
                    {
                        MySqlCommand command = new MySqlCommand(
                            insertString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        command.Dispose();
                    }*/
                    MessageBox.Show("Welcome to The Stove Place familiy dude!");
                    this.Close();
                    this.Show();
                }
            }
        }
        private void CheckAdminPassword(string connectionString)
        {
            if (isAdminRadio.Checked == true)
            {

                /*string queryString =
                    $"Select userPassword FROM Employees WHERE userName = '{adminUsernameTextbox.Text}' AND isAdmin = '1';";
                using (MySqlConnection connection = new MySqlConnection(
                           connectionString))
                {
                    MySqlCommand getAdminInfo = new MySqlCommand(
                        queryString, connection);
                    connection.Open();
                    using (MySqlDataReader reader = getAdminInfo.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            adminPasswordFound = (String.Format("{0}", reader[0]));
                        }
                    }
                    connection.Close();
                    getAdminInfo.Dispose();
                }*/
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
