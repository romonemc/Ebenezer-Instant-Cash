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
                dgvLoans.DataSource = loanTableAdapter.GetLoanInfo(TRN);
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
            e.Row.Cells["borrowerTRN"].Value = TRN;
            e.Row.Cells["disburseDate"].Value = DateTime.Today;
            //e.Row.Cells["LoanID"].Value = 
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
                if (LastLoanRow.RowState == DataRowState.Added || LastLoanRow.RowState == DataRowState.Deleted || LastLoanRow.RowState == DataRowState.Modified)
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
                borrowerBindingSource.Filter;
            }
            else
            {
                string q = "'%" + txtFilterCustomers.Text + "%'";
                borrowerBindingSource.Filter = "[Name] like " + q;
            }
        }
    }
}
