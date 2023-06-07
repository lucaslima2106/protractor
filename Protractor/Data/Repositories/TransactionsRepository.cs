using Dapper;
using Protractor.Contracts;
using Protractor.Data.Context;
using Protractor.Models;
using System.Collections.Generic;

namespace Protractor.Data.Repositories
{
	public class TransactionsRepository : ITransactionsRepository
	{
		private DbSession _session;

		public TransactionsRepository(DbSession session)
		{
			_session = session;
		}

		public IEnumerable<Transaction> SearchTransaction(string entryNumber)
		{
			string query = $@"
							SELECT
								[WorkOrder].[WorkOrderNumber] AS 'WorkOrder',
								[WOTransaction].[EntryNumber] AS 'Entry',
								[WOTransactionItem].[Description],
								[WOTransactionItem].[Amount]
							FROM
								[WOTransaction]
							INNER JOIN
								[WorkOrder] ON [WorkOrder].[ID] = [WOTransaction].[WorkOrderID]
							INNER JOIN
								[WOTransactionItem] ON [WOTransactionItem].[WOTransactionID] = [WOTransaction].[ID]
							WHERE
								[WOTransaction].[EntryNumber] LIKE '%{entryNumber}%';
							";

			IEnumerable<Transaction> transactions = _session.Connection.Query<Transaction>(query, null, _session.Transaction);

			return transactions;
		}
	}
}
