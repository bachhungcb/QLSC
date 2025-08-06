namespace KhanhLinh
{
    partial class ItemScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roleStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcKhoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcLoạiXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcTuyếnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcBộPhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcCôngViệcSửaChữaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhMứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuTheoDõiHànhTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.vItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet1 = new KhanhLinh.FinalDataSet1();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khanhLinhDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khanhLinhDataSet1 = new KhanhLinh.KhanhLinhDataSet1();
            this.itemTableAdapter = new KhanhLinh.KhanhLinhDataSet1TableAdapters.ItemTableAdapter();
            this.vItemTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.vItemTableAdapter();
            this.statusBarUC1 = new KhanhLinh.StatusBarUC();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isItemWithSerialDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleStripComboBox1,
            this.danhMụcToolStripMenuItem,
            this.địnhMứcToolStripMenuItem,
            this.phiếuToolStripMenuItem,
            this.thêmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // roleStripComboBox1
            // 
            this.roleStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.roleStripComboBox1.AutoSize = false;
            this.roleStripComboBox1.Items.AddRange(new object[] {
            "Điều phối sửa chữa",
            "Thủ kho",
            "Phòng QLTH",
            "Ban lãnh đạo"});
            this.roleStripComboBox1.Name = "roleStripComboBox1";
            this.roleStripComboBox1.Size = new System.Drawing.Size(200, 28);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcKhoHàngToolStripMenuItem,
            this.danhMụcNhânViênToolStripMenuItem,
            this.danhMụcLoạiXeToolStripMenuItem,
            this.danhMụcTuyếnToolStripMenuItem,
            this.danhMụcBộPhậnToolStripMenuItem,
            this.danhMụcXeToolStripMenuItem,
            this.danhMụcCôngViệcSửaChữaToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // danhMụcKhoHàngToolStripMenuItem
            // 
            this.danhMụcKhoHàngToolStripMenuItem.Name = "danhMụcKhoHàngToolStripMenuItem";
            this.danhMụcKhoHàngToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcKhoHàngToolStripMenuItem.Text = "Danh mục kho hàng";
            this.danhMụcKhoHàngToolStripMenuItem.Click += new System.EventHandler(this.danhMụcKhoHàngToolStripMenuItem_Click);
            // 
            // danhMụcNhânViênToolStripMenuItem
            // 
            this.danhMụcNhânViênToolStripMenuItem.Name = "danhMụcNhânViênToolStripMenuItem";
            this.danhMụcNhânViênToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcNhânViênToolStripMenuItem.Text = "Danh mục nhân viên";
            this.danhMụcNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhMụcNhânViênToolStripMenuItem_Click);
            // 
            // danhMụcLoạiXeToolStripMenuItem
            // 
            this.danhMụcLoạiXeToolStripMenuItem.Name = "danhMụcLoạiXeToolStripMenuItem";
            this.danhMụcLoạiXeToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcLoạiXeToolStripMenuItem.Text = "Danh mục loại xe";
            this.danhMụcLoạiXeToolStripMenuItem.Click += new System.EventHandler(this.danhMụcLoạiXeToolStripMenuItem_Click);
            // 
            // danhMụcTuyếnToolStripMenuItem
            // 
            this.danhMụcTuyếnToolStripMenuItem.Name = "danhMụcTuyếnToolStripMenuItem";
            this.danhMụcTuyếnToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcTuyếnToolStripMenuItem.Text = "Danh mục tuyến";
            this.danhMụcTuyếnToolStripMenuItem.Click += new System.EventHandler(this.danhMụcTuyếnToolStripMenuItem_Click);
            // 
            // danhMụcBộPhậnToolStripMenuItem
            // 
            this.danhMụcBộPhậnToolStripMenuItem.Name = "danhMụcBộPhậnToolStripMenuItem";
            this.danhMụcBộPhậnToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcBộPhậnToolStripMenuItem.Text = "Danh mục bộ phận";
            this.danhMụcBộPhậnToolStripMenuItem.Click += new System.EventHandler(this.danhMụcBộPhậnToolStripMenuItem_Click);
            // 
            // danhMụcXeToolStripMenuItem
            // 
            this.danhMụcXeToolStripMenuItem.Name = "danhMụcXeToolStripMenuItem";
            this.danhMụcXeToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcXeToolStripMenuItem.Text = "Danh mục xe";
            this.danhMụcXeToolStripMenuItem.Click += new System.EventHandler(this.danhMụcXeToolStripMenuItem_Click);
            // 
            // danhMụcCôngViệcSửaChữaToolStripMenuItem
            // 
            this.danhMụcCôngViệcSửaChữaToolStripMenuItem.Name = "danhMụcCôngViệcSửaChữaToolStripMenuItem";
            this.danhMụcCôngViệcSửaChữaToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcCôngViệcSửaChữaToolStripMenuItem.Text = "Danh mục công việc sửa chữa";
            this.danhMụcCôngViệcSửaChữaToolStripMenuItem.Click += new System.EventHandler(this.danhMụcCôngViệcSửaChữaToolStripMenuItem_Click);
            // 
            // địnhMứcToolStripMenuItem
            // 
            this.địnhMứcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem,
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem});
            this.địnhMứcToolStripMenuItem.Name = "địnhMứcToolStripMenuItem";
            this.địnhMứcToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.địnhMứcToolStripMenuItem.Text = "Định mức";
            // 
            // địnhMứcVậtTưTiêuHaoToolStripMenuItem
            // 
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem.Name = "địnhMứcVậtTưTiêuHaoToolStripMenuItem";
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem.Text = "Định mức vật tư tiêu hao";
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem.Click += new System.EventHandler(this.địnhMứcVậtTưTiêuHaoToolStripMenuItem_Click);
            // 
            // địnhMứcVậtTưSửaChữaToolStripMenuItem
            // 
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem.Name = "địnhMứcVậtTưSửaChữaToolStripMenuItem";
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem.Text = "Định mức vật tư sửa chữa";
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem.Click += new System.EventHandler(this.địnhMứcVậtTưSửaChữaToolStripMenuItem_Click);
            // 
            // phiếuToolStripMenuItem
            // 
            this.phiếuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuTheoDõiHànhTrìnhToolStripMenuItem,
            this.phiếuNhậpKhoToolStripMenuItem,
            this.phiếuXuấtKhoToolStripMenuItem});
            this.phiếuToolStripMenuItem.Name = "phiếuToolStripMenuItem";
            this.phiếuToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.phiếuToolStripMenuItem.Text = "Phiếu";
            // 
            // phiếuTheoDõiHànhTrìnhToolStripMenuItem
            // 
            this.phiếuTheoDõiHànhTrìnhToolStripMenuItem.Name = "phiếuTheoDõiHànhTrìnhToolStripMenuItem";
            this.phiếuTheoDõiHànhTrìnhToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.phiếuTheoDõiHànhTrìnhToolStripMenuItem.Text = "Phiếu theo dõi hành trình";
            this.phiếuTheoDõiHànhTrìnhToolStripMenuItem.Click += new System.EventHandler(this.phiếuTheoDõiHànhTrìnhToolStripMenuItem_Click);
            // 
            // phiếuNhậpKhoToolStripMenuItem
            // 
            this.phiếuNhậpKhoToolStripMenuItem.Name = "phiếuNhậpKhoToolStripMenuItem";
            this.phiếuNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.phiếuNhậpKhoToolStripMenuItem.Text = "Phiếu nhập kho";
            this.phiếuNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpKhoToolStripMenuItem_Click);
            // 
            // phiếuXuấtKhoToolStripMenuItem
            // 
            this.phiếuXuấtKhoToolStripMenuItem.Name = "phiếuXuấtKhoToolStripMenuItem";
            this.phiếuXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.phiếuXuấtKhoToolStripMenuItem.Text = "Phiếu xuất kho";
            this.phiếuXuấtKhoToolStripMenuItem.Click += new System.EventHandler(this.phiếuXuấtKhoToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = global::KhanhLinh.Properties.Resources.add__1_;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(34, 24);
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.metroPanel2.Controls.Add(this.metroGrid1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(12, 40);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1020, 464);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.unitDescriptionDataGridViewTextBoxColumn,
            this.isItemWithSerialDataGridViewCheckBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.metroGrid1.DataSource = this.vItemBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1020, 464);
            this.metroGrid1.TabIndex = 4;
            // 
            // vItemBindingSource
            // 
            this.vItemBindingSource.DataMember = "vItem";
            this.vItemBindingSource.DataSource = this.finalDataSet1BindingSource;
            // 
            // finalDataSet1BindingSource
            // 
            this.finalDataSet1BindingSource.DataSource = this.finalDataSet1;
            this.finalDataSet1BindingSource.Position = 0;
            // 
            // finalDataSet1
            // 
            this.finalDataSet1.DataSetName = "FinalDataSet1";
            this.finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.khanhLinhDataSet1BindingSource;
            // 
            // khanhLinhDataSet1BindingSource
            // 
            this.khanhLinhDataSet1BindingSource.DataSource = this.khanhLinhDataSet1;
            this.khanhLinhDataSet1BindingSource.Position = 0;
            // 
            // khanhLinhDataSet1
            // 
            this.khanhLinhDataSet1.DataSetName = "KhanhLinhDataSet1";
            this.khanhLinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // vItemTableAdapter
            // 
            this.vItemTableAdapter.ClearBeforeFill = true;
            // 
            // statusBarUC1
            // 
            this.statusBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.statusBarUC1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarUC1.Location = new System.Drawing.Point(0, 510);
            this.statusBarUC1.Name = "statusBarUC1";
            this.statusBarUC1.Size = new System.Drawing.Size(1044, 41);
            this.statusBarUC1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Đơn vị";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDescriptionDataGridViewTextBoxColumn
            // 
            this.unitDescriptionDataGridViewTextBoxColumn.DataPropertyName = "UnitDescription";
            this.unitDescriptionDataGridViewTextBoxColumn.HeaderText = "Miêu tả về đơn vị";
            this.unitDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDescriptionDataGridViewTextBoxColumn.Name = "unitDescriptionDataGridViewTextBoxColumn";
            this.unitDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // isItemWithSerialDataGridViewCheckBoxColumn
            // 
            this.isItemWithSerialDataGridViewCheckBoxColumn.DataPropertyName = "IsItemWithSerial";
            this.isItemWithSerialDataGridViewCheckBoxColumn.HeaderText = "Theo dõi Serial";
            this.isItemWithSerialDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isItemWithSerialDataGridViewCheckBoxColumn.Name = "isItemWithSerialDataGridViewCheckBoxColumn";
            this.isItemWithSerialDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isItemWithSerialDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Hoạt động";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 551);
            this.Controls.Add(this.statusBarUC1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox roleStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcKhoHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcLoạiXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcTuyếnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcBộPhậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcCôngViệcSửaChữaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhMứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhMứcVậtTưTiêuHaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhMứcVậtTưSửaChữaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuTheoDõiHànhTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtKhoToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource khanhLinhDataSet1BindingSource;
        private KhanhLinhDataSet1 khanhLinhDataSet1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private KhanhLinhDataSet1TableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.BindingSource finalDataSet1BindingSource;
        private FinalDataSet1 finalDataSet1;
        private System.Windows.Forms.BindingSource vItemBindingSource;
        private FinalDataSet1TableAdapters.vItemTableAdapter vItemTableAdapter;
        private StatusBarUC statusBarUC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isItemWithSerialDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}