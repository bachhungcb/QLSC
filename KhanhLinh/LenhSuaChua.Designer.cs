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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusBarUC1 = new KhanhLinh.StatusBarUC();
            this.menuStripUC1 = new KhanhLinh.MenuStripUC();
            this.noiDungBaoDuong1 = new KhanhLinh.NoiDungBaoDuong();
            this.thongTinVatTu1 = new KhanhLinh.ThongTinVatTu();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusBarUC1
            // 
            this.statusBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.statusBarUC1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarUC1.Location = new System.Drawing.Point(0, 619);
            this.statusBarUC1.Name = "statusBarUC1";
            this.statusBarUC1.Size = new System.Drawing.Size(1029, 41);
            this.statusBarUC1.TabIndex = 1;
            // 
            // menuStripUC1
            // 
            this.menuStripUC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStripUC1.Location = new System.Drawing.Point(0, 0);
            this.menuStripUC1.Name = "menuStripUC1";
            this.menuStripUC1.Size = new System.Drawing.Size(1029, 41);
            this.menuStripUC1.TabIndex = 0;
            // 
            // noiDungBaoDuong1
            // 
            this.noiDungBaoDuong1.Location = new System.Drawing.Point(12, 379);
            this.noiDungBaoDuong1.Name = "noiDungBaoDuong1";
            this.noiDungBaoDuong1.Size = new System.Drawing.Size(150, 150);
            this.noiDungBaoDuong1.TabIndex = 4;
            // 
            // thongTinVatTu1
            // 
            this.thongTinVatTu1.Location = new System.Drawing.Point(226, 366);
            this.thongTinVatTu1.Name = "thongTinVatTu1";
            this.thongTinVatTu1.Size = new System.Drawing.Size(150, 150);
            this.thongTinVatTu1.TabIndex = 5;
            // 
            // LenhSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 660);
            this.Controls.Add(this.thongTinVatTu1);
            this.Controls.Add(this.noiDungBaoDuong1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusBarUC1);
            this.Controls.Add(this.menuStripUC1);
            this.Name = "LenhSuaChua";
            this.Text = "LenhSuaChua";
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStripUC menuStripUC1;
        private StatusBarUC statusBarUC1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private NoiDungBaoDuong noiDungBaoDuong1;
        private ThongTinVatTu thongTinVatTu1;
    }
}