namespace KhanhLinh
{
    partial class AddCarTypeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarTypeScreen));
            this.panel2 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.carTypeDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.carTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carTypeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripUC1 = new KhanhLinh.MenuStripUC();
            this.statusBarUC1 = new KhanhLinh.StatusBarUC();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.carTypeDescription);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.carTypeName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.carTypeCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 566);
            this.panel2.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(850, 488);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 42);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // carTypeDescription
            // 
            this.carTypeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carTypeDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTypeDescription.Location = new System.Drawing.Point(149, 141);
            this.carTypeDescription.Multiline = true;
            this.carTypeDescription.Name = "carTypeDescription";
            this.carTypeDescription.Size = new System.Drawing.Size(835, 85);
            this.carTypeDescription.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mô tả";
            // 
            // carTypeName
            // 
            this.carTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carTypeName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTypeName.Location = new System.Drawing.Point(149, 87);
            this.carTypeName.Name = "carTypeName";
            this.carTypeName.Size = new System.Drawing.Size(835, 38);
            this.carTypeName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên";
            // 
            // carTypeCode
            // 
            this.carTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carTypeCode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTypeCode.Location = new System.Drawing.Point(149, 33);
            this.carTypeCode.Name = "carTypeCode";
            this.carTypeCode.Size = new System.Drawing.Size(835, 38);
            this.carTypeCode.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã";
            // 
            // menuStripUC1
            // 
            this.menuStripUC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStripUC1.Location = new System.Drawing.Point(0, 0);
            this.menuStripUC1.Name = "menuStripUC1";
            this.menuStripUC1.Size = new System.Drawing.Size(1029, 41);
            this.menuStripUC1.TabIndex = 9;
            this.menuStripUC1.Load += new System.EventHandler(this.menuStripUC1_Load);
            // 
            // statusBarUC1
            // 
            this.statusBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.statusBarUC1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarUC1.Location = new System.Drawing.Point(0, 619);
            this.statusBarUC1.Name = "statusBarUC1";
            this.statusBarUC1.Size = new System.Drawing.Size(1029, 41);
            this.statusBarUC1.TabIndex = 10;
            // 
            // AddCarTypeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 660);
            this.Controls.Add(this.statusBarUC1);
            this.Controls.Add(this.menuStripUC1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCarTypeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarTypeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox carTypeDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox carTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carTypeCode;
        private System.Windows.Forms.Label label1;
        private MenuStripUC menuStripUC1;
        private StatusBarUC statusBarUC1;
    }
}