using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace blood_bank_management_sys
{
    public partial class SignupForm : Form
    {
        string connectionString = @"Server=PAYAL\SQLEXPRESS;Database=BloodBankDB;Trusted_Connection=True;";

        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cbRole.SelectedItem.ToString();
            string fullname = txtFullName.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(fullname))
            {
                lblStatus.Text = "Please fill in all fields.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if username exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int userExists = (int)checkCmd.ExecuteScalar();
                        if (userExists > 0)
                        {
                            lblStatus.Text = "Username already exists!";
                            return;
                        }
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO Users (Username, PasswordHash, Role, FullName) " +
                                         "VALUES (@Username, @Password, @Role, @FullName)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); 
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@FullName", fullname);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            lblStatus.Text = "Registration successful! Please login.";
                        }
                        else
                        {
                            lblStatus.Text = "Registration failed!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
