using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace The_Stove_Place
{
    public partial class Login_Page : Form
    {
        string passwordFound;
        public Login_Page()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            CheckPassword("Server=209.106.201.103;Database=group5;uid=dbstudent21;pwd=thinbrick54");

            if (passwordInputTextbox.Text == (passwordFound).Trim())
            {
                MessageBox.Show("You have been logged in successfully!");
                Main_Menu_Page page = new Main_Menu_Page();
                page.Show();
                this.Hide();
            }
            //"Select pasword"
        }

        private void CheckPassword(string connectionString)
        {
            string queryString =
                $"Select userPassword FROM Employees WHERE firstName = '{usernameInputTextbox.Text}';";
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
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            //Open employee add page
        }
    }
}
// to add the sql.data run this nuget packet console --> "Install-Package MySql.Data -Version 8.0.19"
