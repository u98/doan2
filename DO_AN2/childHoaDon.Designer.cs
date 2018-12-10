namespace DO_AN2
{
    partial class childHoaDon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSumSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumTT = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.macthd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macthd,
            this.tenmh,
            this.soluong,
            this.dongia,
            this.tt});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(628, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(425, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Thành tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(306, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lượng:";
            // 
            // txtSumSL
            // 
            this.txtSumSL.Location = new System.Drawing.Point(364, 381);
            this.txtSumSL.Name = "txtSumSL";
            this.txtSumSL.ReadOnly = true;
            this.txtSumSL.Size = new System.Drawing.Size(55, 20);
            this.txtSumSL.TabIndex = 13;
            this.txtSumSL.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng:";
            // 
            // txtSumTT
            // 
            this.txtSumTT.Location = new System.Drawing.Point(489, 381);
            this.txtSumTT.Name = "txtSumTT";
            this.txtSumTT.ReadOnly = true;
            this.txtSumTT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSumTT.Size = new System.Drawing.Size(133, 20);
            this.txtSumTT.TabIndex = 11;
            this.txtSumTT.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(571, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // macthd
            // 
            this.macthd.DataPropertyName = "MA_CT_HD";
            this.macthd.HeaderText = "Mã CTHD";
            this.macthd.Name = "macthd";
            this.macthd.ReadOnly = true;
            this.macthd.Width = 90;
            // 
            // tenmh
            // 
            this.tenmh.DataPropertyName = "TEN_MAT_HANG";
            this.tenmh.HeaderText = "Tên mặt hàng";
            this.tenmh.Name = "tenmh";
            this.tenmh.ReadOnly = true;
            this.tenmh.Width = 200;
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
            // tt
            // 
            this.tt.DataPropertyName = "THANH_TIEN";
            this.tt.HeaderText = "Thành tiền";
            this.tt.Name = "tt";
            this.tt.ReadOnly = true;
            // 
            // childHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 408);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSumSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSumTT);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "childHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.childHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSumSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumTT;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn macthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
    }
}