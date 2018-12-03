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
    public partial class BanHang : Form
    {
        string idUser;
        public BanHang(string name)
        {
            InitializeComponent();
            this.idUser = name;
        }

        SqlServer sql = new SqlServer();
        DataTable dt;
        int soLuong, donGia;
        public void LoadDataSanPham(string name)
        {
            string query = String.Format("select MA_MAT_HANG, TEN_MAT_HANG, DON_GIA, SO_LUONG from MAT_HANG where MA_MAT_HANG like N'%{0}%' or TEN_MAT_HANG like N'%{1}%'", name, name);
            SqlDataAdapter da = new SqlDataAdapter(query, sql.conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvSanPham.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ten = txtSanPham.Text;
            if (!String.IsNullOrEmpty(ten))
                LoadDataSanPham(ten);
            else
            {
                dt.Clear();
            }
                
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            sql.MoKetNoi();
            loadComboBox();
            loadNhanVien();
        }

        public int checkMaMatHang(string name)
        {
            for (int i = 0; i < dgvBanHang.Rows.Count; i++)
            {
                if (name == dgvBanHang.Rows[i].Cells[0].Value.ToString())
                    return i;
            }
            return -1;
        }
        private void tinhTongAll()
        {
            int sumSL = 0, sumTT = 0;
            for (int i = 0; i < dgvBanHang.Rows.Count; i++)
            {
                sumSL += int.Parse(dgvBanHang.Rows[i].Cells[3].Value.ToString().Trim());
                sumTT += int.Parse(dgvBanHang.Rows[i].Cells[4].Value.ToString().Trim());
            }
            txtSumSL.Text = sumSL.ToString();
            txtSumTT.Text = String.Format("{0:n0}", sumTT);
        }

        private void dgvSanPham_DoubleClick(object sender, EventArgs e)
        {
            int line = dgvSanPham.CurrentRow.Index;
            string ma = dgvSanPham.Rows[line].Cells[0].Value.ToString().Trim();
            string ten = dgvSanPham.Rows[line].Cells[1].Value.ToString().Trim();
            string dg = dgvSanPham.Rows[line].Cells[2].Value.ToString().Trim();
            string sl = dgvSanPham.Rows[line].Cells[3].Value.ToString().Trim();
            int indexMH = checkMaMatHang(ma);
            if (indexMH >= 0)
            {
                if (MessageBox.Show("Mặt hàng đã tồn tại! bạn có muốn thêm số lượng không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
            }
            if (indexMH >= 0)
            {
                int donGia = int.Parse(dgvBanHang.Rows[indexMH].Cells[2].Value.ToString());
                int soLuong = int.Parse(dgvBanHang.Rows[indexMH].Cells[3].Value.ToString());
                soLuong++;
                dgvBanHang.Rows[indexMH].Cells[3].Value = soLuong.ToString();
                dgvBanHang.Rows[indexMH].Cells[4].Value = (soLuong * donGia).ToString();
            }
            else
            {
                int index = dgvBanHang.Rows.Add();
                dgvBanHang.Rows[index].Cells[0].Value = ma;
                dgvBanHang.Rows[index].Cells[1].Value = ten;
                dgvBanHang.Rows[index].Cells[2].Value = dg;
                dgvBanHang.Rows[index].Cells[3].Value = 1;
                dgvBanHang.Rows[index].Cells[4].Value = dg;
            }
            tinhTongAll();
        }

        private void dgvBanHang_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int line = e.RowIndex;
            donGia = int.Parse(dgvBanHang.Rows[line].Cells[2].Value.ToString());
            soLuong = int.Parse(dgvBanHang.Rows[line].Cells[3].Value.ToString());
        }

        private void dgvBanHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tinhTongAll();
        }
        private void loadComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KHACH_HANG", sql.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbKH.DataSource = dt;
            cbKH.DisplayMember = "TEN_KHACH_HANG";
            cbKH.ValueMember = "MA_KHACH_HANG";
            cbKH.SelectedValue = "root";
        }

        private void loadNhanVien()
        {
            string query = String.Format("select * from NHAN_VIEN where MA_NHAN_VIEN = '{0}'", idUser);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            SqlDataReader dr =  cmd.ExecuteReader();
            if (dr.Read())
                txtNV.Text = dr["HO_VA_TEN"].ToString();
            dr.Close();
        }

        private void resetBanHang()
        {
            cbKH.SelectedValue = "root";
            dgvBanHang.Rows.Clear();
            txtSanPham.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maKH = cbKH.SelectedValue.ToString();
            string date = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            string query = String.Format("insert into HOA_DON (MA_NHAN_VIEN, MA_KHACH_HANG, MA_NCC, LOAI_HOA_DON, NGAY_NHAP) output INSERTED.MA_HOA_DON values (N'{0}', N'{1}', N'{2}', N'{3}', '{4}')", idUser, maKH, "root", "out", date);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            try
            {
                string maHD = cmd.ExecuteScalar().ToString();
                for (int i = 0; i < dgvBanHang.Rows.Count; i ++)
                {
                    string maMH = dgvBanHang.Rows[i].Cells[0].Value.ToString().Trim();
                    string soLuong = dgvBanHang.Rows[i].Cells[3].Value.ToString().Trim();
                    string donGia = dgvBanHang.Rows[i].Cells[2].Value.ToString().Trim();
                    query = String.Format("insert into CT_HOA_DON (MA_HOA_DON, MA_MAT_HANG, SO_LUONG, GIA_NHAP) values ('{0}', '{1}', '{2}', '{3}')", maHD, maMH, soLuong, donGia);
                    cmd = new SqlCommand(query, sql.conn);
                    cmd.ExecuteNonQuery();
                }
                resetBanHang();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            resetBanHang();
        }

        private void BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminDashboard(this.idUser).Show();
            this.Hide();
        }

        private void dgvBanHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int line = e.RowIndex;
            try
            {
                int dg = int.Parse(dgvBanHang.Rows[line].Cells[2].Value.ToString());
                int sl = int.Parse(dgvBanHang.Rows[line].Cells[3].Value.ToString());
                dgvBanHang.Rows[line].Cells[4].Value = (sl * dg).ToString();
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvBanHang.Rows[line].Cells[2].Value = donGia.ToString();
                dgvBanHang.Rows[line].Cells[3].Value = soLuong.ToString();
            }
            tinhTongAll();

        }
    }
}
