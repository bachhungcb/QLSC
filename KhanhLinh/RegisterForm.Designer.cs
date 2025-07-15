namespace KhanhLinh
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.register_loginLabel = new System.Windows.Forms.Label();
            this.register_loginBtn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.register_showpwd = new System.Windows.Forms.CheckBox();
            this.register_passwordBox = new System.Windows.Forms.TextBox();
            this.register_password = new System.Windows.Forms.Label();
            this.register_usernameBox = new System.Windows.Forms.TextBox();
            this.register_username = new System.Windows.Forms.Label();
            this.exit_click = new System.Windows.Forms.Label();
            this.register_fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.register_phoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.register_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(186)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.register_loginLabel);
            this.panel1.Controls.Add(this.register_loginBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 791);
            this.panel1.TabIndex = 6;
            // 
            // register_loginLabel
            // 
            this.register_loginLabel.AutoSize = true;
            this.register_loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.register_loginLabel.Location = new System.Drawing.Point(69, 645);
            this.register_loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.register_loginLabel.Name = "register_loginLabel";
            this.register_loginLabel.Size = new System.Drawing.Size(263, 31);
            this.register_loginLabel.TabIndex = 3;
            this.register_loginLabel.Text = "Đăng nhập tài khoản";
            // 
            // register_loginBtn
            // 
            this.register_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.register_loginBtn.FlatAppearance.BorderSize = 0;
            this.register_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.register_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.register_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.register_loginBtn.Location = new System.Drawing.Point(16, 689);
            this.register_loginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_loginBtn.Name = "register_loginBtn";
            this.register_loginBtn.Size = new System.Drawing.Size(392, 57);
            this.register_loginBtn.TabIndex = 4;
            this.register_loginBtn.Text = "Đăng nhập";
            this.register_loginBtn.UseVisualStyleBackColor = false;
            this.register_loginBtn.Click += new System.EventHandler(this.register_loginBtn_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.register_btn.Location = new System.Drawing.Point(463, 689);
            this.register_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(392, 57);
            this.register_btn.TabIndex = 1;
            this.register_btn.Text = "Đăng ký";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(473, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký tài khoản";
            // 
            // register_showpwd
            // 
            this.register_showpwd.AutoSize = true;
            this.register_showpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showpwd.Location = new System.Drawing.Point(863, 447);
            this.register_showpwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_showpwd.Name = "register_showpwd";
            this.register_showpwd.Size = new System.Drawing.Size(177, 28);
            this.register_showpwd.TabIndex = 12;
            this.register_showpwd.Text = "Hiển thị mật khẩu";
            this.register_showpwd.UseVisualStyleBackColor = true;
            this.register_showpwd.CheckedChanged += new System.EventHandler(this.register_showpwd_CheckedChanged);
            // 
            // register_passwordBox
            // 
            this.register_passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_passwordBox.Location = new System.Drawing.Point(463, 404);
            this.register_passwordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_passwordBox.Name = "register_passwordBox";
            this.register_passwordBox.PasswordChar = '*';
            this.register_passwordBox.Size = new System.Drawing.Size(587, 34);
            this.register_passwordBox.TabIndex = 17;
            // 
            // register_password
            // 
            this.register_password.AutoSize = true;
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.register_password.Location = new System.Drawing.Point(457, 370);
            this.register_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(115, 29);
            this.register_password.TabIndex = 10;
            this.register_password.Text = "Mật khẩu:";
            // 
            // register_usernameBox
            // 
            this.register_usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_usernameBox.Location = new System.Drawing.Point(463, 298);
            this.register_usernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_usernameBox.Name = "register_usernameBox";
            this.register_usernameBox.Size = new System.Drawing.Size(587, 34);
            this.register_usernameBox.TabIndex = 16;
            // 
            // register_username
            // 
            this.register_username.AutoSize = true;
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.register_username.Location = new System.Drawing.Point(457, 265);
            this.register_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(181, 29);
            this.register_username.TabIndex = 8;
            this.register_username.Text = "Tên đăng nhập:";
            // 
            // exit_click
            // 
            this.exit_click.AutoSize = true;
            this.exit_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_click.Location = new System.Drawing.Point(1220, 11);
            this.exit_click.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit_click.Name = "exit_click";
            this.exit_click.Size = new System.Drawing.Size(32, 31);
            this.exit_click.TabIndex = 13;
            this.exit_click.Text = "X";
            this.exit_click.Click += new System.EventHandler(this.exit_click_Click);
            // 
            // register_fullname
            // 
            this.register_fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_fullname.Location = new System.Drawing.Point(463, 197);
            this.register_fullname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_fullname.Name = "register_fullname";
            this.register_fullname.Size = new System.Drawing.Size(587, 34);
            this.register_fullname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(457, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Họ và tên:";
            // 
            // register_phoneNumber
            // 
            this.register_phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_phoneNumber.Location = new System.Drawing.Point(463, 502);
            this.register_phoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_phoneNumber.Name = "register_phoneNumber";
            this.register_phoneNumber.Size = new System.Drawing.Size(593, 34);
            this.register_phoneNumber.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(463, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số điện thoại:";
            // 
            // register_email
            // 
            this.register_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_email.Location = new System.Drawing.Point(463, 594);
            this.register_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_email.Name = "register_email";
            this.register_email.Size = new System.Drawing.Size(593, 34);
            this.register_email.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.label4.Location = new System.Drawing.Point(463, 561);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KhanhLinh.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(139, 58);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 123);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1271, 791);
            this.Controls.Add(this.register_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_phoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.register_fullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit_click);
            this.Controls.Add(this.register_showpwd);
            this.Controls.Add(this.register_passwordBox);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_usernameBox);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox register_showpwd;
        private System.Windows.Forms.TextBox register_passwordBox;
        private System.Windows.Forms.Label register_password;
        private System.Windows.Forms.TextBox register_usernameBox;
        private System.Windows.Forms.Label register_username;
        private System.Windows.Forms.Label register_loginLabel;
        private System.Windows.Forms.Button register_loginBtn;
        private System.Windows.Forms.Label exit_click;
        private System.Windows.Forms.TextBox register_fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox register_phoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox register_email;
        private System.Windows.Forms.Label label4;
    }
}