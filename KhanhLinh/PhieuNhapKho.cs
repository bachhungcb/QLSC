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
    public partial class PhieuNhapKho : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public PhieuNhapKho()
        {
            InitializeComponent();
        }

        private void PhieuNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.vVoucherDetail' table. You can move, or remove it, as needed.
            this.vVoucherDetailTableAdapter.Fill(this.finalDataSet1.vVoucherDetail);
            // TODO: This line of code loads data into the 'finalDataSet1.vInventoryVoucher' table. You can move, or remove it, as needed.
            this.vInventoryVoucherTableAdapter.FillByPN(this.finalDataSet1.vInventoryVoucher);

        }

        private void fillByPNToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vInventoryVoucherTableAdapter.FillByPN(this.finalDataSet1.vInventoryVoucher);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhieuNhapKho addPhieuNhapKho = new AddPhieuNhapKho();
            this.Hide();
            addPhieuNhapKho.Show();
        }

        private void phieuNhapKhoOverview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var voucherId = "";
            if (e.RowIndex >= 0)
            {
                voucherId = phieuNhapKhoOverview.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value?.ToString();
            }

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT * FROM vVoucherDetail WHERE ParentId = @voucherId", connect);
                    cmd.Parameters.AddWithValue("@voucherId", voucherId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    phieuNhapKhoDetail.DataSource = dt;


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

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuXuatKho phieuXuatKho = new PhieuXuatKho();
            this.Hide();
            phieuXuatKho.Show();
        }
    }
}
