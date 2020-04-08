using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace The_Stove_Place
{
    public partial class Tools_Info_Page : Form
    {
        static string connString = "Server=209.106.201.103;Database=group5;uid=dbstudent7;pwd=smartpage45";
        MySqlConnection con = new MySqlConnection(connString);
        public Tools_Info_Page()
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

        private void Tools_Info_Page_Load(object sender, EventArgs e)
        {
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            toolsInfoTitle.Location = new Point((this.Width / 2) - (toolsInfoTitle.Size.Width / 2), toolsInfoTitle.Location.Y);
            GetToolsList();
        }

        private void Tools_Info_Page_Resize(object sender, EventArgs e)
        {
            // this is to keep the login button near the edge of the screen
            logOutLink.Location = new Point(this.Width - 90, logOutLink.Location.Y);
            backLink.Location = new Point(this.Width - 90, backLink.Location.Y);
            // this is to keep the Title in the center
            toolsInfoTitle.Location = new Point((this.Width / 2) - (toolsInfoTitle.Size.Width / 2), toolsInfoTitle.Location.Y);
        }

        private void GetToolsList()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            MySqlCommand cmd;
            string select = "Select * From Parts_and_Tools Left Join Manufactures On Parts_and_Tools.manufactureId = Manufactures.manufactureId Where partType = \"tool\";";
            cmd = new MySqlCommand(select, con);
            adapter.SelectCommand = cmd;

            //FILL DS with Manufacture data
            adapter.Fill(ds, 0, 100, "Tools");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
