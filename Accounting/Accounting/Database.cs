using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Accounting
{
    public class Database
    {
        public class AccountingDatabase : DbContext
        {
            public DbSet<Customer> Customers { get; set; }
        }

        public class Customer
        {
            public  int ID { get; set; }
            public string FullName { get; set; }
            //Colume is added
            public string EMail { get; set; }
        }
    }
}
