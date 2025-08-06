using KhanhLinh.DataObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using KhanhLinh.DataObject;

namespace KhanhLinh
{
    public partial class UpdateCarTypeScreen : Form
    {
        private string carTypeId = SharedId.Id;
        private  string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public UpdateCarTypeScreen()
        {
            InitializeComponent();
        }

        private void UpdateCarTypeScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.finalDataSet1.CarType);
            carTypeId1.Text = "";
            GetCarTypeInfo(carTypeId);
        }

        private void GetCarTypeInfo(string Id)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT Code, Name, IsActive, Description " +
                                                    "FROM CarType WHERE Id = @carTypeId1", connect);


                    cmd.Parameters.AddWithValue("@carTypeId1", Id);

                    SqlDataReader result = cmd.ExecuteReader();

                    if (result.Read())
                    {
                        string Code = result["Code"].ToString();
                        string Name = result["Name"].ToString();
                        string Description = result["Description"].ToString();
                        bool IsActive = (bool)result["IsActive"];

                        carTypeCode.Text = Code;
                        carTypeId1.Text = Name;
                        carTypeDescription.Text = Description;
                        carTypeIsActive.Checked = IsActive;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho loại xe = " + carTypeId1);
                    }

                    result.Close();
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            string Code = carTypeCode.Text.ToString().Trim();
            string Name = carTypeId1.Text.ToString().Trim();
            string Description = carTypeDescription.Text.ToString().Trim();
            bool IsActive = carTypeIsActive.Checked;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE CarType " +
                                                    "SET Code = @Code, Name = @Name, Description = @Description, IsActive = @IsActive " +
                                                    "WHERE Id = @carTypeId1", connect);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@carTypeId1", carTypeId);
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thể loại xe thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCarTypeInfo(carTypeId);
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTypeScreen carTypeScreen = new CarTypeScreen();
            this.Hide();
            carTypeScreen.Show();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
