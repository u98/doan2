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
    public partial class childHoaDon : Form
    {
        string maHD;

        SqlServer sql = new SqlServer();
        
        public childHoaDon(string mahd)
        {
            InitializeComponent();
            this.maHD = mahd;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.MoKetNoi();
            int line = dataGridView1.CurrentRow.Index;
            string mact = dataGridView1.Rows[line].Cells[0].Value.ToString().Trim();
            string query = String.Format("delete from CT_HOA_DON where MA_CT_HD = '{0}'", mact);
            SqlCommand cmd = new SqlCommand(query, sql.conn);
            cmd.ExecuteNonQuery();
            loadGridView();
            sumCTHD();
            sql.DongKetNoi();

        }
        private void loadGridView()
        {
            sql.MoKetNoi();
            string query = String.Format("select CT_HOA_DON.MA_CT_HD, MAT_HANG.TEN_MAT_HANG, CT_HOA_DON.SO_LUONG, MAT_HANG.DON_GIA, (CT_HOA_DON.SO_LUONG * MAT_HANG.DON_GIA) as THANH_TIEN from CT_HOA_DON, MAT_HANG where CT_HOA_DON.MA_HOA_DON = '{0}' and CT_HOA_DON.MA_MAT_HANG = MAT_HANG.MA_MAT_HANG", maHD);
            SqlDataAdapter da = new SqlDataAdapter(query, sql.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.DongKetNoi();
        }
        private void sumCTHD()
        {
            int sumSL = 0, sumTT = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sumSL += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString().Trim());
                sumTT += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString().Trim());
            }
            txtSumSL.Text = sumSL.ToString();
            txtSumTT.Text = sumTT.ToString();
        }

        private void childHoaDon_Load(object sender, EventArgs e)
        {
            loadGridView();
            sumCTHD();
        }
    }
}
