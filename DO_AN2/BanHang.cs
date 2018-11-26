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
        public BanHang()
        {
            InitializeComponent();
        }

        SqlServer sql = new SqlServer();
        DataTable dt;

        public void LoadDataSanPham(string name)
        {
            string query = String.Format("select MA_MAT_HANG, TEN_MAT_HANG, DON_GIA, MA_NCC AS SO_LUONG from MAT_HANG where MA_MAT_HANG like N'%{0}%' or TEN_MAT_HANG like N'%{1}%'", name, name);
            SqlDataAdapter da = new SqlDataAdapter(query, sql.conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
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
        }
    }
}
