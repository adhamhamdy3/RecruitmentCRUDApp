using Microsoft.VisualBasic.ApplicationServices;
using RecruitmentApplication.Utilities;
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

namespace RecruitmentApplication.Views.Profiles
{
    public partial class JobSeekerProfileControl : UserControl
    {
        public JobSeekerProfileControl()
        {
            InitializeComponent();
        }

        private void btnSaveChangesSkills_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs before saving
                if (!ValidateUserInputs())
                {
                    return;
                }

                using (SqlConnection connection = new SqlConnection(AppUtilities.DatabaseConstants.ConnectionString))
                {
                    connection.Open();
                    int userChanges = SaveUserChanges(connection);
                    int skillsChanges = SaveSkillsChanges(connection);

                    if (userChanges > 0 && skillsChanges > 0)
                    {
                        AppUtilities.ShowInfo("Saved changes successfully");
                        return;
                    }

                    if (skillsChanges <= 0)
                    {
                        AppUtilities.ShowError("Couldn't save skills and interests changes.");
                    }

                    if (userChanges <= 0)
                    {
                        AppUtilities.ShowError("Couldn't save user information changes.");
                    }
                }
            }
            catch (Exception ex)
            {
                AppUtilities.ShowError($"Error saving changes: {ex.Message}");
            }
        }

        private bool ValidateUserInputs()
        {
            string fullname = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string phoneNumber = txtPhoneNumber.Text.Trim();
            DateTime? birthDate = birthDatePicker.Value;
            string skills = textBoxSkills.Text.Trim();
            string interests = textBoxInterests.Text.Trim();

            // Validate full name
            if (string.IsNullOrWhiteSpace(fullname))
            {
                AppUtilities.ShowError("Please enter your full name.");
                return false;
            }

            // Validate email
            if (!AppUtilities.IsValidEmail(email))
            {
                AppUtilities.ShowError("Please enter a valid email address.");
                return false;
            }

            // Validate password
            if (!AppUtilities.IsValidPassword(password))
            {
                AppUtilities.ShowError($"Password must be between {AppUtilities.ValidationRules.MinPasswordLength} and {AppUtilities.ValidationRules.MaxPasswordLength} characters long, " +
                    "and contain at least one uppercase letter, one lowercase letter, one number, and one special character.");
                return false;
            }

            // Validate phone number
            if (!AppUtilities.IsValidPhoneNumber(phoneNumber))
            {
                AppUtilities.ShowError("Please enter a valid phone number.");
                return false;
            }

            // Validate birth date
            if (birthDate.HasValue && !AppUtilities.IsValidBirthDate(birthDate.Value))
            {
                AppUtilities.ShowError("Please enter a valid birth date. You must be at least 16 years old.");
                return false;
            }

            // Validate skills length
            if (!AppUtilities.IsValidSkills(skills))
            {
                AppUtilities.ShowError($"Skills text is too long. Maximum length is {AppUtilities.ValidationRules.MaxSkillsLength} characters.");
                return false;
            }

            // Validate interests length
            if (!AppUtilities.IsValidInterests(interests))
            {
                AppUtilities.ShowError($"Interests text is too long. Maximum length is {AppUtilities.ValidationRules.MaxInterestsLength} characters.");
                return false;
            }

            return true;
        }

        private int SaveSkillsChanges(SqlConnection connection)
        {
            string skills = textBoxSkills.Text;
            string interests = textBoxInterests.Text;

            string saveUserChangesQuery =
                "UPDATE [JobSeeker] " +
                "SET skills = @skills, interests = @interests " +
                "WHERE user_id = @userId;";
            SqlCommand saveUserChangesCmd = new SqlCommand(saveUserChangesQuery, connection);
            saveUserChangesCmd.Parameters.AddWithValue("@skills", skills);
            saveUserChangesCmd.Parameters.AddWithValue("@interests", interests);
            saveUserChangesCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

            return saveUserChangesCmd.ExecuteNonQuery();
        }

        private int SaveUserChanges(SqlConnection connection)
        {
            string fullname = txtFullName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string phoneNumber = txtPhoneNumber.Text;
            DateTime? birthDate = birthDatePicker.Value;

            string saveUserChangesQuery =
                "UPDATE [User] " +
                "SET name = @name, email = @email, password = @password, phone = @phoneNumber, birth_date = @birthDate " +
                "WHERE user_id = @userId;";
            SqlCommand saveUserChangesCmd = new SqlCommand(saveUserChangesQuery, connection);
            saveUserChangesCmd.Parameters.AddWithValue("@name", fullname);
            saveUserChangesCmd.Parameters.AddWithValue("@email", email);
            saveUserChangesCmd.Parameters.AddWithValue("@password", password);
            saveUserChangesCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            saveUserChangesCmd.Parameters.AddWithValue("@birthDate", birthDate);
            saveUserChangesCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

            return saveUserChangesCmd.ExecuteNonQuery();
        }

        private void JobSeekerProfileControl_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserId.HasValue)
            {
                try
                {
                    int id = Session.CurrentUserId.Value;
                    using (SqlConnection conn = new SqlConnection(AppUtilities.DatabaseConstants.ConnectionString))
                    using (SqlCommand cmd = new SqlCommand(@"SELECT 
                                                                U.name, 
                                                                U.email, 
                                                                U.phone, 
                                                                U.password, 
                                                                U.birth_date, 
                                                                U.signup_date, 
                                                                J.skills, 
                                                                J.interests 
                                                            FROM [User] U INNER JOIN [JobSeeker] J ON U.user_id = J.user_id 
                                                            WHERE U.user_id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                labelUserName.Text = reader["name"]?.ToString() ?? "";
                                txtFullName.Text = reader["name"]?.ToString() ?? "";
                                txtEmail.Text = reader["email"]?.ToString() ?? "";
                                txtPassword.Text = reader["password"]?.ToString() ?? "";
                                txtPhoneNumber.Text = reader["phone"]?.ToString() ?? "";
                                if (reader["birth_date"] != DBNull.Value)
                                    birthDatePicker.Value = Convert.ToDateTime(reader["birth_date"]);
                                else
                                    birthDatePicker.Value = DateTime.Now;
                                textBox4.Text = reader["signup_date"]?.ToString() ?? "";
                                textBoxSkills.Text = reader["skills"]?.ToString() ?? "";
                                textBoxInterests.Text = reader["interests"]?.ToString() ?? "";
                            }
                            else
                            {
                                ClearAllFields();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    AppUtilities.ShowError($"Error loading profile data: {ex.Message}");
                    ClearAllFields();
                }
            }
            else
            {
                ClearAllFields();
            }
        }

        private void ClearAllFields()
        {
            labelUserName.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            birthDatePicker.Value = DateTime.Now;
            textBox4.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
