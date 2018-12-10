namespace DO_AN2
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(609, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.nhanvien,
            this.khachhang,
            this.ngayNhap});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(687, 348);
            this.dataGridView1.TabIndex = 19;
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "MA_HOA_DON";
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.Name = "maHD";
            this.maHD.ReadOnly = true;
            // 
            // nhanvien
            // 
            this.nhanvien.DataPropertyName = "HO_VA_TEN";
            this.nhanvien.HeaderText = "Nhân viên nhập";
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.ReadOnly = true;
            this.nhanvien.Width = 200;
            // 
            // khachhang
            // 
            this.khachhang.DataPropertyName = "TEN_KHACH_HANG";
            this.khachhang.HeaderText = "Khách hàng";
            this.khachhang.Name = "khachhang";
            this.khachhang.ReadOnly = true;
            this.khachhang.Width = 200;
            // 
            // ngayNhap
            // 
            this.ngayNhap.DataPropertyName = "NGAY_NHAP";
            this.ngayNhap.HeaderText = "Ngày nhập";
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.ReadOnly = true;
            this.ngayNhap.Width = 135;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Xem chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.MaximizeBox = false;
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoaDon_FormClosing);
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.Button button1;
    }
}