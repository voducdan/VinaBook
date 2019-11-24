using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace VinaBook
{
    public partial class System_Admin : Form
    {
        public System_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String str = globalVeriable.GlobalVeriable;
                SqlConnection connection = new SqlConnection(str);
                connection.Open();

                SqlCommand cmd = new SqlCommand("sp_InfoDaiLy", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable agency = new DataTable();
                da.Fill(agency);
                dataGridView1.DataSource = agency;
                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String str = globalVeriable.GlobalVeriable;
                SqlConnection connection = new SqlConnection(str);
                connection.Open();

                SqlCommand cmd = new SqlCommand("sp_XepLoai_NhanVien", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable agency = new DataTable();
                da.Fill(agency);
                dataGridView1.DataSource = agency;
                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        private void searchStaffBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String str = globalVeriable.GlobalVeriable;
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                String param = searchStaff.Text;
                SqlCommand cmd = new SqlCommand("sp_Tim_NhanVien", connection);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Ten_nhan_vien";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = param;
                cmd.Parameters.Add(parameter);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void revenueBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            revenue newRevenue = new revenue();
            newRevenue.ShowDialog();    
        }

        private void warehouseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            warehouse newWarehouse = new warehouse();
            newWarehouse.ShowDialog();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            order newOrder = new order();
            newOrder.ShowDialog();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
            this.Close();
        }
    }
}
