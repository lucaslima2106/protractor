using Protractor.Models;
using System.Collections.Generic;

namespace Protractor.Contracts
{
    public interface ITransactionsRepository
    {
        IEnumerable<Transaction> SearchTransaction(string entryNumber);
    }
}
