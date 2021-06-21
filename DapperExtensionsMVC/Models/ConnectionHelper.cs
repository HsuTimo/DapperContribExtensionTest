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
        private readonly IConfiguration _configuration;
        public ConnectionHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection GetConnection(string name)
        {
            return new SqlConnection(_configuration.GetConnectionString(name));
        }
    }
}
