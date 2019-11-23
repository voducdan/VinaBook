using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
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
            try
            {
                String selectedItem = typeOfBook.Items[typeOfBook.SelectedIndex].ToString();
                String str = globalVeriable.GlobalVeriable;
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
                danhmuc.Items.Clear();
                while (reader.Read())
                {
                    danhmuc.Items.Add(reader[1]);
                };
                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                String selectedItem = danhmuc.Items[danhmuc.SelectedIndex].ToString();
                String str = globalVeriable.GlobalVeriable;
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
                if (String.Compare(selectedItem, "System.Data.DataRowView", true) < 0)
                {
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable book = new DataTable();
                    da.Fill(book);
                    dataGridView1.DataSource = book;
                }

                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            String path = @"D:\Projects\school\csdlnc-th1\DoAn2\vinabook\VinaBook\isLogin.txt";
            String isLogin = File.ReadAllText(path);
            isLogin = isLogin.Trim().Replace("\r\n", String.Empty);
            if (String.Compare(isLogin, "", true) == 0)
            {
                loginBtn.Visible = true;
                signUpBtn.Visible = true;
                username.Visible = false;
                logoutBtn.Visible = false;
            }
            else
            {
                loginBtn.Visible = false;
                signUpBtn.Visible = false;
                username.Visible = true;
                logoutBtn.Visible = true;
                username.Text = isLogin;
            }
            String str = globalVeriable.GlobalVeriable;
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SACH", connection);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable book = new DataTable();
            da.Fill(book);
            dataGridView1.DataSource = book;
            connection.Close();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            String path = @"D:\Projects\school\csdlnc-th1\DoAn2\vinabook\VinaBook\isLogin.txt";
            File.WriteAllText(path, "");
            this.Close();
            this.ShowDialog();
        }

        private void bestSaler_Click(object sender, EventArgs e)
        {
            String str = globalVeriable.GlobalVeriable;
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_SachMoiPhatHanh", connection);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable book = new DataTable();
            da.Fill(book);
            dataGridView1.DataSource = book;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            String str = globalVeriable.GlobalVeriable;
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            
            //dataGridView1.DataSource = book;
            int index = dataGridView1.SelectedRows.Count;
            if(index > 0)
            {
                String path = @"D:\Projects\school\csdlnc-th1\DoAn2\vinabook\VinaBook\isLogin.txt";
                String isLogin = File.ReadAllText(path);
                isLogin = isLogin.Trim().Replace("\r\n", String.Empty);
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    try
                    {
                        string Id = row.Cells[0].Value.ToString();
                        String query = "SELECT * FROM KHACHHANG WHERE Ten_khach_hang = N'" + isLogin + "'";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable book = new DataTable();
                        da.Fill(book);
                        cmd = new SqlCommand("sp_ThemSachVaoGioHang", connection);
                        SqlParameter idKhachHang = new SqlParameter();
                        idKhachHang.ParameterName = "@Id_khach_hang";
                        idKhachHang.SqlDbType = SqlDbType.Int;
                        idKhachHang.Direction = ParameterDirection.Input;
                        idKhachHang.Value = book.Rows[0][0];
                        cmd.Parameters.Add(idKhachHang);
                        SqlParameter idSach = new SqlParameter();
                        idSach.ParameterName = "@Id_sach";
                        idSach.SqlDbType = SqlDbType.Int;
                        idSach.Direction = ParameterDirection.Input;
                        idSach.Value = Id;
                        cmd.Parameters.Add(idSach);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }
                }
                MessageBox.Show("Thêm vào giỏ hàng thành công");
            }

        }

        private void cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cart().ShowDialog();
            this.Close();
        }
    }
}
