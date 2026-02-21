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
    public partial class CreateCompanyForm : Form
    {
        public CreateCompanyForm()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            string companyName = txtCompanyName.Text.Trim();
            string email = textEmail.Text.Trim();
            string phone = textPhone.Text.Trim();
            string description = textDescription.Text.Trim();

            // Validate company name
            if (!AppUtilities.IsValidCompanyName(companyName))
            {
                AppUtilities.ShowError($"Company name must be between {AppUtilities.ValidationRules.MinCompanyNameLength} and {AppUtilities.ValidationRules.MaxCompanyNameLength} characters.");
                txtCompanyName.Focus();
                return false;
            }

            // Validate email
            if (!AppUtilities.IsValidEmail(email))
            {
                AppUtilities.ShowError("Please enter a valid email address.");
                textEmail.Focus();
                return false;
            }

            // Validate phone (optional)
            if (!string.IsNullOrWhiteSpace(phone) && !AppUtilities.IsValidPhoneNumber(phone))
            {
                AppUtilities.ShowError("Please enter a valid phone number.");
                textPhone.Focus();
                return false;
            }

            // Validate description (optional)
            if (!string.IsNullOrWhiteSpace(description) && !AppUtilities.IsValidCompanyDescription(description))
            {
                AppUtilities.ShowError($"Company description must not exceed {AppUtilities.ValidationRules.MaxCompanyDescriptionLength} characters.");
                textDescription.Focus();
                return false;
            }

            return true;
        }

        private void brnCreate_Click(object sender, EventArgs e)
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

                    // Check if company with same email already exists
                    string checkEmailQuery = "SELECT COUNT(*) FROM [Company] WHERE email = @email";
                    using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@email", textEmail.Text.Trim());
                        int existingCount = (int)checkEmailCmd.ExecuteScalar();
                        if (existingCount > 0)
                        {
                            AppUtilities.ShowError("A company with this email already exists.");
                            return;
                        }
                    }

                    // sql command for inserting company
                    string insertCompanyQuery =
                        "INSERT INTO [Company] " +
                        "(name, email, phone, description, manager_id) " +
                        "VALUES (@name, @email, @phone, @description, @managerId);";

                    using (SqlCommand insertCompanyCmd = new SqlCommand(insertCompanyQuery, connection))
                    {
                        insertCompanyCmd.Parameters.AddWithValue("@name", txtCompanyName.Text.Trim());
                        insertCompanyCmd.Parameters.AddWithValue("@email", textEmail.Text.Trim());
                        insertCompanyCmd.Parameters.AddWithValue("@phone", string.IsNullOrWhiteSpace(textPhone.Text) ? (object)DBNull.Value : textPhone.Text.Trim());
                        insertCompanyCmd.Parameters.AddWithValue("@description", string.IsNullOrWhiteSpace(textDescription.Text) ? (object)DBNull.Value : textDescription.Text.Trim());
                        insertCompanyCmd.Parameters.AddWithValue("@managerId", Session.CurrentUserId);

                        var result = insertCompanyCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            AppUtilities.ShowInfo($"Company '{txtCompanyName.Text.Trim()}' created successfully!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            AppUtilities.ShowError("Failed to create company.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppUtilities.ShowError($"An error occurred while creating the company: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
