namespace KhanhLinh
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_checkpwd = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.login_pwd = new System.Windows.Forms.TextBox();
            this.login_username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_checkpwd
            // 
            this.login_checkpwd.AutoSize = true;
            this.login_checkpwd.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.login_checkpwd.Location = new System.Drawing.Point(99, 274);
            this.login_checkpwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_checkpwd.Name = "login_checkpwd";
            this.login_checkpwd.Size = new System.Drawing.Size(217, 35);
            this.login_checkpwd.TabIndex = 7;
            this.login_checkpwd.Text = "Hiển thị mật khẩu";
            this.login_checkpwd.UseVisualStyleBackColor = true;
            this.login_checkpwd.CheckedChanged += new System.EventHandler(this.login_checkpwd_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.login_checkpwd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.login_pwd);
            this.panel1.Controls.Add(this.login_username);
            this.panel1.Location = new System.Drawing.Point(596, 151);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 500);
            this.panel1.TabIndex = 8;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btnDangNhap.Location = new System.Drawing.Point(146, 389);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(179, 42);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập mật khẩu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhập ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // login_pwd
            // 
            this.login_pwd.BackColor = System.Drawing.Color.White;
            this.login_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_pwd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pwd.Location = new System.Drawing.Point(100, 228);
            this.login_pwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_pwd.Name = "login_pwd";
            this.login_pwd.PasswordChar = '*';
            this.login_pwd.Size = new System.Drawing.Size(274, 38);
            this.login_pwd.TabIndex = 1;
            this.login_pwd.TextChanged += new System.EventHandler(this.login_pwd_TextChanged);
            // 
            // login_username
            // 
            this.login_username.AcceptsReturn = true;
            this.login_username.AcceptsTab = true;
            this.login_username.BackColor = System.Drawing.Color.White;
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(99, 133);
            this.login_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(274, 38);
            this.login_username.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1563, 753);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox login_checkpwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox login_pwd;
        private System.Windows.Forms.TextBox login_username;
    }
}

