using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.SQLDatabase
{
    public struct SearchDetails
    {
        public string searchstring;
        public int ArgumentNr;
        public int ColumIndex;

        public bool DateTimeConverter(out DateTime date)
        {
            if (DateTime.TryParse(searchstring, out date))
                return true;           
            else
                return false;
        }

        public Accounting.DatabaseContext tabel;


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
