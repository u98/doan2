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
        string maHD, idUser;

        SqlServer sql = new SqlServer();
        
        public childHoaDon(string mahd, string name)
        {
            InitializeComponent();
            this.maHD = mahd;
            this.idUser = name;
        }



        private void childHoaDon_Load(object sender, EventArgs e)
        {
            sql.MoKetNoi();
            string query = String.Format("select MAT_HANG.TEN_MAT_HANG, CT_HOA_DON.SO_LUONG, MAT_HANG.DON_GIA, (CT_HOA_DON.SO_LUONG * MAT_HANG.DON_GIA) as THANH_TIEN from CT_HOA_DON, MAT_HANG where CT_HOA_DON.MA_HOA_DON = '{0}' and CT_HOA_DON.MA_MAT_HANG = MAT_HANG.MA_MAT_HANG", maHD);
            SqlDataAdapter da = new SqlDataAdapter(query, sql.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            int sumSL = 0, sumTT = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sumSL += int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString().Trim());
                sumTT += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString().Trim());
            }
            txtSumSL.Text = sumSL.ToString();
            txtSumTT.Text = sumTT.ToString();
        }
    }
}
