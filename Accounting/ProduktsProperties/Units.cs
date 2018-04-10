using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
     public class Units
    {
        /// <summary>
        /// Unit Piece
        /// </summary>
        public List<string> Unit { get { return new List<string>() { "Piece", "Gramm", "Pound" }; } }
    }
}
