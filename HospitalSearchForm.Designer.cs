namespace blood_bank_management_sys
{
    partial class HospitalSearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.TextBox txtHospitalName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvHospitals;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAddHospital;
        private System.Windows.Forms.Label lblAddAddress;
        private System.Windows.Forms.Label lblAddContact;
        private System.Windows.Forms.TextBox txtAddHospital;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.TextBox txtAddContact;
        private System.Windows.Forms.Button btnAddHospital; 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.txtHospitalName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvHospitals = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAddHospital = new System.Windows.Forms.Label();
            this.lblAddAddress = new System.Windows.Forms.Label();
            this.lblAddContact = new System.Windows.Forms.Label();
            this.txtAddHospital = new System.Windows.Forms.TextBox();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.txtAddContact = new System.Windows.Forms.TextBox();
            this.btnAddHospital = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitals)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(320, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hospital Search";
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.Location = new System.Drawing.Point(150, 80);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(100, 23);
            this.lblHospitalName.TabIndex = 1;
            this.lblHospitalName.Text = "Hospital Name";
            // 
            // txtHospitalName
            // 
            this.txtHospitalName.Location = new System.Drawing.Point(320, 75);
            this.txtHospitalName.Name = "txtHospitalName";
            this.txtHospitalName.Size = new System.Drawing.Size(250, 22);
            this.txtHospitalName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            // 
            // dgvHospitals
            // 
            this.dgvHospitals.ColumnHeadersHeight = 29;
            this.dgvHospitals.Location = new System.Drawing.Point(150, 170);
            this.dgvHospitals.Name = "dgvHospitals";
            this.dgvHospitals.RowHeadersWidth = 51;
            this.dgvHospitals.Size = new System.Drawing.Size(550, 150);
            this.dgvHospitals.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(210, 421);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status messages / alerts";
            // 
            // lblAddHospital
            // 
            this.lblAddHospital.Location = new System.Drawing.Point(97, 338);
            this.lblAddHospital.Name = "lblAddHospital";
            this.lblAddHospital.Size = new System.Drawing.Size(100, 23);
            this.lblAddHospital.TabIndex = 6;
            this.lblAddHospital.Text = "New Hospital";
            // 
            // lblAddAddress
            // 
            this.lblAddAddress.Location = new System.Drawing.Point(367, 338);
            this.lblAddAddress.Name = "lblAddAddress";
            this.lblAddAddress.Size = new System.Drawing.Size(60, 23);
            this.lblAddAddress.TabIndex = 8;
            this.lblAddAddress.Text = "Address";
            // 
            // lblAddContact
            // 
            this.lblAddContact.Location = new System.Drawing.Point(567, 338);
            this.lblAddContact.Name = "lblAddContact";
            this.lblAddContact.Size = new System.Drawing.Size(60, 23);
            this.lblAddContact.TabIndex = 10;
            this.lblAddContact.Text = "Contact";
            // 
            // txtAddHospital
            // 
            this.txtAddHospital.Location = new System.Drawing.Point(207, 338);
            this.txtAddHospital.Name = "txtAddHospital";
            this.txtAddHospital.Size = new System.Drawing.Size(150, 22);
            this.txtAddHospital.TabIndex = 7;
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Location = new System.Drawing.Point(437, 338);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(120, 22);
            this.txtAddAddress.TabIndex = 9;
            // 
            // txtAddContact
            // 
            this.txtAddContact.Location = new System.Drawing.Point(637, 338);
            this.txtAddContact.Name = "txtAddContact";
            this.txtAddContact.Size = new System.Drawing.Size(100, 22);
            this.txtAddContact.TabIndex = 11;
            // 
            // btnAddHospital
            // 
            this.btnAddHospital.Location = new System.Drawing.Point(343, 379);
            this.btnAddHospital.Name = "btnAddHospital";
            this.btnAddHospital.Size = new System.Drawing.Size(120, 30);
            this.btnAddHospital.TabIndex = 12;
            this.btnAddHospital.Text = "Add Hospital";
            // 
            // HospitalSearchForm
            // 
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHospitalName);
            this.Controls.Add(this.txtHospitalName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvHospitals);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAddHospital);
            this.Controls.Add(this.txtAddHospital);
            this.Controls.Add(this.lblAddAddress);
            this.Controls.Add(this.txtAddAddress);
            this.Controls.Add(this.lblAddContact);
            this.Controls.Add(this.txtAddContact);
            this.Controls.Add(this.btnAddHospital);
            this.Name = "HospitalSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Search";
            this.Load += new System.EventHandler(this.HospitalSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
