using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace The_Stove_Place
{
    public partial class Login_Page : Form
    {
        string passwordFound;
        public static string username;
        public Login_Page()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameInputTextbox.Text;
            CheckPassword(StringsUsed.connectionString);

            if (passwordInputTextbox.Text == passwordFound)
            {
                this.Hide();
                Main_Menu_Page mainMenu = new Main_Menu_Page();
                mainMenu.ShowDialog();
            }

            else
            {
                MessageBox.Show("Login failed. Please verify information an try again.");
            }
        }

        private void CheckPassword(string connectionString)
        {
            string queryString = $"Select userPassword FROM Employees WHERE userName = '{username}';";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(queryString, connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        passwordFound = (String.Format("{0}", reader[0]));
                    }
                }
                MessageBox.Show(passwordFound);
                connection.Close();
                command.Dispose();
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            Employee_Add_Page addEmp = new Employee_Add_Page();
            addEmp.ShowDialog();
        }
    }
}
// to add the sql.data run this nuget packet console --> "Install-Package MySql.Data -Version 8.0.19"
