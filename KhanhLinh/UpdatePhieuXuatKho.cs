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
using System.Windows.Forms;
using System.Xml.Linq;

namespace KhanhLinh
{
    public partial class UpdatePhieuXuatKho : Form
    {
        private readonly string phieuXuatKhoId = SharedId.Id;
        private string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        private void metroGrid1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Bỏ qua lỗi nếu value không nằm trong danh sách ComboBox
            e.ThrowException = false;

            // (Tuỳ chọn) hiển thị log lỗi cụ thể nếu cần debug
            Console.WriteLine($"DataError at column: {e.ColumnIndex}, row: {e.RowIndex}, error: {e.Exception?.Message}");
        }


        private void GetPhieuXuatKho()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT * FROM vInventoryVoucher WHERE Id = @voucherId", connect);
                    cmd.Parameters.AddWithValue("@voucherId", phieuXuatKhoId);

                    SqlDataReader result = cmd.ExecuteReader();

                    if (result.Read())
                    {
                        string CreatedAt = result["CreatedAt"].ToString();
                        string CreatedBy = result["CreatedBy"].ToString();
                        string Description = result["Description"].ToString();
                        string DocNo = result["DocNo"].ToString();
                        string DocStatus = result["DocStatus"].ToString();

                        phieuNhapKhoDocNo.Text = DocNo;
                        PNKDocStatus.Text = DocStatus;
                        PNKCreatedBy.SelectedValue = CreatedBy;
                        PNKDescription.Text = Description;
                        PNKCreatedAt.Value = DateTime.Parse(CreatedAt);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho Phiếu = " + phieuXuatKhoId);
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
        private void GetPhieuXuatKhoDetail()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT ItemId, ItemCode AS ItemCode, ItemName, Unit AS ItemUnit, Quantity, WarehouseId AS Warehouse, CarCode, CarId " +
                                                    "FROM vVoucherDetail WHERE ParentId = @voucherId", connect);
                    cmd.Parameters.AddWithValue("@voucherId", phieuXuatKhoId);

                    SqlDataReader result = cmd.ExecuteReader();


                    while (result.Read())
                    {

                            string itemId = result["ItemId"].ToString();
                            string itemCode = result["ItemCode"].ToString();
                            string name = result["ItemName"].ToString();
                            string itemUnit = result["ItemUnit"].ToString();
                            decimal quantity = result.GetDecimal(result.GetOrdinal("Quantity"));
                            string warehouse = result["Warehouse"].ToString();
                            string carCode = result["CarCode"].ToString();
                            string carId = result["CarId"].ToString();


                            int rowIndex = metroGrid1.Rows.Add();

                            metroGrid1.Rows[rowIndex].Cells["ItemCode"].Value = Guid.Parse(itemId); // Cột ComboBox (ValueMember là Guid
                            metroGrid1.Rows[rowIndex].Cells["ItemName"].Value = name;
                            metroGrid1.Rows[rowIndex].Cells["ItemUnit"].Value = itemUnit;
                            metroGrid1.Rows[rowIndex].Cells["Quantity"].Value = quantity;
                            metroGrid1.Rows[rowIndex].Cells["Warehouse"].Value = Guid.Parse(warehouse);
                            metroGrid1.Rows[rowIndex].Cells["CarCode"].Value = Guid.Parse(carId);
 

                    }


                    if (!result.HasRows)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho CarId = " + phieuXuatKhoId);
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

        public UpdatePhieuXuatKho()
        {
            InitializeComponent();
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

        }

        private void UpdatePhieuXuatKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khanhLinhDataSet1.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.khanhLinhDataSet1.Warehouse);
            // TODO: This line of code loads data into the 'finalDataSet1.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.finalDataSet1.Car);
            // TODO: This line of code loads data into the 'finalDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.finalDataSet1.Department);
            // TODO: This line of code loads data into the 'finalDataSet1.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.finalDataSet1.Item);
            // TODO: This line of code loads data into the 'finalDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.finalDataSet1.Employee);
            metroGrid1.DataError += metroGrid1_DataError;
            GetPhieuXuatKho();
            GetPhieuXuatKhoDetail();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuXuatKho phieuXuatKho = new PhieuXuatKho();
            this.Hide();
            phieuXuatKho.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            string DocCode = "PX";
            string DocNo = phieuNhapKhoDocNo.Text.ToString().Trim();
            string DocStatus = PNKDocStatus.Text.ToString().Trim();
            string Description = PNKDescription.Text.ToString().Trim();
            Guid CreatedBy = Guid.Parse(PNKCreatedBy.SelectedValue.ToString().Trim());
            DateTime CreatedAt = PNKCreatedAt.Value;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("UpdatePNK", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", phieuXuatKhoId);
                    cmd.Parameters.AddWithValue("@DocCode", DocCode);
                    cmd.Parameters.AddWithValue("@DocNo", DocNo);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@DocStatus", DocStatus);
                    cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                    cmd.Parameters.AddWithValue("@CreatedAt", CreatedAt);

                    cmd.ExecuteNonQuery();


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

            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                if (row.IsNewRow) continue;
                var item = new InventoryVoucherDetail
                {
                    ItemId = row.Cells["ItemCode"].Value?.ToString(),
                    ItemCode = row.Cells["ItemCode"].FormattedValue?.ToString(),
                    ItemName = row.Cells["ItemName"].Value?.ToString(),
                    Unit = row.Cells["ItemUnit"].Value?.ToString(),
                    Quantity = decimal.TryParse(row.Cells["Quantity"].Value?.ToString(), out decimal qty) ? qty : 0,
                    WarehouseCode = row.Cells["Warehouse"].Value?.ToString(),
                    CarCode = row.Cells["CarCode"].Value?.ToString()
                };

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        if (connect.State != ConnectionState.Open)
                        {
                            connect.Open();
                        }

                        SqlCommand cmd = new SqlCommand("UpdatePNKDetail", connect);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ParentId", phieuXuatKhoId);
                        cmd.Parameters.AddWithValue("@ItemId", item.ItemId);
                        cmd.Parameters.AddWithValue("@CarId", item.CarCode);
                        cmd.Parameters.AddWithValue("@WarehouseId", item.WarehouseCode);
                        cmd.Parameters.AddWithValue("@Quantity", item.Quantity);

                        cmd.ExecuteNonQuery();

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

            MessageBox.Show("Cập nhật phiếu xuất kho thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        private void GetItemInfoPXK(string itemId, int rowIndex)
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
                        string Unit = result["Unit"].ToString();

                        metroGrid1.Rows[rowIndex].Cells["ItemName"].Value = Name;
                        metroGrid1.Rows[rowIndex].Cells["ItemUnit"].Value = Unit;

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
                    GetItemInfoPXK(selectedValue, e.RowIndex);
                }

                if (column.Name == "Warehouse")
                {
                    var selectedValue = metroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                }


                if (column.Name == "CarCode")
                {
                    var selectedValue = metroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                }
            }
        }
    }
}
