using MetroFramework.Controls;
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
    public partial class frmSelectEmployees : Form
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();
        public List<Employee> SelectedEmployees { get; set; } = new List<Employee>();

        private void frmSelectEmployees_Load(object sender, EventArgs e)
        {
            // Lấy danh sách nhân viên từ DB
            var employees = GetEmployeeInfo();

            // Xóa dữ liệu cũ (nếu có)
            checkedListBox1.Items.Clear();

            // Thêm dữ liệu mới
            foreach (var emp in employees)
            {
                checkedListBox1.Items.Add(emp, false); // false = mặc định chưa check
            }
        }

        public class Employee
        {
            public Guid Id { get; set; }   // hoặc int nếu cột Id trong DB là int
            public string Name { get; set; }
            public string Code { get; set; }

            public override string ToString()
            {
                // Để hiển thị dễ hơn trong CheckedListBox / ListBox
                return $"{Code} - {Name}";
            }
        }

        public frmSelectEmployees()
        {
            InitializeComponent();
            this.Load += frmSelectEmployees_Load;
        }

        /// <summary>
        /// Lấy danh sách nhân viên từ bảng Employee
        /// </summary>
        public List<Employee> GetEmployeeInfo()
        {
            var employees = new List<Employee>();

            try
            {
                using (var connect = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SELECT Id, Name, Code FROM Employee", connect))
                {
                    connect.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee
                            {
                                Id = reader.GetGuid(0),   // Nếu là int: reader.GetInt32(0)
                                Name = reader.GetString(1),
                                Code = reader.GetString(2)
                            });
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

            return employees;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            SelectedEmployees.Clear();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (item is Employee emp)
                    SelectedEmployees.Add(emp);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
