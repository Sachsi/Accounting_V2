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
            public DbSet<Income> Incomes { get; set; }
            public DbSet<Produce> Produces { get; set; }

        }

        public class Customer
        {
            public  int ID { get; set; }
            public string FullName { get; set; }
            //Colume is added because of the ADD-Migration tool
            public string EMail { get; set; }
            public ulong Phone { get; set; }

            public virtual List<Income> Incomes { get; set; }

            public Customer()
            {
                this.Incomes = new List<Income>();
            }
        }

        public class Income
        {
            public int ID { get; set; }
            public double Price  { get; set; }
            //add this colume later
            //public DateTime Date { get; set; }
            public virtual Produce Proudces { get; set; }

            public virtual Customer CustomerName { get; set; }
        }
        public class Produce
        {
            public int ID { get; set; }
            public string ProduceName { get; set; }

            public virtual List<Income> Incomes { get; set; }

            public Produce()
            {
                this.Incomes = new List<Income>();
            }
        }
    }
}
