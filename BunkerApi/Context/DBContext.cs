using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace BunkerApi.Context
{
    public class DBContext : IDisposable
    {
        private readonly IConfiguration _configuration;
        private readonly string? _connectionString;
        private IDbConnection _connection { get; set; }

        public DBContext(IConfiguration configuration) 
        { 
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Default");

            if (_connection == null)
            {
                _connection = new MySqlConnection(_connectionString);
            }
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }
        public IDbConnection Connection()
        {
            return _connection;
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}
