using Microsoft.Data.SqlClient;
using RecruitmentApplication.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Views
{
    public partial class SavedJobsControl : UserControl
    {
        public SavedJobsControl()
        {
            InitializeComponent();
            LoadSavedJobs();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            var applyButtonColumn = new DataGridViewButtonColumn();
            applyButtonColumn.Name = "Apply";
            applyButtonColumn.HeaderText = "Apply";
            applyButtonColumn.Text = "Apply";
            applyButtonColumn.UseColumnTextForButtonValue = true;
            dataGridSavedJobs.Columns.Add(applyButtonColumn);

            var detailsButtonColumn = new DataGridViewButtonColumn();
            detailsButtonColumn.Name = "Details";
            detailsButtonColumn.HeaderText = "Details";
            detailsButtonColumn.Text = "Details";
            detailsButtonColumn.UseColumnTextForButtonValue = true;
            dataGridSavedJobs.Columns.Add(detailsButtonColumn);

            dataGridSavedJobs.AllowUserToAddRows = false;
            dataGridSavedJobs.AutoGenerateColumns = false;
            dataGridSavedJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn column in dataGridSavedJobs.Columns)
            {
                if (!(column is DataGridViewButtonColumn))
                {
                    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
                column.ReadOnly = true;
            }
        }

        private void LoadSavedJobs()
        {
            if (Session.CurrentUserId.HasValue)
            {
                int userId = Session.CurrentUserId.Value;

                using (var conn = new SqlConnection("Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;"))
                using (var cmd = new SqlCommand(
                    @"SELECT   
                v.vacancy_id,
                v.employer_id,
                c.name AS 'Company Name',
                v.title AS 'Job Title', 
                v.deadline AS 'Deadline', 
                FORMAT(s.save_date, 'dd MMM yyyy') AS 'Save Date'
              FROM SavedJob s
              JOIN Vacancy v ON s.vacancy_id = v.vacancy_id
              JOIN Company c ON v.company_id = c.company_id
              WHERE s.jobseeker_id = @userId", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    conn.Open();

                    DataTable dt = new DataTable();
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    dataGridSavedJobs.DataSource = dt;

                    dataGridSavedJobs.Columns["vacancy_id"].Visible = false;
                    dataGridSavedJobs.Columns["employer_id"].Visible = false;
                }
            }
        }

        private void dataGridSavedJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            int jobId = Convert.ToInt32(dataGridSavedJobs.Rows[e.RowIndex].Cells["vacancy_id"].Value);
            int empId = Convert.ToInt32(dataGridSavedJobs.Rows[e.RowIndex].Cells["employer_id"].Value);

            if (dataGridSavedJobs.Columns[e.ColumnIndex].Name == "Details")
            {
                var detailsForm = new JobDetailsForm(jobId);
                detailsForm.ShowDialog();
            }
            else if (dataGridSavedJobs.Columns[e.ColumnIndex].Name == "Apply")
            {
                string jobTitle = dataGridSavedJobs.Rows[e.RowIndex].Cells["Job Title"].Value?.ToString() ?? "this job";

                if (HasUserAlreadAppliedToJob(jobId))
                {
                    MessageBox.Show("You have already applied to this job.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to apply to \"{jobTitle}\"?",
                    "Confirm Application",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    ApplyToJob(jobId, empId);
                }
            }
        }

        private void ApplyToJob(int jobId, int employerId)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string applyToJobQuery =
                    @"INSERT INTO [JobApplication]
                      (jobseeker_id, vacancy_id, employer_id)
                      VALUES (@userId, @jobId, @empId);";
                SqlCommand applyToJobCommand = new SqlCommand(applyToJobQuery, connection);
                applyToJobCommand.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                applyToJobCommand.Parameters.AddWithValue("@jobId", jobId);
                applyToJobCommand.Parameters.AddWithValue("@empId", employerId);

                var result = applyToJobCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully applied to job.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to apply to the job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool HasUserAlreadAppliedToJob(int jobId)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string hasUserAppliedQuery = "SELECT * FROM [JobApplication] WHERE vacancy_id = @jobId AND jobseeker_id = @userId";
                SqlCommand hasUserAppliedCmd = new SqlCommand(hasUserAppliedQuery, connection);
                hasUserAppliedCmd.Parameters.AddWithValue("@jobId", jobId);
                hasUserAppliedCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                SqlDataReader reader = hasUserAppliedCmd.ExecuteReader();
                bool applied = reader.HasRows;
                reader.Close();
                return applied;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSavedJobs();
        }
    }
}
