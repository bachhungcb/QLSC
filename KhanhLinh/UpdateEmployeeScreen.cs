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
using System.Windows.Forms; using KhanhLinh.DataObject;

namespace KhanhLinh
{
    public partial class UpdateEmployeeScreen : Form
    {
        private string EmpId = SharedId.Id;
        private string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public UpdateEmployeeScreen()
        {
            InitializeComponent();
        }

        private void UpdateEmployeeScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.finalDataSet.Department);
            // TODO: This line of code loads data into the 'finalDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.finalDataSet.Employee);



            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    string query = "SELECT Id, Code,Name FROM vEmployee";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dt.Columns.Add("MultipleValues",typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["MultipleValues"] = row["Name"].ToString() + " (" + row["Code"].ToString() +")";
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
            empDOB.Text = "";
            departmentBox.DisplayMember = "Name";
            GetEmpInfo(EmpId);
        }

        private void empName_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void GetEmpInfo(string empId)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT Code, Name, DepartmentId ,PhoneNumber, BirthDate, Gender, BirthPlace, JobSkillLevel,IsRepairMan " +
                                                    "FROM Employee WHERE Id = @EmpId", connect);


                    cmd.Parameters.AddWithValue("@EmpId", empId);

                    SqlDataReader result = cmd.ExecuteReader();

                    if (result.Read())
                    {
                        string Code = result["Code"].ToString();
                        string Name = result["Name"].ToString();
                        string PhoneNumber = result["PhoneNumber"].ToString();
                        Guid DeptId = Guid.Parse(result["DepartmentId"].ToString());
                        DateTime BirthDate = (DateTime)result["BirthDate"];
                        string Gender = result["Gender"].ToString();
                        string BirthPlace = result["BirthPlace"].ToString();
                        string JobSkillLevel = result["JobSkillLevel"].ToString();
                        bool IsRepairMan = (bool)result["IsRepairMan"];


                        empCode.Text = Code;
                        empPhoneNumber.Text = PhoneNumber;
                        empName.Text = Name;
                        empGender.Text = Gender;
                        departmentBox.SelectedValue = DeptId;
                        empDOB.Value = BirthDate;
                        empBornPlace.Text = BirthPlace;
                        empJobSkillLevel.Text = JobSkillLevel;
                        empIsRepairMan.Checked = IsRepairMan;

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho Nhân viên = " + EmpId);
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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmpInfo(EmpId);
        }

        private void listEmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeScreen empScreen = new EmployeeScreen();
            this.Hide();
            empScreen.Show();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string Code = empCode.Text.Trim();
            string Name = empName.Text.ToString().Trim();
            string DeptId = departmentBox.SelectedValue.ToString();
            string PhoneNumber = empPhoneNumber.Text.Trim();
            DateTime BirthDate = empDOB.Value;
            string Gender = empGender.Text.Trim();
            string BirthPlace = empBornPlace.Text.Trim();
            string JobSkillLevel = empJobSkillLevel.Text.Trim();
            int IsRepairMan = Convert.ToInt32(empIsRepairMan.Checked);


            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE Employee " +
                                                    "SET Code = @Code, Name = @Name, DepartmentId = @DeptId," +
                                                    "PhoneNumber = @PhoneNumber, BirthDate = @BirthDate, Gender = @Gender," +
                                                    "JobSkillLevel =@JobSkillLevel, IsRepairMan = @IsRepairMan " +
                                                    "WHERE Id = @EmpId", connect);
                    
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@EmpId", EmpId);
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@DeptId", DeptId);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@BirthPlace", BirthPlace);
                    cmd.Parameters.AddWithValue("@JobSkillLevel", JobSkillLevel);
                    cmd.Parameters.AddWithValue("@IsRepairMan", IsRepairMan);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật nhân viên thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

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

        private void danhSachsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeScreen empScreen = new EmployeeScreen();
            this.Hide();
            empScreen.Show();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
