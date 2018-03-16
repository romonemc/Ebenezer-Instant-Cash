using System;
using System.Windows.Forms;

namespace Ebenezar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eICDataSet.Borrower' table. You can move, or remove it, as needed.
            this.borrowerTableAdapter.Fill(this.eICDataSet.Borrower);

        }

        private void dgvBorrowers_SelectionChanged(object sender, EventArgs e)
        {
            // Load loans for selected borrower on selection changed.

        }
    }
}
