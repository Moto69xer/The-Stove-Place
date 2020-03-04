using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace The_Stove_Place
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string myconnectionstring = "Server=209.106.201.103;Database=group5;uid=dbstudent21;pwd=thinbrick54";
            MySqlConnection conn = new MySqlConnection(myconnectionstring);
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("connection opened");
                conn.Close();
            }
            //"Select pasword"
            if(passwordInputTextbox.Text == "696969")
            {
                this.Close();
                Main_Menu_Page.ActiveForm.Activate();
            }
        }
    }
}
