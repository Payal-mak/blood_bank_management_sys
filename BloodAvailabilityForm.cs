using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace blood_bank_management_sys
{
    public partial class BloodAvailabilityForm : Form
    {
        string connectionString = @"Server=PAYAL\SQLEXPRESS;Database=BloodBankDB;Trusted_Connection=True;";

        public BloodAvailabilityForm()
        {
            InitializeComponent();
            btnSearch.Click += btnSearch_Click;
        }

        // Designer references this
        private void BloodAvailabilityForm_Load(object sender, EventArgs e)
        {
            LoadBloodInventory();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string group = cbBloodGroupSearch.SelectedItem?.ToString();
            LoadBloodInventory(group);
        }

        private void LoadBloodInventory(string group = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT BloodInventory.BloodGroup, BloodInventory.UnitsAvailable, BloodInventory.ExpiryDate, BloodBanks.BankName " +
                                   "FROM BloodInventory INNER JOIN BloodBanks ON BloodInventory.BankID = BloodBanks.BankID";
                    if (!string.IsNullOrEmpty(group))
                        query += " WHERE BloodInventory.BloodGroup = @bg";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    if (!string.IsNullOrEmpty(group))
                        adapter.SelectCommand.Parameters.AddWithValue("@bg", group);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBloodInventory.DataSource = dt;
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
