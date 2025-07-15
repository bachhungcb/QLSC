using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KhanhLinh
{
    public partial class CarAndDeviceScreen : Form
    {
        
        string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();
        public CarAndDeviceScreen()
        {
            InitializeComponent();
        }

        private void CarAndDeviceScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khanhLinhDataSet1.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.khanhLinhDataSet1.Car);
            // TODO: This line of code loads data into the 'khanhLinhDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.khanhLinhDataSet.Department);
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            string carCodeString = carCode.Text.Trim();
            string CarName = carName.Text.Trim();
            int MadeYear = Int32.Parse(madeYear.Text.Trim());
            string Model = model.Text.Trim();
            string ChassisNumber = chassisNumber.Text.Trim();
            string DeptId = departmentBox.SelectedValue.ToString();
            string CarStatus = carStatus.Text.Trim();
            string LisencePlate = licensePlate.Text.Trim();
            DateTime FirstUsedDate = firstUsedDate.Value;
            DateTime PurchasedDate = purchaseDate.Value;



            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("AddCar", connect);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CarCode", carCodeString);
                    cmd.Parameters.AddWithValue("@CarName", CarName);
                    cmd.Parameters.AddWithValue("@MadeYear", MadeYear);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@FirstUsedDate", FirstUsedDate);
                    cmd.Parameters.AddWithValue("@PurchaseDate", PurchasedDate);
                    cmd.Parameters.AddWithValue("@LisencePlate", LisencePlate);
                    cmd.Parameters.AddWithValue("@ChassisNumber", ChassisNumber);
                    cmd.Parameters.AddWithValue("@DepartmentId", DeptId);
                    cmd.Parameters.AddWithValue("@CarStatus", CarStatus);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm xe thành công" ,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }
                catch(Exception ex)
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
