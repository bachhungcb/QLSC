using KhanhLinh.DataObject;
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
using System.Windows.Forms;

namespace KhanhLinh
{
    public partial class UpdateConsumptionNormScreen : Form
    {
        private readonly string NormId = SharedId.Id;
        private string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public UpdateConsumptionNormScreen()
        {
            InitializeComponent();

        }

        private void GetItemInfo(string itemId)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT Code, Name, Unit FROM Item WHERE Id = @ItemId", connect);

                    cmd.Parameters.AddWithValue("@ItemId", itemId);

                    SqlDataReader result = cmd.ExecuteReader();

                    if (result.Read())
                    {
                        string ItemCode = result["Code"].ToString();
                        string ItemName = result["Name"].ToString();
                        string ItemUnit = result["Unit"].ToString();

                        conNormItemName.Text = ItemName;
                        conNormItemCode.Text = ItemCode;
                        conNormItemUnit.Text = ItemUnit;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho ItemId = " + itemId);
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

        private void GetConsumptionNormInfo()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT StartDate, FinishDate, CarTypeId, Description, CreatedBy, IsActive, ItemId, Quantity " +
                                                    "FROM ConsumptionNorm WHERE Id = @NormId", connect);

                    cmd.Parameters.AddWithValue("@NormId", NormId);

                    SqlDataReader result = cmd.ExecuteReader();

                    if (result.Read())
                    {
                        DateTime StartDate = (DateTime)result["StartDate"];
                        DateTime FinishDate = (DateTime)result["FinishDate"];
                        Guid CarTypeId = (Guid)result["CarTypeId"];
                        string Description = result["Description"].ToString();
                        Guid CreatedBy = (Guid)result["CreatedBy"];
                        Guid ItemId = (Guid)result["ItemId"];
                        int Quantity = result["Quantity"] != DBNull.Value ? Convert.ToInt32(result["Quantity"]) : 0;

                        conNormStartDate.Value = StartDate;
                        conNormFinishDate.Value = FinishDate;
                        conNormCarTypeId.SelectedValue = CarTypeId;
                        conNormDescription.Text = Description;
                        conNormCreatedBy.SelectedValue = CreatedBy;
                        conNormItemType.SelectedValue = ItemId;
                        conNormItemQuantity.Text = Quantity.ToString();
                        GetItemInfo(ItemId.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho phiếu = " + NormId);
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

                    SqlCommand cmd = new SqlCommand("UpdateConsupmtionNorm", connect);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.Parameters.AddWithValue("@FinishDate", FinishDate);
                    cmd.Parameters.AddWithValue("@CarTypeId", CarTypeId);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                    cmd.Parameters.AddWithValue("@ItemId", ItemId);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@Id", NormId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật vật tư tiêu hao thành công",
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

        private void conNormItemType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ItemId = conNormItemType.SelectedValue.ToString();
            GetItemInfo(ItemId);
        }

        private void UpdateConsumptionNormScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter1.Fill(this.finalDataSet1.Item);
            // TODO: This line of code loads data into the 'finalDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.finalDataSet1.Employee);
            // TODO: This line of code loads data into the 'finalDataSet1.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter1.Fill(this.finalDataSet1.CarType);
            GetConsumptionNormInfo();
        }
    }
}
