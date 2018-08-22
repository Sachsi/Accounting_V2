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
        None    = 0,
        Date_Des    ,
        Date_Asc,
        FullName ,
        EMail    ,
        Phone       ,
        CSA         ,
        HorsBarn    ,
        Neigtbar    ,
    }

    enum IncomeColuems : int
    {
        None    = 0,
        Date_Des,
        Date_Asc,
        FullName    ,
        Price       ,
        Products    ,
        Price_Des   ,
        Price_Asc
    }

    enum ExpensesColums : int
    {
        None = 0,
        Date_Des,
        Date_Asc,
        Dealer      ,
        Price       ,
        Details     ,
        Price_Des   ,
        Price_Asc
    }

    enum ProductColums : int
    {
        None = 0,
        Date_Des,
        Date_Asc,
        Farmer      ,
        Produce     ,
        Price_Des   ,
        Price_Asc   ,
        Quantity_Des,
        Quantity_Asc,
        Unit        ,
    }
}
