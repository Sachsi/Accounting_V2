using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public class TabControl
    {
        private static Font tablefont = new Font("tablefont", 18, FontStyle.Bold, GraphicsUnit.Pixel);

        internal static Font Tablefont { get => tablefont; set => tablefont = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        public static void RefreshCustomer(MetroListView listview)
        {
            using (DatabaseContext Db = new DatabaseContext())
            {
                ClearTableCustomer(listview);
                var list = Db.Customers.ToList();
                listview.Font = tablefont;

                foreach (Customer c in list)
                {
                    ListViewItem a = new ListViewItem(c.Date.ToShortDateString());
                    a.SubItems.Add(c.Full_Name);
                    a.SubItems.Add(c.E_Mail);
                    a.SubItems.Add(c.PhoneNr);
                    a.SubItems.Add(c.CSA.ToString());
                    a.SubItems.Add(c.Neighbarhood.ToString());
                    a.SubItems.Add(c.Hors_Barn.ToString());
                    listview.Items.Add(a);
                }
            }
        }
        /// <summary>
        /// cleared the whole table content of table Customer and create 6 new columns
        /// </summary>
        /// <param name="list_Customer"></param>
        private static void ClearTableCustomer(MetroListView list_Customer)
        {
            list_Customer.Clear();
            
            list_Customer.Columns.Add("Date", 150, textAlign: HorizontalAlignment.Left);
            list_Customer.Columns.Add("Full Name", 120, textAlign: HorizontalAlignment.Left);
            list_Customer.Columns.Add("E-Mail Address", 150, textAlign: HorizontalAlignment.Left);
            list_Customer.Columns.Add("Phone Number", 150, textAlign: HorizontalAlignment.Left);
            list_Customer.Columns.Add("CSA", 90, textAlign: HorizontalAlignment.Left);
            list_Customer.Columns.Add("Neighbarhood", 90, textAlign: HorizontalAlignment.Left);
            list_Customer.Columns.Add("Horse Barn", 90, textAlign: HorizontalAlignment.Left);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        public static void RefreshIncome(MetroListView listview)
        {
            
            using (DatabaseContext Db = new DatabaseContext())
            {
                ClearTableIncome(listview);
                var list = Db.Incomes.ToList();
                listview.Font = tablefont;

                foreach (Income c in list)
                {
                    ListViewItem b = new ListViewItem(c.Date.ToShortDateString());
                    try
                    {
                        b.SubItems.Add(c.Customer.Full_Name);
                    }
                    catch (Exception)
                    {///wenn die abgespeicherten Kundennamen nicht mehr vorhanden sind, erscheint Error.
                        b.SubItems.Add("Error");
                    }
                    b.SubItems.Add(c.Payment);
                    b.SubItems.Add(c.Price.ToString("c",ucSetting.CurrencyDefault));
                    b.SubItems.Add(c.Products);
                    listview.Items.Add(b);
                }
            }
        }
        /// <summary>
        /// cleared the whole table content of table Income and create 5 new columns
        /// </summary>
        /// <param name="list_Income"></param>
        private static void ClearTableIncome(MetroListView list_Income)
        {
            list_Income.Clear();

            list_Income.Columns.Add("Date", 150, textAlign: HorizontalAlignment.Left);
            list_Income.Columns.Add("Full Name", 180, textAlign: HorizontalAlignment.Left);
            list_Income.Columns.Add("Payment", 150, textAlign: HorizontalAlignment.Left);
            list_Income.Columns.Add("Price", 100, textAlign: HorizontalAlignment.Left);
            list_Income.Columns.Add("Products", 200, textAlign: HorizontalAlignment.Left);
            //list_Produkts.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        internal static void RefreshProdukt(MetroListView list_Produkts, MetroListView selected_Produkts)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                
                var list = db.Produkts.ToList();

                selected_Produkts.Clear();
                ClearTableProdukts(list_Produkts);
                list_Produkts.Font = tablefont;

                foreach (var item in list)
                {
                    ListViewItem listItems = new ListViewItem(item.Date.ToLongDateString());
                    listItems.SubItems.Add(item.Farmer);
                    listItems.SubItems.Add(item.Produce);
                    listItems.SubItems.Add(item.Price.ToString("c",ucSetting.CurrencyDefault));
                    listItems.SubItems.Add(item.Quantity.ToString());
                    try
                    {
                        listItems.SubItems.Add(item.Units[item.Unit]);
                    }
                    catch (Exception)
                    {
                        item.Unit = 0;
                        listItems.SubItems.Add(item.Units[item.Unit]);
                    }
                    list_Produkts.Items.Add(listItems);
                    selected_Produkts.Items.Add(item.Produce);
                }
            }
        }

        /// <summary>
        /// cleared the whole table content of table Produkts and create 6 new columns
        /// </summary>
        /// <param name="list_Produkts"></param>
        private static void ClearTableProdukts(MetroListView list_Produkts)
        {
            list_Produkts.Clear();
            
            list_Produkts.Columns.Add("Date", 150, textAlign: HorizontalAlignment.Left);
            list_Produkts.Columns.Add("Farmer", 180, textAlign: HorizontalAlignment.Left);
            list_Produkts.Columns.Add("Produce", 150, textAlign: HorizontalAlignment.Left);
            list_Produkts.Columns.Add("Price", 100, textAlign: HorizontalAlignment.Left);
            list_Produkts.Columns.Add("Quantity", 90, textAlign: HorizontalAlignment.Left);
            list_Produkts.Columns.Add("Units", 90, textAlign: HorizontalAlignment.Left);
            //list_Produkts.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list_Expenses"></param>
        public static void RefreshExpenses(MetroListView list_Expenses)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                ClearTableExpenses(list_Expenses);
                var list = db.Expenses.ToList();
                list_Expenses.Font = tablefont;
                foreach (var item in list)
                {
                    ListViewItem listItems = new ListViewItem(item.Date.ToShortDateString());
                    listItems.SubItems.Add(item.Dealer);
                    listItems.SubItems.Add(item.Payment);
                    listItems.SubItems.Add(item.Price.ToString("c",ucSetting.CurrencyDefault));
                    try
                    {
                        listItems.SubItems.Add(item.Details.ToString());
                    }
                    catch (Exception)
                    {
                        listItems.SubItems.Add("No details");
                    }
                    
                    list_Expenses.Items.Add(listItems);
                }
            }
        }

        /// <summary>
        /// cleared the whole table content of table Expenses and create 5 new columns
        /// </summary>
        /// <param name="list_Expenses"></param>
        private static void ClearTableExpenses(MetroListView list_Expenses)
        {
            list_Expenses.Clear();

            list_Expenses.Columns.Add("Date", 150, textAlign: HorizontalAlignment.Left);
            list_Expenses.Columns.Add("Dealer", 180, textAlign: HorizontalAlignment.Left);
            list_Expenses.Columns.Add("Payment", 150, textAlign: HorizontalAlignment.Left);
            list_Expenses.Columns.Add("Price", 100, textAlign: HorizontalAlignment.Left);
            list_Expenses.Columns.Add("Details", 200, textAlign: HorizontalAlignment.Left);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        /// <param name="customer"></param>
        public static void AddCustomer(MetroListView listview, Customer customer)
        {
            ListViewItem a = new ListViewItem(customer.Date.ToShortDateString());
            a.SubItems.Add(customer.Full_Name);
            a.SubItems.Add(customer.E_Mail);
            a.SubItems.Add(customer.PhoneNr);
            a.SubItems.Add(customer.CSA.ToString());
            a.SubItems.Add(customer.Neighbarhood.ToString());
            a.SubItems.Add(customer.Hors_Barn.ToString());
            listview.Items.Add(a);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        /// <param name="income"></param>
        public static void AddIncome(MetroListView listview, Income income)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var customerID = db.Customers.First(c => c.Id == income.Customer_Id);
                ListViewItem a = new ListViewItem(income.Date.ToShortDateString());
                a.SubItems.Add(customerID.Full_Name);
                a.SubItems.Add(income.Payment);
                a.SubItems.Add(income.Price.ToString("c"));
                a.SubItems.Add(income.Products);
                listview.Items.Add(a);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        public static void RemoveRow(MetroListView listview)
        {
            listview.Items.Remove(listview.SelectedItems[0]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list_Expenses"></param>
        /// <param name="obj_Expense"></param>
        public static void AddExpenses(MetroListView list_Expenses, Expense obj_Expense)
        {
            ListViewItem item = new ListViewItem(obj_Expense.Date.ToShortDateString());
            item.SubItems.Add(obj_Expense.Dealer);
            item.SubItems.Add(obj_Expense.Payment);
            item.SubItems.Add(obj_Expense.Price.ToString("c"));
            item.SubItems.Add(obj_Expense.Details.ToString());
            list_Expenses.Items.Add(item);
        }

    }
}
