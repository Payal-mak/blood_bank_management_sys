namespace blood_bank_management_sys
{
    partial class BloodAvailabilityForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBloodGroupSearch;
        private System.Windows.Forms.ComboBox cbBloodGroupSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBloodInventory;
        private System.Windows.Forms.Label lblStatus;
        


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodAvailabilityForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBloodGroupSearch = new System.Windows.Forms.Label();
            this.cbBloodGroupSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBloodInventory = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(320, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Blood Availability";
            // 
            // lblBloodGroupSearch
            // 
            this.lblBloodGroupSearch.Location = new System.Drawing.Point(150, 80);
            this.lblBloodGroupSearch.Name = "lblBloodGroupSearch";
            this.lblBloodGroupSearch.Size = new System.Drawing.Size(100, 23);
            this.lblBloodGroupSearch.TabIndex = 1;
            this.lblBloodGroupSearch.Text = "Blood Group";
            // 
            // cbBloodGroupSearch
            // 
            this.cbBloodGroupSearch.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbBloodGroupSearch.Location = new System.Drawing.Point(320, 75);
            this.cbBloodGroupSearch.Name = "cbBloodGroupSearch";
            this.cbBloodGroupSearch.Size = new System.Drawing.Size(250, 24);
            this.cbBloodGroupSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            // 
            // dgvBloodInventory
            // 
            this.dgvBloodInventory.ColumnHeadersHeight = 29;
            this.dgvBloodInventory.Location = new System.Drawing.Point(150, 170);
            this.dgvBloodInventory.Name = "dgvBloodInventory";
            this.dgvBloodInventory.RowHeadersWidth = 51;
            this.dgvBloodInventory.Size = new System.Drawing.Size(550, 150);
            this.dgvBloodInventory.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(150, 400);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status messages / alerts";
            // 
            // BloodAvailabilityForm
            // 
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBloodGroupSearch);
            this.Controls.Add(this.cbBloodGroupSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvBloodInventory);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BloodAvailabilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Availability";
            this.Load += new System.EventHandler(this.BloodAvailabilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
