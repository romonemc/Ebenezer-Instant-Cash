using System;
using System.Data;
using System.Windows.Forms;
using Ebenezar.Models;

namespace Ebenezar
{
    public partial class Main : Form
    {
        private int TRN;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                borrowerTableAdapter.Fill(eICDataSet.Borrower);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load records, please contact the System Administrator, or try again." + Environment.NewLine + ex.Message, "Could not load records.", MessageBoxButtons.OK);
            }
        }

        private void dgvBorrowers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TRN = Convert.ToInt32(dgvBorrowers[0, e.RowIndex].Value);
                loanTableAdapter.FillWithLoanInfo(eICDataSet.Loan, TRN);
            }
            catch (Exception)
            {
            }
        }

        private DataRow LastBorrRow;

        private void borrowerBindingSource_PositionChanged(object sender, EventArgs e)
        {
            BindingSource borrBindingSource = (BindingSource)sender;
            DataRow thisRow = ((DataRowView)borrBindingSource.Current).Row;

            if (thisRow == LastBorrRow)
            {
                return;
            }

            if (LastBorrRow != null)
            {
                if (LastBorrRow.RowState == DataRowState.Added || LastBorrRow.RowState == DataRowState.Deleted || LastBorrRow.RowState == DataRowState.Modified)
                {
                    borrowerTableAdapter.Update(LastBorrRow);
                }
            }

            LastBorrRow = thisRow;
        }

        private void dgvLoans_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if (dgvBorrowers["BorrowerDOB", dgvBorrowers.SelectedRows[0].Index].Value != DBNull.Value)
            {
                String dob = Convert.ToDateTime(dgvBorrowers["BorrowerDOB", dgvBorrowers.SelectedRows[0].Index].Value).ToShortDateString();
                e.Row.Cells["LoanID"].Value = TRN.ToString().Substring(0, 3) + dob.Substring(dob.Length - 2);
            }
            else
            {
                MessageBox.Show("Customer Date of Birth must be entered into the system to produce Loan ID.", "Loan ID Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            e.Row.Cells["borrowerTRN"].Value = TRN;
            e.Row.Cells["disburseDate"].Value = DateTime.Today;
        }

        private DataRow LastLoanRow;

        private void loanBindingSource_PositionChanged(object sender, EventArgs e)
        {
            BindingSource loanBS = (BindingSource)sender;
            DataRow thisRow = ((DataRowView)loanBS.Current).Row;

            if (thisRow == LastLoanRow)
            {
                return;
            }

            if (LastLoanRow != null)
            {
                if (LastLoanRow.RowState != DataRowState.Unchanged)
                {
                    loanTableAdapter.Update(LastLoanRow);
                }
            }

            LastLoanRow = thisRow;
        }

        private void txtFilterCustomers_TextChanged(object sender, EventArgs e)
        {
            loanBindingSource.RemoveFilter();

            if (int.TryParse(txtFilterCustomers.Text, out int query))
            {
                borrowerBindingSource.Filter = "TRN = " + query;
            }
            else
            {
                string q = "'%" + txtFilterCustomers.Text + "%'";
                borrowerBindingSource.Filter = "[Name] like " + q;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm(Convert.ToInt32(dgvBorrowers.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dgvLoans.SelectedRows[0].Cells[0].Value));
            rf.ShowDialog();
        }
    }
}
