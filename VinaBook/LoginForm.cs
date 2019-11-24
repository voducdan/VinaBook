using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace VinaBook
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String str = globalVeriable.GlobalVeriable;
                String username = uname.Text;
                String password = pwd.Text;

                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                String query = "SELECT * FROM KHACHHANG WHERE Ten_dang_nhap='" + username + "'AND Mat_khau='" + password + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string isAdminPath = $"{Directory.GetCurrentDirectory()}\\isAdmin.txt";
                    if (String.Equals(username, globalVeriable.UserAdmin) && String.Equals(password, globalVeriable.PassAdmin))
                    {
                        File.WriteAllText(isAdminPath, "true");
                    }
                    string path = $"{Directory.GetCurrentDirectory()}\\isLogin.txt";
                    string isLogin = dt.Rows[0][1].ToString();
                    File.WriteAllText(path, isLogin);
                    this.Hide();
                    new Home().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                connection.Close();
            }

            catch (Exception es)

            {
                MessageBox.Show(es.Message);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
