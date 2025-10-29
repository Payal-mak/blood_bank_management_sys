using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace blood_bank_management_sys
{
    public partial class HospitalSearchForm : Form
    {
        string connectionString = @"Server=PAYAL\SQLEXPRESS;Database=BloodBankDB;Trusted_Connection=True;";

        public HospitalSearchForm()
        {
            InitializeComponent();
            btnSearch.Click += btnSearch_Click;
            btnAddHospital.Click += btnAddHospital_Click; // New 
        }

        private void btnAddHospital_Click(object sender, EventArgs e)
        {
            string name = txtAddHospital.Text.Trim();
            string address = txtAddAddress.Text.Trim();
            string contact = txtAddContact.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contact))
            {
                lblStatus.Text = "Name and contact required!";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Hospitals (HospitalName, Address, ContactNumber) VALUES (@n, @a, @c)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@a", address);
                        cmd.Parameters.AddWithValue("@c", contact);
                        cmd.ExecuteNonQuery();
                    }
                }
                lblStatus.Text = "Hospital added!";
                txtAddHospital.Text = "";
                txtAddAddress.Text = "";
                txtAddContact.Text = "";
                LoadHospitals(); // Refresh the table
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error adding hospital: " + ex.Message;
            }
        }

        // Designer references this
        private void HospitalSearchForm_Load(object sender, EventArgs e)
        {
            LoadHospitals();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadHospitals(txtHospitalName.Text.Trim());
        }

        private void LoadHospitals(string nameFilter = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Hospitals";
                    if (!string.IsNullOrEmpty(nameFilter))
                        query += " WHERE HospitalName LIKE @name";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    if (!string.IsNullOrEmpty(nameFilter))
                        adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + nameFilter + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvHospitals.DataSource = dt;
                }
                lblStatus.Text = "Search complete.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }
    }
}
