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
    public partial class HangHoa : Form
    {
        string idUser;
        public HangHoa(string name)
        {
            InitializeComponent();
            this.idUser = name;
        }

        SqlServer sql = new SqlServer();

        private void loadGridView()
        {
            sql.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter("select MAT_HANG.MA_MAT_HANG, MAT_HANG.TEN_MAT_HANG, LOAI_HANG.TEN_LOAI_HANG, NHA_CUNG_CAP.TEN_NCC, MAT_HANG.SO_LUONG, MAT_HANG.DON_GIA from MAT_HANG, LOAI_HANG, NHA_CUNG_CAP where MAT_HANG.MA_LOAI_HANG = LOAI_HANG.MA_LOAI_HANG and MAT_HANG.MA_NCC = NHA_CUNG_CAP.MA_NCC", sql.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.DongKetNoi();

        }

        private void loadComboBox(ComboBox cb, string query, string value, string display)
        {
            sql.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, sql.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb.DataSource = dt;
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.SelectedValue = "root";
            sql.DongKetNoi();

        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            loadGridView();
            loadComboBox(cbNCC, "select * from NHA_CUNG_CAP", "MA_NCC", "TEN_NCC");
            loadComboBox(cbLoaiHang, "select * from LOAI_HANG", "MA_LOAI_HANG", "TEN_LOAI_HANG");
        }
        
        private bool checkNameProduct(string name)
        {
            sql.MoKetNoi();
            string query = String.Format("select count(*) from MAT_HANG where TEN_MAT_HANG = N'{0}'", name);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            int count = int.Parse(cmd.ExecuteScalar().ToString());
            if (count >= 1)
                return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                btnAdd.Text = "Lưu lại";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                txtMaMH.Clear();
                txtTenMH.Clear();
                txtDG.Clear();
                txtSL.Clear();
                txtTT.Clear();
                txtMaMH.Enabled = true;
            } 
            else
            {
                string tenMH = txtTenMH.Text;
                if (checkNameProduct(tenMH))
                {
                    MessageBox.Show("Tên mặt hàng đã tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql.MoKetNoi();
                string maMH = txtMaMH.Text.Trim();
                string ncc = cbNCC.SelectedValue.ToString().Trim();
                string loaiHang = cbLoaiHang.SelectedValue.ToString().Trim();
                string soLuong = txtSL.Text.Trim();
                string donGia = txtDG.Text.Trim();
                string date = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
                string query = String.Format("insert into MAT_HANG values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}')", maMH, ncc, loaiHang, tenMH, donGia, soLuong, date);
                SqlCommand cmd = new SqlCommand(query, sql.conn);
                cmd.ExecuteNonQuery();
                sql.DongKetNoi();
                loadGridView();

            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            sql.MoKetNoi();
            int line = e.RowIndex;
            btnAdd.Text = "Thêm";
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            txtMaMH.Enabled = false;
            string maMH = dataGridView1.Rows[line].Cells[0].Value.ToString().Trim();
            string query = String.Format("select MA_NCC, MA_LOAI_HANG from MAT_HANG where MA_MAT_HANG = '{0}'", maMH);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            SqlDataReader dr =  cmd.ExecuteReader();
            if (dr.Read())
            {
                cbLoaiHang.SelectedValue = dr["MA_LOAI_HANG"];
                cbNCC.SelectedValue = dr["MA_NCC"];
            }
            int soLuong = int.Parse(dataGridView1.Rows[line].Cells[4].Value.ToString().Trim());
            int donGia = int.Parse(dataGridView1.Rows[line].Cells[5].Value.ToString().Trim());
            txtMaMH.Text = dataGridView1.Rows[line].Cells[0].Value.ToString().Trim();
            txtTenMH.Text = dataGridView1.Rows[line].Cells[1].Value.ToString().Trim();
            txtDG.Text = donGia.ToString();
            txtSL.Text = soLuong.ToString();
            txtTT.Text = (soLuong * donGia).ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sql.MoKetNoi();
            string tenMH = txtTenMH.Text.Trim();
            string maMH = txtMaMH.Text.Trim();
            string ncc = cbNCC.SelectedValue.ToString().Trim();
            string loaiHang = cbLoaiHang.SelectedValue.ToString().Trim();
            string soLuong = txtSL.Text.Trim();
            string donGia = txtDG.Text.Trim();
            string query = String.Format("update MAT_HANG set TEN_MAT_HANG = N'{0}', MA_NCC = N'{1}', MA_LOAI_HANG = N'{2}', DON_GIA = '{3}', SO_LUONG = '{4}' where MA_MAT_HANG = '{5}'", tenMH, ncc, loaiHang, donGia, soLuong, maMH);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            cmd.ExecuteNonQuery();
            sql.DongKetNoi();
            loadGridView();
        }

        private void sumTT()
        {
            int soLuong, donGia;
            try
            {
                soLuong = int.Parse(txtSL.Text.Trim());
                donGia = int.Parse(txtDG.Text.Trim());
            }
            catch
            {
                soLuong = 0;
                donGia = 0;
            }
            txtTT.Text = (soLuong * donGia).ToString();
        }

        private void txtDG_TextChanged(object sender, EventArgs e)
        {
            sumTT();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            sumTT();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.MoKetNoi();
            int line = dataGridView1.CurrentRow.Index;
            string maMH = dataGridView1.Rows[line].Cells[0].Value.ToString();
            string query = String.Format("delete  from MAT_HANG where MA_MAT_HANG = '{0}'", maMH);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            cmd.ExecuteNonQuery();
            sql.DongKetNoi();
            loadGridView();
        }

        private void HangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminDashboard(this.idUser).Show();
            this.Hide();
        }
    }
}
