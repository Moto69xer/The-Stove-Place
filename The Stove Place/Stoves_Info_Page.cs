using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace The_Stove_Place
{
    public partial class Stoves_Info_Page : Form
    {
        MySqlConnection con = new MySqlConnection(StringsUsed.connectionString);
        public Stoves_Info_Page()
        {
            InitializeComponent();
        }
        protected void logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        protected void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void Stoves_Info_Page_Load(object sender, EventArgs e)
        {
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            stovesInfoTitle.Location = new Point((this.Width / 2) - (stovesInfoTitle.Size.Width / 2), stovesInfoTitle.Location.Y);
            searchBar.Location = new Point(stovesInfoTitle.Location.X + (stovesInfoTitle.Width / 4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
            searchParamComboBox.SelectedIndex = 0;
            GetStovesList();
        }

        private void Stoves_Info_Page_Resize(object sender, EventArgs e)
        {
            // this is to keep the login button near the edge of the screen
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            // this is to keep the Title in the center
            stovesInfoTitle.Location = new Point((this.Width / 2) - (stovesInfoTitle.Size.Width / 2), stovesInfoTitle.Location.Y);
            searchBar.Location = new Point(stovesInfoTitle.Location.X + (stovesInfoTitle.Width / 4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
        }

        private void GetStovesList()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            string select = "Select * From Stoves Left Join Manufactures USING (manufactureId);";
            cmd = new MySqlCommand(select, con);
            adapter.SelectCommand = cmd;

            //FILL DS with Manufacture data
            adapter.Fill(ds, 0, 100, "Stoves");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Manufacture ID";
            dataGridView1.Columns[1].HeaderText = "Stove ID";
            dataGridView1.Columns[2].HeaderText = "Model Number";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].HeaderText = "Manufacture Date";
            dataGridView1.Columns[5].HeaderText = "Color";
            dataGridView1.Columns[6].HeaderText = "Manufacture Name";
            dataGridView1.Columns[7].HeaderText = "Manufacture Website";
            dataGridView1.Columns[8].HeaderText = "Manufacture Phone Number";
            for (int i = 0; i <= 8; i++)
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
                    GetStovesList();
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
                    quaryString = $"Select * From Stoves Left Join Manufactures USING (manufactureId) WHERE stoveId = '{searchString}';";
                    break;
                case 1:
                    quaryString = $"Select * From Stoves Left Join Manufactures USING (manufactureId) WHERE stoveModelNumber = '{searchString}';";
                    break;
                case 2:
                    quaryString = $"Select * From Stoves Left Join Manufactures USING (manufactureId) WHERE manufactureDate = '{searchString}';";
                    break;
                case 3:
                    quaryString = $"Select * From Stoves Left Join Manufactures USING (manufactureId) WHERE color = '{searchString}';";
                    break;
                case 4:
                    quaryString = $"Select * From Stoves Left Join Manufactures USING (manufactureId) WHERE manufactureId = '{searchString}';";
                    break;
                case 5:
                    quaryString = $"Select * From Stoves Left Join Manufactures USING (manufactureId) WHERE manufactureName = '{searchString}';";
                    break;
                default:
                    quaryString = $"Select * From Stoves Left Join Manufactures USING (manufactureId);";
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
                GetStovesList();
            }
            else
            {
                Search(searchString);
            }
        }
    }
}
