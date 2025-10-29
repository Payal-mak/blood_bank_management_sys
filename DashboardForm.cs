using System;
using System.Windows.Forms;

namespace blood_bank_management_sys
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            donorRegistrationToolStripMenuItem.Click += donorRegistrationToolStripMenuItem_Click;
            recipientRegistrationToolStripMenuItem.Click += recipientRegistrationToolStripMenuItem_Click; // Added for Recipient Registration
            bloodBankManagementToolStripMenuItem.Click += bloodBankManagementToolStripMenuItem_Click;
            hospitalSearchToolStripMenuItem.Click += hospitalSearchToolStripMenuItem_Click;
            bloodAvailabilityToolStripMenuItem.Click += bloodAvailabilityToolStripMenuItem_Click;
            reportGenerationToolStripMenuItem.Click += reportGenerationToolStripMenuItem_Click;
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome User";
        }

        private void donorRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorRegistrationForm donorForm = new DonorRegistrationForm();
            donorForm.ShowDialog();
        }

        private void recipientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecipientForm recipientForm = new RecipientForm();
            recipientForm.ShowDialog();
        }

        private void bloodBankManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloodBankManagementForm bankForm = new BloodBankManagementForm();
            bankForm.ShowDialog();
        }

        private void hospitalSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HospitalSearchForm hospitalForm = new HospitalSearchForm();
            hospitalForm.ShowDialog();
        }

        private void bloodAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloodAvailabilityForm availabilityForm = new BloodAvailabilityForm();
            availabilityForm.ShowDialog();
        }

        private void reportGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportGenerationForm reportForm = new ReportGenerationForm();
            reportForm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out!");
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // haha
        }
    }
}
