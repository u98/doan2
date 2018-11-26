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
        string idUser = "NV01";
        /*public AdminDashboard(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }*/
        public AdminDashboard()
        {
            InitializeComponent();
        }
        SqlServer sql = new SqlServer();

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void LoadDataNhanVien()
        {
            sql.MoKetNoi();
            string query = String.Format("select * from NHAN_VIEN where MA_NHAN_VIEN = '{0}'", idUser);
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
    }
}
