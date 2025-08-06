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
    public partial class RepairJobScreen : Form
    {
        public RepairJobScreen()
        {
            InitializeComponent();
        }

        private void RepairJobScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khanhLinhDataSet.vRepairJob' table. You can move, or remove it, as needed.
            this.vRepairJobTableAdapter.Fill(this.khanhLinhDataSet.vRepairJob);

        }

        private void addRepairJobBtn_Click(object sender, EventArgs e)
        {
            AddRepairJobScreen addRepairJobScreen = new AddRepairJobScreen();
            this.Hide();
            addRepairJobScreen.Show();
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

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeScreen employeeScreen = new EmployeeScreen();
            this.Hide();
            employeeScreen.Show();
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

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRepairJobScreen addRepairJobScreen = new AddRepairJobScreen();
            this.Hide();
            addRepairJobScreen.Show();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SharedId.Id == null)
            {
                MessageBox.Show("Dòng chọn chưa hợp lệ");
            }
            else
            {
                UpdateRepairJobScreen updateRepairJobScreen = new UpdateRepairJobScreen();
                updateRepairJobScreen.Show();

            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var repairJobId = "";
            if (e.RowIndex >= 0)
            {
                repairJobId = metroGrid1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value?.ToString();
            }
            SharedId.Id = repairJobId;
        }
    }
}
