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
using RecruitmentApplication.Utilities;

namespace RecruitmentApplication.Views
{
    public partial class EditJobForm : Form
    {
        private int jobId;
        public EditJobForm(int jobId)
        {
            InitializeComponent();
            InitializeComboBoxes();
            this.jobId = jobId;
        }

        private bool ValidateInputs()
        {
            string title = tboxTitle.Text.Trim();
            string description = tboxDescription.Text.Trim();
            string skills = tboxSkills.Text.Trim();
            string status = cmboxStatus.Text?.ToString();
            string expLevel = cmboxExpLevel.Text?.ToString();
            string workMode = cmboxWorkMode.Text?.ToString();
            string jobType = cmboxJobType.Text?.ToString();
            DateTime deadline = dateDeadline.Value;

            // Validate title
            if (!AppUtilities.IsValidJobTitle(title))
            {
                AppUtilities.ShowError($"Job title must be between {AppUtilities.ValidationRules.MinJobTitleLength} and {AppUtilities.ValidationRules.MaxJobTitleLength} characters.");
                tboxTitle.Focus();
                return false;
            }

            // Validate experience level
            if (string.IsNullOrEmpty(expLevel) || !AppUtilities.IsValidExperienceLevel(expLevel))
            {
                AppUtilities.ShowError("Please select a valid experience level.");
                cmboxExpLevel.Focus();
                return false;
            }

            // Validate work mode
            if (string.IsNullOrEmpty(workMode) || !AppUtilities.IsValidWorkMode(workMode))
            {
                AppUtilities.ShowError("Please select a valid work mode.");
                cmboxWorkMode.Focus();
                return false;
            }

            // Validate job type
            if (string.IsNullOrEmpty(jobType) || !AppUtilities.IsValidJobType(jobType))
            {
                AppUtilities.ShowError("Please select a valid job type.");
                cmboxJobType.Focus();
                return false;
            }

            // Validate status
            if (string.IsNullOrEmpty(status) || !AppUtilities.IsValidVacancyStatus(status))
            {
                AppUtilities.ShowError("Please select a valid status.");
                cmboxStatus.Focus();
                return false;
            }

            // Validate deadline
            if (!AppUtilities.IsValidDeadline(deadline))
            {
                AppUtilities.ShowError("Deadline must be a future date.");
                dateDeadline.Focus();
                return false;
            }

            // Validate job ID
            if (jobId <= 0)
            {
                AppUtilities.ShowError("Invalid job ID. Cannot update job vacancy!");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(AppUtilities.DatabaseConstants.ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string updateQuery = @"UPDATE [Vacancy]
                                        SET title = @Title, 
                                            description = @Description, 
                                            skills = @Skills, 
                                            status = @Status, 
                                            experience_level = @ExpLevel, 
                                            work_mode = @WorkMode, 
                                            job_type = @JobType, 
                                            deadline = @Deadline
                                        WHERE vacancy_id = @VacancyId";

                            using (SqlCommand cmd = new SqlCommand(updateQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Title", tboxTitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@Description", tboxDescription.Text.Trim());
                                cmd.Parameters.AddWithValue("@Skills", tboxSkills.Text.Trim());
                                cmd.Parameters.AddWithValue("@Status", cmboxStatus.Text.ToString());
                                cmd.Parameters.AddWithValue("@ExpLevel", cmboxExpLevel.Text.ToString());
                                cmd.Parameters.AddWithValue("@WorkMode", cmboxWorkMode.Text.ToString());
                                cmd.Parameters.AddWithValue("@JobType", cmboxJobType.Text.ToString());
                                cmd.Parameters.AddWithValue("@Deadline", dateDeadline.Value);
                                cmd.Parameters.AddWithValue("@VacancyId", jobId);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    AppUtilities.ShowInfo("Job vacancy updated successfully!");

                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    AppUtilities.ShowError("Failed to update job vacancy. The job may no longer exist.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppUtilities.ShowError($"Error updating job vacancy: {ex.Message}");
            }
        }

        private void EditJobForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AppUtilities.DatabaseConstants.ConnectionString))
                {
                    connection.Open();
                    string getJobDataQuery = "SELECT * FROM [Vacancy] WHERE vacancy_id = @jobId";
                    SqlCommand cmd = new SqlCommand(getJobDataQuery, connection);
                    cmd.Parameters.AddWithValue("@jobId", jobId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        tboxTitle.Text = reader["title"].ToString();
                        cmboxStatus.Text = reader["status"].ToString();
                        cmboxExpLevel.Text = reader["experience_level"].ToString();
                        cmboxWorkMode.Text = reader["work_mode"].ToString();
                        cmboxJobType.Text = reader["job_type"].ToString();
                        if (reader["deadline"] != DBNull.Value)
                            dateDeadline.Value = Convert.ToDateTime(reader["deadline"]);
                        else
                            dateDeadline.Value = DateTime.Now;
                        tboxSkills.Text = reader["skills"].ToString();
                        tboxDescription.Text = reader["description"].ToString();
                    } 
                    else
                    {
                        AppUtilities.ShowError("Failed to fetch job data from the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                AppUtilities.ShowError($"Error loading job data: {ex.Message}");
            }
        }

        private void InitializeComboBoxes()
        {
            // Status options
            cmboxStatus.Items.Add(AppUtilities.DatabaseConstants.VacancyStatus.Open);
            cmboxStatus.Items.Add(AppUtilities.DatabaseConstants.VacancyStatus.Closed);
            cmboxStatus.Items.Add(AppUtilities.DatabaseConstants.VacancyStatus.Hidden);
            cmboxStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            // Experience level options
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.Student);
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.FreshGraduate);
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.Junior);
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.MidLevel);
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.Senior);
            cmboxExpLevel.DropDownStyle = ComboBoxStyle.DropDownList;

            // Work mode options
            cmboxWorkMode.Items.Add(AppUtilities.DatabaseConstants.WorkModes.OnSite);
            cmboxWorkMode.Items.Add(AppUtilities.DatabaseConstants.WorkModes.Remote);
            cmboxWorkMode.Items.Add(AppUtilities.DatabaseConstants.WorkModes.Hybrid);
            cmboxWorkMode.DropDownStyle = ComboBoxStyle.DropDownList;

            // Job type options
            cmboxJobType.Items.Add(AppUtilities.DatabaseConstants.JobTypes.FullTime);
            cmboxJobType.Items.Add(AppUtilities.DatabaseConstants.JobTypes.PartTime);
            cmboxJobType.Items.Add(AppUtilities.DatabaseConstants.JobTypes.Internship);
            cmboxJobType.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
