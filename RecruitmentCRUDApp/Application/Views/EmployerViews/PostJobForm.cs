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
    public partial class PostJobForm : Form
    {
        public PostJobForm()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            string title = tboxTitle.Text.Trim();
            string description = tboxDescription.Text.Trim();
            string skills = tboxSkills.Text.Trim();
            string status = cmboxStatus.SelectedItem?.ToString();
            string expLevel = cmboxExpLevel.SelectedItem?.ToString();
            string workMode = cmboxWorkMode.SelectedItem?.ToString();
            string jobType = cmboxJobType.SelectedItem?.ToString();
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

            return true;
        }

        private void btnPost_Click(object sender, EventArgs e)
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
                            string getCompanyIdQuery = "SELECT company_id FROM [Employer] WHERE user_id = @userId";
                            SqlCommand getCompanyIdCmd = new SqlCommand(getCompanyIdQuery, connection, transaction);
                            getCompanyIdCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                            
                            int companyId;
                            using (SqlDataReader reader = getCompanyIdCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    companyId = reader.GetInt32(0);
                                }
                                else
                                {
                                    transaction.Rollback();
                                    AppUtilities.ShowError("Failed to get company information.");
                                    return;
                                }
                            }

                            string insertVacancyQuery =
                                "INSERT INTO [Vacancy] " +
                                "(title, description, skills, status, experience_level, work_mode, job_type, deadline, company_id, employer_id) " +
                                "VALUES (@title, @description, @skills, @status, @expLevel, @workMode, @jobType, @deadline, @companyId, @employerId);";
                            
                            using (SqlCommand insertVacancyCmd = new SqlCommand(insertVacancyQuery, connection, transaction))
                            {
                                insertVacancyCmd.Parameters.AddWithValue("@title", tboxTitle.Text.Trim());
                                insertVacancyCmd.Parameters.AddWithValue("@description", tboxDescription.Text.Trim());
                                insertVacancyCmd.Parameters.AddWithValue("@skills", tboxSkills.Text.Trim());
                                insertVacancyCmd.Parameters.AddWithValue("@status", cmboxStatus.SelectedItem.ToString());
                                insertVacancyCmd.Parameters.AddWithValue("@expLevel", cmboxExpLevel.SelectedItem.ToString());
                                insertVacancyCmd.Parameters.AddWithValue("@workMode", cmboxWorkMode.SelectedItem.ToString());
                                insertVacancyCmd.Parameters.AddWithValue("@jobType", cmboxJobType.SelectedItem.ToString());
                                insertVacancyCmd.Parameters.AddWithValue("@deadline", dateDeadline.Value);
                                insertVacancyCmd.Parameters.AddWithValue("@companyId", companyId);
                                insertVacancyCmd.Parameters.AddWithValue("@employerId", Session.CurrentUserId);

                                int result = insertVacancyCmd.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    transaction.Commit();
                                    AppUtilities.ShowInfo($"Vacancy {tboxTitle.Text.Trim()} posted successfully!");
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    AppUtilities.ShowError($"Failed to post job {tboxTitle.Text.Trim()}.");
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
                AppUtilities.ShowError($"Error posting job vacancy: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostJobForm_Load(object sender, EventArgs e)
        {
            // Status options
            cmboxStatus.Items.Add(AppUtilities.DatabaseConstants.VacancyStatus.Open);
            cmboxStatus.Items.Add(AppUtilities.DatabaseConstants.VacancyStatus.Closed);
            cmboxStatus.Items.Add(AppUtilities.DatabaseConstants.VacancyStatus.Hidden);
            cmboxStatus.SelectedIndex = 0;
            cmboxStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            // Experience level options
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.Student);
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.FreshGraduate);
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.Junior);
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.MidLevel);
            cmboxExpLevel.Items.Add(AppUtilities.DatabaseConstants.ExperienceLevels.Senior);
            cmboxExpLevel.SelectedIndex = 0;
            cmboxExpLevel.DropDownStyle = ComboBoxStyle.DropDownList;

            // Work mode options
            cmboxWorkMode.Items.Add(AppUtilities.DatabaseConstants.WorkModes.OnSite);
            cmboxWorkMode.Items.Add(AppUtilities.DatabaseConstants.WorkModes.Remote);
            cmboxWorkMode.Items.Add(AppUtilities.DatabaseConstants.WorkModes.Hybrid);
            cmboxWorkMode.SelectedIndex = 0;
            cmboxWorkMode.DropDownStyle = ComboBoxStyle.DropDownList;

            // Job type options
            cmboxJobType.Items.Add(AppUtilities.DatabaseConstants.JobTypes.FullTime);
            cmboxJobType.Items.Add(AppUtilities.DatabaseConstants.JobTypes.PartTime);
            cmboxJobType.Items.Add(AppUtilities.DatabaseConstants.JobTypes.Internship);
            cmboxJobType.SelectedIndex = 0;
            cmboxJobType.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
