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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecruitmentApplication.Views.Profiles
{
    public partial class CompanyProfileControl : UserControl
    {
        private int companyId;
        public CompanyProfileControl(int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int userChanges = SaveUserChanges(connection);
                if (userChanges > 0)
                {
                    MessageBox.Show("Saved changes successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (userChanges <= 0)
                {
                    MessageBox.Show("Couldn't user information changes.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int SaveUserChanges(SqlConnection connection)
        {
            string fullname = txtName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string description = textBoxDescription.Text;

            string saveUserChangesQuery =
                "UPDATE [Company] " +
                "SET name = @name, email = @email,phone = @phoneNumber, description = @desc " +
                "WHERE company_id = @companyId;";
            SqlCommand saveUserChangesCmd = new SqlCommand(saveUserChangesQuery, connection);
            saveUserChangesCmd.Parameters.AddWithValue("@name", fullname);
            saveUserChangesCmd.Parameters.AddWithValue("@email", email);
            saveUserChangesCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            saveUserChangesCmd.Parameters.AddWithValue("@desc", description);
            saveUserChangesCmd.Parameters.AddWithValue("@companyId", companyId);

            return saveUserChangesCmd.ExecuteNonQuery();
        }

        private void CompanyControl_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserId.HasValue)
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;"))
                using (SqlCommand cmd = new SqlCommand("SELECT name, email, phone, description FROM [Company] WHERE company_id = @companyId", conn))
                {
                    cmd.Parameters.AddWithValue("@companyId", companyId);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelUserName.Text = reader["name"]?.ToString() ?? "";
                            txtName.Text = reader["name"]?.ToString() ?? "";
                            txtEmail.Text = reader["email"]?.ToString() ?? "";
                            txtPhoneNumber.Text = reader["phone"]?.ToString() ?? "";
                            textBoxDescription.Text = reader["description"]?.ToString() ?? "";
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
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            textBoxDescription.Text = "";
        }
        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
