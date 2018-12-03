namespace DO_AN2
{
    partial class BanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.mmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSumTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm, Mã sản phẩm";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Location = new System.Drawing.Point(15, 46);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(396, 20);
            this.txtSanPham.TabIndex = 1;
            this.txtSanPham.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mmh,
            this.tmh,
            this.dg,
            this.sl});
            this.dgvSanPham.Location = new System.Drawing.Point(15, 85);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(474, 386);
            this.dgvSanPham.TabIndex = 3;
            this.dgvSanPham.DoubleClick += new System.EventHandler(this.dgvSanPham_DoubleClick);
            // 
            // mmh
            // 
            this.mmh.DataPropertyName = "MA_MAT_HANG";
            this.mmh.HeaderText = "Mã mặt hàng";
            this.mmh.Name = "mmh";
            this.mmh.ReadOnly = true;
            // 
            // tmh
            // 
            this.tmh.DataPropertyName = "TEN_MAT_HANG";
            this.tmh.HeaderText = "Tên mặt hàng";
            this.tmh.Name = "tmh";
            this.tmh.ReadOnly = true;
            this.tmh.Width = 180;
            // 
            // dg
            // 
            this.dg.DataPropertyName = "DON_GIA";
            this.dg.HeaderText = "Đơn giá";
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "SO_LUONG";
            this.sl.HeaderText = "Số lượng";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Width = 50;
            // 
            // dgvBanHang
            // 
            this.dgvBanHang.AllowUserToAddRows = false;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.thanhtien});
            this.dgvBanHang.Location = new System.Drawing.Point(526, 85);
            this.dgvBanHang.MultiSelect = false;
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.Size = new System.Drawing.Size(581, 364);
            this.dgvBanHang.TabIndex = 4;
            this.dgvBanHang.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvBanHang_CellBeginEdit);
            this.dgvBanHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanHang_CellEndEdit);
            this.dgvBanHang.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBanHang_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã mặt hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên mặt hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // thanhtien
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.thanhtien.DefaultCellStyle = dataGridViewCellStyle18;
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // txtSumTT
            // 
            this.txtSumTT.Location = new System.Drawing.Point(938, 455);
            this.txtSumTT.Name = "txtSumTT";
            this.txtSumTT.ReadOnly = true;
            this.txtSumTT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSumTT.Size = new System.Drawing.Size(133, 20);
            this.txtSumTT.TabIndex = 5;
            this.txtSumTT.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(523, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng:";
            // 
            // txtSumSL
            // 
            this.txtSumSL.Location = new System.Drawing.Point(813, 455);
            this.txtSumSL.Name = "txtSumSL";
            this.txtSumSL.ReadOnly = true;
            this.txtSumSL.Size = new System.Drawing.Size(55, 20);
            this.txtSumSL.TabIndex = 7;
            this.txtSumSL.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(755, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(874, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thành tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(1077, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(524, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhân viên nhập:";
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(616, 44);
            this.txtNV.Name = "txtNV";
            this.txtNV.ReadOnly = true;
            this.txtNV.Size = new System.Drawing.Size(191, 20);
            this.txtNV.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(818, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Khách hàng:";
            // 
            // cbKH
            // 
            this.cbKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(892, 44);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(215, 21);
            this.cbKH.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1004, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(892, 497);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Phiên nhập mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 524);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSumSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSumTT);
            this.Controls.Add(this.dgvBanHang);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSanPham);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BanHang_FormClosing);
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridView dgvBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.TextBox txtSumTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
    }
}