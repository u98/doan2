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
    public partial class LoaiHang : Form
    {
        string MaNV;
        public LoaiHang(string name)
        {
            InitializeComponent();
            this.MaNV = name;
        }
        SqlServer sql = new SqlServer();

        private void loadGridView()
        {
            sql.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter("select * from LOAI_HANG", sql.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.DongKetNoi();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                txtMaNCC.Enabled = true;
                txtMaNCC.Clear();
                txtTenNCC.Clear();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Text = "Lưu lại";
            }
            else
            {
                sql.MoKetNoi();
                string mancc = txtMaNCC.Text;
                string tenncc = txtTenNCC.Text;
                string query = String.Format("insert into LOAI_HANG values(N'{0}', N'{1}')", mancc, tenncc);
                SqlCommand cmd = new SqlCommand(query, sql.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sql.DongKetNoi();
                loadGridView();
            }
        }

        private void LoaiHang_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int line = e.RowIndex;
            string mancc = dataGridView1.Rows[line].Cells[0].Value.ToString().Trim();
            string tenncc = dataGridView1.Rows[line].Cells[1].Value.ToString().Trim();
            txtMaNCC.Text = mancc;
            txtTenNCC.Text = tenncc;
            txtMaNCC.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Text = "Thêm";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string mancc = txtMaNCC.Text;
            if (mancc == "root")
            {
                MessageBox.Show("Loại hàng mặc định, không thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql.MoKetNoi();
            string tenncc = txtTenNCC.Text;
            string query = String.Format("update LOAI_HANG set TEN_LOAI_HANG = N'{0}' where MA_LOAI_HANG = '{1}'", tenncc, mancc);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sql.DongKetNoi();
            loadGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            string mancc = dataGridView1.Rows[line].Cells[0].Value.ToString().Trim();
            if (mancc == "root")
            {
                MessageBox.Show("Loại hàng mặc định, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql.MoKetNoi();
            string query = String.Format("delete from LOAI_HANG where MA_LOAI_HANG = '{0}'", mancc);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sql.DongKetNoi();
            loadGridView();
        }

        private void LoaiHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminDashboard(this.MaNV).Show();
            this.Hide();
        }
    }
}
