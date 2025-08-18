namespace KhanhLinh
{
    partial class LenhSuaChua
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet1 = new KhanhLinh.FinalDataSet1();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docNo = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.carId = new System.Windows.Forms.ComboBox();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docDate = new System.Windows.Forms.DateTimePicker();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.thongTinVatTu2 = new KhanhLinh.ThongTinVatTu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.noiDungBaoDuong2 = new KhanhLinh.NoiDungBaoDuong();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.carTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.CarTableAdapter();
            this.routeTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.RouteTableAdapter();
            this.carTypeTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.CarTypeTableAdapter();
            this.departmentTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.DepartmentTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new KhanhLinh.FinalDataSet1TableAdapters.EmployeeTableAdapter();
            this.summary = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createdBy = new System.Windows.Forms.ComboBox();
            this.khanhLinhDataSet1 = new KhanhLinh.KhanhLinhDataSet1();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new KhanhLinh.KhanhLinhDataSet1TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "1. Số phiếu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "3. Kết luận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label7.Size = new System.Drawing.Size(73, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "4. Diễn giải";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.finalDataSet1;
            // 
            // finalDataSet1
            // 
            this.finalDataSet1.DataSetName = "FinalDataSet1";
            this.finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.finalDataSet1;
            // 
            // docNo
            // 
            this.docNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.docNo.Location = new System.Drawing.Point(180, 67);
            this.docNo.Margin = new System.Windows.Forms.Padding(4);
            this.docNo.Name = "docNo";
            this.docNo.Size = new System.Drawing.Size(683, 22);
            this.docNo.TabIndex = 18;
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description.Location = new System.Drawing.Point(180, 132);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(683, 22);
            this.description.TabIndex = 19;
            this.description.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label8.Size = new System.Drawing.Size(36, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "2. Xe";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 173);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label13.Size = new System.Drawing.Size(75, 26);
            this.label13.TabIndex = 25;
            this.label13.Text = "6. Ngày tạo";
            // 
            // carId
            // 
            this.carId.DataSource = this.carBindingSource1;
            this.carId.DisplayMember = "Name";
            this.carId.FormattingEnabled = true;
            this.carId.Location = new System.Drawing.Point(180, 88);
            this.carId.Margin = new System.Windows.Forms.Padding(4);
            this.carId.Name = "carId";
            this.carId.Size = new System.Drawing.Size(683, 24);
            this.carId.TabIndex = 27;
            this.carId.ValueMember = "Id";
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataMember = "Car";
            this.carBindingSource1.DataSource = this.finalDataSet1;
            // 
            // carTypeBindingSource
            // 
            this.carTypeBindingSource.DataMember = "CarType";
            this.carTypeBindingSource.DataSource = this.finalDataSet1;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.finalDataSet1;
            // 
            // docDate
            // 
            this.docDate.Location = new System.Drawing.Point(180, 174);
            this.docDate.Margin = new System.Windows.Forms.Padding(4);
            this.docDate.Name = "docDate";
            this.docDate.Size = new System.Drawing.Size(683, 22);
            this.docDate.TabIndex = 30;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(21, 834);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 28);
            this.SaveBtn.TabIndex = 36;
            this.SaveBtn.Tag = "SaveBtn";
            this.SaveBtn.Text = "Lưu";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(129, 834);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 28);
            this.CancelBtn.TabIndex = 37;
            this.CancelBtn.Tag = "CancelBtn";
            this.CancelBtn.Text = "Hủy";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.thongTinVatTu2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1517, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin vật tư thay thế, bảo dưỡng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // thongTinVatTu2
            // 
            this.thongTinVatTu2.BackColor = System.Drawing.Color.White;
            this.thongTinVatTu2.Location = new System.Drawing.Point(-4, -4);
            this.thongTinVatTu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thongTinVatTu2.Name = "thongTinVatTu2";
            this.thongTinVatTu2.Size = new System.Drawing.Size(2604, 709);
            this.thongTinVatTu2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.noiDungBaoDuong2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1517, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin nội dung bảo dưỡng, sửa chữa";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // noiDungBaoDuong2
            // 
            this.noiDungBaoDuong2.BackColor = System.Drawing.Color.White;
            this.noiDungBaoDuong2.Location = new System.Drawing.Point(-2, -4);
            this.noiDungBaoDuong2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noiDungBaoDuong2.Name = "noiDungBaoDuong2";
            this.noiDungBaoDuong2.Size = new System.Drawing.Size(1519, 709);
            this.noiDungBaoDuong2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 229);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1525, 598);
            this.tabControl1.TabIndex = 34;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // carTypeTableAdapter
            // 
            this.carTypeTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.finalDataSet1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // summary
            // 
            this.summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summary.Location = new System.Drawing.Point(180, 111);
            this.summary.Margin = new System.Windows.Forms.Padding(4);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(683, 22);
            this.summary.TabIndex = 38;
            // 
            // status
            // 
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Location = new System.Drawing.Point(180, 153);
            this.status.Margin = new System.Windows.Forms.Padding(4);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(683, 22);
            this.status.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "5. Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 41;
            this.label3.Text = "6. Người tạo";
            // 
            // createdBy
            // 
            this.createdBy.DataSource = this.employeeBindingSource1;
            this.createdBy.DisplayMember = "Code";
            this.createdBy.FormattingEnabled = true;
            this.createdBy.Location = new System.Drawing.Point(180, 195);
            this.createdBy.Margin = new System.Windows.Forms.Padding(4);
            this.createdBy.Name = "createdBy";
            this.createdBy.Size = new System.Drawing.Size(683, 24);
            this.createdBy.TabIndex = 43;
            this.createdBy.ValueMember = "Id";
            // 
            // khanhLinhDataSet1
            // 
            this.khanhLinhDataSet1.DataSetName = "KhanhLinhDataSet1";
            this.khanhLinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.khanhLinhDataSet1;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // LenhSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 916);
            this.Controls.Add(this.createdBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.docDate);
            this.Controls.Add(this.carId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.description);
            this.Controls.Add(this.docNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LenhSuaChua";
            this.Text = "LenhSuaChua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LenhSuaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khanhLinhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStripUC menuStripUC1;
        private StatusBarUC statusBarUC1;
        private NoiDungBaoDuong noiDungBaoDuong1;
        private ThongTinVatTu thongTinVatTu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox docNo;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox carId;
        private System.Windows.Forms.DateTimePicker docDate;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private ThongTinVatTu thongTinVatTu2;
        private System.Windows.Forms.TabPage tabPage1;
        private NoiDungBaoDuong noiDungBaoDuong2;
        private System.Windows.Forms.TabControl tabControl1;
        private FinalDataSet1 finalDataSet1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private FinalDataSet1TableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private FinalDataSet1TableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.BindingSource carTypeBindingSource;
        private FinalDataSet1TableAdapters.CarTypeTableAdapter carTypeTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private FinalDataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private FinalDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox summary;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox createdBy;
        private KhanhLinhDataSet1 khanhLinhDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private KhanhLinhDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
    }
}