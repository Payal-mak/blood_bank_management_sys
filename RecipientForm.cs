using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace blood_bank_management_sys
{
    public partial class RecipientForm : Form
    {
        string connectionString = @"Server=PAYAL\SQLEXPRESS;Database=BloodBankDB;Trusted_Connection=True;";

        public RecipientForm()
        {
            InitializeComponent();
            btnAddRecipient.Click += BtnAddRecipient_Click;
        }

        private void RecipientForm_Load(object sender, EventArgs e)
        {
            LoadHospitals();
            LoadRecipients();
        }

        private void LoadHospitals()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT HospitalID, HospitalName FROM Hospitals", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbHospital.DataSource = dt;
                cbHospital.DisplayMember = "HospitalName";
                cbHospital.ValueMember = "HospitalID";
            }
        }

        private void BtnAddRecipient_Click(object sender, EventArgs e)
        {
            string name = txtRecipientName.Text.Trim();
            string bloodGroup = cbBloodGroup.SelectedItem?.ToString();
            string unitsNeeded = txtUnitsNeeded.Text.Trim();
            int hospitalID = cbHospital.SelectedValue != null ? Convert.ToInt32(cbHospital.SelectedValue) : 0;
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime requestDate = dtpRequestDate.Value.Date;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(bloodGroup) ||
                string.IsNullOrEmpty(unitsNeeded) || hospitalID == 0)
            {
                lblStatus.Text = "Please fill all required fields!";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insert = @"INSERT INTO Recipients 
                        (Name, BloodGroup, UnitsNeeded, HospitalID, Contact, Address, Email, RequestDate)
                        VALUES (@n, @bg, @u, @h, @c, @a, @e, @d)";
                    using (SqlCommand cmd = new SqlCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@bg", bloodGroup);
                        cmd.Parameters.AddWithValue("@u", Convert.ToInt32(unitsNeeded));
                        cmd.Parameters.AddWithValue("@h", hospitalID);
                        cmd.Parameters.AddWithValue("@c", contact);
                        cmd.Parameters.AddWithValue("@a", address);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@d", requestDate);
                        cmd.ExecuteNonQuery();
                    }
                }

                lblStatus.Text = "Recipient added!";
                LoadRecipients();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void LoadRecipients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT r.RecipientID, r.Name, r.BloodGroup, r.UnitsNeeded, h.HospitalName, r.Contact, r.Address, r.Email, r.RequestDate
                        FROM Recipients r LEFT JOIN Hospitals h ON r.HospitalID = h.HospitalID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvRecipients.DataSource = dt;
            }
        }
    }
}
