using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace The_Stove_Place
{
    public partial class Login_Page : Form
    {
        string passwordFound;
        public string connectionString = "Server=209.106.201.103;Database=group5;uid=dbstudent21;pwd=thinbrick54";
        public Login_Page()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            CheckPassword(connectionString);

            if (passwordInputTextbox.Text == passwordFound)
            {
                MessageBox.Show("You have been logged in successfully!");
                Main_Menu_Page main_Menu = new Main_Menu_Page();
                main_Menu.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Login failed. Please verify information.");
            }
            //"Select pasword"
        }

        private void CheckPassword(string connectionString)
        {
            string queryString =
                $"Select userPassword FROM Employees WHERE userName = '{usernameInputTextbox.Text}';";
            using (MySqlConnection connection = new MySqlConnection(
                       connectionString))
            {
                MySqlCommand command = new MySqlCommand(
                    queryString, connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        passwordFound = (String.Format("{0}", reader[0]));
                    }
                }
                connection.Close();
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            Employee_Add_Page employee_Add = new Employee_Add_Page();
            employee_Add.Show();
        }
    }
}
// to add the sql.data run this nuget packet console --> "Install-Package MySql.Data -Version 8.0.19"
