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
    public partial class AddCarScreen : Form
    {
        private  string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public AddCarScreen()
        {
            InitializeComponent();
        }
     
        private void addCarBtn_Click(object sender, EventArgs e)
        {
            Guid carId = Guid.NewGuid();
            string carCodeString = carCode.Text.Trim();
            string CarName = carName.Text.Trim();
            int MadeYear = Int32.Parse(madeYear.Text.Trim());
            string Model = model.Text.Trim();
            string ChassisNumber = chassisNumber.Text.Trim();
            string DeptId = departmentBox.SelectedValue.ToString();
            string CarTypeId = carTypeId.SelectedValue.ToString();
            string CarStatus = carStatus.Text.Trim();
            string LisencePlate = licensePlate.Text.Trim();
            int noS = Int32.Parse(NoS.Text.Trim());
            string EngineNumber = engineNumber.Text.ToString().Trim();
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

                    cmd.Parameters.AddWithValue("@Id", carId);
                    cmd.Parameters.AddWithValue("@CarCode", carCodeString);
                    cmd.Parameters.AddWithValue("@CarName", CarName);
                    cmd.Parameters.AddWithValue("@MadeYear", MadeYear);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@FirstUsedDate", FirstUsedDate);
                    cmd.Parameters.AddWithValue("@PurchaseDate", PurchasedDate);
                    cmd.Parameters.AddWithValue("@LisencePlate", LisencePlate);
                    cmd.Parameters.AddWithValue("@ChassisNumber", ChassisNumber);
                    cmd.Parameters.AddWithValue("@DepartmentId", DeptId);
                    cmd.Parameters.AddWithValue("@CarTypeId", CarTypeId);
                    cmd.Parameters.AddWithValue("@CarStatus", CarStatus);
                    cmd.Parameters.AddWithValue("@NoS", noS);
                    cmd.Parameters.AddWithValue("@EngineNumber", EngineNumber);

                    cmd.ExecuteNonQuery();

                    foreach (DataGridViewRow row in metroGrid1.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var item = new AddCarDetailItems
                        {
                            ItemId = row.Cells["ItemCode"].Value?.ToString(),
                            Serial = row.Cells["ItemSerial"].Value?.ToString(),
                            Quantity = decimal.TryParse(row.Cells["ItemQuantity"].Value?.ToString(), out decimal qty) ? qty : 0,
                            ReplacementDate = DateTime.Parse(row.Cells["ReplacementDate"].Value?.ToString()),
                            ReplacementKm = decimal.TryParse(row.Cells["ReplacementKm"].Value?.ToString(), out decimal qty1) ? qty1 : 0,
                            Description = row.Cells["ItemDescription"].Value?.ToString(),

                        };

                        using (SqlConnection connect1 = new SqlConnection(connectionString))
                        {
                            try
                            {
                                if (connect1.State != ConnectionState.Open)
                                {
                                    connect1.Open();
                                }

                                SqlCommand cmd1 = new SqlCommand("AddCarDetail", connect1);
                                cmd1.CommandType = System.Data.CommandType.StoredProcedure;

                                cmd1.Parameters.AddWithValue("@CarId", carId);
                                cmd1.Parameters.AddWithValue("@ItemId", item.ItemId);
                                cmd1.Parameters.AddWithValue("@Serial", item.Serial);
                                cmd1.Parameters.AddWithValue("@Quantity", item.Quantity);
                                cmd1.Parameters.AddWithValue("@ReplacementDate", item.ReplacementDate);
                                cmd1.Parameters.AddWithValue("@ReplacementKm", item.ReplacementKm);
                                cmd1.Parameters.AddWithValue("@Description", item.Description);

                                cmd1.ExecuteNonQuery();

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


            MessageBox.Show("Thêm xe thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAndDeviceScreen carAndDeviceScreen = new CarAndDeviceScreen();
            this.Hide();
            carAndDeviceScreen.Show();
        }

        private void metroGrid1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (metroGrid1.Columns[e.ColumnIndex].Name)
            {
                case "ReplacementDate":
                    break;
            }
        }

        private void GetItemInfo(string itemId, int rowIndex)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT Name,Unit FROM Item WHERE Id = @ItemId", connect);
                    cmd.Parameters.AddWithValue("@ItemId", itemId);

                    SqlDataReader result = cmd.ExecuteReader();

                    if (result.Read())
                    {
                        string Name = result["Name"].ToString();

                        metroGrid1.Rows[rowIndex].Cells["ItemName"].Value = Name;
                     

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho Nhân viên = " + itemId);
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

        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = metroGrid1.Columns[e.ColumnIndex];

                // Ví dụ: chỉ xử lý khi là ComboBox column "ItemCode"
                if (column.Name == "ItemCode")
                {
                    var selectedValue = metroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                    GetItemInfo(selectedValue, e.RowIndex);
                }
                if(column.Name == "ReplacementDate")
                {
                    var selectedValue = metroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                    DateTime selectedValue1 = DateTime.Parse(selectedValue);
                    Console.WriteLine("Date: " + selectedValue1);
                }

            }
        }

        private void AddCarScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.finalDataSet1.CarType);
            // TODO: This line of code loads data into the 'finalDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.finalDataSet1.Department);
            // TODO: This line of code loads data into the 'finalDataSet1.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.finalDataSet1.Item);
            // TODO: This line of code loads data into the 'finalDataSet1.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.finalDataSet1.Item);

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
            PhieuNhapKho phieuNhapKho = new PhieuNhapKho();
            this.Hide();
            phieuNhapKho.Show();
        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuXuatKho phieuXuatKho = new PhieuXuatKho();
            this.Hide();
            phieuXuatKho.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void carStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
