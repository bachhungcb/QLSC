using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using KhanhLinh.DataObject;
using System.Data.SqlClient;

namespace KhanhLinh
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=scic.navistar.io,1435;Initial Catalog=KhanhLinh;User ID=khanhlinh;Password=vi2@pipi;TrustServerCertificate=True");
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void exit_click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void register_showpwd_CheckedChanged(object sender, EventArgs e)
        {
            register_passwordBox.PasswordChar = register_showpwd.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_usernameBox.Text == "" ||
                register_passwordBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản/mật khẩu",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string userName = register_usernameBox.Text.Trim();
                        string password = register_passwordBox.Text.Trim();
                        string phoneNumber = register_phoneNumber.Text.Trim();
                        string fullName = register_fullname.Text.Trim();
                        string email = register_email.Text.Trim();

                        string selectUsername = "SELECT COUNT(Id) FROM Users WHERE UserName = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", userName);

                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Tên đăng nhập đã tồn tại",
                                                "Lỗi",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }
                            else
                            {
                                //Generate Salt for hashing pwd
                                string salt = BCrypt.Net.BCrypt.GenerateSalt();

                                //hashing pwd
                                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password, salt);

                                string insertData = "INSERT INTO Users " +
                                                    "(UserName, FullName ,PasswordHash, PhoneNumber, Email)" +
                                                    "VALUES (@username, @fullname,@passwordHash, @phonenumber, @email)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", userName);
                                    cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
                                    cmd.Parameters.AddWithValue("@fullname", fullName);
                                    cmd.Parameters.AddWithValue("@phonenumber", phoneNumber);
                                    cmd.Parameters.AddWithValue("@email", email);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Đăng ký thành công",
                                       "Thông báo",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);

                                    LoginForm loginForm = new LoginForm();
                                    loginForm.Show();
                                    this.Hide();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message,
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
}
