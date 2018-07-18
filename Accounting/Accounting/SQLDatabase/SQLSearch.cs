using Accounting.SQLClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.SQLDatabase
{
    public class SQLSearch : ISearchInDB
    {
        public List<DbSet> SearchInDatabase { get { return searchInDatabase; } set { searchInDatabase = value; } }
        private List<DbSet> searchInDatabase;
        public List<DbSet> SearchResult { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchFor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// methode to search for a special name in the Income table. Ordered by date.
        /// </summary>
        /// <param name="db">the table in which you want to search</param>
        /// <param name="searchFor">The string what you are searching for</param>
        /// <returns></returns>
        public static List<Income> SearchForNameIncome(DatabaseContext db, string searchFor)
        {
            List<Income> list;
            IEnumerable<Income> b;
            b = from c in db.Incomes
                where c.Customer.Full_Name == searchFor
                orderby c.Date descending
                select c;
            list = b.ToList();
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchArg"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerName(string searchArg)
        {
            List<Customer> customer;
            using (DatabaseContext db = new DatabaseContext())
            {
                customer = db.Customers.ToList();

                customer = (from Name in customer
                            where Name.Full_Name.Contains(searchArg)
                            orderby Name.Date descending
                            select Name).ToList();
            }
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchArg"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerPhone(string searchArg)
        {
            List<Customer> customer;
            using (DatabaseContext db = new DatabaseContext())
            {
                customer = db.Customers.ToList();

                customer = (from Name in customer
                            where Name.PhoneNr.Contains(searchArg)
                            orderby Name.Date descending
                            select Name).ToList();
            }
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchArg"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerMail(string searchArg)
        {
            List<Customer> customer;
            using (DatabaseContext db = new DatabaseContext())
            {
                customer = db.Customers.ToList();

                customer = (from Name in customer
                            where Name.E_Mail.Contains(searchArg)
                            orderby Name.Date descending
                            select Name).ToList();
            }
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerDate(DateTime dateTime)
        {
            List<Customer> customer;
            using (DatabaseContext db = new DatabaseContext())
            {
                customer = db.Customers.ToList();

                customer = (from Name in customer
                            where Name.Date == dateTime
                            orderby Name.Date descending
                            select Name).ToList();
            }
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerCSA(bool csa)
        {
            List<Customer> customer;
            using (DatabaseContext db = new DatabaseContext())
            {
                customer = db.Customers.ToList();

                customer = (from Name in customer
                            where Name.CSA == csa
                            orderby Name.Date descending
                            select Name).ToList();
            }
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerNeighbarhood(bool neighbarhood)
        {
            List<Customer> customer;
            using (DatabaseContext db = new DatabaseContext())
            {
                customer = db.Customers.ToList();

                customer = (from Name in customer
                            where Name.Neighbarhood == neighbarhood
                            orderby Name.Date descending
                            select Name).ToList();
            }
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerHorseBarn(bool horsebar)
        {
            List<Customer> customer;
            using (DatabaseContext db = new DatabaseContext())
            {
                customer = db.Customers.ToList();

                customer = (from Name in customer
                            where Name.Hors_Barn == horsebar
                            orderby Name.Date descending
                            select Name).ToList();
            }
            return customer;
        }
    }
}
