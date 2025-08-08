namespace KhanhLinh
{
    partial class AddConsumptionNormScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roleStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcKhoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcVậtTưHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcLoạiXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcTuyếnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcBộPhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcCôngViệcSửaChữaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhMứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuTheoDõiHànhTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.conNormItemQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.conNormItemCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.conNormItemUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.conNormCreatedBy = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet = new KhanhLinh.FinalDataSet();
            this.conNormFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.conNormStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.conNormItemType = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.conNormDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.conNormCarTypeId = new System.Windows.Forms.ComboBox();
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTypeTableAdapter = new KhanhLinh.FinalDataSetTableAdapters.CarTypeTableAdapter();
            this.employeeTableAdapter = new KhanhLinh.FinalDataSetTableAdapters.EmployeeTableAdapter();
            this.itemTableAdapter = new KhanhLinh.FinalDataSetTableAdapters.ItemTableAdapter();
            this.statusBarUC1 = new KhanhLinh.StatusBarUC();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).BeginInit();
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
            this.phiếuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 41);
            this.menuStrip1.TabIndex = 2;
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
            this.danhMụcVậtTưHàngHóaToolStripMenuItem,
            this.danhMụcNhânViênToolStripMenuItem,
            this.danhMụcLoạiXeToolStripMenuItem,
            this.danhMụcTuyếnToolStripMenuItem,
            this.danhMụcBộPhậnToolStripMenuItem,
            this.danhMụcXeToolStripMenuItem,
            this.danhMụcCôngViệcSửaChữaToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 37);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // danhMụcKhoHàngToolStripMenuItem
            // 
            this.danhMụcKhoHàngToolStripMenuItem.Name = "danhMụcKhoHàngToolStripMenuItem";
            this.danhMụcKhoHàngToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcKhoHàngToolStripMenuItem.Text = "Danh mục kho hàng";
            this.danhMụcKhoHàngToolStripMenuItem.Click += new System.EventHandler(this.danhMụcKhoHàngToolStripMenuItem_Click);
            // 
            // danhMụcVậtTưHàngHóaToolStripMenuItem
            // 
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Name = "danhMụcVậtTưHàngHóaToolStripMenuItem";
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Text = "Danh mục vật tư hàng hóa";
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.danhMụcVậtTưHàngHóaToolStripMenuItem_Click);
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
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem});
            this.địnhMứcToolStripMenuItem.Name = "địnhMứcToolStripMenuItem";
            this.địnhMứcToolStripMenuItem.Size = new System.Drawing.Size(87, 37);
            this.địnhMứcToolStripMenuItem.Text = "Định mức";
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
            this.phiếuToolStripMenuItem.Size = new System.Drawing.Size(59, 37);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.conNormItemQuantity);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.conNormItemCode);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.conNormItemUnit);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.conNormCreatedBy);
            this.panel2.Controls.Add(this.conNormFinishDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.conNormStartDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.conNormItemType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.conNormDescription);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.conNormCarTypeId);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 644);
            this.panel2.TabIndex = 11;
            // 
            // conNormItemQuantity
            // 
            this.conNormItemQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conNormItemQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormItemQuantity.Location = new System.Drawing.Point(352, 271);
            this.conNormItemQuantity.Name = "conNormItemQuantity";
            this.conNormItemQuantity.Size = new System.Drawing.Size(354, 38);
            this.conNormItemQuantity.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(276, 31);
            this.label10.TabIndex = 48;
            this.label10.Text = "Số định mức (trên 100km)";
            // 
            // conNormItemCode
            // 
            this.conNormItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conNormItemCode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormItemCode.Location = new System.Drawing.Point(352, 472);
            this.conNormItemCode.Name = "conNormItemCode";
            this.conNormItemCode.Size = new System.Drawing.Size(299, 38);
            this.conNormItemCode.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(190, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 31);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mã vật tư";
            // 
            // conNormItemUnit
            // 
            this.conNormItemUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conNormItemUnit.Enabled = false;
            this.conNormItemUnit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormItemUnit.Location = new System.Drawing.Point(827, 210);
            this.conNormItemUnit.Name = "conNormItemUnit";
            this.conNormItemUnit.Size = new System.Drawing.Size(155, 38);
            this.conNormItemUnit.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(752, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 31);
            this.label8.TabIndex = 44;
            this.label8.Text = "ĐVT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "Người tạo";
            // 
            // conNormCreatedBy
            // 
            this.conNormCreatedBy.DataSource = this.employeeBindingSource;
            this.conNormCreatedBy.DisplayMember = "Name";
            this.conNormCreatedBy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormCreatedBy.FormattingEnabled = true;
            this.conNormCreatedBy.Location = new System.Drawing.Point(637, 88);
            this.conNormCreatedBy.Name = "conNormCreatedBy";
            this.conNormCreatedBy.Size = new System.Drawing.Size(345, 39);
            this.conNormCreatedBy.TabIndex = 40;
            this.conNormCreatedBy.ValueMember = "Id";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.finalDataSetBindingSource;
            // 
            // finalDataSetBindingSource
            // 
            this.finalDataSetBindingSource.DataSource = this.finalDataSet;
            this.finalDataSetBindingSource.Position = 0;
            // 
            // finalDataSet
            // 
            this.finalDataSet.DataSetName = "FinalDataSet";
            this.finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conNormFinishDate
            // 
            this.conNormFinishDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conNormFinishDate.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormFinishDate.CustomFormat = "dd/MM/yyyy";
            this.conNormFinishDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.conNormFinishDate.Location = new System.Drawing.Point(590, 27);
            this.conNormFinishDate.Name = "conNormFinishDate";
            this.conNormFinishDate.Size = new System.Drawing.Size(162, 38);
            this.conNormFinishDate.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ngày kết thúc";
            // 
            // conNormStartDate
            // 
            this.conNormStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conNormStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormStartDate.CustomFormat = "dd/MM/yyyy";
            this.conNormStartDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.conNormStartDate.Location = new System.Drawing.Point(187, 27);
            this.conNormStartDate.Name = "conNormStartDate";
            this.conNormStartDate.Size = new System.Drawing.Size(159, 38);
            this.conNormStartDate.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // conNormItemType
            // 
            this.conNormItemType.DataSource = this.itemBindingSource;
            this.conNormItemType.DisplayMember = "Name";
            this.conNormItemType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormItemType.FormattingEnabled = true;
            this.conNormItemType.Location = new System.Drawing.Point(187, 210);
            this.conNormItemType.Name = "conNormItemType";
            this.conNormItemType.Size = new System.Drawing.Size(519, 39);
            this.conNormItemType.TabIndex = 35;
            this.conNormItemType.ValueMember = "Id";
            this.conNormItemType.SelectionChangeCommitted += new System.EventHandler(this.itemType_SelectionChangeCommitted);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.finalDataSetBindingSource;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "Vật tư";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(817, 579);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 42);
            this.addBtn.TabIndex = 33;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại xe";
            // 
            // conNormDescription
            // 
            this.conNormDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conNormDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormDescription.Location = new System.Drawing.Point(187, 149);
            this.conNormDescription.Name = "conNormDescription";
            this.conNormDescription.Size = new System.Drawing.Size(795, 38);
            this.conNormDescription.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mô tả";
            // 
            // conNormCarTypeId
            // 
            this.conNormCarTypeId.DataSource = this.carTypeBindingSource;
            this.conNormCarTypeId.DisplayMember = "Code";
            this.conNormCarTypeId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNormCarTypeId.FormattingEnabled = true;
            this.conNormCarTypeId.Location = new System.Drawing.Point(187, 88);
            this.conNormCarTypeId.Name = "conNormCarTypeId";
            this.conNormCarTypeId.Size = new System.Drawing.Size(269, 39);
            this.conNormCarTypeId.TabIndex = 0;
            this.conNormCarTypeId.ValueMember = "Id";
            // 
            // carTypeBindingSource
            // 
            this.carTypeBindingSource.DataMember = "CarType";
            this.carTypeBindingSource.DataSource = this.finalDataSetBindingSource;
            // 
            // carTypeTableAdapter
            // 
            this.carTypeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // statusBarUC1
            // 
            this.statusBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.statusBarUC1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarUC1.Location = new System.Drawing.Point(0, 703);
            this.statusBarUC1.Name = "statusBarUC1";
            this.statusBarUC1.Size = new System.Drawing.Size(1034, 41);
            this.statusBarUC1.TabIndex = 12;
            // 
            // AddConsumptionNormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 744);
            this.Controls.Add(this.statusBarUC1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddConsumptionNormScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddConsumptionNormScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddConsumptionNormScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox roleStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcKhoHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcVậtTưHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcLoạiXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcTuyếnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcBộPhậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcCôngViệcSửaChữaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhMứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhMứcVậtTưSửaChữaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuTheoDõiHànhTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox conNormItemType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox conNormDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox conNormCarTypeId;
        private System.Windows.Forms.DateTimePicker conNormStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker conNormFinishDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox conNormCreatedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox conNormItemUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox conNormItemCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox conNormItemQuantity;
        private System.Windows.Forms.BindingSource finalDataSetBindingSource;
        private FinalDataSet finalDataSet;
        private System.Windows.Forms.BindingSource carTypeBindingSource;
        private FinalDataSetTableAdapters.CarTypeTableAdapter carTypeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private FinalDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private FinalDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private StatusBarUC statusBarUC1;
    }
}