using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Views
{
    public partial class JobDetailsForm : Form
    {
        private int jobId;
        public JobDetailsForm(int jobId )
        {
            InitializeComponent();
            this.jobId = jobId ; 

            readOnlyFields();
            loadJobDetails();
        }

        public void readOnlyFields()
        {
            tboxTitle.ReadOnly = true;
            tboxStatus.ReadOnly = true;
            tboxExpLevel.ReadOnly = true;
            tboxWorkMode.ReadOnly = true;
            tboxJobType.ReadOnly = true;
            tboxSkills.ReadOnly = true;
            tboxDescription.ReadOnly = true;
        }
        public void loadJobDetails()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;"))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT V.title, V.status, V.experience_level, V.work_mode, V.job_type, V.skills, V.description, V.deadline, C.name 
                  FROM [Vacancy] V INNER JOIN [Company] C
                  ON V.company_id = C.company_id
                  WHERE vacancy_id = @jobId", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@jobId", jobId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tboxTitle.Text = reader["title"]?.ToString() ?? "";
                        tboxStatus.Text = reader["status"]?.ToString() ?? "";
                        tboxExpLevel.Text = reader["experience_level"]?.ToString() ?? "";
                        tboxWorkMode.Text = reader["work_mode"]?.ToString() ?? "";
                        tboxJobType.Text = reader["job_type"]?.ToString() ?? "";
                        tboxSkills.Text = reader["skills"]?.ToString() ?? "";
                        tboxDescription.Text = reader["description"]?.ToString() ?? "";
                        tboxCompanyName.Text = reader["name"]?.ToString() ??  "";
                        if (reader["deadline"] != DBNull.Value)
                            dateDeadline.Value = Convert.ToDateTime(reader["deadline"]);
                        else
                            dateDeadline.Value = DateTime.Now;
                    }
                    else
                    {
                        tboxTitle.Text = "";
                        tboxStatus.Text = "";
                        tboxExpLevel.Text = "";
                        tboxWorkMode.Text = "";
                        tboxJobType.Text = "";
                        tboxSkills.Text = "";
                        tboxDescription.Text = "";
                        tboxCompanyName.Text = "";
                        dateDeadline.Value = DateTime.Now;
                    }
                }
            }
        }

        private void tboxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
