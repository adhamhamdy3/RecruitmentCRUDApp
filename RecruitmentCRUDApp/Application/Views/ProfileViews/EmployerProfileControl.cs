using Microsoft.VisualBasic.ApplicationServices;
using RecruitmentApplication.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace RecruitmentApplication.Views.Profiles
{
    public partial class EmployerProfileControl : UserControl
    {
        public EmployerProfileControl()
        {
            InitializeComponent();
            LoadCompanyDataIntoComboBox();
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int userChanges = SaveUserChanges(connection);
                    int companyChanges = SaveCompanySelection(connection);

                    if (userChanges > 0 && companyChanges >= 0)
                    {
                        MessageBox.Show("Saved changes successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (companyChanges < 0)
                    {
                        MessageBox.Show("Couldn't save company selection changes.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (userChanges <= 0)
                    {
                        MessageBox.Show("Couldn't save user information changes.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private int SaveCompanySelection(SqlConnection connection)
        {
            // Get the selected company from combo box
            if (comboBoxCompany.SelectedItem == null)
            {
                return 0;
            }

            string selectedCompany = comboBoxCompany.SelectedItem.ToString();

            int companyId = 0;
            string getCompanyIdQuery = "SELECT company_id FROM [Company] WHERE name = @companyName";
            using (SqlCommand companyIdCmd = new SqlCommand(getCompanyIdQuery, connection))
            {
                companyIdCmd.Parameters.AddWithValue("@companyName", selectedCompany);
                var result = companyIdCmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    companyId = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Selected company not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }

            string saveCompanyQuery =
                "UPDATE [Employer] " +
                "SET company_id = @companyId " +
                "WHERE user_id = @userId;";

            SqlCommand saveCompanyCmd = new SqlCommand(saveCompanyQuery, connection);
            saveCompanyCmd.Parameters.AddWithValue("@companyId", companyId);
            saveCompanyCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

            return saveCompanyCmd.ExecuteNonQuery();
        }

        private void EmployerControl_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserId.HasValue)
            {
                int id = Session.CurrentUserId.Value;
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;"))
                using (SqlCommand cmd = new SqlCommand("SELECT name, email, phone, password, birth_date, signup_date FROM [User] WHERE user_id = @Id", conn))
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
                        }
                        else
                        {
                            ClearAllFields();
                        }
                    }
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

        private void LoadCompanyDataIntoComboBox()
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            int selectedIndex = -1;
            string userCompanyName = GetUserCompanyName();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name FROM [Company]";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        string companyName = reader["name"].ToString();
                        comboBoxCompany.Items.Add(companyName);

                        if (companyName == userCompanyName)
                        {
                            selectedIndex = i;
                        }

                        i++;
                    }
                }

                comboBoxCompany.DropDownStyle = ComboBoxStyle.DropDownList;

                if (selectedIndex != -1)
                {
                    comboBoxCompany.SelectedIndex = selectedIndex;
                }

            }
        }

        private string GetUserCompanyName()
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            string companyName = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT C.name FROM [Employer] E JOIN [Company] C ON E.company_id = C.company_id WHERE E.user_id = @userId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            companyName = reader["name"].ToString();
                        }
                    }
                }
            }

            return companyName;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateCompany_Click(object sender, EventArgs e)
        {
            Form createCompanyForm = new CreateCompanyForm();


            createCompanyForm.ShowDialog();
            LoadCompanyDataIntoComboBox();
        }
    }
}