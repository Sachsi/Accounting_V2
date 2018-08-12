using Accounting.Enums;
using Accounting.SQLDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Accounting
{
    public partial class ucSearch : MetroFramework.Controls.MetroUserControl
    {
        public string[] tableName = new string[4];
        public string[] CustomColumName = new string[9];
        public string[] IncomeColumName = new string[8];
        public string[] ExpensesColumName = new string[8];
        public string[] ProductsColumName = new string[10];

        List<Income> income = new List<Income>();
        List<Expense> expense = new List<Expense>();
        List<Produkt> produkt = new List<Produkt>();
        List<Customer> customer = new List<Customer>();

        public SearchDetails[] searchDetails = new SearchDetails[4];

        /// <summary>
        /// Number of the maximum search arguments
        /// </summary>
        private int CountSearchArguments = 0;
        private int MAXCountOfArguments = 4;
        /// <summary>
        /// 
        /// </summary>
        public ucSearch()
        {
            InitializeComponent();

            tableName[0] = "Customer"; tableName[1] = "Income";  tableName[2] = "Expenses";  tableName[3] = "Products";

            CustomColumName[0] = " "; CustomColumName[1] = "Date <"; CustomColumName[2] = "Date >"; CustomColumName[3] = "Full Name"; CustomColumName[4] = "E-Mail Address";
            CustomColumName[5] = "Phone Number"; CustomColumName[6] = "CSA"; CustomColumName[7] = "Horse Barn";
            CustomColumName[8] = "Neightbarhood";

            IncomeColumName[0] = " "; IncomeColumName[1] = "Date <"; IncomeColumName[2] = "Date >"; IncomeColumName[3] = "Full Name"; IncomeColumName[4] = "Price";
            IncomeColumName[5] = "Products"; IncomeColumName[6] = "Price <"; ; IncomeColumName[7] = "Price >";

            ExpensesColumName[0] = " "; ExpensesColumName[1] = "Date <"; ExpensesColumName[2] = "Date >"; ExpensesColumName[3] = "Dealer";
            ExpensesColumName[4] = "Price"; ExpensesColumName[5] = "Details"; ExpensesColumName[6] = "Price <"; ExpensesColumName[7] = "Price >";

            ProductsColumName[0] = " "; ProductsColumName[1] = "Date <"; ProductsColumName[2] = "Date >"; ProductsColumName[3] = "Farmer";
            ProductsColumName[4] = "Produce"; ProductsColumName[5] = "Price <";ProductsColumName[6] = "Price >"; ProductsColumName[7] = "Quantity <";
            ProductsColumName[8] = "Quantity >"; ProductsColumName[9] = "Unit";

            ClearAllArguemntTextBox();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucSearch_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < tableName.Length; i++)
            {
                mCB_SelectTable.Items.Add(tableName[i]);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableSelected(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroListView temp = new MetroFramework.Controls.MetroListView();
            using (Accounting.DatabaseContext db = new DatabaseContext())
            {
                
                switch (mCB_SelectTable.SelectedIndex)
                {
                    case (int)Table.Customer:
                        TabControl.RefreshCustomer(List_Search);
                        LoadAllArguments(Table.Customer);

                        break;
                    case (int)Table.Income:
                        TabControl.RefreshIncome(List_Search);
                        LoadAllArguments(Table.Income);
                        income = db.Incomes.ToList();
      
                        break;
                    case (int)Table.Expenses:
                        TabControl.RefreshExpenses(List_Search);
                        LoadAllArguments(Table.Expenses);
           
                        break;
                    case (int)Table.Products:
                        TabControl.RefreshProdukt(List_Search, temp);
                        LoadAllArguments(Table.Products);
               
                        break;
                    default:
                        break;
                }
                ClearFilter();
            }
        }
        /// <summary>
        /// reload all metro comboboxes with the colums names to selected. Dependend of the selected table. 
        /// </summary>
        /// <param name="table">selected table</param>
        private void LoadAllArguments(Table table)
        {
            ClearAllArgumentComboBox();
            ClearAllArguemntTextBox();

            switch (table)
            {
                case Table.Customer:
                    for (int i = 0; i < CustomColumName.Length; i++)
                    {
                        metroComboBox2.Items.Add(CustomColumName[i]);
                        metroComboBox3.Items.Add(CustomColumName[i]);
                        metroComboBox4.Items.Add(CustomColumName[i]);
                        metroComboBox5.Items.Add(CustomColumName[i]);
                    }
                    break;
                case Table.Income:
                    for (int i = 0; i < IncomeColumName.Length; i++)
                    {
                        metroComboBox2.Items.Add(IncomeColumName[i]);
                        metroComboBox3.Items.Add(IncomeColumName[i]);
                        metroComboBox4.Items.Add(IncomeColumName[i]);
                        metroComboBox5.Items.Add(IncomeColumName[i]);
                    }
                    break;
                case Table.Expenses:
                    for (int i = 0; i < ExpensesColumName.Length; i++)
                    {
                        metroComboBox2.Items.Add(ExpensesColumName[i]);
                        metroComboBox3.Items.Add(ExpensesColumName[i]);
                        metroComboBox4.Items.Add(ExpensesColumName[i]);
                        metroComboBox5.Items.Add(ExpensesColumName[i]);
                    }
                    break;
                case Table.Products:
                    for (int i = 0; i < ProductsColumName.Length; i++)
                    {
                        metroComboBox2.Items.Add(ProductsColumName[i]);
                        metroComboBox3.Items.Add(ProductsColumName[i]);
                        metroComboBox4.Items.Add(ProductsColumName[i]);
                        metroComboBox5.Items.Add(ProductsColumName[i]);
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clear all argument combo boxes to reload those.
        /// </summary>
        private void ClearAllArgumentComboBox()
        {
            metroComboBox2.Items.Clear();
            metroComboBox3.Items.Clear();
            metroComboBox4.Items.Clear();
            metroComboBox5.Items.Clear();
        }

        /// <summary>
        /// Disable and reset all search argument boxes
        /// </summary>
        private void ClearFilter()
        {
            
            ClearAllArguemntTextBox();

            metroComboBox2.SelectedIndex = 0;
            metroComboBox3.SelectedIndex = 0;
            metroComboBox4.SelectedIndex = 0;
            metroComboBox5.SelectedIndex = 0;

        }
        /// <summary>
        /// clear all four search text boxes
        /// </summary>
        private void ClearAllArguemntTextBox()
        {
            mTB_SearchArg1.Clear();
            mTB_SearchArg2.Clear();
            mTB_SearchArg3.Clear();
            mTB_SearchArg4.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        private void EnableNextSearchBox()
        {
 
            if (metroComboBox2.SelectedIndex > (int)ErrorState.Nothing)
            {
                searchDetails[0].searchstring = mTB_SearchArg1.Text;
                searchDetails[0].ColumIndex = metroComboBox2.SelectedIndex;
                searchDetails[0].ArgumentNr = 1;

                if (CountSearchArguments < 1)
                    CountSearchArguments = 1;
            }

            if (metroComboBox3.SelectedIndex > (int)ErrorState.Nothing)
            {
                searchDetails[1].searchstring = mTB_SearchArg2.Text;
                searchDetails[1].ColumIndex = metroComboBox3.SelectedIndex;
                searchDetails[1].ArgumentNr = 2;

                if (CountSearchArguments < 2)
                    CountSearchArguments = 2;
            }

            if (metroComboBox4.SelectedIndex > (int)ErrorState.Nothing)
            {
                searchDetails[2].searchstring = mTB_SearchArg3.Text;
                searchDetails[2].ColumIndex = metroComboBox4.SelectedIndex;
                searchDetails[2].ArgumentNr = 3;

                if (CountSearchArguments < 3)
                    CountSearchArguments = 3;
            }

            if (metroComboBox5.SelectedIndex > (int)ErrorState.Nothing)
            {
                searchDetails[3].searchstring = mTB_SearchArg4.Text;
                searchDetails[3].ColumIndex = metroComboBox5.SelectedIndex;
                searchDetails[3].ArgumentNr = 4;
                if (CountSearchArguments < 4)
                    CountSearchArguments = 4;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Search_Click(object sender, EventArgs e)
        {
            EnableNextSearchBox();
            using (DatabaseContext db = new DatabaseContext())
            {
                 switch (mCB_SelectTable.SelectedIndex)
                 {
                     case (int)Table.Customer:
                        customer = db.Customers.ToList();
                         for(int i = 0; i < CountSearchArguments; i++)
                         {
                             SelectColumCustomer(searchDetails[i]);
                         }
                        LoadCustomerList(customer);
                         break;
                     case (int)Table.Income:
                        income = db.Incomes.ToList();
                         for (int i = 0; i < CountSearchArguments; i++)
                         {
                             SelectColumIncome(searchDetails[i]);
                         }
                         LoadIncomeList(income);
                         break;
                     case (int)Table.Expenses:
                        expense = db.Expenses.ToList();
                         for (int i = 0; i < CountSearchArguments; i++)
                         {
                             SelectColumExpenses(searchDetails[i]);
                         }
                         LoadExpensesList(expense);
                         break;
                     case (int)Table.Products:
                        produkt = db.Produkts.ToList();
                         for (int i = 0; i < CountSearchArguments; i++)
                         {
                             SelectColumProduce(searchDetails[i]);
                         }
                         LoadProductList(produkt);
                         break;
                     default:
                         MetroFramework.MetroMessageBox.Show(this, "No table selected! Please select one table.", 
                                             "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         break;
                 }

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchDetails"></param>
        private void SelectColumExpenses(SearchDetails searchDetails)
        {
            double temp;
            DateTime dateTime;
            switch (searchDetails.ColumIndex)
            {
                case (int)ExpensesColums.Date_Asc:
                    if (searchDetails.DateTimeConverter(out dateTime))
                    {
                        expense = SQLSearch.SearchExpenseDateAsc(expense,dateTime);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct date!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ExpensesColums.Date_Des:
                    if (searchDetails.DateTimeConverter(out dateTime))
                    {
                        expense = SQLSearch.SearchExpenseDateDes(expense, dateTime);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct date!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ExpensesColums.Dealer:
                    expense = SQLSearch.SearchExpenseDealer(expense,searchDetails.searchstring);
                    break;
                case (int)ExpensesColums.Price:
                    if (double.TryParse(searchDetails.searchstring, out temp))
                    {
                        expense = SQLSearch.SearchExpensePrice(expense,temp);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ExpensesColums.Details:
                    expense = SQLSearch.SearchExpenseDetails(expense,searchDetails.searchstring);
                    break;
                case (int)ExpensesColums.Price_Des:
                    if (double.TryParse(searchDetails.searchstring, out temp))
                    {
                        expense = SQLSearch.SearchExpensePriceDesc(expense,temp);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ExpensesColums.Price_Asc:
                    if (double.TryParse(searchDetails.searchstring, out temp))
                    {
                        expense = SQLSearch.SearchExpensePriceAsc(expense,temp);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        private void SelectColumIncome(SearchDetails searchDetails)
        {
            double temp;
            DateTime dateTime;
            switch (searchDetails.ColumIndex)
            {
                case (int)IncomeColuems.Date_Asc:
                    
                    if (searchDetails.DateTimeConverter(out dateTime))
                    {
                        income = SQLSearch.SearchIncomeDateAsc(income, dateTime);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct date!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)IncomeColuems.Date_Des:

                    if (searchDetails.DateTimeConverter(out dateTime))
                    {
                        income = SQLSearch.SearchIncomeDateDes(income, dateTime);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct date!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)IncomeColuems.FullName:
                    income = SQLSearch.SearchIncomeName(income,searchDetails.searchstring);
                    break;
                case (int)IncomeColuems.Price:

                    if (double.TryParse(searchDetails.searchstring, out temp))
                    {
                        income = SQLSearch.SearchIncomePrice(income,temp);
                    }else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)IncomeColuems.Products:
                    income = SQLSearch.SearchIncomeProduct(income,searchDetails.searchstring);
                    break;
                case (int)IncomeColuems.Price_Des:
                    if (double.TryParse(searchDetails.searchstring, out temp))
                    {
                        income = SQLSearch.SearchIncomePriceDesc(income,temp);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)IncomeColuems.Price_Asc:
                    if (double.TryParse(searchDetails.searchstring, out temp))
                    {
                        income = SQLSearch.SearchIncomePriceAsce(income,temp);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        private void SelectColumCustomer(SearchDetails searchDetails)
        {
            bool result;
            DateTime dateTime;
            switch (searchDetails.ColumIndex)
            {
                case (int)CustomerColums.Date_Asc:
                    if (searchDetails.DateTimeConverter(out dateTime))
                    {
                        customer = SQLSearch.SearchCustomerDateAsc(customer,dateTime);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct date!","Information",  
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)CustomerColums.Date_Des:
                    
                    if (searchDetails.DateTimeConverter(out dateTime))
                    {
                        customer = SQLSearch.SearchCustomerDateDes(customer, dateTime);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct date!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)CustomerColums.FullName:
                    customer = SQLSearch.SearchCustomerName(customer,searchDetails.searchstring);
                    break;
                case (int)CustomerColums.EMail:
                    customer = SQLSearch.SearchCustomerMail(customer,searchDetails.searchstring);
                    break;
                case (int)CustomerColums.Phone:
                    customer = SQLSearch.SearchCustomerPhone(customer,searchDetails.searchstring);
                    break;
                case (int)CustomerColums.CSA:
                    if(bool.TryParse(searchDetails.searchstring, out result))
                        customer = SQLSearch.SearchCustomerCSA(customer,result);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter true or false!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)CustomerColums.HorsBarn:
                    if(bool.TryParse(searchDetails.searchstring, out result))
                        customer = SQLSearch.SearchCustomerHorseBarn(customer,result);
                     else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter true or false!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)CustomerColums.Neigtbar:
                    if(bool.TryParse(searchDetails.searchstring, out result))
                        customer = SQLSearch.SearchCustomerNeighbarhood(customer,result);
                     else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter true or false!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchDetails"></param>
        private void SelectColumProduce(SearchDetails searchDetails)
        {
            double temp;
            DateTime dateTime;
            switch (searchDetails.ColumIndex)
            {
                case (int)ProductColums.Date_Asc:
                   
                    if (searchDetails.DateTimeConverter(out dateTime))
                    {
                        produkt = SQLSearch.SearchProductsDateAsc(produkt, dateTime);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct date!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ProductColums.Date_Des:
                   
                    if (searchDetails.DateTimeConverter(out dateTime))
                    {
                        produkt = SQLSearch.SearchProductsDateDes(produkt, dateTime);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct date!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ProductColums.Farmer:
                    produkt = SQLSearch.SearchProductsFarmer(produkt,searchDetails.searchstring);
                    break;
                case (int)ProductColums.Produce:
                    produkt = SQLSearch.SearchProductsProduce(produkt,searchDetails.searchstring);
                    break;
                case (int)ProductColums.Price_Asc:
                    if(double.TryParse(searchDetails.searchstring, out temp))
                    {
                        produkt = SQLSearch.SearchProductsPriceAsc(produkt,temp);
                    }else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ProductColums.Price_Des:
                    if (double.TryParse(searchDetails.searchstring, out temp))
                    {
                        produkt = SQLSearch.SearchProductsPriceDesc(produkt,temp);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ProductColums.Unit:
                        produkt = SQLSearch.SearchProductsUnit(produkt,searchDetails.searchstring);
                    break;
                case (int)ProductColums.Quantity_Asc:
                    if (double.TryParse(searchDetails.searchstring, out temp))
                    {
                        produkt = SQLSearch.SearchProductsQuantityAsc(produkt,temp);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ProductColums.Quantity_Des:
                    if (double.TryParse(searchDetails.searchstring, out temp))
                    {
                        produkt = SQLSearch.SearchProductsQuantityDesc(produkt,temp);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct dezimal number!", "Information",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// clear the current list view and load it with the customer entites
        /// </summary>
        /// <param name="customer">new customer list to load</param>
        private void LoadCustomerList(List<Customer> customer)
        {  
                List_Search.Items.Clear();

                foreach (Customer item in customer)
                {
                    ListViewItem b = new ListViewItem(item.Date.ToShortDateString());
                    b.SubItems.Add(item.Full_Name);
                    b.SubItems.Add(item.E_Mail);
                    b.SubItems.Add(item.PhoneNr);
                    b.SubItems.Add(item.CSA.ToString());
                    b.SubItems.Add(item.Neighbarhood.ToString());
                    b.SubItems.Add(item.Hors_Barn.ToString());
                    List_Search.Items.Add(b);
                }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="income"></param>
        private void LoadIncomeList(List<Income> income)
        {
            List_Search.Items.Clear();

            foreach (Income item in income)
            {
                ListViewItem b = new ListViewItem(item.Date.ToShortDateString());
                b.SubItems.Add(item.Customer.Full_Name);
                b.SubItems.Add(item.Payment);
                b.SubItems.Add(item.Price.ToString("c", ucSetting.CurrencyDefault));
                b.SubItems.Add(item.Products);
                List_Search.Items.Add(b);
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expenses"></param>
        private void LoadExpensesList(List<Expense> expenses)
        {
            List_Search.Items.Clear();

            foreach (Expense item in expenses)
            {
                ListViewItem b = new ListViewItem(item.Date.ToShortDateString());
                b.SubItems.Add(item.Dealer);
                b.SubItems.Add(item.Payment);
                b.SubItems.Add(item.Price.ToString("c", ucSetting.CurrencyDefault));
                b.SubItems.Add(item.Details);
                List_Search.Items.Add(b);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="producs"></param>
        private void LoadProductList(List<Produkt> producs)
        {
            List_Search.Items.Clear();

            foreach (Produkt item in producs)
            {
                ListViewItem b = new ListViewItem(item.Date.ToShortDateString());
                b.SubItems.Add(item.Farmer);
                b.SubItems.Add(item.Produce);
                b.SubItems.Add(item.Price.ToString("c", ucSetting.CurrencyDefault));
                b.SubItems.Add(item.Quantity.ToString());
                b.SubItems.Add(item.Units[item.Unit]);
                List_Search.Items.Add(b);
            }
        }

        /// <summary>
        /// Relaod Database table with all his entries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_RelaodDB_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroListView temp =new MetroFramework.Controls.MetroListView();
            using (Accounting.DatabaseContext db = new DatabaseContext())
            {
                switch (mCB_SelectTable.SelectedIndex)
                {
                    case (int)Table.Customer:
                        TabControl.RefreshCustomer(List_Search);
                        break;
                    case (int)Table.Expenses:
                        TabControl.RefreshExpenses(List_Search);
                        break;
                    case (int)Table.Income:
                        TabControl.RefreshIncome(List_Search);
                        income = db.Incomes.ToList();
                    break;
                    case (int)Table.Products:
                        TabControl.RefreshProdukt(List_Search, temp);
                        break;
                    default:
                        break;
                }
            }

        }

        private void mB_Print_Click(object sender, EventArgs e)
        {
            Accounting.ReportViewer reports = new ReportViewer();


            reports.Show();
        }
    }
}
