using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperExtensionsMVC.Interfaces
{
    public interface IConnectionHelper
    {
        IDbConnection GetConnection();
    }
}
