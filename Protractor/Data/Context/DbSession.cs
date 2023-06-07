using System;
using System.Data;
using System.Data.SqlClient;

namespace Protractor.Data.Context
{
    public class DbSession : IDisposable
    {
        private readonly string ConnectionString = @"Server=.\SQLEXPRESS; Database=protractor; Trusted_Connection=True;";
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }

        public DbSession()
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection?.Dispose();
        }
    }
}
