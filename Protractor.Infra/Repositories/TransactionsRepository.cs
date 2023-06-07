using Dapper;
using Protractor.Infra.Context;
using Protractor.Models;
using Protractor.Repositories;
using System;
using System.Collections.Generic;

namespace Protractor.Infra.Repositories
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
            string query = @"
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
								[WOTransaction].[EntryNumber] = '{0}';
							";

			IEnumerable<Transaction> transactions = _session.Connection.Query<Transaction>(query, entryNumber, _session.Transaction);

			return transactions;
		}
    }
}
