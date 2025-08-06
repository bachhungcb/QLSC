using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using KhanhLinh.DataObject;


namespace KhanhLinh
{
    public partial class CarAndDeviceScreen : Form
    {
        
        
        private  string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();
        public CarAndDeviceScreen()
        {
            InitializeComponent();
        }

        private void CarAndDeviceScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.vCar' table. You can move, or remove it, as needed.
            this.vCarTableAdapter1.Fill(this.finalDataSet1.vCar);
            // TODO: This line of code loads data into the 'finalDataSet1.vCarDetail' table. You can move, or remove it, as needed.
            //this.vCarDetailTableAdapter.Fill(this.finalDataSet1.vCarDetail);
            // TODO: This line of code loads data into the 'finalDataSet1.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.finalDataSet1.Car);
            // TODO: This line of code loads data into the 'khanhLinhDataSet1.vCar' table. You can move, or remove it, as needed.
            this.vCarTableAdapter.Fill(this.khanhLinhDataSet1.vCar);
            // TODO: This line of code loads data into the 'khanhLinhDataSet1.vCar' table. You can move, or remove it, as needed.
            this.vCarTableAdapter.Fill(this.khanhLinhDataSet1.vCar);
            // TODO: This line of code loads data into the 'khanhLinhDataSet.Car' table. You can move, or remove it, as needed.

        }

       

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.vCarTableAdapter.Fill(this.khanhLinhDataSet1.vCar);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseManagement warehouseManagement = new WarehouseManagement();
            this.Hide();
            warehouseManagement.Show();
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcVậtTưHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemScreen itemScreen = new ItemScreen();
            this.Hide();
            itemScreen.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeScreen employeeScreen = new EmployeeScreen();
            this.Hide();
            employeeScreen.Show();
        }
        private void danhMụcLoạiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTypeScreen carTypeScreen = new CarTypeScreen();
            this.Hide();
            carTypeScreen.Show();
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

        private void danhMụcCôngViệcSửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairJobScreen repairJobScreen = new RepairJobScreen();
            this.Hide();
            repairJobScreen.Show();
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

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarScreen addCarScreen = new AddCarScreen();
            this.Hide();
            addCarScreen.Show();
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var carId = "";
            if (e.RowIndex >= 0) 
            {
                carId = carOverview.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value?.ToString();
            }
            SharedId.Id = carId;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT * FROM vCarDetail WHERE CarId = @CarId", connect);
                    cmd.Parameters.AddWithValue("@CarId", carId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    
                    carDetail.DataSource = dt;


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

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SharedId.Id == null)
            {
                MessageBox.Show("Dòng chọn không hợp lệ");
            }
            else
            {
                UpdateCarScreen updateCarScreen = new UpdateCarScreen();
                updateCarScreen.Show();
            }
        }

        private void carOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carId = "";
            if (e.RowIndex >= 0)
            {
                carId = carOverview.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value?.ToString();
            }
            SharedId.Id = carId;
        }
    }
}
