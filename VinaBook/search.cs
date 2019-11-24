using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace VinaBook
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }
        public void showResult(ref TextBox searchText)
        {
            try
            {
                String str = globalVeriable.GlobalVeriable;
                String param = searchText.Text;
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemSachTheoTen", connection);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@noidung";
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            this.showResult(ref searchInput);
        }
    }
}
