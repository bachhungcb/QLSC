namespace KhanhLinh
{
    partial class UpdateRepairJobScreen
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
            this.địnhMứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhMứcVậtTưTiêuHaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhMứcVậtTưSửaChữaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuTheoDõiHànhTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.repairJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet1 = new KhanhLinh.FinalDataSet1();
            this.jobType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.intendTime = new System.Windows.Forms.DateTimePicker();
            this.skillLevel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repairJobDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repairJobCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repairJobCarTypeId = new System.Windows.Forms.ComboBox();
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairJobTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.RepairJobTableAdapter();
            this.carTypeTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.CarTypeTableAdapter();
            this.statusBarUC1 = new KhanhLinh.StatusBarUC();
            this.repairJobName1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).BeginInit();
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
            this.phiếuToolStripMenuItem,
            this.danhSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 41);
            this.menuStrip1.TabIndex = 3;
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
            this.danhMụcXeToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 37);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // danhMụcKhoHàngToolStripMenuItem
            // 
            this.danhMụcKhoHàngToolStripMenuItem.Name = "danhMụcKhoHàngToolStripMenuItem";
            this.danhMụcKhoHàngToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcKhoHàngToolStripMenuItem.Text = "Danh mục kho hàng";
            // 
            // danhMụcVậtTưHàngHóaToolStripMenuItem
            // 
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Name = "danhMụcVậtTưHàngHóaToolStripMenuItem";
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcVậtTưHàngHóaToolStripMenuItem.Text = "Danh mục vật tư hàng hóa";
            // 
            // danhMụcNhânViênToolStripMenuItem
            // 
            this.danhMụcNhânViênToolStripMenuItem.Name = "danhMụcNhânViênToolStripMenuItem";
            this.danhMụcNhânViênToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcNhânViênToolStripMenuItem.Text = "Danh mục nhân viên";
            // 
            // danhMụcLoạiXeToolStripMenuItem
            // 
            this.danhMụcLoạiXeToolStripMenuItem.Name = "danhMụcLoạiXeToolStripMenuItem";
            this.danhMụcLoạiXeToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcLoạiXeToolStripMenuItem.Text = "Danh mục loại xe";
            // 
            // danhMụcTuyếnToolStripMenuItem
            // 
            this.danhMụcTuyếnToolStripMenuItem.Name = "danhMụcTuyếnToolStripMenuItem";
            this.danhMụcTuyếnToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcTuyếnToolStripMenuItem.Text = "Danh mục tuyến";
            // 
            // danhMụcBộPhậnToolStripMenuItem
            // 
            this.danhMụcBộPhậnToolStripMenuItem.Name = "danhMụcBộPhậnToolStripMenuItem";
            this.danhMụcBộPhậnToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcBộPhậnToolStripMenuItem.Text = "Danh mục bộ phận";
            // 
            // danhMụcXeToolStripMenuItem
            // 
            this.danhMụcXeToolStripMenuItem.Name = "danhMụcXeToolStripMenuItem";
            this.danhMụcXeToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcXeToolStripMenuItem.Text = "Danh mục xe";
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
            // 
            // phiếuNhậpKhoToolStripMenuItem
            // 
            this.phiếuNhậpKhoToolStripMenuItem.Name = "phiếuNhậpKhoToolStripMenuItem";
            this.phiếuNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.phiếuNhậpKhoToolStripMenuItem.Text = "Phiếu nhập kho";
            // 
            // phiếuXuấtKhoToolStripMenuItem
            // 
            this.phiếuXuấtKhoToolStripMenuItem.Name = "phiếuXuấtKhoToolStripMenuItem";
            this.phiếuXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
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
            this.panel2.Controls.Add(this.repairJobName1);
            this.panel2.Controls.Add(this.jobType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.intendTime);
            this.panel2.Controls.Add(this.skillLevel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.repairJobDescription);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.repairJobCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.repairJobCarTypeId);
            this.panel2.Location = new System.Drawing.Point(9, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 556);
            this.panel2.TabIndex = 11;
            // 
            // repairJobBindingSource
            // 
            this.repairJobBindingSource.DataMember = "RepairJob";
            this.repairJobBindingSource.DataSource = this.finalDataSet1BindingSource;
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
            // jobType
            // 
            this.jobType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobType.FormattingEnabled = true;
            this.jobType.Location = new System.Drawing.Point(485, 389);
            this.jobType.Name = "jobType";
            this.jobType.Size = new System.Drawing.Size(506, 39);
            this.jobType.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(489, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "Loại công việc";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(860, 499);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(134, 42);
            this.updateBtn.TabIndex = 33;
            this.updateBtn.Text = "Lưu";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // intendTime
            // 
            this.intendTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intendTime.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intendTime.CustomFormat = "dd/MM/yyyy";
            this.intendTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intendTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.intendTime.Location = new System.Drawing.Point(485, 294);
            this.intendTime.Name = "intendTime";
            this.intendTime.Size = new System.Drawing.Size(509, 38);
            this.intendTime.TabIndex = 23;
            // 
            // skillLevel
            // 
            this.skillLevel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLevel.Location = new System.Drawing.Point(21, 390);
            this.skillLevel.Name = "skillLevel";
            this.skillLevel.Size = new System.Drawing.Size(458, 38);
            this.skillLevel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bậc thợ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thời gian dự kiến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại xe";
            // 
            // repairJobDescription
            // 
            this.repairJobDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairJobDescription.Location = new System.Drawing.Point(21, 182);
            this.repairJobDescription.Name = "repairJobDescription";
            this.repairJobDescription.Size = new System.Drawing.Size(970, 38);
            this.repairJobDescription.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            // 
            // repairJobCode
            // 
            this.repairJobCode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairJobCode.Location = new System.Drawing.Point(21, 73);
            this.repairJobCode.Name = "repairJobCode";
            this.repairJobCode.Size = new System.Drawing.Size(458, 38);
            this.repairJobCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // repairJobCarTypeId
            // 
            this.repairJobCarTypeId.DataSource = this.carTypeBindingSource;
            this.repairJobCarTypeId.DisplayMember = "Name";
            this.repairJobCarTypeId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairJobCarTypeId.FormattingEnabled = true;
            this.repairJobCarTypeId.Location = new System.Drawing.Point(21, 293);
            this.repairJobCarTypeId.Name = "repairJobCarTypeId";
            this.repairJobCarTypeId.Size = new System.Drawing.Size(458, 39);
            this.repairJobCarTypeId.TabIndex = 0;
            this.repairJobCarTypeId.ValueMember = "Id";
            // 
            // carTypeBindingSource
            // 
            this.carTypeBindingSource.DataMember = "CarType";
            this.carTypeBindingSource.DataSource = this.finalDataSet1BindingSource;
            // 
            // repairJobTableAdapter
            // 
            this.repairJobTableAdapter.ClearBeforeFill = true;
            // 
            // carTypeTableAdapter
            // 
            this.carTypeTableAdapter.ClearBeforeFill = true;
            // 
            // statusBarUC1
            // 
            this.statusBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.statusBarUC1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarUC1.Location = new System.Drawing.Point(0, 619);
            this.statusBarUC1.Name = "statusBarUC1";
            this.statusBarUC1.Size = new System.Drawing.Size(1029, 41);
            this.statusBarUC1.TabIndex = 12;
            // 
            // repairJobName1
            // 
            this.repairJobName1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairJobName1.Location = new System.Drawing.Point(495, 73);
            this.repairJobName1.Name = "repairJobName1";
            this.repairJobName1.Size = new System.Drawing.Size(496, 38);
            this.repairJobName1.TabIndex = 37;
            // 
            // UpdateRepairJobScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 660);
            this.Controls.Add(this.statusBarUC1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UpdateRepairJobScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRepairJobScreen";
            this.Load += new System.EventHandler(this.UpdateRepairJobScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem địnhMứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhMứcVậtTưTiêuHaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhMứcVậtTưSửaChữaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuTheoDõiHànhTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox jobType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DateTimePicker intendTime;
        private System.Windows.Forms.TextBox skillLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox repairJobDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repairJobCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox repairJobCarTypeId;
        private System.Windows.Forms.BindingSource finalDataSet1BindingSource;
        private FinalDataSet1 finalDataSet1;
        private System.Windows.Forms.BindingSource repairJobBindingSource;
        private FinalDataSet1TableAdapters.RepairJobTableAdapter repairJobTableAdapter;
        private System.Windows.Forms.BindingSource carTypeBindingSource;
        private FinalDataSet1TableAdapters.CarTypeTableAdapter carTypeTableAdapter;
        private StatusBarUC statusBarUC1;
        private System.Windows.Forms.TextBox repairJobName1;
    }
}