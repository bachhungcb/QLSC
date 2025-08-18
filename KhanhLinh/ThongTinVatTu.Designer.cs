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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.finalDataSet1 = new KhanhLinh.FinalDataSet1();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.WarehouseTableAdapter();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.ItemTableAdapter();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.VatTu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuongYeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatTuThuHoi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SerialThuHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThuHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialXuatThayThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kho = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThucXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VatTu,
            this.SoLuongYeuCau,
            this.VatTuThuHoi,
            this.SerialThuHoi,
            this.GhiChu,
            this.SoLuongThuHoi,
            this.SerialXuatThayThe,
            this.Kho,
            this.TenVatTu,
            this.SoLuongThucXuat,
            this.DonViTinh});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(2065, 709);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // finalDataSet1
            // 
            this.finalDataSet1.DataSetName = "FinalDataSet1";
            this.finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.finalDataSet1;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.finalDataSet1;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "Item";
            this.itemBindingSource1.DataSource = this.finalDataSet1;
            // 
            // VatTu
            // 
            this.VatTu.DataSource = this.itemBindingSource;
            this.VatTu.DisplayMember = "Name";
            this.VatTu.HeaderText = "Vật tư";
            this.VatTu.MinimumWidth = 6;
            this.VatTu.Name = "VatTu";
            this.VatTu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VatTu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VatTu.ValueMember = "Id";
            this.VatTu.Width = 125;
            // 
            // SoLuongYeuCau
            // 
            this.SoLuongYeuCau.HeaderText = "Số lượng yêu cầu";
            this.SoLuongYeuCau.MinimumWidth = 6;
            this.SoLuongYeuCau.Name = "SoLuongYeuCau";
            this.SoLuongYeuCau.Width = 125;
            // 
            // VatTuThuHoi
            // 
            this.VatTuThuHoi.DataSource = this.itemBindingSource1;
            this.VatTuThuHoi.DisplayMember = "Name";
            this.VatTuThuHoi.HeaderText = "Vật tư thu hồi";
            this.VatTuThuHoi.MinimumWidth = 6;
            this.VatTuThuHoi.Name = "VatTuThuHoi";
            this.VatTuThuHoi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VatTuThuHoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VatTuThuHoi.ValueMember = "Id";
            this.VatTuThuHoi.Width = 125;
            // 
            // SerialThuHoi
            // 
            this.SerialThuHoi.HeaderText = "Serial thu hồi";
            this.SerialThuHoi.MinimumWidth = 6;
            this.SerialThuHoi.Name = "SerialThuHoi";
            this.SerialThuHoi.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 150;
            // 
            // SoLuongThuHoi
            // 
            this.SoLuongThuHoi.HeaderText = "Số lượng thu hồi";
            this.SoLuongThuHoi.MinimumWidth = 6;
            this.SoLuongThuHoi.Name = "SoLuongThuHoi";
            this.SoLuongThuHoi.Width = 125;
            // 
            // SerialXuatThayThe
            // 
            this.SerialXuatThayThe.HeaderText = "Serial xuất thay thế";
            this.SerialXuatThayThe.MinimumWidth = 6;
            this.SerialXuatThayThe.Name = "SerialXuatThayThe";
            this.SerialXuatThayThe.Width = 150;
            // 
            // Kho
            // 
            this.Kho.DataSource = this.warehouseBindingSource;
            this.Kho.DisplayMember = "Code";
            this.Kho.HeaderText = "Kho";
            this.Kho.MinimumWidth = 6;
            this.Kho.Name = "Kho";
            this.Kho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Kho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Kho.ValueMember = "Id";
            this.Kho.Width = 125;
            // 
            // TenVatTu
            // 
            this.TenVatTu.HeaderText = "Tên vật tư";
            this.TenVatTu.MinimumWidth = 6;
            this.TenVatTu.Name = "TenVatTu";
            this.TenVatTu.Visible = false;
            this.TenVatTu.Width = 500;
            // 
            // SoLuongThucXuat
            // 
            this.SoLuongThucXuat.HeaderText = "Số lượng thực xuất";
            this.SoLuongThucXuat.MinimumWidth = 6;
            this.SoLuongThucXuat.Name = "SoLuongThucXuat";
            this.SoLuongThucXuat.Visible = false;
            this.SoLuongThucXuat.Width = 125;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = false;
            this.DonViTinh.Width = 125;
            // 
            // ThongTinVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongTinVatTu";
            this.Size = new System.Drawing.Size(2065, 709);
            this.Load += new System.EventHandler(this.ThongTinVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private FinalDataSet1 finalDataSet1;
        private FinalDataSet1TableAdapters.WarehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private FinalDataSet1TableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn VatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongYeuCau;
        private System.Windows.Forms.DataGridViewComboBoxColumn VatTuThuHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialThuHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThuHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialXuatThayThe;
        private System.Windows.Forms.DataGridViewComboBoxColumn Kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThucXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
    }
}
