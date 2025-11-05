namespace blood_bank_management_sys
{
    partial class BloodBankManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnAddBank;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvBanks;

        private System.Windows.Forms.Label lblAPlus;
        private System.Windows.Forms.TextBox txtUnitsAPlus;
        private System.Windows.Forms.DateTimePicker dtpExpiryAPlus;

        private System.Windows.Forms.Label lblAMinus;
        private System.Windows.Forms.TextBox txtUnitsAMinus;
        private System.Windows.Forms.DateTimePicker dtpExpiryAMinus;

        private System.Windows.Forms.Label lblBPlus;
        private System.Windows.Forms.TextBox txtUnitsBPlus;
        private System.Windows.Forms.DateTimePicker dtpExpiryBPlus;

        private System.Windows.Forms.Label lblBMinus;
        private System.Windows.Forms.TextBox txtUnitsBMinus;
        private System.Windows.Forms.DateTimePicker dtpExpiryBMinus;

        private System.Windows.Forms.Label lblABPlus;
        private System.Windows.Forms.TextBox txtUnitsABPlus;
        private System.Windows.Forms.DateTimePicker dtpExpiryABPlus;

        private System.Windows.Forms.Label lblABMinus;
        private System.Windows.Forms.TextBox txtUnitsABMinus;
        private System.Windows.Forms.DateTimePicker dtpExpiryABMinus;

        private System.Windows.Forms.Label lblOPlus;
        private System.Windows.Forms.TextBox txtUnitsOPlus;
        private System.Windows.Forms.DateTimePicker dtpExpiryOPlus;

        private System.Windows.Forms.Label lblOMinus;
        private System.Windows.Forms.TextBox txtUnitsOMinus;
        private System.Windows.Forms.DateTimePicker dtpExpiryOMinus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodBankManagementForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvBanks = new System.Windows.Forms.DataGridView();
            this.lblAPlus = new System.Windows.Forms.Label();
            this.txtUnitsAPlus = new System.Windows.Forms.TextBox();
            this.dtpExpiryAPlus = new System.Windows.Forms.DateTimePicker();
            this.lblAMinus = new System.Windows.Forms.Label();
            this.txtUnitsAMinus = new System.Windows.Forms.TextBox();
            this.dtpExpiryAMinus = new System.Windows.Forms.DateTimePicker();
            this.lblBPlus = new System.Windows.Forms.Label();
            this.txtUnitsBPlus = new System.Windows.Forms.TextBox();
            this.dtpExpiryBPlus = new System.Windows.Forms.DateTimePicker();
            this.lblBMinus = new System.Windows.Forms.Label();
            this.txtUnitsBMinus = new System.Windows.Forms.TextBox();
            this.dtpExpiryBMinus = new System.Windows.Forms.DateTimePicker();
            this.lblABPlus = new System.Windows.Forms.Label();
            this.txtUnitsABPlus = new System.Windows.Forms.TextBox();
            this.dtpExpiryABPlus = new System.Windows.Forms.DateTimePicker();
            this.lblABMinus = new System.Windows.Forms.Label();
            this.txtUnitsABMinus = new System.Windows.Forms.TextBox();
            this.dtpExpiryABMinus = new System.Windows.Forms.DateTimePicker();
            this.lblOPlus = new System.Windows.Forms.Label();
            this.txtUnitsOPlus = new System.Windows.Forms.TextBox();
            this.dtpExpiryOPlus = new System.Windows.Forms.DateTimePicker();
            this.lblOMinus = new System.Windows.Forms.Label();
            this.txtUnitsOMinus = new System.Windows.Forms.TextBox();
            this.dtpExpiryOMinus = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(270, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 37);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Blood Bank Management";
            // 
            // lblBankName
            // 
            this.lblBankName.Location = new System.Drawing.Point(78, 77);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(100, 23);
            this.lblBankName.TabIndex = 25;
            this.lblBankName.Text = "Bank Name";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(78, 117);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.Location = new System.Drawing.Point(78, 157);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(100, 23);
            this.lblContact.TabIndex = 29;
            this.lblContact.Text = "Contact";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(248, 72);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(250, 22);
            this.txtBankName.TabIndex = 26;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(248, 112);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 22);
            this.txtAddress.TabIndex = 28;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(248, 152);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(250, 22);
            this.txtContact.TabIndex = 30;
            // 
            // btnAddBank
            // 
            this.btnAddBank.Location = new System.Drawing.Point(248, 192);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(100, 30);
            this.btnAddBank.TabIndex = 31;
            this.btnAddBank.Text = "Add Bank";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(113, 421);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 20);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status messages / alerts";
            // 
            // dgvBanks
            // 
            this.dgvBanks.ColumnHeadersHeight = 29;
            this.dgvBanks.Location = new System.Drawing.Point(32, 246);
            this.dgvBanks.Name = "dgvBanks";
            this.dgvBanks.RowHeadersWidth = 51;
            this.dgvBanks.Size = new System.Drawing.Size(550, 150);
            this.dgvBanks.TabIndex = 32;
            // 
            // lblAPlus
            // 
            this.lblAPlus.Location = new System.Drawing.Point(600, 80);
            this.lblAPlus.Name = "lblAPlus";
            this.lblAPlus.Size = new System.Drawing.Size(60, 23);
            this.lblAPlus.TabIndex = 0;
            this.lblAPlus.Text = "A+ Units";
            // 
            // txtUnitsAPlus
            // 
            this.txtUnitsAPlus.Location = new System.Drawing.Point(670, 80);
            this.txtUnitsAPlus.Name = "txtUnitsAPlus";
            this.txtUnitsAPlus.Size = new System.Drawing.Size(40, 22);
            this.txtUnitsAPlus.TabIndex = 1;
            // 
            // dtpExpiryAPlus
            // 
            this.dtpExpiryAPlus.Location = new System.Drawing.Point(720, 80);
            this.dtpExpiryAPlus.Name = "dtpExpiryAPlus";
            this.dtpExpiryAPlus.Size = new System.Drawing.Size(148, 22);
            this.dtpExpiryAPlus.TabIndex = 2;
            // 
            // lblAMinus
            // 
            this.lblAMinus.Location = new System.Drawing.Point(600, 110);
            this.lblAMinus.Name = "lblAMinus";
            this.lblAMinus.Size = new System.Drawing.Size(60, 23);
            this.lblAMinus.TabIndex = 3;
            this.lblAMinus.Text = "A- Units";
            // 
            // txtUnitsAMinus
            // 
            this.txtUnitsAMinus.Location = new System.Drawing.Point(670, 110);
            this.txtUnitsAMinus.Name = "txtUnitsAMinus";
            this.txtUnitsAMinus.Size = new System.Drawing.Size(40, 22);
            this.txtUnitsAMinus.TabIndex = 4;
            // 
            // dtpExpiryAMinus
            // 
            this.dtpExpiryAMinus.Location = new System.Drawing.Point(720, 110);
            this.dtpExpiryAMinus.Name = "dtpExpiryAMinus";
            this.dtpExpiryAMinus.Size = new System.Drawing.Size(148, 22);
            this.dtpExpiryAMinus.TabIndex = 5;
            // 
            // lblBPlus
            // 
            this.lblBPlus.Location = new System.Drawing.Point(600, 140);
            this.lblBPlus.Name = "lblBPlus";
            this.lblBPlus.Size = new System.Drawing.Size(60, 23);
            this.lblBPlus.TabIndex = 6;
            this.lblBPlus.Text = "B+ Units";
            // 
            // txtUnitsBPlus
            // 
            this.txtUnitsBPlus.Location = new System.Drawing.Point(670, 140);
            this.txtUnitsBPlus.Name = "txtUnitsBPlus";
            this.txtUnitsBPlus.Size = new System.Drawing.Size(40, 22);
            this.txtUnitsBPlus.TabIndex = 7;
            // 
            // dtpExpiryBPlus
            // 
            this.dtpExpiryBPlus.Location = new System.Drawing.Point(720, 140);
            this.dtpExpiryBPlus.Name = "dtpExpiryBPlus";
            this.dtpExpiryBPlus.Size = new System.Drawing.Size(148, 22);
            this.dtpExpiryBPlus.TabIndex = 8;
            // 
            // lblBMinus
            // 
            this.lblBMinus.Location = new System.Drawing.Point(600, 170);
            this.lblBMinus.Name = "lblBMinus";
            this.lblBMinus.Size = new System.Drawing.Size(60, 23);
            this.lblBMinus.TabIndex = 9;
            this.lblBMinus.Text = "B- Units";
            // 
            // txtUnitsBMinus
            // 
            this.txtUnitsBMinus.Location = new System.Drawing.Point(670, 170);
            this.txtUnitsBMinus.Name = "txtUnitsBMinus";
            this.txtUnitsBMinus.Size = new System.Drawing.Size(40, 22);
            this.txtUnitsBMinus.TabIndex = 10;
            // 
            // dtpExpiryBMinus
            // 
            this.dtpExpiryBMinus.Location = new System.Drawing.Point(720, 170);
            this.dtpExpiryBMinus.Name = "dtpExpiryBMinus";
            this.dtpExpiryBMinus.Size = new System.Drawing.Size(148, 22);
            this.dtpExpiryBMinus.TabIndex = 11;
            // 
            // lblABPlus
            // 
            this.lblABPlus.Location = new System.Drawing.Point(600, 200);
            this.lblABPlus.Name = "lblABPlus";
            this.lblABPlus.Size = new System.Drawing.Size(60, 23);
            this.lblABPlus.TabIndex = 12;
            this.lblABPlus.Text = "AB+ Units";
            // 
            // txtUnitsABPlus
            // 
            this.txtUnitsABPlus.Location = new System.Drawing.Point(670, 200);
            this.txtUnitsABPlus.Name = "txtUnitsABPlus";
            this.txtUnitsABPlus.Size = new System.Drawing.Size(40, 22);
            this.txtUnitsABPlus.TabIndex = 13;
            // 
            // dtpExpiryABPlus
            // 
            this.dtpExpiryABPlus.Location = new System.Drawing.Point(720, 202);
            this.dtpExpiryABPlus.Name = "dtpExpiryABPlus";
            this.dtpExpiryABPlus.Size = new System.Drawing.Size(148, 22);
            this.dtpExpiryABPlus.TabIndex = 14;
            // 
            // lblABMinus
            // 
            this.lblABMinus.Location = new System.Drawing.Point(600, 230);
            this.lblABMinus.Name = "lblABMinus";
            this.lblABMinus.Size = new System.Drawing.Size(60, 23);
            this.lblABMinus.TabIndex = 15;
            this.lblABMinus.Text = "AB- Units";
            // 
            // txtUnitsABMinus
            // 
            this.txtUnitsABMinus.Location = new System.Drawing.Point(670, 230);
            this.txtUnitsABMinus.Name = "txtUnitsABMinus";
            this.txtUnitsABMinus.Size = new System.Drawing.Size(40, 22);
            this.txtUnitsABMinus.TabIndex = 16;
            // 
            // dtpExpiryABMinus
            // 
            this.dtpExpiryABMinus.Location = new System.Drawing.Point(720, 230);
            this.dtpExpiryABMinus.Name = "dtpExpiryABMinus";
            this.dtpExpiryABMinus.Size = new System.Drawing.Size(148, 22);
            this.dtpExpiryABMinus.TabIndex = 17;
            // 
            // lblOPlus
            // 
            this.lblOPlus.Location = new System.Drawing.Point(600, 260);
            this.lblOPlus.Name = "lblOPlus";
            this.lblOPlus.Size = new System.Drawing.Size(60, 23);
            this.lblOPlus.TabIndex = 18;
            this.lblOPlus.Text = "O+ Units";
            // 
            // txtUnitsOPlus
            // 
            this.txtUnitsOPlus.Location = new System.Drawing.Point(670, 260);
            this.txtUnitsOPlus.Name = "txtUnitsOPlus";
            this.txtUnitsOPlus.Size = new System.Drawing.Size(40, 22);
            this.txtUnitsOPlus.TabIndex = 19;
            // 
            // dtpExpiryOPlus
            // 
            this.dtpExpiryOPlus.Location = new System.Drawing.Point(720, 260);
            this.dtpExpiryOPlus.Name = "dtpExpiryOPlus";
            this.dtpExpiryOPlus.Size = new System.Drawing.Size(148, 22);
            this.dtpExpiryOPlus.TabIndex = 20;
            // 
            // lblOMinus
            // 
            this.lblOMinus.Location = new System.Drawing.Point(600, 290);
            this.lblOMinus.Name = "lblOMinus";
            this.lblOMinus.Size = new System.Drawing.Size(60, 23);
            this.lblOMinus.TabIndex = 21;
            this.lblOMinus.Text = "O- Units";
            // 
            // txtUnitsOMinus
            // 
            this.txtUnitsOMinus.Location = new System.Drawing.Point(670, 290);
            this.txtUnitsOMinus.Name = "txtUnitsOMinus";
            this.txtUnitsOMinus.Size = new System.Drawing.Size(40, 22);
            this.txtUnitsOMinus.TabIndex = 22;
            // 
            // dtpExpiryOMinus
            // 
            this.dtpExpiryOMinus.Location = new System.Drawing.Point(720, 290);
            this.dtpExpiryOMinus.Name = "dtpExpiryOMinus";
            this.dtpExpiryOMinus.Size = new System.Drawing.Size(148, 22);
            this.dtpExpiryOMinus.TabIndex = 23;
            // 
            // BloodBankManagementForm
            // 
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.lblAPlus);
            this.Controls.Add(this.txtUnitsAPlus);
            this.Controls.Add(this.dtpExpiryAPlus);
            this.Controls.Add(this.lblAMinus);
            this.Controls.Add(this.txtUnitsAMinus);
            this.Controls.Add(this.dtpExpiryAMinus);
            this.Controls.Add(this.lblBPlus);
            this.Controls.Add(this.txtUnitsBPlus);
            this.Controls.Add(this.dtpExpiryBPlus);
            this.Controls.Add(this.lblBMinus);
            this.Controls.Add(this.txtUnitsBMinus);
            this.Controls.Add(this.dtpExpiryBMinus);
            this.Controls.Add(this.lblABPlus);
            this.Controls.Add(this.txtUnitsABPlus);
            this.Controls.Add(this.dtpExpiryABPlus);
            this.Controls.Add(this.lblABMinus);
            this.Controls.Add(this.txtUnitsABMinus);
            this.Controls.Add(this.dtpExpiryABMinus);
            this.Controls.Add(this.lblOPlus);
            this.Controls.Add(this.txtUnitsOPlus);
            this.Controls.Add(this.dtpExpiryOPlus);
            this.Controls.Add(this.lblOMinus);
            this.Controls.Add(this.txtUnitsOMinus);
            this.Controls.Add(this.dtpExpiryOMinus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.btnAddBank);
            this.Controls.Add(this.dgvBanks);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BloodBankManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank Management";
            this.Load += new System.EventHandler(this.BloodBankManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
