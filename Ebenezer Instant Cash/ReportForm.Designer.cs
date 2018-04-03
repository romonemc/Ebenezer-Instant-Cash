namespace Ebenezar
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.lblMaturityDate = new System.Windows.Forms.Label();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eICDataSet = new Ebenezar.EICDataSet();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblAmountBorrowed = new System.Windows.Forms.Label();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.borrowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTRN = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape13 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape12 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape11 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.borrowerTableAdapter = new Ebenezar.EICDataSetTableAdapters.BorrowerTableAdapter();
            this.loanTableAdapter = new Ebenezar.EICDataSetTableAdapters.LoanTableAdapter();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAmountBorrowed);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.lblTotalRepayment);
            this.panel1.Controls.Add(this.lblMaturityDate);
            this.panel1.Controls.Add(this.lblLoanDate);
            this.panel1.Controls.Add(this.lblPeriod);
            this.panel1.Controls.Add(this.lblLoanID);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.lblTelephone);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblTRN);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 631);
            this.panel1.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(611, 405);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 25);
            this.label21.TabIndex = 8;
            this.label21.Text = "60%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(492, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 25);
            this.label19.TabIndex = 3;
            this.label19.Text = "Interest Rate:";
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalRepayment.Location = new System.Drawing.Point(611, 440);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(76, 25);
            this.lblTotalRepayment.TabIndex = 8;
            this.lblTotalRepayment.Text = "label19";
            // 
            // lblMaturityDate
            // 
            this.lblMaturityDate.AutoSize = true;
            this.lblMaturityDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loanBindingSource, "Maturity Date", true));
            this.lblMaturityDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMaturityDate.Location = new System.Drawing.Point(611, 368);
            this.lblMaturityDate.Name = "lblMaturityDate";
            this.lblMaturityDate.Size = new System.Drawing.Size(76, 25);
            this.lblMaturityDate.TabIndex = 8;
            this.lblMaturityDate.Text = "label19";
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.DataSource = this.eICDataSet;
            // 
            // eICDataSet
            // 
            this.eICDataSet.DataSetName = "EICDataSet";
            this.eICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblLoanDate
            // 
            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loanBindingSource, "Disbursement Date", true));
            this.lblLoanDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLoanDate.Location = new System.Drawing.Point(611, 330);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(76, 25);
            this.lblLoanDate.TabIndex = 8;
            this.lblLoanDate.Text = "label19";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loanBindingSource, "Repayment Frequency", true));
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPeriod.Location = new System.Drawing.Point(611, 291);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(76, 25);
            this.lblPeriod.TabIndex = 8;
            this.lblPeriod.Text = "label19";
            // 
            // lblAmountBorrowed
            // 
            this.lblAmountBorrowed.AutoSize = true;
            this.lblAmountBorrowed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loanBindingSource, "Borrowed", true));
            this.lblAmountBorrowed.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAmountBorrowed.Location = new System.Drawing.Point(647, 249);
            this.lblAmountBorrowed.Name = "lblAmountBorrowed";
            this.lblAmountBorrowed.Size = new System.Drawing.Size(76, 25);
            this.lblAmountBorrowed.TabIndex = 8;
            this.lblAmountBorrowed.Text = "label19";
            // 
            // lblLoanID
            // 
            this.lblLoanID.AutoSize = true;
            this.lblLoanID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loanBindingSource, "Loan ID", true));
            this.lblLoanID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLoanID.Location = new System.Drawing.Point(611, 207);
            this.lblLoanID.Name = "lblLoanID";
            this.lblLoanID.Size = new System.Drawing.Size(76, 25);
            this.lblLoanID.TabIndex = 8;
            this.lblLoanID.Text = "label19";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Address", true));
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(193, 368);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 25);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "label19";
            // 
            // borrowerBindingSource
            // 
            this.borrowerBindingSource.DataMember = "Borrower";
            this.borrowerBindingSource.DataSource = this.eICDataSet;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(113, 371);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 25);
            this.label20.TabIndex = 3;
            this.label20.Text = "Address:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Telephone", true));
            this.lblTelephone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTelephone.Location = new System.Drawing.Point(193, 330);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(76, 25);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "label19";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "DOB", true));
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDOB.Location = new System.Drawing.Point(193, 290);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(76, 25);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "label19";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Name", true));
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(193, 249);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 25);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "label19";
            // 
            // lblTRN
            // 
            this.lblTRN.AutoSize = true;
            this.lblTRN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "TRN", true));
            this.lblTRN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTRN.Location = new System.Drawing.Point(193, 206);
            this.lblTRN.Name = "lblTRN";
            this.lblTRN.Size = new System.Drawing.Size(76, 25);
            this.lblTRN.TabIndex = 8;
            this.lblTRN.Text = "label19";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(3, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 283);
            this.panel3.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(439, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 25);
            this.label17.TabIndex = 3;
            this.label17.Text = "Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Customer Signature:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "Signed by Credit Officer:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 161);
            this.panel2.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrint.Location = new System.Drawing.Point(713, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 26);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ebenezar.Properties.Resources.EIC_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(135, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ebenezar Instant Cash Loan Services";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(136, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address: Cornwall Courts, Montego Bay, St. James\r\nTelephone: (876) 543-8740, (876" +
    ") 856-1831, (876) 578-6398\r\n";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(480, 179);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 21);
            this.label18.TabIndex = 1;
            this.label18.Text = "Loan Information";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(44, 179);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "Personal Information";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 631);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(459, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Total Repayment:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(519, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Due Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Date of Loan:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Period of Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Amount Borrowed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Loan ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telephone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer\'s Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer\'s TRN:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape13,
            this.lineShape10,
            this.lineShape12,
            this.lineShape11,
            this.lineShape9,
            this.lineShape8,
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(824, 631);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape13
            // 
            this.lineShape13.Name = "lineShape13";
            this.lineShape13.X1 = 537;
            this.lineShape13.X2 = 795;
            this.lineShape13.Y1 = 430;
            this.lineShape13.Y2 = 430;
            // 
            // lineShape10
            // 
            this.lineShape10.Name = "lineShape10";
            this.lineShape10.X1 = 167;
            this.lineShape10.X2 = 416;
            this.lineShape10.Y1 = 274;
            this.lineShape10.Y2 = 274;
            // 
            // lineShape12
            // 
            this.lineShape12.Name = "lineShape12";
            this.lineShape12.X1 = 538;
            this.lineShape12.X2 = 796;
            this.lineShape12.Y1 = 465;
            this.lineShape12.Y2 = 465;
            // 
            // lineShape11
            // 
            this.lineShape11.Name = "lineShape11";
            this.lineShape11.X1 = 538;
            this.lineShape11.X2 = 796;
            this.lineShape11.Y1 = 531;
            this.lineShape11.Y2 = 531;
            // 
            // lineShape9
            // 
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.X1 = 537;
            this.lineShape9.X2 = 795;
            this.lineShape9.Y1 = 393;
            this.lineShape9.Y2 = 393;
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 534;
            this.lineShape8.X2 = 792;
            this.lineShape8.Y1 = 232;
            this.lineShape8.Y2 = 232;
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 534;
            this.lineShape7.X2 = 792;
            this.lineShape7.Y1 = 274;
            this.lineShape7.Y2 = 274;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 535;
            this.lineShape6.X2 = 793;
            this.lineShape6.Y1 = 355;
            this.lineShape6.Y2 = 355;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 535;
            this.lineShape5.X2 = 793;
            this.lineShape5.Y1 = 316;
            this.lineShape5.Y2 = 316;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 166;
            this.lineShape4.X2 = 415;
            this.lineShape4.Y1 = 355;
            this.lineShape4.Y2 = 355;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 166;
            this.lineShape3.X2 = 415;
            this.lineShape3.Y1 = 393;
            this.lineShape3.Y2 = 393;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 165;
            this.lineShape2.X2 = 414;
            this.lineShape2.Y1 = 315;
            this.lineShape2.Y2 = 315;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 165;
            this.lineShape1.X2 = 414;
            this.lineShape1.Y1 = 232;
            this.lineShape1.Y2 = 232;
            // 
            // borrowerTableAdapter
            // 
            this.borrowerTableAdapter.ClearBeforeFill = true;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(611, 249);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 25);
            this.label22.TabIndex = 8;
            this.label22.Text = "$JA";
            // 
            // ReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 631);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebenezer Instant Cash";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eICDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape12;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape11;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTRN;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblTelephone;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape10;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.Label lblMaturityDate;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblAmountBorrowed;
        private System.Windows.Forms.Label lblLoanID;
        private EICDataSet eICDataSet;
        private System.Windows.Forms.BindingSource borrowerBindingSource;
        private EICDataSetTableAdapters.BorrowerTableAdapter borrowerTableAdapter;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private EICDataSetTableAdapters.LoanTableAdapter loanTableAdapter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape13;
        private System.Windows.Forms.Label label22;
    }
}

