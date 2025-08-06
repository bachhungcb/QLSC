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
    public partial class UpdateRepairJobScreen : Form
    {

        private readonly string SharedRepairJobId = SharedId.Id;
        private string connectionString = ConfigurationManager.ConnectionStrings["KhanhLinh.Properties.Settings.KhanhLinhConnectionString"].ToString();

        public UpdateRepairJobScreen()
        {
            InitializeComponent();
            GetRepairJobInfo(SharedRepairJobId);
        }

        private void UpdateRepairJobScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.finalDataSet1.CarType);
            // TODO: This line of code loads data into the 'finalDataSet1.RepairJob' table. You can move, or remove it, as needed.
            this.repairJobTableAdapter.Fill(this.finalDataSet1.RepairJob);
            jobType.Items.Add("Công việc 1");
            jobType.Items.Add("Công việc 2");
            jobType.Items.Add("Công việc 3");
        }

        private void GetRepairJobInfo(string Id)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT Code, Name, Description, SkillLevel, IntendTime, CarTypeId, JobType " +
                                                    "FROM RepairJob WHERE Id = @repairJobId", connect);


                    cmd.Parameters.AddWithValue("@repairJobId", Id);

                    SqlDataReader result = cmd.ExecuteReader();

                    if (result.Read())
                    {
                        string Code = result["Code"].ToString();
                        string Name = result["Name"].ToString();
                        string Description = result["Description"].ToString();
                        string SkillLevel = result["SkillLevel"].ToString();
                        DateTime IntendTime = (DateTime)result["IntendTime"];
                        Guid CarTypeId = Guid.Parse(result["CarTypeId"].ToString());
                        string JobType = result["JobType"].ToString();

                        repairJobCode.Text = Code;
                        repairJobName1.Text = Name;
                        repairJobDescription.Text = Description;
                        repairJobCarTypeId.SelectedValue = CarTypeId;
                        skillLevel.Text = SkillLevel;
                        jobType.Text = JobType;


                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho loại công việc = " + Id);
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

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairJobScreen repairJobScreen = new RepairJobScreen();
            this.Hide();
            repairJobScreen.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            string Code = repairJobCode.Text.ToString().Trim();
            string Name = repairJobName1.Text.ToString().Trim();
            string Description = repairJobDescription.Text.ToString().Trim();
            string SkillLevel = skillLevel.Text.ToString().Trim();
            DateTime IntendTime = intendTime.Value;
            string CarTypeId = repairJobCarTypeId.SelectedValue.ToString();
            string JobType = jobType.SelectedItem.ToString();


            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    SqlCommand cmd = new SqlCommand("UPDATE RepairJob " +
                                                    "SET Code = @Code, Name = @Name, Description = @Description," +
                                                    "SkillLevel = @SkillLevel, IntendTime = @IntendTime, JobType = @JobType " +
                                                    "WHERE Id = @repairJobId", connect);

                    cmd.CommandType = System.Data.CommandType.Text;


                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@SkillLevel", SkillLevel);
                    cmd.Parameters.AddWithValue("@IntendTime", IntendTime);
                    cmd.Parameters.AddWithValue("@repairJobId", SharedRepairJobId);
                    cmd.Parameters.AddWithValue("@JobType", JobType);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật công việc sửa chữa thành công",
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
    }
}
