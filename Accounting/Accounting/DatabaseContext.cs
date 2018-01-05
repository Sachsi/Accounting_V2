using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{


    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name= AccountingDatabase") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Income> Incomes { get; set; }
    }
}
