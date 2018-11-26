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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.mmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mmh,
            this.tmh,
            this.dg,
            this.sl});
            this.dataGridView.Location = new System.Drawing.Point(15, 85);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(474, 386);
            this.dataGridView.TabIndex = 3;
            // 
            // mmh
            // 
            this.mmh.DataPropertyName = "MA_MAT_HANG";
            this.mmh.HeaderText = "Mã mặt hàng";
            this.mmh.Name = "mmh";
            // 
            // tmh
            // 
            this.tmh.DataPropertyName = "TEN_MAT_HANG";
            this.tmh.HeaderText = "Tên mặt hàng";
            this.tmh.Name = "tmh";
            this.tmh.Width = 180;
            // 
            // dg
            // 
            this.dg.DataPropertyName = "DON_GIA";
            this.dg.HeaderText = "Đơn giá";
            this.dg.Name = "dg";
            // 
            // sl
            // 
            this.sl.DataPropertyName = "SO_LUONG";
            this.sl.HeaderText = "Số lượng";
            this.sl.Name = "sl";
            this.sl.Width = 50;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 594);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSanPham);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "BanHang";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
    }
}