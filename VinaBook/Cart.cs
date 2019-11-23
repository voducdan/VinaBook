using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
namespace VinaBook
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }
        private List<int> _listBook = new List<int>();
        private List<int> _quantity = new List<int>();
        private void Cart_Load(object sender, EventArgs e)
        {
            try
            {
                String str = globalVeriable.GlobalVeriable;
                String path = @"D:\Projects\school\csdlnc-th1\DoAn2\vinabook\VinaBook\isLogin.txt";
                String isLogin = File.ReadAllText(path);
                isLogin = isLogin.Trim().Replace("\r\n", String.Empty);
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                String query = "SELECT * FROM KHACHHANG WHERE Ten_khach_hang = N'" + isLogin + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter idKhachHang = new SqlParameter();
                DataTable user = new DataTable();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(user);
                idKhachHang.ParameterName = "@Id_khach_hang";
                idKhachHang.SqlDbType = SqlDbType.Int;
                idKhachHang.Direction = ParameterDirection.Input;
                idKhachHang.Value = user.Rows[0][0];
                cmd = new SqlCommand("sp_XemGioHang", connection);
                cmd.Parameters.Add(idKhachHang);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable cart = new DataTable();
                da.Fill(cart);
                dataGridView1.DataSource = cart;
                numOfBook.Text = cart.Rows.Count.ToString();
                transportFee.Text = "Miễn phí";
                int soLuong = 0;
                float totalDueValue = 0;
                foreach (DataRow row in cart.Rows)
                {
                    try
                    {
                        String temp = row[5].ToString();
                        soLuong += Int32.Parse(temp);
                        totalDueValue += float.Parse(temp) * float.Parse(row[2].ToString());
                        totalDue.Text = totalDueValue.ToString();
                        _listBook.Add(Int32.Parse(row[0].ToString()));
                        _quantity.Add(Int32.Parse(row[5].ToString()));
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }
                }
                quantity.Text = soLuong.ToString();
                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }

        private void incBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    int temp = Int32.Parse(row.Cells[5].Value.ToString()) + 1;
                    float currentDue = float.Parse(totalDue.Text);
                    row.Cells[5].Value = temp;
                    int soluong = Int32.Parse(quantity.Text) + 1;
                    currentDue += float.Parse(row.Cells[2].Value.ToString());
                    quantity.Text = soluong.ToString();
                    numOfBook.Text = soluong.ToString();
                    totalDue.Text = currentDue.ToString();
                    decBtn.Enabled = true;
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    if (String.Compare(row.Cells[5].Value.ToString(), "0") != 0)
                    {
                        int temp = Int32.Parse(row.Cells[5].Value.ToString()) - 1;
                        float currentDue = float.Parse(totalDue.Text);
                        row.Cells[5].Value = temp;
                        if (String.Compare(row.Cells[5].Value.ToString(), "0") == 0)
                        {
                            decBtn.Enabled = false;
                        }
                        int soluong = Int32.Parse(quantity.Text) - 1;
                        currentDue -= float.Parse(row.Cells[2].Value.ToString());
                        quantity.Text = soluong.ToString();
                        numOfBook.Text = soluong.ToString();
                        totalDue.Text = currentDue.ToString();
                    }
                    
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int flag = 1;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (String.Compare(row.Cells[5].Value.ToString(), "0") == 0)
                {
                    decBtn.Enabled = false;
                    flag = 0;
                    break;
                }

            }
            if (flag == 1)
            {
                decBtn.Enabled = true;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
        }

        private void delBook_Click(object sender, EventArgs e)
        {
            String path = @"D:\Projects\school\csdlnc-th1\DoAn2\vinabook\VinaBook\isLogin.txt";
            String isLogin = File.ReadAllText(path);
            isLogin = isLogin.Trim().Replace("\r\n", String.Empty);
            String str = globalVeriable.GlobalVeriable;
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            String query = "SELECT * FROM KHACHHANG WHERE Ten_khach_hang = N'" + isLogin + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable book = new DataTable();
            da.Fill(book);
            int idKhachHang = Int32.Parse(book.Rows[0][0].ToString());
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    query = $"DELETE FROM GIOHANG WHERE Id_khach_hang = {idKhachHang} AND Id_sach = {row.Cells[0].Value.ToString()}";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    float totalDueValue = float.Parse(totalDue.Text);
                    totalDueValue -= float.Parse(row.Cells[2].Value.ToString()) * float.Parse(row.Cells[5].Value.ToString());
                    totalDue.Text = totalDueValue.ToString();
                    int tempQuantity = Int32.Parse(quantity.Text) - Int32.Parse(row.Cells[5].Value.ToString());
                    quantity.Text = tempQuantity.ToString();
                    int tempNumOfBook = Int32.Parse(numOfBook.Text) - Int32.Parse(row.Cells[5].Value.ToString());
                    numOfBook.Text = tempNumOfBook.ToString();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            cmd = new SqlCommand("sp_XemGioHang", connection);
            SqlParameter Id_khach_hang = new SqlParameter();
            Id_khach_hang.ParameterName = "@Id_khach_hang";
            Id_khach_hang.SqlDbType = SqlDbType.Int;
            Id_khach_hang.Direction = ParameterDirection.Input;
            Id_khach_hang.Value = idKhachHang;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(Id_khach_hang);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            book = new DataTable();
            da.Fill(book);
            dataGridView1.DataSource = book;
            dataGridView1.Update();
            dataGridView1.Refresh();
            connection.Close();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment pay = new payment();
            pay.TongTien(float.Parse(totalDue.Text));
            pay.Quantity(_quantity);
            pay.ListBook(_listBook);
            pay.ShowDialog();
            this.Close();
        }
    }
}
