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
    public partial class AddConsumptionNormScreen : Form
    {
       private  string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public AddConsumptionNormScreen()
        {
            InitializeComponent();
        }

        private void AddConsumptionNormScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.finalDataSet.Item);
            // TODO: This line of code loads data into the 'finalDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.finalDataSet.Employee);
            // TODO: This line of code loads data into the 'finalDataSet.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.finalDataSet.CarType);


            if (conNormItemType.Items.Count > 0)
            {
                conNormItemType.SelectedIndex = 0;
            }

        }

        private void itemType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ItemId = conNormItemType.SelectedValue.ToString();
            string ItemCode = "";
            string ItemName = "";
            string ItemUnit = "";
            using (SqlConnection connect = new SqlConnection(connectionString)) 
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT Code, Name, Unit FROM Item WHERE Id = @ItemId", connect);

                    cmd.Parameters.AddWithValue("@ItemId", ItemId);

                    SqlDataReader result = cmd.ExecuteReader();

                    if (result.Read())
                    {
                        ItemCode = result["Code"].ToString();
                        ItemName = result["Name"].ToString();
                        ItemUnit = result["Unit"].ToString();

                        conNormItemName.Text = ItemName;
                        conNormItemCode.Text = ItemCode;
                        conNormItemUnit.Text = ItemUnit;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho ItemId = " + ItemId);
                    }

                    result.Close();

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

        private void addBtn_Click(object sender, EventArgs e)
        {
            DateTime StartDate = conNormStartDate.Value;
            DateTime FinishDate = conNormFinishDate.Value;
            Guid CarTypeId = Guid.Parse(conNormCarTypeId.SelectedValue.ToString().Trim());
            string Description = conNormDescription.Text.ToString().Trim();
            Guid CreatedBy = Guid.Parse(conNormCreatedBy.SelectedValue.ToString().Trim());
            Guid ItemId = Guid.Parse(conNormItemType.SelectedValue.ToString().Trim());
            int Quantity = Int32.Parse(conNormItemQuantity.Text.ToString().Trim());

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("AddConsumptionNorm", connect);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.Parameters.AddWithValue("@FinishDate", FinishDate);
                    cmd.Parameters.AddWithValue("@CarTypeId", CarTypeId);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                    cmd.Parameters.AddWithValue("@ItemId", ItemId);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm vật tư tiêu hao thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);


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

        private void listConsumptionNorm_Click(object sender, EventArgs e)
        {
            ConsumptionNormScreen consumptionNormScreen = new ConsumptionNormScreen();
            this.Hide();
            consumptionNormScreen.Show();
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
    }
}
