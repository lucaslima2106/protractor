using Protractor.Contracts;
using Protractor.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Protractor
{
    public partial class transactionsForm : Form
    {
        private readonly ITransactionsRepository _transactionsRepository;

        public transactionsForm(ITransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
            InitializeComponent();
        }

        private void txtBoxSearchTX_KeyUp(object sender, KeyEventArgs e)
        {
            dgvResult.Rows.Clear();

            List<Transaction> transactions = _transactionsRepository.SearchTransaction(txtBoxSearchTX.Text).ToList();

            foreach (var item in transactions)
                dgvResult.Rows.Add(item.WorkOrder, item.Entry, item.Description, item.Amount.ToString("C2"));
        }
    }
}
