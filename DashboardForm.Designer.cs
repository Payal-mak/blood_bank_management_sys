namespace blood_bank_management_sys
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodBankManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipientRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipientRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodBankManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(300, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(201, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome User";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorRegistrationToolStripMenuItem,
            this.recipientRegistrationToolStripMenuItem,
            this.bloodBankManagementToolStripMenuItem,
            this.hospitalSearchToolStripMenuItem,
            this.bloodAvailabilityToolStripMenuItem,
            this.reportGenerationToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // donorRegistrationToolStripMenuItem
            // 
            this.donorRegistrationToolStripMenuItem.Name = "donorRegistrationToolStripMenuItem";
            this.donorRegistrationToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.donorRegistrationToolStripMenuItem.Text = "Donor Registration";
            // 
            // recipientRegistrationToolStripMenuItem
            // 
            this.recipientRegistrationToolStripMenuItem.Name = "recipientRegistrationToolStripMenuItem";
            this.recipientRegistrationToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.recipientRegistrationToolStripMenuItem.Text = "Recipient Registration";
            this.recipientRegistrationToolStripMenuItem.Click += new System.EventHandler(this.recipientRegistrationToolStripMenuItem_Click);
            // 
            // bloodBankManagementToolStripMenuItem
            // 
            this.bloodBankManagementToolStripMenuItem.Name = "bloodBankManagementToolStripMenuItem";
            this.bloodBankManagementToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bloodBankManagementToolStripMenuItem.Text = "Blood Bank Management";
            // 
            // hospitalSearchToolStripMenuItem
            // 
            this.hospitalSearchToolStripMenuItem.Name = "hospitalSearchToolStripMenuItem";
            this.hospitalSearchToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.hospitalSearchToolStripMenuItem.Text = "Hospital Search";
            // 
            // bloodAvailabilityToolStripMenuItem
            // 
            this.bloodAvailabilityToolStripMenuItem.Name = "bloodAvailabilityToolStripMenuItem";
            this.bloodAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.bloodAvailabilityToolStripMenuItem.Text = "Blood Availability";
            // 
            // reportGenerationToolStripMenuItem
            // 
            this.reportGenerationToolStripMenuItem.Name = "reportGenerationToolStripMenuItem";
            this.reportGenerationToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.reportGenerationToolStripMenuItem.Text = "Report Generation";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 410);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(147, 16);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status message / alerts";
            // 
            // DashboardForm
            // 
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
