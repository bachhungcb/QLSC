namespace KhanhLinh
{
    partial class ThongTinVatTu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongYeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThucXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialXuatThayThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatTuThuHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialThuHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThuHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VatTu,
            this.TenVatTu,
            this.DonViTinh,
            this.SoLuongYeuCau,
            this.SoLuongThucXuat,
            this.Kho,
            this.SerialXuatThayThe,
            this.VatTuThuHoi,
            this.SerialThuHoi,
            this.SoLuongThuHoi,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1953, 576);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VatTu
            // 
            this.VatTu.HeaderText = "Vật tư";
            this.VatTu.Name = "VatTu";
            // 
            // TenVatTu
            // 
            this.TenVatTu.HeaderText = "Tên vật tư";
            this.TenVatTu.Name = "TenVatTu";
            this.TenVatTu.Width = 500;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuongYeuCau
            // 
            this.SoLuongYeuCau.HeaderText = "Số lượng yêu cầu";
            this.SoLuongYeuCau.Name = "SoLuongYeuCau";
            // 
            // SoLuongThucXuat
            // 
            this.SoLuongThucXuat.HeaderText = "Số lượng thực xuất";
            this.SoLuongThucXuat.Name = "SoLuongThucXuat";
            // 
            // Kho
            // 
            this.Kho.HeaderText = "Kho";
            this.Kho.Name = "Kho";
            // 
            // SerialXuatThayThe
            // 
            this.SerialXuatThayThe.HeaderText = "Serial xuất thay thế";
            this.SerialXuatThayThe.Name = "SerialXuatThayThe";
            this.SerialXuatThayThe.Width = 200;
            // 
            // VatTuThuHoi
            // 
            this.VatTuThuHoi.HeaderText = "Vật tư thu hồi";
            this.VatTuThuHoi.Name = "VatTuThuHoi";
            // 
            // SerialThuHoi
            // 
            this.SerialThuHoi.HeaderText = "Serial thu hồi";
            this.SerialThuHoi.Name = "SerialThuHoi";
            // 
            // SoLuongThuHoi
            // 
            this.SoLuongThuHoi.HeaderText = "Số lượng thu hồi";
            this.SoLuongThuHoi.Name = "SoLuongThuHoi";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 300;
            // 
            // ThongTinVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThongTinVatTu";
            this.Size = new System.Drawing.Size(1953, 576);
            this.Load += new System.EventHandler(this.ThongTinVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongYeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThucXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialXuatThayThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatTuThuHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialThuHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThuHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}
