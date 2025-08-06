namespace KhanhLinh
{
    partial class AddRouteTrackingScreen
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
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.routeTrackingRouteLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.routeTrackingTotalKm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.routeTrackingRouteKm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.routeTrackingRouteId = new System.Windows.Forms.ComboBox();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet = new KhanhLinh.FinalDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.routeTrackingCarId = new System.Windows.Forms.ComboBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addBtn = new System.Windows.Forms.Button();
            this.routeTrackingDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.routeTrackingStartDate = new System.Windows.Forms.DateTimePicker();
            this.routeTrackingOthersKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.routeTrackingMobilKm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.carTableAdapter = new KhanhLinh.FinalDataSetTableAdapters.CarTableAdapter();
            this.routeTableAdapter = new KhanhLinh.FinalDataSetTableAdapters.RouteTableAdapter();
            this.statusBarUC1 = new KhanhLinh.StatusBarUC();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
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
            this.danhSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 41);
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
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem,
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem});
            this.địnhMứcToolStripMenuItem.Name = "địnhMứcToolStripMenuItem";
            this.địnhMứcToolStripMenuItem.Size = new System.Drawing.Size(87, 37);
            this.địnhMứcToolStripMenuItem.Text = "Định mức";
            // 
            // địnhMứcVậtTưTiêuHaoToolStripMenuItem
            // 
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem.Name = "địnhMứcVậtTưTiêuHaoToolStripMenuItem";
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem.Text = "Định mức vật tư tiêu hao";
            // 
            // địnhMứcVậtTưSửaChữaToolStripMenuItem
            // 
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem.Name = "địnhMứcVậtTưSửaChữaToolStripMenuItem";
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem.Text = "Định mức vật tư sửa chữa";
            // 
            // phiếuToolStripMenuItem
            // 
            this.phiếuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuNhậpKhoToolStripMenuItem,
            this.phiếuXuấtKhoToolStripMenuItem});
            this.phiếuToolStripMenuItem.Name = "phiếuToolStripMenuItem";
            this.phiếuToolStripMenuItem.Size = new System.Drawing.Size(59, 37);
            this.phiếuToolStripMenuItem.Text = "Phiếu";
            // 
            // phiếuNhậpKhoToolStripMenuItem
            // 
            this.phiếuNhậpKhoToolStripMenuItem.Name = "phiếuNhậpKhoToolStripMenuItem";
            this.phiếuNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.phiếuNhậpKhoToolStripMenuItem.Text = "Phiếu nhập kho";
            // 
            // phiếuXuấtKhoToolStripMenuItem
            // 
            this.phiếuXuấtKhoToolStripMenuItem.Name = "phiếuXuấtKhoToolStripMenuItem";
            this.phiếuXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.phiếuXuấtKhoToolStripMenuItem.Text = "Phiếu xuất kho";
            // 
            // danhSáchToolStripMenuItem
            // 
            this.danhSáchToolStripMenuItem.Image = global::KhanhLinh.Properties.Resources.icons8_list_50;
            this.danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            this.danhSáchToolStripMenuItem.Size = new System.Drawing.Size(111, 37);
            this.danhSáchToolStripMenuItem.Text = "Danh sách";
            this.danhSáchToolStripMenuItem.Click += new System.EventHandler(this.danhSáchToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.routeTrackingRouteLength);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.routeTrackingTotalKm);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.routeTrackingRouteKm);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.routeTrackingRouteId);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.routeTrackingCarId);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.routeTrackingDesc);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.routeTrackingStartDate);
            this.panel2.Controls.Add(this.routeTrackingOthersKm);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.empName);
            this.panel2.Controls.Add(this.routeTrackingMobilKm);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 560);
            this.panel2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Miêu tả";
            // 
            // routeTrackingRouteLength
            // 
            this.routeTrackingRouteLength.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingRouteLength.Location = new System.Drawing.Point(683, 322);
            this.routeTrackingRouteLength.Name = "routeTrackingRouteLength";
            this.routeTrackingRouteLength.Size = new System.Drawing.Size(310, 38);
            this.routeTrackingRouteLength.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(678, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Độ dài hành trình";
            // 
            // routeTrackingTotalKm
            // 
            this.routeTrackingTotalKm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingTotalKm.Location = new System.Drawing.Point(32, 319);
            this.routeTrackingTotalKm.Name = "routeTrackingTotalKm";
            this.routeTrackingTotalKm.Size = new System.Drawing.Size(316, 38);
            this.routeTrackingTotalKm.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Tổng số Km";
            // 
            // routeTrackingRouteKm
            // 
            this.routeTrackingRouteKm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingRouteKm.Location = new System.Drawing.Point(683, 219);
            this.routeTrackingRouteKm.Name = "routeTrackingRouteKm";
            this.routeTrackingRouteKm.Size = new System.Drawing.Size(310, 38);
            this.routeTrackingRouteKm.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Số Km của hành trình";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // routeTrackingRouteId
            // 
            this.routeTrackingRouteId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeTrackingRouteId.DataSource = this.routeBindingSource;
            this.routeTrackingRouteId.DisplayMember = "Name";
            this.routeTrackingRouteId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingRouteId.FormattingEnabled = true;
            this.routeTrackingRouteId.Location = new System.Drawing.Point(544, 46);
            this.routeTrackingRouteId.Name = "routeTrackingRouteId";
            this.routeTrackingRouteId.Size = new System.Drawing.Size(449, 39);
            this.routeTrackingRouteId.TabIndex = 35;
            this.routeTrackingRouteId.ValueMember = "Id";
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.finalDataSetBindingSource;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(544, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Hành trình";
            // 
            // routeTrackingCarId
            // 
            this.routeTrackingCarId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeTrackingCarId.DataSource = this.carBindingSource;
            this.routeTrackingCarId.DisplayMember = "Name";
            this.routeTrackingCarId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingCarId.FormattingEnabled = true;
            this.routeTrackingCarId.Location = new System.Drawing.Point(32, 46);
            this.routeTrackingCarId.Name = "routeTrackingCarId";
            this.routeTrackingCarId.Size = new System.Drawing.Size(506, 39);
            this.routeTrackingCarId.TabIndex = 33;
            this.routeTrackingCarId.ValueMember = "Id";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.finalDataSetBindingSource;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(859, 501);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 42);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // routeTrackingDesc
            // 
            this.routeTrackingDesc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingDesc.Location = new System.Drawing.Point(32, 139);
            this.routeTrackingDesc.Name = "routeTrackingDesc";
            this.routeTrackingDesc.Size = new System.Drawing.Size(961, 38);
            this.routeTrackingDesc.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, -51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Miêu tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // routeTrackingStartDate
            // 
            this.routeTrackingStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeTrackingStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingStartDate.CustomFormat = "dd/MM/yyyy";
            this.routeTrackingStartDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.routeTrackingStartDate.Location = new System.Drawing.Point(367, 319);
            this.routeTrackingStartDate.Name = "routeTrackingStartDate";
            this.routeTrackingStartDate.Size = new System.Drawing.Size(299, 38);
            this.routeTrackingStartDate.TabIndex = 22;
            // 
            // routeTrackingOthersKm
            // 
            this.routeTrackingOthersKm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingOthersKm.Location = new System.Drawing.Point(367, 219);
            this.routeTrackingOthersKm.Name = "routeTrackingOthersKm";
            this.routeTrackingOthersKm.Size = new System.Drawing.Size(299, 38);
            this.routeTrackingOthersKm.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số Km phát sinh";
            // 
            // empName
            // 
            this.empName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(32, 219);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(316, 38);
            this.empName.TabIndex = 19;
            // 
            // routeTrackingMobilKm
            // 
            this.routeTrackingMobilKm.AutoSize = true;
            this.routeTrackingMobilKm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTrackingMobilKm.Location = new System.Drawing.Point(33, 191);
            this.routeTrackingMobilKm.Name = "routeTrackingMobilKm";
            this.routeTrackingMobilKm.Size = new System.Drawing.Size(146, 25);
            this.routeTrackingMobilKm.TabIndex = 18;
            this.routeTrackingMobilKm.Text = "Số Km huy động";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Xe";
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // statusBarUC1
            // 
            this.statusBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.statusBarUC1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarUC1.Location = new System.Drawing.Point(0, 619);
            this.statusBarUC1.Name = "statusBarUC1";
            this.statusBarUC1.Size = new System.Drawing.Size(1029, 41);
            this.statusBarUC1.TabIndex = 9;
            // 
            // AddRouteTrackingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 660);
            this.Controls.Add(this.statusBarUC1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddRouteTrackingScreen";
            this.Load += new System.EventHandler(this.AddRouteTrackingScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem địnhMứcVậtTưTiêuHaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhMứcVậtTưSửaChữaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox routeTrackingDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker routeTrackingStartDate;
        private System.Windows.Forms.TextBox routeTrackingOthersKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label routeTrackingMobilKm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox routeTrackingCarId;
        private System.Windows.Forms.BindingSource finalDataSetBindingSource;
        private FinalDataSet finalDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private FinalDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.ComboBox routeTrackingRouteId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private FinalDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.TextBox routeTrackingRouteKm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox routeTrackingRouteLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox routeTrackingTotalKm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private StatusBarUC statusBarUC1;
    }
}