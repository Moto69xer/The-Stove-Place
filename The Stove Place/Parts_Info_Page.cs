using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace The_Stove_Place
{
    public partial class Parts_Info_Page : Form
    {
        MySqlConnection con = new MySqlConnection(StringsUsed.connectionString);
        public Parts_Info_Page()
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

        private void Parts_Info_Page_Load(object sender, EventArgs e)
        {
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            partsInfoTitle.Location = new Point((this.Width / 2) - (partsInfoTitle.Size.Width / 2), partsInfoTitle.Location.Y);
            searchBar.Location = new Point(partsInfoTitle.Location.X + (partsInfoTitle.Width / 4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
            searchParamComboBox.SelectedIndex = 0;
            GetPartsList();
        }

        private void Parts_Info_Page_Resize(object sender, EventArgs e)
        {
            // this is to keep the login button near the edge of the screen
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            // this is to keep the Title in the center
            partsInfoTitle.Location = new Point((this.Width / 2) - (partsInfoTitle.Size.Width / 2), partsInfoTitle.Location.Y);
            searchBar.Location = new Point(partsInfoTitle.Location.X + (partsInfoTitle.Width / 4), searchBar.Location.Y);
            searchParamComboBox.Location = new Point(searchBar.Location.X - searchParamComboBox.Width - 15, searchParamComboBox.Location.Y);
            searchButton.Location = new Point(searchBar.Location.X + searchBar.Width + 10, searchButton.Location.Y);
        }

        private void GetPartsList()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            string select = "SELECT a.partId, a.description, a.price, a.stockLevel, a.partType, a.manufactureId, b.manufactureName, b.websiteLink, b.phoneNumber From Parts_and_Tools AS a LEFT JOIN Manufactures AS b ON a.manufactureId = b.manufactureId Where partType != \"tool\";";
            cmd = new MySqlCommand(select, con);
            adapter.SelectCommand = cmd;

            //FILL DS with Manufacture data
            adapter.Fill(ds, 0, 100, "Parts");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Part Id";
            dataGridView1.Columns[1].HeaderText = "Description";
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[3].HeaderText = "Stock Level";
            dataGridView1.Columns[4].HeaderText = "Part Type";
            dataGridView1.Columns[5].HeaderText = "Manufacture Id";
            dataGridView1.Columns[6].HeaderText = "Manufacture Name";
            dataGridView1.Columns[7].HeaderText = "Website";
            dataGridView1.Columns[8].HeaderText = "Phone Number";

            for (int i = 0; i <= 8; i++)
            { 
            this.dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

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
                    GetPartsList();
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
                    quaryString = $"SELECT a.partId, a.description, a.price, a.stockLevel, a.partType, a.manufactureId, b.manufactureName, b.websiteLink, b.phoneNumber From Parts_and_Tools AS a LEFT JOIN Manufactures AS b ON a.manufactureId = b.manufactureId Where partType != \"tool\" AND partId = '{searchString}';";
                    break;
                case 1:
                    quaryString = $"SELECT a.partId, a.description, a.price, a.stockLevel, a.partType, a.manufactureId, b.manufactureName, b.websiteLink, b.phoneNumber From Parts_and_Tools AS a LEFT JOIN Manufactures AS b ON a.manufactureId = b.manufactureId Where partType != \"tool\" AND a.manufactureId = '{searchString}';";
                    break;
                case 2:
                    quaryString = $"SELECT a.partId, a.description, a.price, a.stockLevel, a.partType, a.manufactureId, b.manufactureName, b.websiteLink, b.phoneNumber From Parts_and_Tools AS a LEFT JOIN Manufactures AS b ON a.manufactureId = b.manufactureId Where partType != \"tool\" AND partType = '{searchString}';";
                    break;
                default:
                    quaryString = $"SELECT a.partId, a.description, a.price, a.stockLevel, a.partType, a.manufactureId, b.manufactureName, b.websiteLink, b.phoneNumber From Parts_and_Tools AS a LEFT JOIN Manufactures AS b ON a.manufactureId = b.manufactureId Where partType != \"tool\";";
                    break;
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            cmd = new MySqlCommand(quaryString, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, 0, 100, "Parts_and_Tools");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString = searchBar.Text;
            if (searchString == "")
            {
                GetPartsList();
            }
            else
            {
                Search(searchString);
            }
        }
    }
}

