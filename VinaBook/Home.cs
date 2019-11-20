using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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
            search Search = new search();
            Search.showResult(ref searchInput);
            Search.ShowDialog();
            this.Close();
        }

        private void typeOfBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = typeOfBook.Items[typeOfBook.SelectedIndex].ToString();
            try
            {
                String str = "Data Source=DESKTOP-SEKM9M5\\SQLEXPRESS;Initial Catalog=Vinabook;User ID=danvo;Password=Voducdantiep.1";
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_TimSach", connection);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@tenloaisach";
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
                SqlCommand cmd1 = new SqlCommand("sp_DanhMuc_Sach", connection);

                SqlDataReader reader;
                DataTable dm = new DataTable();
                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@tenloaisach";
                parameter2.SqlDbType = SqlDbType.NVarChar;
                parameter2.Direction = ParameterDirection.Input;
                parameter2.Value = selectedItem;
                cmd1.Parameters.Add(parameter2);
                cmd1.CommandType = CommandType.StoredProcedure;
                reader = cmd1.ExecuteReader();
                dm.Columns.Add("danhmuc", typeof(String));
                dm.Columns.Add("Ten_danh_muc", typeof(String));
                dm.Load(reader);
                danhmuc.ValueMember = "danhmuc";
                danhmuc.DisplayMember = "Ten_danh_muc";
                danhmuc.DataSource = dm;
                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = danhmuc.Items[danhmuc.SelectedIndex].ToString();

            try
            {
                String str = "Data Source=DESKTOP-SEKM9M5\\SQLEXPRESS;Initial Catalog=Vinabook;User ID=danvo;Password=Voducdantiep.1";
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_Sach_DanhMuc", connection);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@tendanhmuc";
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
                MessageBox.Show("Close");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
