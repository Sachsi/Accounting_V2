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
    }
}
