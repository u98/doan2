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
    public partial class KhachHang : Form
    {
        string MaNV;
        public KhachHang(string name)
        {
            InitializeComponent();
            this.MaNV = name;
        }
        SqlServer sql = new SqlServer();

        private void loadDataGridView()
        {
            sql.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter("select * from KHACH_HANG", sql.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            sql.DongKetNoi();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                txtMaKH.Enabled = true;
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtDT.Clear();
                txtDC.Clear();
                btnAdd.Text = "Lưu lại";
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                sql.MoKetNoi();
                string makh = txtMaKH.Text;
                string tenkh = txtTenKH.Text;
                string dienThoai = txtDT.Text;
                string diaChi = txtDC.Text;
                string query = String.Format("insert into KHACH_HANG values(N'{0}', N'{1}', N'{3}', N'{2}')", makh, tenkh, dienThoai, diaChi);
                SqlCommand cmd = new SqlCommand(query, sql.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql.DongKetNoi();
                loadDataGridView();
                btnAdd.Text = "Thêm";
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }

        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int line = e.RowIndex;
            txtMaKH.Enabled = false;
            txtMaKH.Text = dataGridView.Rows[line].Cells[0].Value.ToString().Trim();
            txtTenKH.Text = dataGridView.Rows[line].Cells[1].Value.ToString().Trim();
            txtDT.Text = dataGridView.Rows[line].Cells[3].Value.ToString().Trim();
            txtDC.Text = dataGridView.Rows[line].Cells[2].Value.ToString().Trim();
            btnAdd.Text = "Thêm";
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            string dienThoai = txtDT.Text;
            string diaChi = txtDC.Text;
            if (makh == "root") {
                MessageBox.Show("Khách hàng mặc định, không thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql.MoKetNoi();
            string query = String.Format("update KHACH_HANG set TEN_KHACH_HANG = N'{0}', SO_DIEN_THOAI = N'{1}', DIA_CHI = N'{2}' where MA_KHACH_HANG = '{3}'", tenkh, dienThoai, diaChi, makh);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql.DongKetNoi();
            loadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int line = dataGridView.CurrentRow.Index;
            string makh = dataGridView.Rows[line].Cells[0].Value.ToString().Trim();
            if (makh == "root")
            {
                MessageBox.Show("Khách hàng mặc định, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql.MoKetNoi();
            string query = String.Format("delete  from KHACH_HANG where MA_KHACH_HANG = '{0}'", makh);
            if (makh == "root") {
                MessageBox.Show("Khách hàng mặc định, không thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql.DongKetNoi();
            loadDataGridView();
        }

        private void KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminDashboard(MaNV).Show();
            this.Hide();
        }
    }
}
