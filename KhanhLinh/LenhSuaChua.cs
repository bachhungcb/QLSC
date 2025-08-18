using KhanhLinh.FinalDataSet1TableAdapters;
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
using static KhanhLinh.frmSelectEmployees;

namespace KhanhLinh
{
    public partial class LenhSuaChua : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public LenhSuaChua()
        {
            InitializeComponent();
        }

        public class JobDetail
        {
            public string JobId { get; set; }
            public double IntendTime { get; set; }
            public List<Employee> Employees { get; set; } = new List<Employee>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Guid Id = Guid.NewGuid();
            int DocNo = Int32.Parse(docNo.Text.ToString().Trim());
            string CarId = carId.SelectedValue.ToString();
            string Summary = summary.Text.ToString().Trim();
            string Description = description.Text.ToString().Trim();
            string Status = status.Text.ToString().Trim();
            string CreatedBy = createdBy.SelectedValue.ToString();
            DateTime DocDate = docDate.Value;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlCommand cmd = new SqlCommand("INSERT INTO RepairCommand(Id, DocNo, CreatedBy, CarId, Description, Status, DocDate, Summary) " +
                                                    "VALUES(@Id, @DocNo, @CreatedBy, @CarId, @Description, @Status, @DocDate, @Summary) ", connect);


                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@DocNo", DocNo);
                    cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                    cmd.Parameters.AddWithValue("@CarId", CarId);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@DocDate", DocDate);
                    cmd.Parameters.AddWithValue("@Summary", Summary);

                    cmd.ExecuteNonQuery();

                    DataGridView CommandJobDetai = noiDungBaoDuong2.DataGridView;
                    DataGridView CommandItemDetail = thongTinVatTu2.DataGridView;
                    // Commit dữ liệu đang nhập ở cell
                    CommandItemDetail.EndEdit();
                    this.Validate();

                    CommandJobDetai.EndEdit();
                    this.Validate();

