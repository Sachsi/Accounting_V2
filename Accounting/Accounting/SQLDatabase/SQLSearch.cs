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
        /// 
        /// </summary>
        /// <param name="searchArg"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerName(List<Customer> list, string searchArg)
        {
            List<Customer> customer;

                customer = list;

                customer = (from Name in customer
                            where Name.Full_Name.Contains(searchArg)
                            orderby Name.Date descending
                            select Name).ToList();
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchArg"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerPhone(List<Customer> list, string searchArg)
        {
            List<Customer> customer;

                customer = list;

                customer = (from Name in customer
                            where Name.PhoneNr.Contains(searchArg)
                            orderby Name.Date descending
                            select Name).ToList();
   
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchArg"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerMail(List<Customer> list, string searchArg)
        {
            List<Customer> customer;

                customer = list;

                customer = (from Name in customer
                            where Name.E_Mail.Contains(searchArg)
                            orderby Name.Date descending
                            select Name).ToList();
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerDateAsc(List<Customer> list, DateTime dateTime)
        {
            List<Customer> customer;

                customer = list;

                customer = (from Name in customer
                            where Name.Date > dateTime
                            orderby Name.Date descending
                            select Name).ToList();

            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerDateDes(List<Customer> list, DateTime dateTime)
        {
            List<Customer> customer;

            customer = list;

            customer = (from Name in customer
                        where Name.Date < dateTime
                        orderby Name.Date descending
                        select Name).ToList();

            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerCSA(List<Customer> list, bool csa)
        {
            List<Customer> customer;

                customer = list;

                customer = (from Name in customer
                            where Name.CSA == csa
                            orderby Name.Date descending
                            select Name).ToList();

            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerNeighbarhood(List<Customer> list, bool neighbarhood)
        {
            List<Customer> customer;

                customer = list;

                customer = (from Name in customer
                            where Name.Neighbarhood == neighbarhood
                            orderby Name.Date descending
                            select Name).ToList();
        
            return customer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static List<Customer> SearchCustomerHorseBarn(List<Customer> list, bool horsebar)
        {
            List<Customer> customer;

                customer = list;

                customer = (from Name in customer
                            where Name.Hors_Barn == horsebar
                            orderby Name.Date descending
                            select Name).ToList();
      
            return customer;
        }
        /// <summary>
        /// returns the count of CSA customer dependends on the bool CSA value
        /// </summary>
        /// <param name="list">database list of customer</param>
        /// <param name="CSA">value who the function looks for</param>
        /// <returns></returns>
        public static int CustomerCountCSA( bool CSA)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<Customer> customer = db.Customers.ToList();

                customer = (from Name in customer
                            where Name.CSA == CSA
                            orderby Name.Date descending
                            select Name).ToList();
                return customer.Count;
            }
            
        }
        /// <summary>
        /// returns the count of Neightbourhood customer dependends on the bool Neightbourhood value
        /// </summary>
        /// <param name="list"></param>
        /// <param name="Neightbourhood"></param>
        /// <returns></returns>
        public static int CustomerCountNeightbourhood(List<Customer> list, bool Neightbourhood)
        {
            List<Customer> customer;

            customer = list;

            customer = (from Name in customer
                        where Name.Neighbarhood == Neightbourhood
                        orderby Name.Date descending
                        select Name).ToList();

            return customer.Count;
        }
        /// <summary>
        /// returns the count of HorseBarn customer dependends on the bool HorseBarn value
        /// </summary>
        /// <param name="list"></param>
        /// <param name="HorseBarn"></param>
        /// <returns></returns>
        public static int CustomerCountHorseBarn(List<Customer> list, bool HorseBarn)
        {
            List<Customer> customer;

            customer = list;

            customer = (from Name in customer
                        where Name.Hors_Barn == HorseBarn
                        orderby Name.Date descending
                        select Name).ToList();

            return customer.Count;
        }

        //==============================Income Querys===============================================
        /// <summary>
        /// methode to search for a special name in the Income table. Ordered by date.
        /// </summary>
        /// <param name="searchString">The string what you are searching for</param>
        /// <returns></returns>
        public static List<Income> SearchIncomeName(List<Income> list, string searchString)
        {
            List<Income> income;

                income = list;

                income = (from Name in income
                          where Name.Customer.Full_Name.Contains(searchString)
                            orderby Name.Date descending
                            select Name).ToList();
     
            return income;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Income> SearchIncomeDateAsc(List<Income> list, DateTime date)
        {
            List<Income> income;

                income = list;

                income = (from Name in income
                          where Name.Date > date
                          orderby Name.Customer.Full_Name descending
                          select Name).ToList();

            return income;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="monthe"></param>
        /// <returns></returns>
        public static List<Income> SearchIncomeDateMonth(List<Income> list, int monthe)
        {
            List<Income> income;

            income = list;

            income = (from Name in income
                      where Name.Date.Month == monthe
                      orderby Name.Customer.Full_Name descending
                      select Name).ToList();

            return income;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static List<Income> SearchIncomeDateYear(List<Income> list, int year)
        {
            List<Income> income;

            income = list;

            income = (from Name in income
                      where Name.Date.Year == year
                      orderby Name.Customer.Full_Name descending
                      select Name).ToList();

            return income;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Income> SearchIncomeDateDes(List<Income> list, DateTime date)
        {
            List<Income> income;

            income = list;

            income = (from Name in income
                      where Name.Date < date
                      orderby Name.Customer.Full_Name descending
                      select Name).ToList();

            return income;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<Income> SearchIncomePrice(List<Income> list, double price)
        {
            List<Income> income;

                income = list;

                income = (from Name in income
                          where Name.Price == price
                          orderby Name.Customer.Full_Name descending
                          select Name).ToList();
            return income;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<Income> SearchIncomePriceDesc(List<Income> list, double price)
        {
            List<Income> income;

                income = list;

                income = (from Name in income
                          where Name.Price <= price
                          orderby Name.Customer.Full_Name descending
                          select Name).ToList();
   
            return income;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<Income> SearchIncomePriceAsce(List<Income> list, double price)
        {
            List<Income> income;

                income = list;

                income = (from Name in income
                          where Name.Price >= price
                          orderby Name.Customer.Full_Name descending
                          select Name).ToList();
            return income;
        }
        /// <summary>
        /// search for a product in the product colume in the income table
        /// </summary>
        /// <param name="searchString">string to search</param>
        /// <returns>returns a list with all rows they contains 
        /// in the colume product the searched string</returns>
        public static List<Income> SearchIncomeProduct(List<Income> list, string searchString)
        {
            List<Income> income;

            income = list;

                   income = (from Name in income
                             where Name.Products.Contains(searchString)
                             orderby Name.Customer.Full_Name descending
                             select Name).ToList();
            return income;
        }

   //==============================Expense Querys===============================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static List<Expense> SearchExpenseDetails(List<Expense> list, string searchString)
        {
            List<Expense> expenses;

                expenses = list;

                expenses = (from Name in expenses
                          where Name.Details.Contains(searchString)
                          orderby Name.Date descending
                          select Name).ToList();
            return expenses;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Expense> SearchExpenseDateAsc(List<Expense> list, DateTime date)
        {
            List<Expense> expenses;

                expenses = list;

                expenses = (from Name in expenses
                            where Name.Date >= date
                            orderby Name.Date descending
                            select Name).ToList();

            return expenses;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static List<Expense> SearchExpenseDateYear(List<Expense> list, int year)
        {
            List<Expense> expenses;

            expenses = list;

            expenses = (from Name in expenses
                        where Name.Date.Year == year
                        orderby Name.Date descending
                        select Name).ToList();

            return expenses;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static List<Expense> SearchExpenseDateMonth(List<Expense> list, int month)
        {
            List<Expense> expenses;

            expenses = list;

            expenses = (from Name in expenses
                        where Name.Date.Month == month
                        orderby Name.Date descending
                        select Name).ToList();

            return expenses;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Expense> SearchExpenseDateDes(List<Expense> list, DateTime date)
        {
            List<Expense> expenses;

            expenses = list;

            expenses = (from Name in expenses
                        where Name.Date <= date
                        orderby Name.Date descending
                        select Name).ToList();

            return expenses;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static List<Expense> SearchExpenseDealer(List<Expense> list, string searchString)
        {
            List<Expense> expenses;

                expenses = list;

                expenses = (from Name in expenses
                            where Name.Dealer.Contains(searchString)
                            orderby Name.Date descending
                            select Name).ToList();
            return expenses;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<Expense> SearchExpensePrice(List<Expense> list, double price)
        {
            List<Expense> expenses;

                expenses = list;

                expenses = (from Name in expenses
                            where Name.Price == price
                            orderby Name.Date descending
                            select Name).ToList();
            return expenses;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<Expense> SearchExpensePriceDesc(List<Expense> list, double price)
        {
            List<Expense> expenses;

                expenses = list;

                expenses = (from Name in expenses
                            where Name.Price <= price
                            orderby Name.Date descending
                            select Name).ToList();
 
            return expenses;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<Expense> SearchExpensePriceAsc(List<Expense> list, double price)
        {
            List<Expense> expenses;

                expenses = list;

                expenses = (from Name in expenses
                            where Name.Price >= price
                            orderby Name.Date descending
                            select Name).ToList();

            return expenses;
        }
        //==============================Products Querys===============================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<Produkt> SearchProductsPriceAsc(List<Produkt> list, double price)
        {
            List<Produkt> products;
                products = list;

                products = (from Name in products
                            where Name.Price >= price
                            orderby Name.Price descending
                            select Name).ToList();
            return products;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<Produkt> SearchProductsPriceDesc(List<Produkt> list, double price)
        {
            List<Produkt> products;
                products = list;

                products = (from Name in products
                            where Name.Price <= price
                            orderby Name.Price descending
                            select Name).ToList();
            return products;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Produkt> SearchProductsDateAsc(List<Produkt> list, DateTime date)
        {
            List<Produkt> products;

                products = list;

                products = (from Name in products
                            where Name.Date > date
                            orderby Name.Date descending
                            select Name).ToList();

            return products;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Produkt> SearchProductsDateDes(List<Produkt> list, DateTime date)
        {
            List<Produkt> products;

            products = list;

            products = (from Name in products
                        where Name.Date < date
                        orderby Name.Date descending
                        select Name).ToList();

            return products;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searcharg"></param>
        /// <returns></returns>
        public static List<Produkt> SearchProductsFarmer(List<Produkt> list, string searcharg)
        {
            List<Produkt> products;
  
                products = list;

                products = (from Name in products
                            where Name.Farmer.Contains(searcharg)
                            orderby Name.Date descending
                            select Name).ToList();
   
            return products;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searcharg"></param>
        /// <returns></returns>
        public static List<Produkt> SearchProductsProduce(List<Produkt> list, string searcharg)
        {
            List<Produkt> products;

                products = list;

                products = (from Name in products
                            where Name.Produce.Contains(searcharg)
                            orderby Name.Date descending
                            select Name).ToList();

            return products;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static List<Produkt> SearchProductsUnit(List<Produkt> list, string unit)
        {
            List<Produkt> products;

                products = list;

                products = (from Name in products
                            where Name.Units[Name.Unit] == unit
                            orderby Name.Date descending
                            select Name).ToList();
           return products;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public static List<Produkt> SearchProductsQuantityAsc(List<Produkt> list, double quantity)
        {
            List<Produkt> products;

                products = list;

                products = (from Name in products
                            where Name.Quantity >= quantity
                            orderby Name.Quantity descending
                            select Name).ToList();

            return products;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public static List<Produkt> SearchProductsQuantityDesc(List<Produkt> list, double quantity)
        {
            List<Produkt> products;

                products = list;

                products = (from Name in products
                            where Name.Quantity <= quantity
                            orderby Name.Quantity descending
                            select Name).ToList();
 
            return products;
        }
    }
}
