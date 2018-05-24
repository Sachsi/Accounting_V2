using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.SQLClient
{
    public interface IDatabase
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; }
        string DataSource { get; set; }
    }
}
