using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace KhanhLinh
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=scic.navistar.io,1435;Initial Catalog=KhanhLinh;User ID=khanhlinh;Password=vi2@pipi;TrustServerCertificate=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void exit_click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void login_checkpwd_CheckedChanged(object sender, EventArgs e)
        {
            login_pwd.PasswordChar = login_checkpwd.Checked ? '\0' : '*';
        }

        private string GetStoredPasswordHashFromDatabase(string username)
        {
            string getPasswordHash = "SELECT PasswordHash FROM Users WHERE UserName = @username";
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();

                    using (SqlCommand getPwdHash = new SqlCommand(getPasswordHash, connect))
                    {
                        getPwdHash.Parameters.AddWithValue("@username", username);

                        string passwordHash = (string)getPwdHash.ExecuteScalar();
                        return passwordHash;

                    }
                }
                return null;

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return null;
            }

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text.Trim();
            string password = login_pwd.Text.Trim();

            string passwordFromDB = GetStoredPasswordHashFromDatabase(username);
            if (username == "" ||
                password == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản/mật khẩu",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    bool isPwdCorrect = BCrypt.Net.BCrypt.Verify(password, passwordFromDB);
                    if (isPwdCorrect)
                    {
                        MainScreen mainScreen = new MainScreen();
                        mainScreen.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản/mật khẩu không chính xác",
                               "Lỗi",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex,
                               "Lỗi",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

            }
        }


    }
}
