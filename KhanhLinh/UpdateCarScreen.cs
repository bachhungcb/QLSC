using KhanhLinh.DataObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhanhLinh
{
    public partial class UpdateCarScreen : Form
    {
        private readonly string CarId = SharedId.Id;
        private string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public UpdateCarScreen()
        {
            InitializeComponent();
        }

        private void GetCarInfo()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT * FROM vCar WHERE Id = @CarId", connect);

                    cmd.Parameters.AddWithValue("@CarId", CarId);

                    SqlDataReader result = cmd.ExecuteReader();

                    while (result.Read())
                    {
                        string Code = result["Code"].ToString();
                        string Name = result["Name"].ToString();
                        string MadeYear = result["MadeYear"].ToString();
                        string Model = result["Model"].ToString();
                        string LicensePlate = result["LisencePlate"].ToString();
                        string FirstUsedDate = result["FirstUsedDate"].ToString();
                        string PurchaseDate = result["PurchaseDate"].ToString();
                        string ChassisNumber = result["ChassisNumber"].ToString();
                        string EngineNumber = result["EngineNumber"].ToString();
                        string noS = result["NoS"].ToString();
                        string DepartmentId = result["DepartmentId"].ToString();
                        string RouteId = result["RouteId"].ToString();
                        string CarTypeId = result["CarTypeId"].ToString();
                        string Status = result["Status"].ToString();


                        int year = int.Parse(MadeYear);
                        DateTime madeYearDate = new DateTime(year, 1, 1);


                        carCode.Text = Code;
                        carName.Text = Name;
                        madeYear.Value = madeYearDate;
                        model.Text = Model;
                        licensePlate.Text = LicensePlate;
                        firstUsedDate.Value = DateTime.Parse(FirstUsedDate);
                        purchaseDate.Value = DateTime.Parse(PurchaseDate);
                        chassisNumber.Text = ChassisNumber;
                        engineNumber.Text = EngineNumber;
                        NoS.Text = noS;
                        carStatus.Text = Status;
                        carTypeBox.SelectedValue = CarTypeId;
                        departmentBox.SelectedValue = DepartmentId;
                    }


                    // Nếu không có dòng nào được trả về
                    if (!result.HasRows)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho CarId = " + CarId);
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


        private void GetItemInfo()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT Item.Id, Item.Code,Item.Name, CarDetail.Serial, CarDetail.Description, CarDetail.Quantity, CarDetail.ReplacementDate, CarDetail.ReplacementKm " +
                                                    "FROM Item " +
                                                    "JOIN CarDetail ON Item.Id = CarDetail.ItemId " +
                                                    "JOIN Car ON Car.Id = CarDetail.CarId " +
                                                    "WHERE CarId = @CarId", connect);

                    cmd.Parameters.AddWithValue("@CarId", CarId);

                    SqlDataReader result = cmd.ExecuteReader();
                    metroGrid1.Rows.Clear();

                    while (result.Read())
                    {
                        string itemId = result["Id"].ToString();
                        string code = result["Code"].ToString();
                        string name = result["Name"].ToString();
                        string serial = result["Serial"].ToString();
                        string description = result["Description"].ToString();
                        double quantity = double.Parse(result["Quantity"].ToString(), CultureInfo.InvariantCulture);
                        string replacementDate = result["ReplacementDate"].ToString();
                        string replacementKm = result["ReplacementKm"].ToString();

                        int rowIndex = metroGrid1.Rows.Add();
                        metroGrid1.Rows[rowIndex].Cells["ItemCode"].Value = Guid.Parse(itemId); // Cột ComboBox (ValueMember là Guid
                        metroGrid1.Rows[rowIndex].Cells["ItemName"].Value = name;
                        metroGrid1.Rows[rowIndex].Cells["ItemSerial"].Value = serial;
                        metroGrid1.Rows[rowIndex].Cells["ItemDescription"].Value = description;
                        metroGrid1.Rows[rowIndex].Cells["ItemQuantity"].Value = quantity;
                        metroGrid1.Rows[rowIndex].Cells["ReplacementDate"].Value = replacementDate;
                        metroGrid1.Rows[rowIndex].Cells["ReplacementKm"].Value = replacementKm;


                    }
                    

                    // Nếu không có dòng nào được trả về
                    if (!result.HasRows)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho CarId = " + CarId);
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

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAndDeviceScreen carAndDeviceScreen = new CarAndDeviceScreen();
            this.Hide();
            carAndDeviceScreen.Show();
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            string carCodeString = carCode.Text.Trim();
            string CarName = carName.Text.Trim();
            int MadeYear = Int32.Parse(madeYear.Text.Trim());
            string Model = model.Text.Trim();
            string ChassisNumber = chassisNumber.Text.Trim();
            string DeptId = departmentBox.SelectedValue.ToString();
            string CarTypeId = carTypeBox.SelectedValue.ToString();
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

                    SqlCommand cmd = new SqlCommand("UpdateCar", connect);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", CarId);
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

                                SqlCommand cmd1 = new SqlCommand("UpdateCarDetail", connect1);
                                cmd1.CommandType = System.Data.CommandType.StoredProcedure;

                                cmd1.Parameters.AddWithValue("@CarId", CarId);
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


            MessageBox.Show("Cập nhật xe thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void UpdateCarScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.finalDataSet1.Department);
            // TODO: This line of code loads data into the 'finalDataSet1.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.finalDataSet1.CarType);
            // TODO: This line of code loads data into the 'finalDataSet1.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.finalDataSet1.Item);
            GetItemInfo();
            GetCarInfo();
        }

        private void GetItemInfoForItemBox(string itemId, int rowIndex)
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
                    GetItemInfoForItemBox(selectedValue, e.RowIndex);
                }
                if (column.Name == "ReplacementDate")
                {
                    var selectedValue = metroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                    DateTime selectedValue1 = DateTime.Parse(selectedValue);
                    Console.WriteLine("Date: " + selectedValue1);
                }

            }
        }
    }
}
