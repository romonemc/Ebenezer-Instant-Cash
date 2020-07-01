namespace Ebenezar
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dgvBorrowers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowerDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eICDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eICDataSet = new Ebenezar.EICDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFilterCustomers = new System.Windows.Forms.TextBox();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.loanTableAdapter = new Ebenezar.EICDataSetTableAdapters.LoanTableAdapter();
            this.borrowerTableAdapter = new Ebenezar.EICDataSetTableAdapters.BorrowerTableAdapter();
            this.LoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disburseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maturityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatePaymentPenalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepaymentFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditOfficer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerTRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBorrowers
            // 
            this.dgvBorrowers.AllowUserToResizeRows = false;
            this.dgvBorrowers.AutoGenerateColumns = false;
            this.dgvBorrowers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBorrowers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBorrowers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.BorrowerDOB});
            this.dgvBorrowers.DataSource = this.borrowerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBorrowers.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvBorrowers.Location = new System.Drawing.Point(8, 112);
            this.dgvBorrowers.MultiSelect = false;
            this.dgvBorrowers.Name = "dgvBorrowers";
            this.dgvBorrowers.RowHeadersVisible = false;
            this.dgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowers.Size = new System.Drawing.Size(492, 501);
            this.dgvBorrowers.TabIndex = 0;
            this.dgvBorrowers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowers_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TRN";
            dataGridViewCellStyle1.Format = "###-###-###";
            dataGridViewCellStyle1.NullValue = "-";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "TRN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telephone";
            dataGridViewCellStyle2.Format = "###-###-####";
            dataGridViewCellStyle2.NullValue = "-";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // BorrowerDOB
            // 
            this.BorrowerDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BorrowerDOB.DataPropertyName = "DOB";
            this.BorrowerDOB.HeaderText = "DOB";
            this.BorrowerDOB.Name = "BorrowerDOB";
            // 
            // borrowerBindingSource
            // 
            this.borrowerBindingSource.DataMember = "Borrower";
            this.borrowerBindingSource.DataSource = this.eICDataSetBindingSource;
            this.borrowerBindingSource.PositionChanged += new System.EventHandler(this.borrowerBindingSource_PositionChanged);
            // 
            // eICDataSetBindingSource
            // 
            this.eICDataSetBindingSource.DataSource = this.eICDataSet;
            this.eICDataSetBindingSource.Position = 0;
            // 
            // eICDataSet
            // 
            this.eICDataSet.DataSetName = "EICDataSet";
            this.eICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(502, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loans";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Ebenezar.Properties.Resources.EIC_Logo1;
            this.pictureBox2.Location = new System.Drawing.Point(9, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 65);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txtFilterCustomers
            // 
            this.txtFilterCustomers.Location = new System.Drawing.Point(94, 83);
            this.txtFilterCustomers.Name = "txtFilterCustomers";
            this.txtFilterCustomers.Size = new System.Drawing.Size(260, 23);
            this.txtFilterCustomers.TabIndex = 7;
            this.txtFilterCustomers.TextChanged += new System.EventHandler(this.txtFilterCustomers_TextChanged);
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToResizeRows = false;
            this.dgvLoans.AutoGenerateColumns = false;
            this.dgvLoans.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLoans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoanID,
            this.disburseDate,
            this.borrowedDataGridViewTextBoxColumn,
            this.maturityDate,
            this.InterestRate,
            this.LatePaymentPenalty,
            this.LoanStatus,
            this.LoanType,
            this.RepaymentMethod,
            this.RepaymentFrequency,
            this.CreditOfficer,
            this.borrowerTRN});
            this.dgvLoans.DataSource = this.loanBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoans.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLoans.Enabled = false;
            this.dgvLoans.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvLoans.Location = new System.Drawing.Point(506, 112);
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLoans.RowHeadersVisible = false;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(575, 501);
            this.dgvLoans.TabIndex = 8;
            this.dgvLoans.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvLoans_DefaultValuesNeeded);
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.DataSource = this.eICDataSetBindingSource;
            this.loanBindingSource.PositionChanged += new System.EventHandler(this.loanBindingSource_PositionChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1006, 83);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // borrowerTableAdapter
            // 
            this.borrowerTableAdapter.ClearBeforeFill = true;
            // 
            // LoanID
            // 
            this.LoanID.DataPropertyName = "Loan ID";
            dataGridViewCellStyle4.Format = "###-##-#####";
            dataGridViewCellStyle4.NullValue = "-";
            this.LoanID.DefaultCellStyle = dataGridViewCellStyle4;
            this.LoanID.Frozen = true;
            this.LoanID.HeaderText = "Loan ID";
            this.LoanID.Name = "LoanID";
            this.LoanID.Width = 75;
            // 
            // disburseDate
            // 
            this.disburseDate.DataPropertyName = "Disbursement Date";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.disburseDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.disburseDate.Frozen = true;
            this.disburseDate.HeaderText = "Disbursement Date";
            this.disburseDate.Name = "disburseDate";
            // 
            // borrowedDataGridViewTextBoxColumn
            // 
            this.borrowedDataGridViewTextBoxColumn.DataPropertyName = "Borrowed";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0";
            this.borrowedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.borrowedDataGridViewTextBoxColumn.Frozen = true;
            this.borrowedDataGridViewTextBoxColumn.HeaderText = "Borrowed";
            this.borrowedDataGridViewTextBoxColumn.Name = "borrowedDataGridViewTextBoxColumn";
            this.borrowedDataGridViewTextBoxColumn.Width = 75;
            // 
            // maturityDate
            // 
            this.maturityDate.DataPropertyName = "Maturity Date";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.maturityDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.maturityDate.Frozen = true;
            this.maturityDate.HeaderText = "Maturity Date";
            this.maturityDate.Name = "maturityDate";
            this.maturityDate.Width = 80;
            // 
            // InterestRate
            // 
            this.InterestRate.DataPropertyName = "Interest Rate";
            dataGridViewCellStyle8.NullValue = "-";
            this.InterestRate.DefaultCellStyle = dataGridViewCellStyle8;
            this.InterestRate.HeaderText = "Int. Rate";
            this.InterestRate.Name = "InterestRate";
            this.InterestRate.Width = 50;
            // 
            // LatePaymentPenalty
            // 
            this.LatePaymentPenalty.DataPropertyName = "Late Payment";
            this.LatePaymentPenalty.HeaderText = "Late Pay. Penalty";
            this.LatePaymentPenalty.Name = "LatePaymentPenalty";
            // 
            // LoanStatus
            // 
            this.LoanStatus.DataPropertyName = "Status";
            this.LoanStatus.HeaderText = "Status";
            this.LoanStatus.Name = "LoanStatus";
            // 
            // LoanType
            // 
            this.LoanType.DataPropertyName = "Loan Type";
            this.LoanType.HeaderText = "Loan Type";
            this.LoanType.Name = "LoanType";
            // 
            // RepaymentMethod
            // 
            this.RepaymentMethod.DataPropertyName = "Repayment Method";
            this.RepaymentMethod.HeaderText = "Repay Method";
            this.RepaymentMethod.Name = "RepaymentMethod";
            // 
            // RepaymentFrequency
            // 
            this.RepaymentFrequency.DataPropertyName = "Repayment Frequency";
            this.RepaymentFrequency.HeaderText = "Repay Freq.";
            this.RepaymentFrequency.Name = "RepaymentFrequency";
            // 
            // CreditOfficer
            // 
            this.CreditOfficer.DataPropertyName = "Credit Officer";
            this.CreditOfficer.HeaderText = "Credit Officer";
            this.CreditOfficer.Name = "CreditOfficer";
            // 
            // borrowerTRN
            // 
            this.borrowerTRN.DataPropertyName = "Borrower TRN";
            this.borrowerTRN.HeaderText = "Borrower TRN";
            this.borrowerTRN.Name = "borrowerTRN";
            this.borrowerTRN.Width = 50;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 619);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.txtFilterCustomers);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBorrowers);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBorrowers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private EICDataSetTableAdapters.LoanTableAdapter loanTableAdapter;
        private System.Windows.Forms.BindingSource eICDataSetBindingSource;
        private EICDataSet eICDataSet;
        private System.Windows.Forms.BindingSource borrowerBindingSource;
        private EICDataSetTableAdapters.BorrowerTableAdapter borrowerTableAdapter;
        private System.Windows.Forms.TextBox txtFilterCustomers;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn disburseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maturityDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatePaymentPenalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepaymentFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditOfficer;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerTRN;
    }
}