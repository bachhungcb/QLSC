using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhanhLinh
{
    public partial class NoiDungBaoDuong : UserControl
    {
        public NoiDungBaoDuong()
        {
            InitializeComponent();
            this.Load += NoiDungBaoDuong_Load;
        }

        public DataGridView DataGridView
        {
            get { return dataGridView1; }
        }

        private void NoiDungBaoDuong_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode) // tránh lỗi khi mở trong VS Designer
            {
                this.repairJobTableAdapter.Fill(this.finalDataSet1.RepairJob);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "ThoSua1")
            {
                using (var frm = new frmSelectEmployees())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var selectedEmployees = frm.SelectedEmployees;

                        // Lưu vào Tag của cell
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = selectedEmployees;

                        // Hiển thị tên + id lên cell
                        string msg = string.Join(", ", selectedEmployees.Select(emp => $"{emp.Name}"));
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = msg;
                    }
                }
            }
        }
    }
}
