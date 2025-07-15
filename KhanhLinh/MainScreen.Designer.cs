namespace KhanhLinh
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roleStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carAndMatManagementStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.repairManagementStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseManagementStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.reportStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.khácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreen_logoutBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mainScreen_logoutBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 898);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QLSC ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 31);
            this.panel2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleStripComboBox1,
            this.quảnLýToolStripMenuItem,
            this.khácToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 28);
            this.menuStrip1.TabIndex = 0;
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
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carAndMatManagementStrip,
            this.repairManagementStrip,
            this.warehouseManagementStrip,
            this.reportStrip});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // carAndMatManagementStrip
            // 
            this.carAndMatManagementStrip.Name = "carAndMatManagementStrip";
            this.carAndMatManagementStrip.Size = new System.Drawing.Size(215, 26);
            this.carAndMatManagementStrip.Text = "Quản lý xe, thiết bị";
            this.carAndMatManagementStrip.Click += new System.EventHandler(this.carAndMatManagementStrip_Click);
            // 
            // repairManagementStrip
            // 
            this.repairManagementStrip.Name = "repairManagementStrip";
            this.repairManagementStrip.Size = new System.Drawing.Size(215, 26);
            this.repairManagementStrip.Text = "Quản lý sửa chữa";
            // 
            // warehouseManagementStrip
            // 
            this.warehouseManagementStrip.Name = "warehouseManagementStrip";
            this.warehouseManagementStrip.Size = new System.Drawing.Size(215, 26);
            this.warehouseManagementStrip.Text = "Quản lý tồn kho";
            // 
            // reportStrip
            // 
            this.reportStrip.Name = "reportStrip";
            this.reportStrip.Size = new System.Drawing.Size(215, 26);
            this.reportStrip.Text = "Báo cáo thống kê";
            // 
            // khácToolStripMenuItem
            // 
            this.khácToolStripMenuItem.Name = "khácToolStripMenuItem";
            this.khácToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.khácToolStripMenuItem.Text = "Khác";
            // 
            // mainScreen_logoutBtn
            // 
            this.mainScreen_logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainScreen_logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.mainScreen_logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainScreen_logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainScreen_logoutBtn.FlatAppearance.BorderSize = 0;
            this.mainScreen_logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainScreen_logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreen_logoutBtn.Image = global::KhanhLinh.Properties.Resources.icons8_logout_50;
            this.mainScreen_logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainScreen_logoutBtn.Location = new System.Drawing.Point(10, 831);
            this.mainScreen_logoutBtn.Name = "mainScreen_logoutBtn";
            this.mainScreen_logoutBtn.Size = new System.Drawing.Size(303, 53);
            this.mainScreen_logoutBtn.TabIndex = 4;
            this.mainScreen_logoutBtn.Text = "Đăng xuất";
            this.mainScreen_logoutBtn.UseVisualStyleBackColor = false;
            this.mainScreen_logoutBtn.Click += new System.EventHandler(this.mainScreen_logoutBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KhanhLinh.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(168, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 128);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::KhanhLinh.Properties.Resources.mainScreen_background;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 929);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox roleStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carAndMatManagementStrip;
        private System.Windows.Forms.ToolStripMenuItem repairManagementStrip;
        private System.Windows.Forms.ToolStripMenuItem warehouseManagementStrip;
        private System.Windows.Forms.ToolStripMenuItem reportStrip;
        private System.Windows.Forms.ToolStripMenuItem khácToolStripMenuItem;
        private System.Windows.Forms.Button mainScreen_logoutBtn;
    }
}