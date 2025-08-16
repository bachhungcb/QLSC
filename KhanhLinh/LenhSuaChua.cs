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
    public partial class LenhSuaChua : Form
    {
        NoiDungBaoDuong noiDungBaoDuong = new NoiDungBaoDuong();
        ThongTinVatTu thongTinVatTu = new ThongTinVatTu();
        public LenhSuaChua()
        {
            InitializeComponent();
            noiDungBaoDuong.Hide();
            thongTinVatTu.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            thongTinVatTu.Hide();
            noiDungBaoDuong.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            noiDungBaoDuong.Hide();
            thongTinVatTu.Show();
        }
    }
}
