namespace DO_AN2
{
    partial class HangHoa
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã mặt hàng";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(146, 10);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(250, 20);
            this.txtMaMH.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(551, 13);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(250, 20);
            this.txtTenMH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhà cung cấp";
            // 
            // cbNCC
            // 
            this.cbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(146, 41);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(250, 21);
            this.cbNCC.TabIndex = 6;
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(146, 68);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(250, 21);
            this.cbLoaiHang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại hàng";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(637, 39);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(164, 20);
            this.txtDG.TabIndex = 10;
            this.txtDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDG.TextChanged += new System.EventHandler(this.txtDG_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đơn giá";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(637, 65);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(164, 20);
            this.txtSL.TabIndex = 12;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng";
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(637, 91);
            this.txtTT.Name = "txtTT";
            this.txtTT.ReadOnly = true;
            this.txtTT.Size = new System.Drawing.Size(164, 20);
            this.txtTT.TabIndex = 14;
            this.txtTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thành tiền";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamh,
            this.tenmh,
            this.loaihang,
            this.ncc,
            this.soluong,
            this.dongia});
            this.dataGridView1.Location = new System.Drawing.Point(16, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(785, 398);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(155, 106);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(295, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mamh
            // 
            this.mamh.DataPropertyName = "MA_MAT_HANG";
            this.mamh.HeaderText = "Mã mặt hàng";
            this.mamh.Name = "mamh";
            this.mamh.ReadOnly = true;
            // 
            // tenmh
            // 
            this.tenmh.DataPropertyName = "TEN_MAT_HANG";
            this.tenmh.HeaderText = "Tên mặt hàng";
            this.tenmh.Name = "tenmh";
            this.tenmh.ReadOnly = true;
            this.tenmh.Width = 150;
            // 
            // loaihang
            // 
            this.loaihang.DataPropertyName = "TEN_LOAI_HANG";
            this.loaihang.HeaderText = "Loại hàng";
            this.loaihang.Name = "loaihang";
            this.loaihang.ReadOnly = true;
            this.loaihang.Width = 150;
            // 
            // ncc
            // 
            this.ncc.DataPropertyName = "TEN_NCC";
            this.ncc.HeaderText = "Nhà cung cấp";
            this.ncc.Name = "ncc";
            this.ncc.ReadOnly = true;
            this.ncc.Width = 150;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SO_LUONG";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "DON_GIA";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 545);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLoaiHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HangHoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HangHoa_FormClosing);
            this.Load += new System.EventHandler(this.HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.ComboBox cbLoaiHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
    }
}