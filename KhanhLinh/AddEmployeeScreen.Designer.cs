namespace KhanhLinh
{
    partial class AddEmployeeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roleStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcVậtTưHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.empIsRepairMan = new System.Windows.Forms.CheckBox();
            this.empJobSkillLevel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.empBornPlace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empDOB = new System.Windows.Forms.DateTimePicker();
            this.empPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khanhLinhDataSet1 = new KhanhLinh.KhanhLinhDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.departmentTableAdapter = new KhanhLinh.KhanhLinhDataSet1TableAdapters.DepartmentTableAdapter();
            this.finalDataSet = new KhanhLinh.FinalDataSet();
            this.statusBarUC1 = new KhanhLinh.StatusBarUC();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
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
            this.danhSáchToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 41);
            this.menuStrip1.TabIndex = 5;
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
            this.danhMụcVậtTưHàngHóaToolStripMenuItem,
            this.danhMụcLoạiXeToolStripMenuItem,
            this.danhMụcTuyếnToolStripMenuItem,
            this.danhMụcBộPhậnToolStripMenuItem,
            this.danhMụcXeToolStripMenuItem,
            this.danhMụcCôngViệcSửaChữaToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 37);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // danhMụcVậtTưHàngHóaToolStripMenuItem
            // 
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Name = "danhMụcVậtTưHàngHóaToolStripMenuItem";
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Text = "Danh mục vật tư hàng hóa";
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.danhMụcVậtTưHàngHóaToolStripMenuItem_Click);
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
            // danhSáchToolStripMenuItem
            // 
            this.danhSáchToolStripMenuItem.Image = global::KhanhLinh.Properties.Resources.icons8_list_50;
            this.danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            this.danhSáchToolStripMenuItem.Size = new System.Drawing.Size(111, 37);
            this.danhSáchToolStripMenuItem.Text = "Danh sách";
            this.danhSáchToolStripMenuItem.Click += new System.EventHandler(this.danhSáchToolStripMenuItem_Click);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Image = global::KhanhLinh.Properties.Resources.icons8_update_50;
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(102, 37);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.empIsRepairMan);
            this.panel2.Controls.Add(this.empJobSkillLevel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.empBornPlace);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.empGender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.empDOB);
            this.panel2.Controls.Add(this.empPhoneNumber);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.empName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.empCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.departmentBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(9, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 543);
            this.panel2.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.addBtn.Location = new System.Drawing.Point(32, 480);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(171, 42);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Lưu và đóng";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // empIsRepairMan
            // 
            this.empIsRepairMan.AutoSize = true;
            this.empIsRepairMan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.empIsRepairMan.Location = new System.Drawing.Point(771, 304);
            this.empIsRepairMan.Name = "empIsRepairMan";
            this.empIsRepairMan.Size = new System.Drawing.Size(207, 29);
            this.empIsRepairMan.TabIndex = 31;
            this.empIsRepairMan.Text = "Công nhân sửa chữa";
            this.empIsRepairMan.UseVisualStyleBackColor = true;
            // 
            // empJobSkillLevel
            // 
            this.empJobSkillLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empJobSkillLevel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.empJobSkillLevel.Location = new System.Drawing.Point(682, 246);
            this.empJobSkillLevel.Name = "empJobSkillLevel";
            this.empJobSkillLevel.Size = new System.Drawing.Size(296, 32);
            this.empJobSkillLevel.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.Location = new System.Drawing.Point(588, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Trình độ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label6.Location = new System.Drawing.Point(27, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Quê quán";
            // 
            // empBornPlace
            // 
            this.empBornPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empBornPlace.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.empBornPlace.Location = new System.Drawing.Point(148, 246);
            this.empBornPlace.Name = "empBornPlace";
            this.empBornPlace.Size = new System.Drawing.Size(418, 32);
            this.empBornPlace.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(665, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Giới tính";
            // 
            // empGender
            // 
            this.empGender.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.empGender.FormattingEnabled = true;
            this.empGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.empGender.Location = new System.Drawing.Point(763, 177);
            this.empGender.Name = "empGender";
            this.empGender.Size = new System.Drawing.Size(215, 33);
            this.empGender.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(381, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ngày sinh";
            // 
            // empDOB
            // 
            this.empDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empDOB.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDOB.CustomFormat = "dd/MM/yyyy";
            this.empDOB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.empDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.empDOB.Location = new System.Drawing.Point(478, 177);
            this.empDOB.Name = "empDOB";
            this.empDOB.Size = new System.Drawing.Size(157, 32);
            this.empDOB.TabIndex = 22;
            // 
            // empPhoneNumber
            // 
            this.empPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.empPhoneNumber.Location = new System.Drawing.Point(148, 177);
            this.empPhoneNumber.Name = "empPhoneNumber";
            this.empPhoneNumber.Size = new System.Drawing.Size(218, 32);
            this.empPhoneNumber.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "SĐT";
            // 
            // empName
            // 
            this.empName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.empName.Location = new System.Drawing.Point(148, 108);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(830, 32);
            this.empName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên";
            // 
            // empCode
            // 
            this.empCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.empCode.Location = new System.Drawing.Point(148, 39);
            this.empCode.Name = "empCode";
            this.empCode.Size = new System.Drawing.Size(386, 32);
            this.empCode.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã";
            // 
            // departmentBox
            // 
            this.departmentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentBox.DataSource = this.departmentBindingSource;
            this.departmentBox.DisplayMember = "Name";
            this.departmentBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(682, 39);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(296, 33);
            this.departmentBox.TabIndex = 14;
            this.departmentBox.ValueMember = "Id";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.khanhLinhDataSet1;
            // 
            // khanhLinhDataSet1
            // 
            this.khanhLinhDataSet1.DataSetName = "KhanhLinhDataSet1";
            this.khanhLinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label8.Location = new System.Drawing.Point(556, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bộ phận";
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // finalDataSet
            // 
            this.finalDataSet.DataSetName = "FinalDataSet";
            this.finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBarUC1
            // 
            this.statusBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.statusBarUC1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarUC1.Location = new System.Drawing.Point(0, 619);
            this.statusBarUC1.Name = "statusBarUC1";
            this.statusBarUC1.Size = new System.Drawing.Size(1029, 41);
            this.statusBarUC1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button1.Location = new System.Drawing.Point(223, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 42);
            this.button1.TabIndex = 33;
            this.button1.Text = "Lưu và thêm mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button2.Location = new System.Drawing.Point(440, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 42);
            this.button2.TabIndex = 34;
            this.button2.Text = "Hủy bỏ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AddEmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 660);
            this.Controls.Add(this.statusBarUC1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployeeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddEmployeeScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox roleStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcVậtTưHàngHóaToolStripMenuItem;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.Label label8;
        private KhanhLinhDataSet1 khanhLinhDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private KhanhLinhDataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.TextBox empPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker empDOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empBornPlace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox empGender;
        private System.Windows.Forms.TextBox empJobSkillLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.CheckBox empIsRepairMan;
        private System.Windows.Forms.Label label1;
        private FinalDataSet finalDataSet;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empCode;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private StatusBarUC statusBarUC1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}