using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace blood_bank_management_sys
{
    public partial class DonorRegistrationForm : Form
    {
        string connectionString = @"Server=PAYAL\SQLEXPRESS;Database=BloodBankDB;Trusted_Connection=True;";

        public DonorRegistrationForm()
        {
            InitializeComponent();
            btnRegister.Click += btnRegister_Click; 
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string bloodGroup = cbBloodGroup.SelectedItem?.ToString();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(bloodGroup) || string.IsNullOrEmpty(contact) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                lblStatus.Text = "Please fill all fields.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string userCheck = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(userCheck, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            lblStatus.Text = "Username already exists!";
                            return;
                        }
                    }

                    string insertUser = "INSERT INTO Users (Username, PasswordHash, Role, FullName) VALUES (@Username, @PasswordHash, @Role, @FullName)";
                    using (SqlCommand userCmd = new SqlCommand(insertUser, conn))
                    {
                        userCmd.Parameters.AddWithValue("@Username", username);
                        userCmd.Parameters.AddWithValue("@PasswordHash", "donorpass"); 
                        userCmd.Parameters.AddWithValue("@Role", "Donor");
                        userCmd.Parameters.AddWithValue("@FullName", fullname);
                        userCmd.ExecuteNonQuery();
                    }

                    
                    string insertDonor = @"INSERT INTO Donors (Name, BloodGroup, Contact, Address, Email, BankID) 
                                           VALUES (@Name, @BloodGroup, @Contact, @Address, @Email, NULL)";
                    using (SqlCommand donorCmd = new SqlCommand(insertDonor, conn))
                    {
                        donorCmd.Parameters.AddWithValue("@Name", fullname);
                        donorCmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                        donorCmd.Parameters.AddWithValue("@Contact", contact);
                        donorCmd.Parameters.AddWithValue("@Address", address);
                        donorCmd.Parameters.AddWithValue("@Email", email);
                        donorCmd.ExecuteNonQuery();
                    }

                    lblStatus.Text = "Registration successful!";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void cbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //haha
        }

        private void DonorRegistrationForm_Load(object sender, EventArgs e)
        {
            // haha
        }
    }
}