                    foreach (DataGridViewRow row in CommandJobDetai.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string JobId = row.Cells["CongViec"].Value?.ToString();
                            double IntendTime = Double.Parse(row.Cells["ThoiGianDuKien"].Value?.ToString());
                            
                            var cell = row.Cells["ThoSua1"];
                            if (cell.Tag != null)
                            {
                                var employees = (List<Employee>)cell.Tag;
                                // Xử lý danh sách employees ở đây
                                foreach (var emp in employees)
                                {
                                    Guid jobDetailId = Guid.NewGuid();
                                    // 1. Insert vào CommandJobDetail
                                    string insertJobDetailQuery = @"
                                                                    INSERT INTO CommandJobDetail (Id,CommandId, JobId, IntendTime)
                                                                    VALUES (@Id, @CommandId, @JobId, @IntendTime)";

                                    using (SqlCommand cmdJobDetail = new SqlCommand(insertJobDetailQuery, connect))
                                    {
                                        cmdJobDetail.Parameters.AddWithValue("@Id", jobDetailId);
                                        cmdJobDetail.Parameters.AddWithValue("@CommandId", Id);        
                                        cmdJobDetail.Parameters.AddWithValue("@JobId", JobId);
                                        cmdJobDetail.Parameters.AddWithValue("@IntendTime", IntendTime);
                                        cmdJobDetail.ExecuteNonQuery();
                                    }

                                    // 2. Insert vào EmployeeCommand
                                    string insertEmployeeCmdQuery = @"
                                                                    INSERT INTO EmployeeCommand (CommandId, EmployeeId)
                                                                    VALUES (@CommandId, @EmployeeId)";

                                    using (SqlCommand cmdEmp = new SqlCommand(insertEmployeeCmdQuery, connect))
                                    {
                                        cmdEmp.Parameters.AddWithValue("@CommandId", jobDetailId);
                                        cmdEmp.Parameters.AddWithValue("@EmployeeId", emp.Id);
                                        cmdEmp.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }

                    // In ra dữ liệu từng cell (kể cả dòng NewRow nếu có nhập gì đó)
                    foreach (DataGridViewRow row in CommandItemDetail.Rows)
                    {
                        if (row.IsNewRow) continue; // bỏ dòng trống cuối cùng

                        var commandId = Id;

                        var itemId = Guid.Parse(row.Cells[0].Value.ToString());
                        var quantity = Convert.ToDecimal(row.Cells[1].Value);
                        var reclaimedItemId = string.IsNullOrEmpty(row.Cells[2].Value?.ToString()) ? (Guid?)null : Guid.Parse(row.Cells[2].Value?.ToString());
                        var reclaimedSerial = row.Cells[3].Value?.ToString();
                        var description = row.Cells[4].Value?.ToString();
                        var reclaimedQuantity = string.IsNullOrEmpty(row.Cells[5].Value?.ToString()) ? (decimal?)null : Convert.ToDecimal(row.Cells[6].Value);
                        var issuedSerial = row.Cells[6].Value?.ToString();
                        var warehouseId = string.IsNullOrEmpty(row.Cells[7].Value?.ToString()) ? (Guid?)null : Guid.Parse(row.Cells[7].Value?.ToString());


                        Console.WriteLine(commandId);
                        Console.WriteLine(itemId);
                        Console.WriteLine(quantity);
                        Console.WriteLine(reclaimedItemId);
                        Console.WriteLine(reclaimedSerial);
                        Console.WriteLine(description);
                        Console.WriteLine(reclaimedQuantity);
                        Console.WriteLine(issuedSerial);
                        Console.WriteLine(warehouseId);

                        InsertCommandItemDetail(commandId, itemId, quantity, reclaimedItemId,
                                                reclaimedSerial, description, reclaimedQuantity,
                                                issuedSerial, warehouseId, connect);
                    }

                    MessageBox.Show("Thêm mới thành công",
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

        private void InsertCommandItemDetail(
            Guid commandId,
            Guid itemId,
            decimal quantity,
            Guid? reclaimedItemId,
            string reclaimedSerial,
            string description,
            decimal? reclaimedQuantity,
            string issuedSerial,
            Guid? warehouseId,
            SqlConnection connect)
        {
                    string query = @"
                INSERT INTO CommandItemDetail
                (CommandId, ItemId, Quantity, ReclaimedItemId, ReclaimedSerial, Description, ReclaimedQuantity, IssuedSerial, WarehouseId)
                VALUES
                (@CommandId, @ItemId, @Quantity, @ReclaimedItemId, @ReclaimedSerial, @Description, @ReclaimedQuantity, @IssuedSerial, @WarehouseId)";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Id", Guid.NewGuid());
                        cmd.Parameters.AddWithValue("@CommandId", commandId);
                        cmd.Parameters.AddWithValue("@ItemId", itemId);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);

                        // Cho phép null
                        cmd.Parameters.AddWithValue("@ReclaimedItemId", (object)reclaimedItemId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ReclaimedSerial", (object)reclaimedSerial ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ReclaimedQuantity", (object)reclaimedQuantity ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IssuedSerial", (object)issuedSerial ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@WarehouseId", (object)warehouseId ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
        }


        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void LenhSuaChua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khanhLinhDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.khanhLinhDataSet1.Employee);
            // TODO: This line of code loads data into the 'finalDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.finalDataSet1.Employee);
            // TODO: This line of code loads data into the 'finalDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.finalDataSet1.Department);
            // TODO: This line of code loads data into the 'finalDataSet1.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.finalDataSet1.CarType);
            // TODO: This line of code loads data into the 'finalDataSet1.Route' table. You can move, or remove it, as needed.
            this.routeTableAdapter.Fill(this.finalDataSet1.Route);
            // TODO: This line of code loads data into the 'finalDataSet1.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.finalDataSet1.Car);

        }
    }
}
