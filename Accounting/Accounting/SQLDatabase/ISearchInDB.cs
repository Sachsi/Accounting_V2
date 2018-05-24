using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.SQLClient
{
    interface ISearchInDB
    {
        /// <summary>
        /// Database in which you want to search for something.
        /// </summary>
        List<DbSet> SearchInDatabase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        List<DbSet> SearchResult { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string SearchFor { get; set; }


    }
}
