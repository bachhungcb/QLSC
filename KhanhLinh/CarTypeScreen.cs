using KhanhLinh.DataObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using KhanhLinh.DataObject;

namespace KhanhLinh
{
    public partial class CarTypeScreen : Form
    {
        public CarTypeScreen()
        {
            InitializeComponent();
        }

        private void CarTypeScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khanhLinhDataSet.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.khanhLinhDataSet.CarType);

        }

        private void addCarTypeBtn_Click(object sender, EventArgs e)
        {
            AddCarTypeScreen addCarTypeScreen = new AddCarTypeScreen();
             
            addCarTypeScreen.Show();
        }

        private void danhMụcXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAndDeviceScreen carAndDeviceScreen = new CarAndDeviceScreen();
            carAndDeviceScreen.Show();
             
        }

        private void danhMụcKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseManagement warehouseManagement = new WarehouseManagement();
             
            warehouseManagement.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeScreen employeeScreen = new EmployeeScreen();
             
            employeeScreen.Show();
        }

        private void danhMụcTuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RouteScreen routeScreen = new RouteScreen();
             
            routeScreen.Show();
        }

        private void danhMụcBộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentScreen departmentScreen = new DepartmentScreen();
             
            departmentScreen.Show();
        }

        private void danhMụcCôngViệcSửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairJobScreen repairJobScreen = new RepairJobScreen();
             
            repairJobScreen.Show();
        }

        private void danhMụcVậtTưHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemScreen itemScreen = new ItemScreen();
             
            itemScreen.Show();
        }

        private void địnhMứcVậtTưTiêuHaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsumptionNormScreen consumptionNormScreen = new ConsumptionNormScreen();
             
            consumptionNormScreen.Show();
        }

        private void địnhMứcVậtTưSửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairNormScreen repairNormScreen = new RepairNormScreen();
             
            repairNormScreen.Show();
        }

        private void phiếuTheoDõiHànhTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RouteTrackingScreen routeTrackingScreen = new RouteTrackingScreen();
             
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
            AddCarTypeScreen addCarTypeScreen = new AddCarTypeScreen();
             
            addCarTypeScreen.Show();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SharedId.Id == null)
            {
                MessageBox.Show("Chọn dòng không hợp lệ");
            }
            else
            {
                UpdateCarTypeScreen updateCarTypeScreen = new UpdateCarTypeScreen();
                updateCarTypeScreen.Show();

            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carTypeId = "";
            if (e.RowIndex >= 0)
            {
                carTypeId = metroGrid1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value?.ToString();
            }
            SharedId.Id = carTypeId;
        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var carTypeId = "";
            if (e.RowIndex >= 0)
            {
                carTypeId = metroGrid1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value?.ToString();
            }
            SharedId.Id = carTypeId;
        }
    }
}
