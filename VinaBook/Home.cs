using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace VinaBook
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 Search = new Form1();
            Search.showResult(ref searchInput);
            Search.ShowDialog();
            this.Close();
        }
    }
}
