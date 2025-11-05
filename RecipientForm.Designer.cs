namespace blood_bank_management_sys
{
    partial class RecipientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecipientName;
        private System.Windows.Forms.TextBox txtRecipientName;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cbBloodGroup;
        private System.Windows.Forms.Label lblUnitsNeeded;
        private System.Windows.Forms.TextBox txtUnitsNeeded;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.ComboBox cbHospital;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.Button btnAddRecipient;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvRecipients;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipientForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecipientName = new System.Windows.Forms.Label();
            this.txtRecipientName = new System.Windows.Forms.TextBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblUnitsNeeded = new System.Windows.Forms.Label();
            this.txtUnitsNeeded = new System.Windows.Forms.TextBox();
            this.lblHospital = new System.Windows.Forms.Label();
            this.cbHospital = new System.Windows.Forms.ComboBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddRecipient = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvRecipients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(295, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Recipient Form";
            // 
            // lblRecipientName
            // 
            this.lblRecipientName.Location = new System.Drawing.Point(60, 70);
            this.lblRecipientName.Name = "lblRecipientName";
            this.lblRecipientName.Size = new System.Drawing.Size(100, 22);
            this.lblRecipientName.TabIndex = 1;
            this.lblRecipientName.Text = "Name";
            // 
            // txtRecipientName
            // 
            this.txtRecipientName.Location = new System.Drawing.Point(180, 70);
            this.txtRecipientName.Name = "txtRecipientName";
            this.txtRecipientName.Size = new System.Drawing.Size(200, 22);
            this.txtRecipientName.TabIndex = 2;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.Location = new System.Drawing.Point(60, 110);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(100, 22);
            this.lblBloodGroup.TabIndex = 3;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // cbBloodGroup
            // 
            this.cbBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbBloodGroup.Location = new System.Drawing.Point(180, 110);
            this.cbBloodGroup.Name = "cbBloodGroup";
            this.cbBloodGroup.Size = new System.Drawing.Size(200, 24);
            this.cbBloodGroup.TabIndex = 4;
            // 
            // lblUnitsNeeded
            // 
            this.lblUnitsNeeded.Location = new System.Drawing.Point(60, 150);
            this.lblUnitsNeeded.Name = "lblUnitsNeeded";
            this.lblUnitsNeeded.Size = new System.Drawing.Size(100, 22);
            this.lblUnitsNeeded.TabIndex = 5;
            this.lblUnitsNeeded.Text = "Units Needed";
            // 
            // txtUnitsNeeded
            // 
            this.txtUnitsNeeded.Location = new System.Drawing.Point(180, 150);
            this.txtUnitsNeeded.Name = "txtUnitsNeeded";
            this.txtUnitsNeeded.Size = new System.Drawing.Size(200, 22);
            this.txtUnitsNeeded.TabIndex = 6;
            // 
            // lblHospital
            // 
            this.lblHospital.Location = new System.Drawing.Point(60, 190);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(100, 22);
            this.lblHospital.TabIndex = 7;
            this.lblHospital.Text = "Hospital";
            // 
            // cbHospital
            // 
            this.cbHospital.Location = new System.Drawing.Point(180, 190);
            this.cbHospital.Name = "cbHospital";
            this.cbHospital.Size = new System.Drawing.Size(200, 24);
            this.cbHospital.TabIndex = 8;
            // 
            // lblContact
            // 
            this.lblContact.Location = new System.Drawing.Point(60, 230);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(100, 22);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(180, 230);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 22);
            this.txtContact.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(60, 270);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 22);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(180, 270);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(60, 310);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 22);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 310);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.Location = new System.Drawing.Point(60, 350);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(100, 22);
            this.lblRequestDate.TabIndex = 15;
            this.lblRequestDate.Text = "Request Date";
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Location = new System.Drawing.Point(180, 350);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(200, 22);
            this.dtpRequestDate.TabIndex = 16;
            // 
            // btnAddRecipient
            // 
            this.btnAddRecipient.Location = new System.Drawing.Point(180, 390);
            this.btnAddRecipient.Name = "btnAddRecipient";
            this.btnAddRecipient.Size = new System.Drawing.Size(120, 32);
            this.btnAddRecipient.TabIndex = 17;
            this.btnAddRecipient.Text = "Add Recipient";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(60, 430);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 20);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status messages / alerts";
            // 
            // dgvRecipients
            // 
            this.dgvRecipients.ColumnHeadersHeight = 29;
            this.dgvRecipients.Location = new System.Drawing.Point(400, 70);
            this.dgvRecipients.Name = "dgvRecipients";
            this.dgvRecipients.RowHeadersWidth = 51;
            this.dgvRecipients.Size = new System.Drawing.Size(400, 310);
            this.dgvRecipients.TabIndex = 19;
            // 
            // RecipientForm
            // 
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(850, 470);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecipientName);
            this.Controls.Add(this.txtRecipientName);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.cbBloodGroup);
            this.Controls.Add(this.lblUnitsNeeded);
            this.Controls.Add(this.txtUnitsNeeded);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.cbHospital);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRequestDate);
            this.Controls.Add(this.dtpRequestDate);
            this.Controls.Add(this.btnAddRecipient);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvRecipients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipient Registration";
            this.Load += new System.EventHandler(this.RecipientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
