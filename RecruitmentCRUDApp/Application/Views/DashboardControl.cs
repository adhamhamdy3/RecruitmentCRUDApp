using Microsoft.Data.SqlClient;
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
    public partial class DashboardControl : UserControl
    {
        private string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
        
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            comboBoxQuestions.Items.Add("What was the most interesting job \"title\" that had maximum number of applicants?");
            comboBoxQuestions.Items.Add("What was the announced job \"title\" that hadn't any applicants last month?");
            comboBoxQuestions.Items.Add("Who was the employer with the maximum announcements last month?");
            comboBoxQuestions.Items.Add("Who were the employers didn't announce any job last month?");
            comboBoxQuestions.Items.Add("What were the available positions at each employer last month?");
            comboBoxQuestions.Items.Add("For each seeker, retrieve all his/her information and the number of jobs he applied for");
            comboBoxQuestions.SelectedIndex = 0;
            comboBoxQuestions.DropDownStyle = ComboBoxStyle.DropDownList;

            // Execute the first query when the form loads
            ExecuteSelectedQuery();
        }

        private void comboBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteSelectedQuery();
        }

        private void ExecuteSelectedQuery()
        {
            try
            {
                // Get the appropriate query based on the selected question
                string query = GetQueryForQuestion(comboBoxQuestions.SelectedIndex);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and format the result
                        string result = FormatQueryResult(command, comboBoxQuestions.SelectedIndex);

                        // Display the result in the label
                        tboxAnswer.Text = result;
                    }
                }
            }
            catch (Exception ex)
            {
                tboxAnswer.Text = "Error executing query: " + ex.Message;
            }
        }

        private string GetQueryForQuestion(int questionIndex)
        {
            switch (questionIndex)
            {
                case 0: // Most interesting job with max applicants
                    return @"
                        SELECT TOP 1 v.title, COUNT(a.app_id) AS application_count
                        FROM Vacancy v
                        JOIN JobApplication a ON v.vacancy_id = a.vacancy_id
                        GROUP BY v.title
                        ORDER BY application_count DESC";

                case 1: // Announced jobs with no applicants last month
                    return @"
                        SELECT v.title
                        FROM Vacancy v
                        WHERE v.post_date >= DATEADD(month, -1, GETDATE())
                        AND NOT EXISTS (
                            SELECT 1 FROM JobApplication a 
                            WHERE a.vacancy_id = v.vacancy_id
                        )";

                case 2: // Employer with max announcements last month
                    return @"
                        SELECT TOP 1 u.name AS employer_name, COUNT(v.vacancy_id) AS vacancy_count
                        FROM [User] u
                        JOIN Employer e ON u.user_id = e.user_id
                        JOIN Vacancy v ON e.user_id = v.employer_id
                        WHERE v.post_date >= DATEADD(month, -1, GETDATE())
                        GROUP BY u.name
                        ORDER BY vacancy_count DESC";

                case 3: // Employers with no job announcements last month
                    return @"
                        SELECT u.name AS employer_name
                        FROM [User] u
                        JOIN Employer e ON u.user_id = e.user_id
                        WHERE NOT EXISTS (
                            SELECT 1 FROM Vacancy v
                            WHERE v.employer_id = e.user_id
                            AND v.post_date >= DATEADD(month, -1, GETDATE())
                        )";

                case 4: // Available positions at each employer last month
                    return @"
                        SELECT u.name AS employer_name, v.title, COUNT(v.vacancy_id) AS position_count
                        FROM [User] u
                        JOIN Employer e ON u.user_id = e.user_id
                        JOIN Vacancy v ON e.user_id = v.employer_id
                        WHERE v.post_date >= DATEADD(month, -1, GETDATE())
                        AND v.status = 'Open'
                        GROUP BY u.name, v.title
                        ORDER BY u.name, position_count DESC";

                case 5: // Job seeker info and number of applications
                    return @"
                        SELECT u.name, u.email, u.phone, js.skills, js.interests,
                               COUNT(ja.app_id) AS applications_count
                        FROM [User] u
                        JOIN JobSeeker js ON u.user_id = js.user_id
                        LEFT JOIN JobApplication ja ON js.user_id = ja.jobseeker_id
                        GROUP BY u.name, u.email, u.phone, js.skills, js.interests
                        ORDER BY applications_count DESC";

                default:
                    return "";
            }
        }

        private string FormatQueryResult(SqlCommand command, int questionIndex)
        {
            StringBuilder result = new StringBuilder();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    return "No results found.";
                }

                switch (questionIndex)
                {
                    case 0: // Most interesting job with max applicants
                        if (reader.Read())
                        {
                            result.AppendLine($"The most interesting job title is: {reader["title"]}");
                            result.AppendLine($"Number of applications: {reader["application_count"]}");
                        }
                        break;

                    case 1: // Announced jobs with no applicants last month
                        result.AppendLine("Jobs with no applicants last month:");
                        while (reader.Read())
                        {
                            result.AppendLine($"- {reader["title"]}");
                        }
                        break;

                    case 2: // Employer with max announcements last month
                        if (reader.Read())
                        {
                            result.AppendLine($"Employer with most announcements: {reader["employer_name"]}");
                            result.AppendLine($"Number of announcements: {reader["vacancy_count"]}");
                        }
                        break;

                    case 3: // Employers with no job announcements last month
                        result.AppendLine("Employers with no job announcements last month:");
                        while (reader.Read())
                        {
                            result.AppendLine($"- {reader["employer_name"]}");
                        }
                        break;

                    case 4: // Available positions at each employer last month
                        result.AppendLine("Available positions by employer last month:");
                        string currentEmployer = "";
                        while (reader.Read())
                        {
                            string employer = reader["employer_name"].ToString();
                            if (employer != currentEmployer)
                            {
                                currentEmployer = employer;
                                result.AppendLine($"\n{currentEmployer}:");
                            }
                            result.AppendLine($"  - {reader["title"]}: {reader["position_count"]} positions");
                        }
                        break;

                    case 5: // Job seeker info and number of applications
                        result.AppendLine("Job seeker information and application counts:");
                        while (reader.Read())
                        {
                            result.AppendLine($"\nName: {reader["name"]}");
                            result.AppendLine($"Email: {reader["email"]}");
                            result.AppendLine($"Phone: {reader["phone"]}");
                            result.AppendLine($"Skills: {reader["skills"]}");
                            result.AppendLine($"Interests: {reader["interests"]}");
                            result.AppendLine($"Number of applications: {reader["applications_count"]}");
                        }
                        break;
                }
            }

            return result.ToString();
        }
    }
}
