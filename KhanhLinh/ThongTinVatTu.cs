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
    public partial class ThongTinVatTu : UserControl
    {
        public ThongTinVatTu()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView
        {
            get { return dataGridView1; }
        }

        private void ThongTinVatTu_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode) // tránh lỗi khi mở trong VS Designer
            {
                this.warehouseTableAdapter.Fill(this.finalDataSet1.Warehouse);
                this.itemTableAdapter.Fill(this.finalDataSet1.Item);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
