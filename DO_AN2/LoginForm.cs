using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DO_AN2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlServer sql = new SqlServer();
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.MoKetNoi();
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            string query = String.Format("select * from NHAN_VIEN where USERNAME='{0}' and PASSWORD='{1}'", user, pass);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                MessageBox.Show("Đăng nhập thành công, bấm OK để tiếp tục", "Thông báo");
                //new AdminDashboard(dr[0].ToString()).Show();
                this.Hide();
                dr.Close();
                sql.DongKetNoi();
                
            } else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại!", "Thông báo");
                sql.DongKetNoi();
            }
        }
    }
}
