using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using KhanhLinh.DataObject;

namespace KhanhLinh
{
    public partial class AddEmployeeScreen : Form
    {
       private  string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public AddEmployeeScreen()
        {
            InitializeComponent();
        }

        private void AddEmployeeScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khanhLinhDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.khanhLinhDataSet1.Department);

        }

        private void listEmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeScreen employeeScreen = new EmployeeScreen();
            this.Hide();
            employeeScreen.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string Code = empCode.Text.Trim();
            string Name = empName.Text.Trim();
            string DeptId = departmentBox.SelectedValue.ToString();
            string PhoneNumber = empPhoneNumber.Text.Trim();
            DateTime BirthDate = empDOB.Value;
            string Gender = empGender.Text.Trim();
            string BirthPlace = empBornPlace.Text.Trim();
            string JobSkillLevel = empJobSkillLevel.Text.Trim();
            int IsRepairMan = Convert.ToInt32(empIsRepairMan.Checked);


            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlCommand cmd = new SqlCommand("AddEmployee", connect);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@DepartmentId", DeptId);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@BirthPlace", BirthPlace);
                    cmd.Parameters.AddWithValue("@JobSkillLevel", JobSkillLevel);
                    cmd.Parameters.AddWithValue("@IsRepairMan", IsRepairMan);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm nhân viên thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("Code already exists"))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", 
                                        "Cảnh báo",
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, 
                                        "Lỗi", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void danhMụcXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAndDeviceScreen carAndDeviceScreen = new CarAndDeviceScreen();
            carAndDeviceScreen.Show();
            this.Hide();
        }

        private void danhMụcKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseManagement warehouseManagement = new WarehouseManagement();
            this.Hide();
            warehouseManagement.Show();
        }

        private void danhMụcTuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RouteScreen routeScreen = new RouteScreen();
            this.Hide();
            routeScreen.Show();
        }

        private void danhMụcBộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentScreen departmentScreen = new DepartmentScreen();
            this.Hide();
            departmentScreen.Show();
        }

        private void danhMụcLoạiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTypeScreen carTypeScreen = new CarTypeScreen();
            this.Hide();
            carTypeScreen.Show();
        }

        private void danhMụcCôngViệcSửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairJobScreen repairJobScreen = new RepairJobScreen();
            this.Hide();
            repairJobScreen.Show();
        }

        private void danhMụcVậtTưHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemScreen itemScreen = new ItemScreen();
            this.Hide();
            itemScreen.Show();
        }

        private void địnhMứcVậtTưTiêuHaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsumptionNormScreen consumptionNormScreen = new ConsumptionNormScreen();
            this.Hide();
            consumptionNormScreen.Show();
        }

        private void địnhMứcVậtTưSửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairNormScreen repairNormScreen = new RepairNormScreen();
            this.Hide();
            repairNormScreen.Show();
        }

        private void phiếuTheoDõiHànhTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RouteTrackingScreen routeTrackingScreen = new RouteTrackingScreen();
            this.Hide();
            routeTrackingScreen.Show();
        }

 private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateEmpBtn_Click(object sender, EventArgs e)
        {
            UpdateEmployeeScreen updateEmployeeScreen = new UpdateEmployeeScreen();
            this.Hide();
            updateEmployeeScreen.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeScreen employeeScreen = new EmployeeScreen();
            this.Hide();
            employeeScreen.Show();
        }

private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEmployeeScreen updateEmployeeScreen = new UpdateEmployeeScreen();

            updateEmployeeScreen.Show();
        }
    }
}
