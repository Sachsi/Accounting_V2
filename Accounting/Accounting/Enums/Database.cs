using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Enums
{
    enum Table : int
    {
        Customer = 0,
        Income,
        Expenses,
        Products
    }

    enum CustomerColums : int
    {
        Date     = 0,
        FullName = 1,
        EMail    = 2,
        Phone       ,
        CSA         ,
        HorsBarn    ,
        Neigtbar    ,
    }

    enum IncomeColuems : int
    {
        Date    = 0 ,
        FullName    ,
        Price       ,
        Products    ,
    }

    enum ExpensesColums : int
    {
        Date    = 0,
        Dealer      ,
        Price       ,
        Details     ,
    }

    enum ProductColums : int
    {
        Date     = 0,
        Farmer      ,
        Produce     ,
        Price       ,
        Quantity    ,
        Unit        ,
    }
}
