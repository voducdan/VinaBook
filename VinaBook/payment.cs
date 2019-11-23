using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
namespace VinaBook
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        private float _tongTien;
        private List<int> _listBook = new List<int>();
        private List<int> _quantity = new List<int>();
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cart().ShowDialog();
            this.Close();
        }
        public void TongTien(float tong)
        {
            _tongTien = tong;
        }
        public void ListBook(List<int> listBook)
        {
            _listBook = listBook;
        }
        public void Quantity(List<int> quantity)
        {
            _quantity = quantity;
        }
        private void continueBtn_Click(object sender, EventArgs e)
        {
            
            String hoten = name.Text;
            String dienthoai = phone.Text;
            String tinh = city.Text;
            String q = quan.Text;
            String p = phuong.Text;
            String maGiamGia = magiamgia.Text;
            if (String.Equals(maGiamGia, ""))
            {
                maGiamGia = "NULL";
            }
            String phuongThucThanhToan = phuongthucthanhtoan.Items[phuongthucthanhtoan.SelectedIndex].ToString();
                String soThe = "NULL";
            if (String.Compare(phuongThucThanhToan, "Tiền mặt") != 0)
            {
                soThe = sothe.Text;
            }
            String ghiChu = ghichugiaohang.Text;
            bool bocSach = bocsach.Checked;
            bool goiQua = goiqua.Checked;
            bool xuatHoaDon = xuathoadon.Checked;

            try
            {


                String str = globalVeriable.GlobalVeriable;
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                String path = @"D:\Projects\school\csdlnc-th1\DoAn2\vinabook\VinaBook\isLogin.txt";
                String isLogin = File.ReadAllText(path);
                isLogin = isLogin.Trim().Replace("\r\n", String.Empty);
                String query = "SELECT * FROM KHACHHANG WHERE Ten_khach_hang = N'" + isLogin + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter idKhachHang = new SqlParameter();
                DataTable user = new DataTable();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(user);
                int Id_khach_hang = Int32.Parse(user.Rows[0][0].ToString());
                query = "select MAX(Id_hoa_don) from HOADON";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable idMax = new DataTable();
                da.Fill(idMax);
                int Id = Int32.Parse(idMax.Rows[0][0].ToString()) + 1;
                String day = DateTime.UtcNow.Date.ToString("yyyy-MM-dd");
                query = $"INSERT INTO HOADON VALUES({Id},'{day}','{day}',N'Đã nhận đơn',{Id_khach_hang},N'{phuongThucThanhToan}','{soThe}',{_tongTien},'{maGiamGia}')";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                
                foreach (int book in _listBook)
                {
                    cmd = new SqlCommand($"select Id_khach_hang from DANGKY_SACH where Id_sach = {book}", connection);
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    query = $"INSERT INTO HOADONCHITIET VALUES ({Id},{Id},{_tongTien})";
                    query = $"INSERT INTO HOADONCHITIET VALUES ({Id},{Id},{_tongTien}, {Int32.Parse(dt.Rows[0][0].ToString())})";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    int index = 0;
                    query = $"INSERT INTO HOADONCHITIET_SACH VALUES ({Id},{book},{_quantity[index]},{Int32.Parse(dt.Rows[0][0].ToString())})";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    index++;
                }
                if (bocSach)
                {
                    cmd = new SqlCommand($"INSERT INTO HOADONCHITIET_DICHVU VALUES(${Id},{2})", connection);
                }
                if (goiQua)
                {
                    cmd = new SqlCommand($"INSERT INTO HOADONCHITIET_DICHVU VALUES(${Id},{3})", connection);
                }
                if (xuatHoaDon)
                {
                    cmd = new SqlCommand($"INSERT INTO HOADONCHITIET_DICHVU VALUES(${Id},{4})", connection);
                }
                cmd = new SqlCommand("select MAX(Id_phieu_giao_hang) from PHIEUGIAOHANG", connection);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable idPGHMax = new DataTable();
                da.Fill(idPGHMax);
                int PGHMax = Int32.Parse(idPGHMax.Rows[0][0].ToString()) + 1;
                cmd = new SqlCommand($"INSERT INTO PHIEUGIAOHANG VALUES ({PGHMax},{Id},{Id_khach_hang},{phone},{p},{q},{city},{_tongTien},'Miễn phí',{new Random().Next(101, 200)})", connection);
                connection.Close();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"DELETE FROM GIOHANG WHERE Id_khach_hang = {Id_khach_hang}", connection);
                this.Hide();
                new Home().ShowDialog();
                this.Close();
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }

        private void payment_Load(object sender, EventArgs e)
        {
            sothe.Visible = false;
            sothelable.Visible = false;
            phuongthucthanhtoan.SelectedIndex = 0;
        }

        private void phuongthucthanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            String phuongThucThanhToan = phuongthucthanhtoan.Items[phuongthucthanhtoan.SelectedIndex].ToString();
            if (String.Equals(phuongThucThanhToan, "Tiền mặt"))
            {
                sothe.Visible = false;
                sothelable.Visible = false;
            }
            else
            {
                sothe.Visible = true;
                sothelable.Visible = true;
            }
        }
    }
}
