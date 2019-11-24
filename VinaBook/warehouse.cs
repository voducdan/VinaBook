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
    public partial class warehouse : Form
    {
        public warehouse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String str = globalVeriable.GlobalVeriable;
                SqlConnection connection = new SqlConnection(str);
                connection.Open();

                SqlCommand cmd = new SqlCommand("sp_ThongTinSach", connection);
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
                String str = globalVeriable.GlobalVeriable;
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                String param = searchBook.Text;
                SqlCommand cmd = new SqlCommand("sp_SachKho", connection);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Ten_sach";
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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new System_Admin().ShowDialog();
        }
    }
}
