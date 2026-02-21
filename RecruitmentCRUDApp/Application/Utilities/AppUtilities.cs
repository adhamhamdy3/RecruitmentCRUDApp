using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RecruitmentApplication.Utilities
{
    public static class AppUtilities
    {
        #region Constants and Definitions
        public static class UserRoles
        {
            public const string Admin = "Admin";
            public const string Employer = "Employer";
            public const string JobSeeker = "JobSeeker";
        }

        public static class ApplicationStatus
        {
            public const string Pending = "Pending";
            public const string UnderReview = "Under Review";
            public const string Interviewed = "Interviewed";
            public const string Accepted = "Accepted";
            public const string Rejected = "Rejected";
        }

        public static class ValidationRules
        {
            public const int MinPasswordLength = 8;
            public const int MaxPasswordLength = 255;
            public const int MinUsernameLength = 3;
            public const int MaxUsernameLength = 100;
            public const int MinCompanyNameLength = 2;
            public const int MaxCompanyNameLength = 100;
            public const int MinJobTitleLength = 3;
            public const int MaxJobTitleLength = 100;
            public const int MaxJobDescriptionLength = 4000;
            public const int MaxSkillsLength = 4000;
            public const int MaxInterestsLength = 4000;
            public const int MaxCompanyDescriptionLength = 4000;
        }
        #endregion

        #region Database Constants
        public static class DatabaseConstants
        {
            // Connection String
            public const string ConnectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";

            // User Types
            public static class UserTypes
            {
                public const string JobSeeker = "JobSeeker";
                public const string Employer = "Employer";
            }

            // Vacancy Status
            public static class VacancyStatus
            {
                public const string Open = "Open";
                public const string Closed = "Closed";
                public const string Hidden = "Hidden";
            }

            // Experience Levels
            public static class ExperienceLevels
            {
                public const string Student = "Student";
                public const string FreshGraduate = "Fresh Graduate";
                public const string Junior = "Junior";
                public const string MidLevel = "Mid-Level";
                public const string Senior = "Senior";
            }

            // Work Modes
            public static class WorkModes
            {
                public const string OnSite = "On-Site";
                public const string Remote = "Remote";
                public const string Hybrid = "Hybrid";
            }

            // Job Types
            public static class JobTypes
            {
                public const string FullTime = "Full-Time";
                public const string PartTime = "Part-Time";
                public const string Internship = "Internship";
            }

            // Application Status
            public static class ApplicationStatus
            {
                public const string Pending = "Pending";
                public const string UnderReview = "Under Review";
                public const string Interviewed = "Interviewed";
                public const string Accepted = "Accepted";
                public const string Rejected = "Rejected";
            }

            // Field Lengths
            public static class FieldLengths
            {
                public const int Name = 100;
                public const int Email = 100;
                public const int Phone = 20;
                public const int UserType = 20;
                public const int VacancyTitle = 100;
                public const int VacancyStatus = 20;
                public const int ExperienceLevel = 20;
                public const int WorkMode = 20;
                public const int JobType = 20;
                public const int ApplicationStatus = 20;
                public const int PreferredLocation = 100;
            }
        }
        #endregion

        #region Validation Methods
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Regular expression for email validation
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            // Check length
            if (password.Length < ValidationRules.MinPasswordLength || 
                password.Length > ValidationRules.MaxPasswordLength)
                return false;

            // Check for at least one uppercase letter
            //if (!Regex.IsMatch(password, @"[A-Z]"))
            //    return false;

            // Check for at least one lowercase letter
            if (!Regex.IsMatch(password, @"[a-z]"))
                return false;

            // Check for at least one number
            if (!Regex.IsMatch(password, @"[0-9]"))
                return false;

            // Check for at least one special character
            //if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?""':{}|<>]"))
            //    return false;

            return true;
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Remove any non-digit characters
            string digitsOnly = Regex.Replace(phoneNumber, @"[^\d]", "");
            
            // Check if the resulting string is a valid length (adjust as needed)
            return digitsOnly.Length >= 10 && digitsOnly.Length <= 15;
        }

        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            // Check length
            if (username.Length < ValidationRules.MinUsernameLength || 
                username.Length > ValidationRules.MaxUsernameLength)
                return false;

            // Check for valid characters (letters, numbers, and underscores only)
            return Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$");
        }

        public static bool IsValidCompanyName(string companyName)
        {
            if (string.IsNullOrWhiteSpace(companyName))
                return false;

            return companyName.Length >= ValidationRules.MinCompanyNameLength && 
                   companyName.Length <= ValidationRules.MaxCompanyNameLength;
        }

        public static bool IsValidJobTitle(string jobTitle)
        {
            if (string.IsNullOrWhiteSpace(jobTitle))
                return false;

            return jobTitle.Length >= ValidationRules.MinJobTitleLength && 
                   jobTitle.Length <= ValidationRules.MaxJobTitleLength;
        }

        public static bool IsValidJobDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return false;

            return description.Length <= ValidationRules.MaxJobDescriptionLength;
        }
        #endregion

        #region Message Box Helpers
        public static void ShowError(string message, string title = "Error")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string message, string title = "Information")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarning(string message, string title = "Warning")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool ShowConfirmation(string message, string title = "Confirmation")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static DialogResult ShowCustomMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(message, title, buttons, icon);
        }
        #endregion

        #region String Formatting
        public static string FormatPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return string.Empty;

            // Remove any non-digit characters
            string digitsOnly = Regex.Replace(phoneNumber, @"[^\d]", "");

            // Format as (XXX) XXX-XXXX
            if (digitsOnly.Length == 10)
            {
                return $"({digitsOnly.Substring(0, 3)}) {digitsOnly.Substring(3, 3)}-{digitsOnly.Substring(6, 4)}";
            }

            return phoneNumber; // Return original if not 10 digits
        }

        public static string TruncateText(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            return text.Length <= maxLength ? text : text.Substring(0, maxLength) + "...";
        }
        #endregion

        #region Date/Time Helpers
        public static string FormatDate(DateTime date)
        {
            return date.ToString("MM/dd/yyyy");
        }

        public static string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("MM/dd/yyyy HH:mm:ss");
        }

        public static bool IsValidDate(DateTime date)
        {
            return date != DateTime.MinValue && date != DateTime.MaxValue;
        }
        #endregion

        #region Database Validation Methods
        public static bool IsValidUserType(string userType)
        {
            return !string.IsNullOrWhiteSpace(userType) &&
                   (userType == DatabaseConstants.UserTypes.JobSeeker ||
                    userType == DatabaseConstants.UserTypes.Employer);
        }

        public static bool IsValidVacancyStatus(string status)
        {
            return !string.IsNullOrWhiteSpace(status) &&
                   (status == DatabaseConstants.VacancyStatus.Open ||
                    status == DatabaseConstants.VacancyStatus.Closed ||
                    status == DatabaseConstants.VacancyStatus.Hidden);
        }

        public static bool IsValidExperienceLevel(string level)
        {
            if (string.IsNullOrWhiteSpace(level))
                return true; // Optional field as per database schema

            return level == DatabaseConstants.ExperienceLevels.Student ||
                   level == DatabaseConstants.ExperienceLevels.FreshGraduate ||
                   level == DatabaseConstants.ExperienceLevels.Junior ||
                   level == DatabaseConstants.ExperienceLevels.MidLevel ||
                   level == DatabaseConstants.ExperienceLevels.Senior;
        }

        public static bool IsValidWorkMode(string mode)
        {
            if (string.IsNullOrWhiteSpace(mode))
                return true; // Optional field as per database schema

            return mode == DatabaseConstants.WorkModes.OnSite ||
                   mode == DatabaseConstants.WorkModes.Remote ||
                   mode == DatabaseConstants.WorkModes.Hybrid;
        }

        public static bool IsValidJobType(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
                return true; // Optional field as per database schema

            return type == DatabaseConstants.JobTypes.FullTime ||
                   type == DatabaseConstants.JobTypes.PartTime ||
                   type == DatabaseConstants.JobTypes.Internship;
        }

        public static bool IsValidApplicationStatus(string status)
        {
            return !string.IsNullOrWhiteSpace(status) &&
                   (status == DatabaseConstants.ApplicationStatus.Pending ||
                    status == DatabaseConstants.ApplicationStatus.UnderReview ||
                    status == DatabaseConstants.ApplicationStatus.Interviewed ||
                    status == DatabaseConstants.ApplicationStatus.Accepted ||
                    status == DatabaseConstants.ApplicationStatus.Rejected);
        }

        public static bool IsValidDeadline(DateTime deadline)
        {
            return deadline >= DateTime.Now;
        }

        public static bool IsValidBirthDate(DateTime birthDate)
        {
            if (birthDate == DateTime.MinValue || birthDate == DateTime.MaxValue)
                return false;

            var age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age)) age--;

            return age >= 0 && age <= 1000; // Assuming minimum age is 0 and maximum is 200
        }

        public static bool IsValidPreferredLocation(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
                return true; // Optional field as per database schema

            return location.Length <= DatabaseConstants.FieldLengths.PreferredLocation;
        }

        public static bool IsValidSkills(string skills)
        {
            if (string.IsNullOrWhiteSpace(skills))
                return true; // Optional field as per database schema

            return skills.Length <= ValidationRules.MaxSkillsLength;
        }

        public static bool IsValidInterests(string interests)
        {
            if (string.IsNullOrWhiteSpace(interests))
                return true; // Optional field as per database schema

            return interests.Length <= ValidationRules.MaxInterestsLength;
        }

        public static bool IsValidCompanyDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return true; // Optional field as per database schema

            return description.Length <= ValidationRules.MaxCompanyDescriptionLength;
        }
        #endregion
    }
} 