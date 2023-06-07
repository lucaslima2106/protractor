using System;
using System.Data;
using System.Data.SqlClient;

namespace Protractor.Infra.Context
{
    public class DbSession : IDisposable
    {
        private readonly string ConnectionString = @"Data Source=LAPTOP-67G84V8M\lucas\\sqlexpress;Initial Catalog=protractor;Integrated Security=True";
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
