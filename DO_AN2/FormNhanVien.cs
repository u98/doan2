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
    public partial class FormNhanVien : Form
    {
        string idUser;
        public FormNhanVien(string name)
        {
            InitializeComponent();
            this.idUser = name;
        }
        SqlServer sql = new SqlServer();

        private void loadGridView()
        {
            sql.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter("select MA_NHAN_VIEN, HO_VA_TEN, CHUC_VU, USERNAME from NHAN_VIEN", sql.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.DongKetNoi();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int line = e.RowIndex;
            txtMaNV.Text = dataGridView1.Rows[line].Cells[0].Value.ToString().Trim();
            txtTenNV.Text = dataGridView1.Rows[line].Cells[1].Value.ToString().Trim();
            cbChucVU.SelectedIndex = dataGridView1.Rows[line].Cells[2].Value.ToString().Trim() == "admin" ? 0 : 1;
            txtUN.Text = dataGridView1.Rows[line].Cells[3].Value.ToString().Trim();
            txtMaNV.Enabled = false;
            btnAdd.Text = "Thêm";
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                btnAdd.Text = "lưu lại";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                txtMaNV.Enabled = true;
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtUN.Clear();
                txtPass.Clear();
            }
            else
            {
                sql.MoKetNoi();
                string maNV = txtMaNV.Text;
                string tenNV = txtTenNV.Text;
                string chucVu = cbChucVU.Text == "Quản trị viên" ? "admin" : "sale";
                string user = txtUN.Text;
                string pass = txtPass.Text;
                string query = String.Format("insert into NHAN_VIEN values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", maNV, tenNV, chucVu, user, pass);
                SqlCommand cmd = new SqlCommand(query, sql.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sql.DongKetNoi();
                loadGridView();
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sql.MoKetNoi();
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string chucVu = cbChucVU.Text == "Quản trị viên" ? "admin" : "sale";
            string user = txtUN.Text;
            string query;
            if (!String.IsNullOrEmpty(txtPass.Text))
            {
                string pass = txtPass.Text;
                query = String.Format("update NHAN_VIEN set HO_VA_TEN = N'{0}', CHUC_VU = N'{1}', USERNAME = N'{2}', PASSWORD = N'{3}' where MA_NHAN_VIEN = N'{4}'", tenNV, chucVu, user, pass, maNV);
            }
            else
            {
                query = String.Format("update NHAN_VIEN set HO_VA_TEN = N'{0}', CHUC_VU = N'{1}', USERNAME = N'{2}' where MA_NHAN_VIEN = N'{3}'", tenNV, chucVu, user, maNV);
            }
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            cmd.ExecuteNonQuery();
            sql.DongKetNoi();
            loadGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.MoKetNoi();
            int line = dataGridView1.CurrentRow.Index;
            string maNV = dataGridView1.Rows[line].Cells[0].Value.ToString().Trim();
            string query = String.Format("delete from NHAN_VIEN where MA_NHAN_VIEN = '{0}'", maNV);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            cmd.ExecuteNonQuery();
            sql.DongKetNoi();
            loadGridView();
        }

        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminDashboard(this.idUser).Show();
            this.Hide();
        }
    }
}
