using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Accounting.Database;

namespace Accounting.Data
{
    public class DummyData
    {
        /// <summary>
        /// dummy list for cutomer table
        /// </summary>
        /// <returns>entries of customer table in a list of getCustomer</returns>
        public static List<Customer> getCutomer()
        {
            List<Customer> Customers = new List<Customer>()
            {
                 new Customer()
                {
                    FullName = "Tobias Sachse",
                    EMail = "tobisachse27@msn.com",
                    Phone = 064101523,
                    CSA = true,
                    Horse_Barn = false,
                    Neighborhood = false,
                    Date = DateTime.Now,
                },
                new Customer()
                {
                    FullName = "Ute Sachse",
                    EMail = "sachsefamily@msn.com",
                    Phone = 03431614176,
                    CSA = true,
                    Horse_Barn = false,
                    Neighborhood = false,
                    Date = DateTime.Now,
                },
                new Customer()
                {
                    FullName = "Max Mustermann",
                    EMail = "maxmusterman@web.com",
                    Phone = 049126958665,
                    CSA = false,
                    Horse_Barn = false,
                    Neighborhood = false,
                    Date = DateTime.Parse("25.05.2016")
                },
               
            };
            return Customers;
        }     

        /// <summary>
        /// dummy Income table with three enteties
        /// </summary>
        /// <returns></returns>
        public static List<Income> getIncome(AccountingDatabase Context)
        {
            List<Income> Incomes = new List<Income>()
            {
                new Income()
                {
                    Date = DateTime.Now,
                    Payment = "Chash",
                    CustomerName = Context.Customers.Find("Tobias Sachse").FullName,
                    Product = Context.Products.Find("Garlic").ProductName,
                    Price = 25.2,
                },
                new Income()
                {
                    Date = DateTime.Now,
                    Payment = "debit",
                    CustomerName = Context.Customers.Find("Marcel Sachse").FullName,
                    Product = Context.Products.Find("Leek").ProductName,
                    Price = 10.2,
                },
                new Income()
                {
                    Date = DateTime.Now,
                    Payment = "Credit",
                    CustomerName = Context.Customers.Find("Ute Sachse").FullName,
                    Product = Context.Products.Find("Leek").ProductName,
                    Price = 9.99,
                },
            };
            return Incomes;
        }

        /// <summary>
        /// dummy Product table of three enteties
        /// </summary>
        /// <returns></returns>
        public static List<Product> getProduts()
        {
            List<Product> Products = new List<Product>()
            {
                new Product
                {
                    Date = DateTime.Parse("07.06.2017"),
                    ProductName = "Leek",
                },
                new Product
                {
                    Date = DateTime.Parse("10.09.2017"),
                    ProductName = "Garlic",
                },
                new Product
                {
                    Date = DateTime.Parse("15.07.2017"),
                    ProductName = "Straberry",
                },
            };
            return Products;
        }
    }
}
