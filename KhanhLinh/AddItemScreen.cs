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
    public partial class AddItemScreen : Form
    {
       private  string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public AddItemScreen()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string Code = itemCode.Text.ToString().Trim();
            string Name = itemName.Text.ToString().Trim();
            bool IsItemWithSerial = isItemWithSerial.Checked;
            string Unit = itemUnit.Text.ToString().Trim();
            string UnitDesc = itemUnitDesc.Text.ToString().Trim();
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }


                    MessageBox.Show("Thêm thể loại xe thành công",
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void itemUnitDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
