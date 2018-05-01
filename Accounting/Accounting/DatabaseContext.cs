using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.Properties;

namespace Accounting
{


    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// konstructor to initialze your Entity Frame Code First Datebase. The Database will created on known path.
        /// The path in the cónnection String.
        /// </summary>
        public DatabaseContext() : base("name = AccountingDatabase")
        {
            if (Settings.Default.FirstStart == true)
            {
                Database.SetInitializer<DatabaseContext>(new DropCreateDatabaseAlways<DatabaseContext>());
                Settings.Default.FirstStart = false;
                Settings.Default.Save();
            }
            else
                Database.SetInitializer<DatabaseContext>(new DropCreateDatabaseIfModelChanges<DatabaseContext>());
        }

        public DatabaseContext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Produkt> Produkts { get; set; }
    }
}
