using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace blood_bank_management_sys
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Server=PAYAL\SQLEXPRESS;Database=BloodBankDB;Trusted_Connection=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbRole.Items.Clear();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Donor");
            cbRole.Items.Add("Patient/Recipient");
            cbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                lblStatus.Text = "Please fill all fields and select a role.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND PasswordHash = @Password AND Role = @Role";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            lblStatus.Text = "Login successful!";
                            DashboardForm dashboardForm = new DashboardForm();
                            dashboardForm.Show();
                            this.Hide(); 
                        }
                        else
                        {
                            lblStatus.Text = "Invalid credentials or role!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

    }
}
