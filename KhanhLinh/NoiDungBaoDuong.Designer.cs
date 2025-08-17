namespace KhanhLinh
{
    partial class NoiDungBaoDuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDungCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoSua1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ThoSua2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ThoSua3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCongViec,
            this.NoiDungCongViec,
            this.ThoiGianDuKien,
            this.ThoSua1,
            this.ThoSua2,
            this.ThoSua3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1137, 576);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaCongViec
            // 
            this.MaCongViec.HeaderText = "Mã công việc";
            this.MaCongViec.Name = "MaCongViec";
            this.MaCongViec.Width = 200;
            // 
            // NoiDungCongViec
            // 
            this.NoiDungCongViec.HeaderText = "Nội dung công việc ";
            this.NoiDungCongViec.Name = "NoiDungCongViec";
            this.NoiDungCongViec.Width = 200;
            // 
            // ThoiGianDuKien
            // 
            this.ThoiGianDuKien.HeaderText = "Thời gian dự kiến (giờ)";
            this.ThoiGianDuKien.Name = "ThoiGianDuKien";
            // 
            // ThoSua1
            // 
            this.ThoSua1.HeaderText = "Thợ sửa 1";
            this.ThoSua1.Name = "ThoSua1";
            this.ThoSua1.Width = 150;
            // 
            // ThoSua2
            // 
            this.ThoSua2.HeaderText = "Thợ sửa 2";
            this.ThoSua2.Name = "ThoSua2";
            this.ThoSua2.Width = 150;
            // 
            // ThoSua3
            // 
            this.ThoSua3.HeaderText = "Thợ sửa 3 ";
            this.ThoSua3.Name = "ThoSua3";
            this.ThoSua3.Width = 150;
            // 
            // NoiDungBaoDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NoiDungBaoDuong";
            this.Size = new System.Drawing.Size(1139, 576);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDungCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDuKien;
        private System.Windows.Forms.DataGridViewComboBoxColumn ThoSua1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ThoSua2;
        private System.Windows.Forms.DataGridViewComboBoxColumn ThoSua3;
    }
}
