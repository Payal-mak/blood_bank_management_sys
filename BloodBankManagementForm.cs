using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace blood_bank_management_sys
{
    public partial class BloodBankManagementForm : Form
    {
        string connectionString = @"Server=PAYAL\SQLEXPRESS;Database=BloodBankDB;Trusted_Connection=True;";

        public BloodBankManagementForm()
        {
            InitializeComponent();
            btnAddBank.Click += BtnAddBank_Click;
        }

        private void BloodBankManagementForm_Load(object sender, EventArgs e)
        {
            LoadBloodBanks();
        }

        private void BtnAddBank_Click(object sender, EventArgs e)
        {
            string name = txtBankName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string contact = txtContact.Text.Trim();

            // Check at least one blood group unit is entered and >0
            bool hasInventory = IsAnyInventoryFilled();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contact))
            {
                lblStatus.Text = "Bank Name and Contact are required.";
                return;
            }
            if (!hasInventory)
            {
                lblStatus.Text = "Please enter units for at least one blood group!";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertBank = "INSERT INTO BloodBanks (BankName, Address, ContactNumber) OUTPUT INSERTED.BankID VALUES (@Name, @Address, @Contact)";
                    int bankId;
                    using (SqlCommand cmd = new SqlCommand(insertBank, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Contact", contact);
                        bankId = (int)cmd.ExecuteScalar();
                    }

                    AddBloodInventory(bankId, "A+", txtUnitsAPlus.Text, dtpExpiryAPlus.Value, conn);
                    AddBloodInventory(bankId, "A-", txtUnitsAMinus.Text, dtpExpiryAMinus.Value, conn);
                    AddBloodInventory(bankId, "B+", txtUnitsBPlus.Text, dtpExpiryBPlus.Value, conn);
                    AddBloodInventory(bankId, "B-", txtUnitsBMinus.Text, dtpExpiryBMinus.Value, conn);
                    AddBloodInventory(bankId, "AB+", txtUnitsABPlus.Text, dtpExpiryABPlus.Value, conn);
                    AddBloodInventory(bankId, "AB-", txtUnitsABMinus.Text, dtpExpiryABMinus.Value, conn);
                    AddBloodInventory(bankId, "O+", txtUnitsOPlus.Text, dtpExpiryOPlus.Value, conn);
                    AddBloodInventory(bankId, "O-", txtUnitsOMinus.Text, dtpExpiryOMinus.Value, conn);
                }

                lblStatus.Text = "Blood bank and inventory added!";
                LoadBloodBanks();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private bool IsAnyInventoryFilled()
        {
            return IsUnitFilled(txtUnitsAPlus.Text) || IsUnitFilled(txtUnitsAMinus.Text) ||
                   IsUnitFilled(txtUnitsBPlus.Text) || IsUnitFilled(txtUnitsBMinus.Text) ||
                   IsUnitFilled(txtUnitsABPlus.Text) || IsUnitFilled(txtUnitsABMinus.Text) ||
                   IsUnitFilled(txtUnitsOPlus.Text) || IsUnitFilled(txtUnitsOMinus.Text);
        }

        private bool IsUnitFilled(string unitsStr)
        {
            return int.TryParse(unitsStr, out int u) && u > 0;
        }

        private void AddBloodInventory(int bankId, string bloodGroup, string unitsStr, DateTime expiryDate, SqlConnection conn)
        {
            if (int.TryParse(unitsStr, out int units) && units > 0)
            {
                string insertInventory = "INSERT INTO BloodInventory (BloodGroup, UnitsAvailable, ExpiryDate, BankID) VALUES (@BloodGroup, @Units, @Expiry, @BankID)";
                using (SqlCommand cmd = new SqlCommand(insertInventory, conn))
                {
                    cmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                    cmd.Parameters.AddWithValue("@Units", units);
                    cmd.Parameters.AddWithValue("@Expiry", expiryDate.Date);
                    cmd.Parameters.AddWithValue("@BankID", bankId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadBloodBanks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                b.BankID, b.BankName, b.Address, b.ContactNumber, 
                                i.BloodGroup, i.UnitsAvailable, i.ExpiryDate
                             FROM 
                                BloodBanks b
                             LEFT JOIN 
                                BloodInventory i ON b.BankID = i.BankID
                             ORDER BY 
                                b.BankName, i.BloodGroup";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBanks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error loading blood banks: " + ex.Message;
            }
        }

    }
}
