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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBorrowers = new System.Windows.Forms.DataGridView();
            this.borrowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilterCustomers = new System.Windows.Forms.TextBox();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.eICDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eICDataSet = new Ebenezar.EICDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowerDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanTableAdapter = new Ebenezar.EICDataSetTableAdapters.LoanTableAdapter();
            this.borrowerTableAdapter = new Ebenezar.EICDataSetTableAdapters.BorrowerTableAdapter();
            this.LoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disburseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maturityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepaymentFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditOfficer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerTRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSet)).BeginInit();
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
            this.dgvBorrowers.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvBorrowers.Location = new System.Drawing.Point(8, 134);
            this.dgvBorrowers.MultiSelect = false;
            this.dgvBorrowers.Name = "dgvBorrowers";
            this.dgvBorrowers.RowHeadersVisible = false;
            this.dgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowers.Size = new System.Drawing.Size(492, 479);
            this.dgvBorrowers.TabIndex = 0;
            this.dgvBorrowers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowers_CellClick);
            // 
            // borrowerBindingSource
            // 
            this.borrowerBindingSource.DataMember = "Borrower";
            this.borrowerBindingSource.DataSource = this.eICDataSetBindingSource;
            this.borrowerBindingSource.PositionChanged += new System.EventHandler(this.borrowerBindingSource_PositionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(502, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loans";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ebenezar.Properties.Resources.EIC_Logo1;
            this.pictureBox2.Location = new System.Drawing.Point(8, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 52);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(506, 497);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active Loan";
            // 
            // txtFilterCustomers
            // 
            this.txtFilterCustomers.Location = new System.Drawing.Point(8, 105);
            this.txtFilterCustomers.Name = "txtFilterCustomers";
            this.txtFilterCustomers.Size = new System.Drawing.Size(242, 23);
            this.txtFilterCustomers.TabIndex = 7;
            this.txtFilterCustomers.TextChanged += new System.EventHandler(this.txtFilterCustomers_TextChanged);
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToResizeRows = false;
            this.dgvLoans.AutoGenerateColumns = false;
            this.dgvLoans.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLoans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoanID,
            this.disburseDate,
            this.borrowedDataGridViewTextBoxColumn,
            this.maturityDate,
            this.LoanStatus,
            this.LoanType,
            this.RepaymentMethod,
            this.RepaymentFrequency,
            this.CreditOfficer,
            this.borrowerTRN});
            this.dgvLoans.DataSource = this.loanBindingSource;
            this.dgvLoans.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvLoans.Location = new System.Drawing.Point(506, 134);
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLoans.RowHeadersVisible = false;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(575, 363);
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
            this.btnPrint.Location = new System.Drawing.Point(1006, 104);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TRN";
            dataGridViewCellStyle1.Format = "###-###-####";
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
            dataGridViewCellStyle2.Format = " ###-####";
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
            dataGridViewCellStyle3.Format = "###-##";
            dataGridViewCellStyle3.NullValue = "-";
            this.LoanID.DefaultCellStyle = dataGridViewCellStyle3;
            this.LoanID.Frozen = true;
            this.LoanID.HeaderText = "Loan ID";
            this.LoanID.Name = "LoanID";
            // 
            // disburseDate
            // 
            this.disburseDate.DataPropertyName = "Disbursement Date";
            this.disburseDate.Frozen = true;
            this.disburseDate.HeaderText = "Disbursement Date";
            this.disburseDate.Name = "disburseDate";
            // 
            // borrowedDataGridViewTextBoxColumn
            // 
            this.borrowedDataGridViewTextBoxColumn.DataPropertyName = "Borrowed";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.borrowedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.borrowedDataGridViewTextBoxColumn.Frozen = true;
            this.borrowedDataGridViewTextBoxColumn.HeaderText = "Borrowed";
            this.borrowedDataGridViewTextBoxColumn.Name = "borrowedDataGridViewTextBoxColumn";
            // 
            // maturityDate
            // 
            this.maturityDate.DataPropertyName = "Maturity Date";
            this.maturityDate.HeaderText = "Maturity Date";
            this.maturityDate.Name = "maturityDate";
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
            this.RepaymentMethod.HeaderText = "Repayment Method";
            this.RepaymentMethod.Name = "RepaymentMethod";
            // 
            // RepaymentFrequency
            // 
            this.RepaymentFrequency.DataPropertyName = "Repayment Frequency";
            this.RepaymentFrequency.HeaderText = "Repayment Frequency";
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
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 619);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.txtFilterCustomers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBorrowers);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBorrowers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerDOB;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn disburseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maturityDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepaymentFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditOfficer;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerTRN;
    }
}