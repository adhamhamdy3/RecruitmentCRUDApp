using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using RecruitmentApplication.Views;
using RecruitmentApplication.Utilities;

namespace RecruitmentApplication.Views.Auth
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string phoneNumber = txtPhoneNumber.Text.Trim();
            DateTime? birthDate = this.birthDate.Value;
            
            // Validate full name
            if (string.IsNullOrWhiteSpace(fullName))
            {
                AppUtilities.ShowError("Please enter your full name.");
                return;
            }

            // Validate email
            if (!AppUtilities.IsValidEmail(email))
            {
                AppUtilities.ShowError("Please enter a valid email address.");
                return;
            }

            // Validate password
            if (!AppUtilities.IsValidPassword(password))
            {
                AppUtilities.ShowError($"Password must be between {AppUtilities.ValidationRules.MinPasswordLength} and {AppUtilities.ValidationRules.MaxPasswordLength} characters long, " +
                    "and contain at least one uppercase letter, one lowercase letter, one number, and one special character.");
                return;
            }

            // Validate password confirmation
            if (password != confirmPassword)
            {
                AppUtilities.ShowError("Passwords do not match.");
                return;
            }

            // Validate phone number
            if (!AppUtilities.IsValidPhoneNumber(phoneNumber))
            {
                AppUtilities.ShowError("Please enter a valid phone number.");
                return;
            }

            // Validate birth date
            if (birthDate.HasValue && !AppUtilities.IsValidBirthDate(birthDate.Value))
            {
                AppUtilities.ShowError("Please enter a valid birth date. You must be at least 16 years old.");
                return;
            }

            string userType = radioBtnEmployer.Checked ? AppUtilities.DatabaseConstants.UserTypes.Employer : AppUtilities.DatabaseConstants.UserTypes.JobSeeker;

            // Validate user type
            if (!AppUtilities.IsValidUserType(userType))
            {
                AppUtilities.ShowError("Invalid user type selected.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(AppUtilities.DatabaseConstants.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string isEmailDuplicateQuery = "SELECT * FROM [User] WHERE email = @email";
                    SqlCommand isEmailDuplicateCmd = new SqlCommand(isEmailDuplicateQuery, connection);
                    isEmailDuplicateCmd.Parameters.Add(new SqlParameter("@email", email));

                    using (SqlDataReader reader = isEmailDuplicateCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            AppUtilities.ShowError("An account already exists with this email.");
                            return;
                        }
                    }

                    string signupQuery = 
                        "INSERT INTO [User] " +
                        "(name, email, password, phone, birth_date, user_type) " +
                        "VALUES (@name, @email, @password, @phone, @birthDate, @userType)";
                    SqlCommand signupCmd = new SqlCommand(signupQuery, connection);
                    signupCmd.Parameters.AddWithValue("@name", fullName);
                    signupCmd.Parameters.AddWithValue("@email", email);
                    signupCmd.Parameters.AddWithValue("@password", password);
                    signupCmd.Parameters.AddWithValue("@phone", phoneNumber);
                    signupCmd.Parameters.AddWithValue("@birthDate", birthDate ?? (object) DBNull.Value);
                    signupCmd.Parameters.AddWithValue("@userType", userType); 
                    var result = signupCmd.ExecuteNonQuery();
                    
                    if (result > 0)
                    {
                        AppUtilities.ShowInfo("Account created successfully!");

                        var loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    } 
                    else
                    {
                        AppUtilities.ShowError("Account creation failed. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    AppUtilities.ShowError($"An error occurred: {ex.Message}");
                }
            }
        }

        private void frmSignup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}