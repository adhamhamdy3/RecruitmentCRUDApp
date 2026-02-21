using RecruitmentApplication.Views.Auth;
using RecruitmentApplication.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(AppUtilities.DatabaseConstants.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [User] WHERE email = @email AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    string userType = reader["user_type"].ToString();
                                    
                                    // Validate user type before login
                                    if (!AppUtilities.IsValidUserType(userType))
                                    {
                                        AppUtilities.ShowError("Invalid user type in database.");
                                        return;
                                    }

                                    Session.Login(reader.GetInt32(0), userType);
                                } 
                                else
                                {
                                    AppUtilities.ShowError("Invalid email or password.");
                                    return;
                                }

                                AppUtilities.ShowInfo("Login successful!");
                                MainForm mainform = new MainForm();
                                mainform.Show();
                                this.Hide();
                            }
                            else
                            {
                                AppUtilities.ShowError("Invalid email or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppUtilities.ShowError($"An error occurred during login: {ex.Message}");
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}