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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void orderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String selectedItem = orderStatus.Items[orderStatus.SelectedIndex].ToString();
                String str = "Data Source=DESKTOP-QA7C0NU;Initial Catalog=Vinabook;User ID=binhnguyen;Password=binh123";
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                SqlParameter parameter = new SqlParameter();
                SqlCommand cmd = new SqlCommand("sp_TinhTranhDonHang", connection);
                parameter.ParameterName = "@Trang_thai";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = selectedItem;
                cmd.Parameters.Add(parameter);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable book = new DataTable();
                da.Fill(book);
                dataGridView1.DataSource = book;
                connection.Close();
                
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedItem = orderStatus.Items[orderStatus.SelectedIndex].ToString();
                String str = "Data Source=DESKTOP-QA7C0NU;Initial Catalog=Vinabook;User ID=binhnguyen;Password=binh123";
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                SqlParameter parameter = new SqlParameter();
                SqlCommand cmd = new SqlCommand("sp_ThongKeTinhTrang", connection);
                parameter.ParameterName = "@Trang_thai";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = selectedItem;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(parameter);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new System_Admin().ShowDialog();
        }
    }
}
