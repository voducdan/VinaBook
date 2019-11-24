using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VinaBook
{
    public partial class revenue : Form
    {
        public revenue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = globalVeriable.GlobalVeriable;
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_DoanhThu_Nam", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable revenueYear = new DataTable();
            da.Fill(revenueYear);
            viewRevenueYear.DataSource = revenueYear;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = globalVeriable.GlobalVeriable;
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_Daily", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable RevenueAgency = new DataTable();
            da.Fill(RevenueAgency);
            viewRevenueAgency.DataSource = RevenueAgency;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new System_Admin().ShowDialog();
        }
    }
}
