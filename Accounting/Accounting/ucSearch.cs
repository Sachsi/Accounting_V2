using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Enums;
using Accounting.SQLDatabase;

namespace Accounting
{
    public partial class ucSearch : MetroFramework.Controls.MetroUserControl
    {
        public string[] tableName = new string[4];
        public string[] CustomColumName = new string[7];
        public string[] IncomeColumName = new string[4];
        public string[] ExpensesColumName = new string[4];
        public string[] ProductsColumName = new string[6];

        List<Income> income = new List<Income>();
        List<Expense> epxpense = new List<Expense>();
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

            CustomColumName[0] = "Date"; CustomColumName[1] = "Full Name"; CustomColumName[2] = "E-Mail Address";
            CustomColumName[3] = "Phone Number"; CustomColumName[4] = "CSA"; CustomColumName[5] = "Horse Barn";
            CustomColumName[6] = "Neightbarhood";

            IncomeColumName[0] = "Date"; IncomeColumName[1] = "Full Name"; IncomeColumName[2] = "Price"; IncomeColumName[3] = "Products";

            ExpensesColumName[0] = "Date"; ExpensesColumName[1] = "Dealer"; ExpensesColumName[2] = "Price"; ExpensesColumName[3] = "Details";

            ProductsColumName[0] = "Date"; ProductsColumName[1] = "Farmer"; ProductsColumName[2] = "Produce"; ProductsColumName[3] = "Price";
            ProductsColumName[4] = "Quantity"; ProductsColumName[5] = "Unit";

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
            using (Accounting.DatabaseContext db = new DatabaseContext())
            {
                switch (mCB_SelectTable.SelectedIndex)
                {
                    case (int)Table.Customer:
                        TabControl.RefreshCustomer(List_Search);
                        LoadAllArguments(Table.Customer);
                        mP_SearchArg1.Enabled = true;
                        break;
                    case (int)Table.Income:
                        TabControl.RefreshIncome(List_Search);
                        LoadAllArguments(Table.Income);
                        mP_SearchArg1.Enabled = true;
                        break;
                    case (int)Table.Expenses:
                        TabControl.RefreshExpenses(List_Search);
                        LoadAllArguments(Table.Expenses);
                        mP_SearchArg1.Enabled = true;
                        break;
                    case (int)Table.Products:
                        TabControl.RefreshProdukt(List_Search, List_Search);
                        LoadAllArguments(Table.Products);
                        mP_SearchArg1.Enabled = true;
                        break;
                    default:
                        DisableAllSearchArg();
                        break;
                }
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
        /// Disable all search argument boxes
        /// </summary>
        private void DisableAllSearchArg()
        {
            mP_SearchArg1.Enabled = false;
            mP_SearchArg2.Enabled = false;
            mP_SearchArg3.Enabled = false;
            mP_SearchArg4.Enabled = false;
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

        private void EnableNextSearchBox(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox answer = sender as MetroFramework.Controls.MetroTextBox;

            if (answer.Text != "")
            {
                switch (answer.Name.ToString())
                {
                    case "mTB_SearchArg1":
                        if (metroComboBox2.SelectedIndex > (int)ErrorState.Nothing)
                        {
                            searchDetails[0].searchstring = mTB_SearchArg1.Text;
                            searchDetails[0].ColumIndex = metroComboBox2.SelectedIndex;
                            searchDetails[0].ArgumentNr = 1;
                            mP_SearchArg2.Enabled = true;
                            CountSearchArguments = 1;
                        }
                        else
                            MessageBox.Show("Please select one colume!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "mTB_SearchArg2":
                        if (metroComboBox3.SelectedIndex > (int)ErrorState.Nothing)
                        {
                            searchDetails[1].searchstring = mTB_SearchArg2.Text;
                            searchDetails[1].ColumIndex = metroComboBox3.SelectedIndex;
                            searchDetails[1].ArgumentNr = 2;
                            mP_SearchArg3.Enabled = true;
                            CountSearchArguments = 2;
                        }else
                            MessageBox.Show("Please select one colume!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "mTB_SearchArg3":
                        if (metroComboBox4.SelectedIndex > (int)ErrorState.Nothing)
                        {
                            searchDetails[2].searchstring = mTB_SearchArg3.Text;
                            searchDetails[2].ColumIndex = metroComboBox3.SelectedIndex;
                            searchDetails[2].ArgumentNr = 3;
                            mP_SearchArg4.Enabled = true;
                            CountSearchArguments = 3;
                        }else
                            MessageBox.Show("Please select one colume!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "mTB_SearchArg4":
                        searchDetails[3].searchstring = mTB_SearchArg4.Text;
                        searchDetails[3].ColumIndex = metroComboBox4.SelectedIndex;
                        searchDetails[3].ArgumentNr = 4;
                        CountSearchArguments = 4;
                        break;
                    default:
                        break;
                }
            }else
            {///reset each argument box and disabled it.
                switch (answer.Name.ToString())
                {
                    case "mTB_SearchArg1":
                        mP_SearchArg2.Enabled = false;
                        mP_SearchArg3.Enabled = false;
                        mP_SearchArg4.Enabled = false;
                        CountSearchArguments = 0;
                        break;
                    case "mTB_SearchArg2":
                        mP_SearchArg3.Enabled = false;
                        mP_SearchArg4.Enabled = false;
                        CountSearchArguments = 1;
                        break;
                    case "mTB_SearchArg3":
                        mP_SearchArg4.Enabled = false;
                        CountSearchArguments = 2;
                        break;
                    case "mTB_SearchArg4":
                        CountSearchArguments = 3;
                        break;
                    default:
                        break;
                }
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Search_Click(object sender, EventArgs e)
        {
            switch (mCB_SelectTable.SelectedIndex)
            {
                case (int)Table.Customer:

                    for(int i = 0; i < CountSearchArguments; i++)
                    {
                        SelectColumCustomer(searchDetails[i]);
                    }
                    LoadCustomerList(customer);
                    break;
                case (int)Table.Income:
                    break;
                case (int)Table.Expenses:
                    break;
                case (int)Table.Products:
                    break;
                default:
                    MetroFramework.MetroMessageBox.Show(this, "No table selected! Please select one table.", 
                                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            //int index = metroComboBox2.SelectedIndex;
    
            //SelectColumCustomer(index);

            //SelectColumIncome(index);
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        private void SelectColumIncome(int index)
        {
            switch (index)
            {
                case (int)IncomeColuems.Date:
                    break;
                case (int)IncomeColuems.FullName:
                    break;
                case (int)IncomeColuems.Price:
                    break;
                case (int)IncomeColuems.Products:
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

            switch (searchDetails.ColumIndex)
            {
                case (int)CustomerColums.Date:
                    DateTime dateTime;
                    if (searchDetails.DateTimeConverter(out dateTime))
                    {
                        customer = SQLSearch.SearchCustomerDate(dateTime);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter a correct date!","Information",  
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)CustomerColums.FullName:
                    customer = SQLSearch.SearchCustomerName(searchDetails.searchstring);
                    break;
                case (int)CustomerColums.EMail:
                    customer = SQLSearch.SearchCustomerMail(searchDetails.searchstring);
                    break;
                case (int)CustomerColums.Phone:
                    customer = SQLSearch.SearchCustomerPhone(searchDetails.searchstring);
                    break;
                case (int)CustomerColums.CSA:
                    if(bool.TryParse(searchDetails.searchstring, out result))
                        customer = SQLSearch.SearchCustomerCSA(result);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter true or false!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)CustomerColums.HorsBarn:
                    if(bool.TryParse(searchDetails.searchstring, out result))
                        customer = SQLSearch.SearchCustomerHorseBarn(result);
                     else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter true or false!", "Information",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)CustomerColums.Neigtbar:
                    if(bool.TryParse(searchDetails.searchstring, out result))
                        customer = SQLSearch.SearchCustomerNeighbarhood(result);
                     else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter true or false!", "Information",
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
    }
}
