using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace blood_bank_management_sys
{
    public partial class ReportGenerationForm : Form
    {
        string connectionString = @"Server=PAYAL\SQLEXPRESS;Database=BloodBankDB;Trusted_Connection=True;";

        public ReportGenerationForm()
        {
            InitializeComponent();
            btnGenerateReport.Click += BtnGenerateReport_Click;
        }

        private void ReportGenerationForm_Load(object sender, EventArgs e)
        {
            cbReportType.SelectedIndex = 0; // default selection
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cbReportType.SelectedItem == null)
            {
                lblStatus.Text = "Please select a report type.";
                return;
            }

            string selectedReport = cbReportType.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "";

                    switch (selectedReport)
                    {
                        case "Stock Report":
                            query = @"SELECT 
                                        b.BankName, i.BloodGroup, SUM(i.UnitsAvailable) AS TotalUnits, MIN(i.ExpiryDate) AS NearestExpiry 
                                      FROM BloodInventory i 
                                      INNER JOIN BloodBanks b ON i.BankID = b.BankID 
                                      GROUP BY b.BankName, i.BloodGroup";
                            break;

                        case "Donor Report":
                            query = "SELECT Name, BloodGroup, Contact, Address, Email FROM Donors";
                            break;

                        case "Recipient Report":
                            query = @"SELECT r.Name, r.BloodGroup, r.UnitsNeeded, h.HospitalName, r.Contact, r.Address, r.Email, r.RequestDate 
                                      FROM Recipients r 
                                      LEFT JOIN Hospitals h ON r.HospitalID = h.HospitalID";
                            break;

                        default:
                            lblStatus.Text = "Invalid report selection.";
                            return;
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReport.DataSource = dt;
                }

                lblStatus.Text = $"{selectedReport} generated.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }
    }
}
