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
    public partial class AdminDashboard : Form
    {
        string idUser;
        public AdminDashboard(string name)
        {
            InitializeComponent();
            this.idUser = name;
        }

        SqlServer sql = new SqlServer();

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void LoadDataNhanVien()
        {
            sql.MoKetNoi();
            string query = String.Format("select * from NHAN_VIEN where MA_NHAN_VIEN = '{0}'", this.idUser);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                labelName.Text = dr["HO_VA_TEN"].ToString();
                labelRoles.Text = dr["CHUC_VU"].ToString() == "admin" ? "Quản trị viên" : "Nhân viên";
            } else
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo");
                Application.Exit();
            }
            sql.DongKetNoi();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDataNhanVien();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            new BanHang(this.idUser).Show();
            this.Hide();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            new KhachHang(this.idUser).Show();
            this.Hide();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            new HoaDon(this.idUser).Show();
            this.Hide();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            new NhaCungCap(this.idUser).Show();
            this.Hide();
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            new LoaiHang(this.idUser).Show();
            this.Hide();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            new HangHoa(this.idUser).Show();
            this.Hide();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            new FormNhanVien(this.idUser).Show();
            this.Hide();
        }
    }
}
