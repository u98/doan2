﻿using System;
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
    public partial class HoaDon : Form
    {
        string MaNV;
        public HoaDon(string name)
        {
            InitializeComponent();
            this.MaNV = name;
        }
        SqlServer sql = new SqlServer();

        private void loadHoaDonXuat()
        {
            sql.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter("select HOA_DON.MA_HOA_DON, NHAN_VIEN.HO_VA_TEN, KHACH_HANG.TEN_KHACH_HANG, HOA_DON.NGAY_NHAP from HOA_DON, NHAN_VIEN, kHACH_HANG where HOA_DON.MA_NHAN_VIEN = NHAN_VIEN.MA_NHAN_VIEN and HOA_DON.MA_KHACH_HANG = KHACH_HANG.MA_KHACH_HANG", sql.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.DongKetNoi();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDonXuat();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.MoKetNoi();
            int line = dataGridView1.CurrentRow.Index;
            string mahd = dataGridView1.Rows[line].Cells[0].Value.ToString();
            string query = String.Format("delete from HOA_DON where MA_HOA_DON = '{0}'", mahd);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            cmd.ExecuteNonQuery();
            loadHoaDonXuat();
        }

        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminDashboard(this.MaNV).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int line = dataGridView1.CurrentRow.Index;
            string mahd = dataGridView1.Rows[line].Cells[0].Value.ToString();
            new childHoaDon(mahd).Show();
        }
    }
}
