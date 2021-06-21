using DapperExtensionsMVC.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DapperExtensionsMVC.Models
{
    public class ConnectionHelper:IConnectionHelper
    {
        private readonly string _connectionString;
        public ConnectionHelper(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
