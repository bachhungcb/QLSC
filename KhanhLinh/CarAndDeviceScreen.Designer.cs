namespace KhanhLinh
{
    partial class CarAndDeviceScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.carCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.licensePlate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chassisNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.khanhLinhDataSet = new KhanhLinh.KhanhLinhDataSet();
            this.departmentTableAdapter = new KhanhLinh.KhanhLinhDataSetTableAdapters.DepartmentTableAdapter();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.carStatus = new System.Windows.Forms.TextBox();
            this.firstUsedDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.madeYear = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.khanhLinhDataSet1 = new KhanhLinh.KhanhLinhDataSet1();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new KhanhLinh.KhanhLinhDataSet1TableAdapters.CarTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstUsedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lisencePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassisNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialManagement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.madeYear);
            this.panel1.Controls.Add(this.addCarBtn);
            this.panel1.Controls.Add(this.purchaseDate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.firstUsedDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.carStatus);
            this.panel1.Controls.Add(this.departmentBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chassisNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.licensePlate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.carName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.carCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(218, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 396);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.materialManagement);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 564);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(218, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 169);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xe, thiết bị";
            // 
            // carCode
            // 
            this.carCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carCode.Location = new System.Drawing.Point(34, 91);
            this.carCode.Name = "carCode";
            this.carCode.Size = new System.Drawing.Size(221, 28);
            this.carCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên xe";
            // 
            // carName
            // 
            this.carName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carName.Location = new System.Drawing.Point(263, 91);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(284, 28);
            this.carName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mẫu mã";
            // 
            // model
            // 
            this.model.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.Location = new System.Drawing.Point(34, 160);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(221, 28);
            this.model.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Biển kiểm soát";
            // 
            // licensePlate
            // 
            this.licensePlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.licensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlate.Location = new System.Drawing.Point(263, 160);
            this.licensePlate.Name = "licensePlate";
            this.licensePlate.Size = new System.Drawing.Size(284, 28);
            this.licensePlate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số khung máy";
            // 
            // chassisNumber
            // 
            this.chassisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chassisNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassisNumber.Location = new System.Drawing.Point(34, 230);
            this.chassisNumber.Name = "chassisNumber";
            this.chassisNumber.Size = new System.Drawing.Size(513, 28);
            this.chassisNumber.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(549, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phòng/ban";
            // 
            // departmentBox
            // 
            this.departmentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentBox.DataSource = this.departmentBindingSource1;
            this.departmentBox.DisplayMember = "DepartmentName";
            this.departmentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(553, 160);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(221, 30);
            this.departmentBox.TabIndex = 6;
            this.departmentBox.ValueMember = "Id";
            // 
            // khanhLinhDataSet
            // 
            this.khanhLinhDataSet.DataSetName = "KhanhLinhDataSet";
            this.khanhLinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.khanhLinhDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Trạng thái xe";
            // 
            // carStatus
            // 
            this.carStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carStatus.Location = new System.Drawing.Point(34, 303);
            this.carStatus.Name = "carStatus";
            this.carStatus.Size = new System.Drawing.Size(513, 28);
            this.carStatus.TabIndex = 9;
            // 
            // firstUsedDate
            // 
            this.firstUsedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstUsedDate.CustomFormat = "dd/MM/yyyy";
            this.firstUsedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstUsedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.firstUsedDate.Location = new System.Drawing.Point(553, 230);
            this.firstUsedDate.Name = "firstUsedDate";
            this.firstUsedDate.Size = new System.Drawing.Size(221, 28);
            this.firstUsedDate.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(549, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ngày đầu tiên sử dụng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(553, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ngày mua";
            // 
            // purchaseDate
            // 
            this.purchaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseDate.CustomFormat = "dd/MM/yyy";
            this.purchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseDate.Location = new System.Drawing.Point(553, 303);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Size = new System.Drawing.Size(221, 28);
            this.purchaseDate.TabIndex = 10;
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(679, 344);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(95, 35);
            this.addCarBtn.TabIndex = 22;
            this.addCarBtn.Text = "Thêm";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // madeYear
            // 
            this.madeYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.madeYear.CustomFormat = "yyyy";
            this.madeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madeYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.madeYear.Location = new System.Drawing.Point(553, 91);
            this.madeYear.Name = "madeYear";
            this.madeYear.Size = new System.Drawing.Size(221, 28);
            this.madeYear.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.carCodeDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.subjectIdDataGridViewTextBoxColumn,
            this.madeYearDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.firstUsedDateDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.lisencePlateDataGridViewTextBoxColumn,
            this.chassisNumberDataGridViewTextBoxColumn,
            this.noSDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.routeIdDataGridViewTextBoxColumn,
            this.carTypeIdDataGridViewTextBoxColumn,
            this.carStatusDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // khanhLinhDataSet1
            // 
            this.khanhLinhDataSet1.DataSetName = "KhanhLinhDataSet1";
            this.khanhLinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.khanhLinhDataSet1;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // carCodeDataGridViewTextBoxColumn
            // 
            this.carCodeDataGridViewTextBoxColumn.DataPropertyName = "CarCode";
            this.carCodeDataGridViewTextBoxColumn.HeaderText = "CarCode";
            this.carCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carCodeDataGridViewTextBoxColumn.Name = "carCodeDataGridViewTextBoxColumn";
            this.carCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            this.carNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectIdDataGridViewTextBoxColumn
            // 
            this.subjectIdDataGridViewTextBoxColumn.DataPropertyName = "SubjectId";
            this.subjectIdDataGridViewTextBoxColumn.HeaderText = "SubjectId";
            this.subjectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectIdDataGridViewTextBoxColumn.Name = "subjectIdDataGridViewTextBoxColumn";
            this.subjectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // madeYearDataGridViewTextBoxColumn
            // 
            this.madeYearDataGridViewTextBoxColumn.DataPropertyName = "MadeYear";
            this.madeYearDataGridViewTextBoxColumn.HeaderText = "MadeYear";
            this.madeYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madeYearDataGridViewTextBoxColumn.Name = "madeYearDataGridViewTextBoxColumn";
            this.madeYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstUsedDateDataGridViewTextBoxColumn
            // 
            this.firstUsedDateDataGridViewTextBoxColumn.DataPropertyName = "FirstUsedDate";
            this.firstUsedDateDataGridViewTextBoxColumn.HeaderText = "FirstUsedDate";
            this.firstUsedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstUsedDateDataGridViewTextBoxColumn.Name = "firstUsedDateDataGridViewTextBoxColumn";
            this.firstUsedDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lisencePlateDataGridViewTextBoxColumn
            // 
            this.lisencePlateDataGridViewTextBoxColumn.DataPropertyName = "LisencePlate";
            this.lisencePlateDataGridViewTextBoxColumn.HeaderText = "LisencePlate";
            this.lisencePlateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lisencePlateDataGridViewTextBoxColumn.Name = "lisencePlateDataGridViewTextBoxColumn";
            this.lisencePlateDataGridViewTextBoxColumn.Width = 125;
            // 
            // chassisNumberDataGridViewTextBoxColumn
            // 
            this.chassisNumberDataGridViewTextBoxColumn.DataPropertyName = "ChassisNumber";
            this.chassisNumberDataGridViewTextBoxColumn.HeaderText = "ChassisNumber";
            this.chassisNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chassisNumberDataGridViewTextBoxColumn.Name = "chassisNumberDataGridViewTextBoxColumn";
            this.chassisNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // noSDataGridViewTextBoxColumn
            // 
            this.noSDataGridViewTextBoxColumn.DataPropertyName = "NoS";
            this.noSDataGridViewTextBoxColumn.HeaderText = "NoS";
            this.noSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noSDataGridViewTextBoxColumn.Name = "noSDataGridViewTextBoxColumn";
            this.noSDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeIdDataGridViewTextBoxColumn
            // 
            this.routeIdDataGridViewTextBoxColumn.DataPropertyName = "RouteId";
            this.routeIdDataGridViewTextBoxColumn.HeaderText = "RouteId";
            this.routeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeIdDataGridViewTextBoxColumn.Name = "routeIdDataGridViewTextBoxColumn";
            this.routeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // carTypeIdDataGridViewTextBoxColumn
            // 
            this.carTypeIdDataGridViewTextBoxColumn.DataPropertyName = "CarTypeId";
            this.carTypeIdDataGridViewTextBoxColumn.HeaderText = "CarTypeId";
            this.carTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carTypeIdDataGridViewTextBoxColumn.Name = "carTypeIdDataGridViewTextBoxColumn";
            this.carTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // carStatusDataGridViewTextBoxColumn
            // 
            this.carStatusDataGridViewTextBoxColumn.DataPropertyName = "CarStatus";
            this.carStatusDataGridViewTextBoxColumn.HeaderText = "CarStatus";
            this.carStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carStatusDataGridViewTextBoxColumn.Name = "carStatusDataGridViewTextBoxColumn";
            this.carStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // materialManagement
            // 
            this.materialManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialManagement.Location = new System.Drawing.Point(3, 143);
            this.materialManagement.Name = "materialManagement";
            this.materialManagement.Size = new System.Drawing.Size(195, 66);
            this.materialManagement.TabIndex = 0;
            this.materialManagement.Text = "Quản lý định mức vật tư theo xe";
            this.materialManagement.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cập nhật phiếu theo dõi hành trình xe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CarAndDeviceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1018, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CarAndDeviceScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarAndDeviceScreen";
            this.Load += new System.EventHandler(this.CarAndDeviceScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox chassisNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox licensePlate;
        private System.Windows.Forms.ComboBox departmentBox;
        private KhanhLinhDataSet khanhLinhDataSet;
        private KhanhLinhDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox carStatus;
        private System.Windows.Forms.DateTimePicker purchaseDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker firstUsedDate;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.DateTimePicker madeYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KhanhLinhDataSet1 khanhLinhDataSet1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private KhanhLinhDataSet1TableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstUsedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lisencePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassisNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button materialManagement;
    }
}