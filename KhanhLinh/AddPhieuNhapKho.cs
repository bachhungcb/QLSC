using KhanhLinh.DataObject;
using MetroFramework.Controls;
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
using System.Windows.Forms; using KhanhLinh.DataObject;

namespace KhanhLinh
{
    public partial class AddPhieuNhapKho : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public AddPhieuNhapKho()
        {
            InitializeComponent();
        }

        private void AddPhieuNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.finalDataSet1.Car);
            // TODO: This line of code loads data into the 'finalDataSet1.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.finalDataSet1.Warehouse);
            // TODO: This line of code loads data into the 'finalDataSet1.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.finalDataSet1.Item);
            // TODO: This line of code loads data into the 'finalDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.finalDataSet1.Employee);

        }



        private void metroGrid1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (metroGrid1.IsCurrentCellDirty)
            {
                metroGrid1.CommitEdit(DataGridViewDataErrorContexts.Commit);
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
                    GetItemInfo( selectedValue, e.RowIndex );
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            Guid PNKId = Guid.NewGuid();
            string DocCode = "PN";
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

                    SqlCommand cmd = new SqlCommand("AddPNK", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", PNKId);
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

            foreach(DataGridViewRow row in metroGrid1.Rows)
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

                        SqlCommand cmd = new SqlCommand("AddPNKDetail", connect);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ParentId", PNKId);
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

            MessageBox.Show("Thêm Phiếu nhập kho thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhapKho phieuNhapKhoSreen = new PhieuNhapKho();
            this.Hide();
            phieuNhapKhoSreen.Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
