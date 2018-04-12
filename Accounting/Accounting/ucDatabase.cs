using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Accounting
{
    public partial class ucDatabase : MetroFramework.Controls.MetroUserControl
    {
        static ucDatabase _instance;


        public static ucDatabase Instance{
            get { 
                    if (_instance == null)
                {
                    _instance = new ucDatabase();
                }
                    return _instance;
            }
            }

        public ucDatabase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Database_Load(object sender, EventArgs e)
        {
            _instance = this;

            using (DatabaseContext db = new DatabaseContext())
            {
                customerBindingSource.DataSource = db.Customers.ToList();
                incomeBindingSource.DataSource = db.Incomes.ToList();
                expensesBindingSource.DataSource = db.Expenses.ToList();
                produktBindingSource.DataSource = db.Produkts.ToList();


                ///Tabellen werden nur geladen, wenn die Datenbanken Einträge enthalten
                if (db.Incomes.Count() != 0)
                    TabControl.RefreshIncome(List_Income);
                if (db.Customers.Count() != 0)
                    TabControl.RefreshCustomer(List_Customer);
                if (db.Expenses.Count() != 0)
                    TabControl.RefreshExpenses(List_Expenses);
                if (db.Produkts.Count() != 0)
                    TabControl.RefreshProdukt(List_Produkts, mlV_Products_Income);
            }
            mP_Customer.Enabled = false;
            mP_Income.Enabled = false;
            mP_Expenses.Enabled = false;
            mP_Produkts.Enabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Add_Customer_Click(object sender, EventArgs e)
        {
            if (mP_Customer.Visible == true)
            {
                mP_Customer.Enabled = true;
                customerBindingSource.Add(new Customer() { ObjectState = 1 });
                customerBindingSource.MoveLast();
                mTB_Date_Customer.Focus();
                mTB_Date_Customer.Text = DateTime.UtcNow.ToShortDateString();
            }
            else if (mP_Income.Visible == true)
            {
                mP_Income.Enabled = true;
                incomeBindingSource.Add(new Income() { ObjectState = 1 });
                incomeBindingSource.MoveLast();
                mTB_Date_Income.Focus();
                mTB_Date_Income.Text = DateTime.UtcNow.ToShortDateString();
            }
            else if (mP_Expenses.Visible == true)
            {
                mP_Expenses.Enabled = true;
                expensesBindingSource.Add(new Expense() { ObjectState = 1 });
                expensesBindingSource.MoveLast();
                mTB_Date_Expenses.Focus();
                mTB_Date_Expenses.Text = DateTime.UtcNow.ToShortDateString();
            }
            else if (mP_Produkts.Visible == true)
            {
                Produkt newProdukt = new Produkt() { ObjectState = 1 };
                mCB_Produkts_Unit.DataSource = newProdukt.Units;
                mP_Produkts.Enabled = true;
                produktBindingSource.Add(newProdukt);
                produktBindingSource.MoveLast();
                mTB_Produkts_Date.Focus();
                mTB_Produkts_Date.Text = DateTime.UtcNow.ToShortDateString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Edit_Customer_Click(object sender, EventArgs e)
        {
            if ((List_Customer.Visible == true) && (List_Customer.SelectedItems.Count > 0))
            {
                mP_Customer.Enabled = true;
                mTB_Date_Customer.Focus();
                Customer obj = customerBindingSource.Current as Customer;
                if (obj != null)
                    obj.ObjectState = 2;
            }
            else if ((List_Income.Visible == true) && (List_Income.SelectedItems.Count > 0))
            {
                mP_Income.Enabled = true;
                mTB_Date_Income.Focus();
                Income obj = incomeBindingSource.Current as Income;
                if (obj != null)
                    obj.ObjectState = 2;
            }

        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Cancel_Click(object sender, EventArgs e)
        {
            mP_Customer.Enabled = false;
            mP_Expenses.Enabled = false;
            mP_Income.Enabled = false;
            mP_Produkts.Enabled = false;
            produktBindingSource.ResetBindings(false);
            incomeBindingSource.ResetBindings(false);
            expensesBindingSource.ResetBindings(false);
            customerBindingSource.ResetBindings(false);
            //Form_Main_Load(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Remove_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();

            using (DatabaseContext db = new DatabaseContext())
            {
                if ((List_Customer.Visible == true) && (List_Customer.SelectedItems.Count > 0))
                {
                    customerBindingSource.Position = (List_Customer.SelectedItems[0].Index);
                    Customer del_customer = customerBindingSource.Current as Customer;

                    a = MetroMessageBox.Show(this, "Do really want to delete the customer " + List_Customer.SelectedItems[0].SubItems[1].Text, "Attantion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (a == DialogResult.No)
                        return;

                    if (del_customer != null)
                    {
                        db.Entry<Customer>(del_customer).State = System.Data.Entity.EntityState.Deleted;
                        db.Set<Customer>().Remove(del_customer);
                        customerBindingSource.RemoveCurrent();
                        TabControl.RemoveRow(List_Customer);
                    }
                    db.SaveChanges();
                }
                else if ((List_Income.Visible == true) && (List_Income.SelectedItems.Count > 0))
                {
                    incomeBindingSource.Position = (List_Income.SelectedItems[0].Index);
                    Income del_Income = incomeBindingSource.Current as Income;

                    a = MetroMessageBox.Show(this, "Do you really want to delete the selectet row?", "Attantion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (a == DialogResult.No)
                        return;

                    if (del_Income != null)
                    {
                        db.Entry<Income>(del_Income).State = System.Data.Entity.EntityState.Deleted;
                        db.Set<Income>().Remove(del_Income);
                        incomeBindingSource.RemoveCurrent();
                        TabControl.RemoveRow(List_Income);
                    }
                    db.SaveChanges();
                }
                else if ((List_Expenses.Visible == true) && (List_Expenses.SelectedItems.Count > 0))
                {
                    expensesBindingSource.Position = List_Expenses.SelectedItems[0].Index;
                    Expense del_Expenses = expensesBindingSource.Current as Expense;

                    a = MetroMessageBox.Show(this, "Do you really want to delete the selectet row?", "Attation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (a == DialogResult.No)
                        return;
                    if (del_Expenses != null)
                    {
                        db.Entry<Expense>(del_Expenses).State = System.Data.Entity.EntityState.Deleted;
                        db.Set<Expense>().Remove(del_Expenses);
                        expensesBindingSource.RemoveCurrent();
                        TabControl.RemoveRow(List_Expenses);
                    }
                    db.SaveChanges();
                }
                else if ((List_Produkts.Visible == true) && (List_Produkts.SelectedItems.Count > 0))
                {
                    produktBindingSource.Position = List_Produkts.SelectedItems[0].Index;
                    Produkt del_Produkt = produktBindingSource.Current as Produkt;

                    a = MetroMessageBox.Show(this, "Do you really want to delete the selected row?", "Attation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (a == DialogResult.No)
                        return;
                    if (del_Produkt != null)
                    {
                        db.Entry<Produkt>(del_Produkt).State = System.Data.Entity.EntityState.Deleted;
                        db.Set<Produkt>().Remove(del_Produkt);
                        produktBindingSource.RemoveCurrent();
                        mlV_Products_Income.Items[produktBindingSource.Position + 1].Remove();
                        TabControl.RemoveRow(List_Produkts);

                    }
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Save_Click(object sender, EventArgs e)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                if (mTC_Accounting.SelectedTab == mTP_Customer)
                {
                    Customer obj_Customer = customerBindingSource.Current as Customer;

                    if (obj_Customer != null)
                    {
                        if (db.Entry<Customer>(obj_Customer).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Customer>().Attach(obj_Customer);
                        if (obj_Customer.ObjectState == 1)
                            db.Entry<Customer>(obj_Customer).State = System.Data.Entity.EntityState.Added;
                        else if (obj_Customer.ObjectState == 2)
                            db.Entry<Customer>(obj_Customer).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();
                        mP_Customer.Enabled = false;
                        obj_Customer.ObjectState = 0;
                        TabControl.AddCustomer(List_Customer, obj_Customer);
                    }
                }
                else if (mTC_Accounting.SelectedTab == mTP_Income)
                {
                    Income obj_Income = incomeBindingSource.Current as Income;

                    if (obj_Income != null)
                    {
                        obj_Income.Customer = db.Customers.First(c => c.Id == obj_Income.Customer_Id);

                        foreach (var item in mlV_Products_Income.CheckedIndices)
                        {
                            string a = mlV_Products_Income.Items[Convert.ToInt32(item)].Text;
                            obj_Income.Products = obj_Income.Products + a + ", ";
                        }

                        if (db.Entry<Income>(obj_Income).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Income>().Attach(obj_Income);
                        if (obj_Income.ObjectState == 1)
                            db.Entry<Income>(obj_Income).State = System.Data.Entity.EntityState.Added;
                        else if (obj_Income.ObjectState == 2)
                            db.Entry<Income>(obj_Income).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();
                        mP_Income.Enabled = false;
                        obj_Income.ObjectState = 0;
                        TabControl.AddIncome(List_Income, obj_Income);
                        return;
                    }
                }
                else if (mTC_Accounting.SelectedTab == mTP_Expenses)
                {
                    Expense obj_Expense = expensesBindingSource.Current as Expense;

                    if (obj_Expense != null)
                    {
                        if (db.Entry<Expense>(obj_Expense).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Expense>().Attach(obj_Expense);
                        if (obj_Expense.ObjectState == 1)
                            db.Entry<Expense>(obj_Expense).State = System.Data.Entity.EntityState.Added;
                        else if (obj_Expense.ObjectState == 2)
                            db.Entry<Expense>(obj_Expense).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();
                        mP_Expenses.Enabled = false;
                        obj_Expense.ObjectState = 0;
                        TabControl.AddExpenses(List_Expenses, obj_Expense);
                        return;
                    }
                }
                else if (mTC_Accounting.SelectedTab == mTP_Produkts)
                {
                    Produkt obj_Produkt = produktBindingSource.Current as Produkt;

                    if (obj_Produkt != null)
                    {
                        obj_Produkt.Unit = mCB_Produkts_Unit.SelectedIndex;

                        if (db.Entry<Produkt>(obj_Produkt).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Produkt>().Attach(obj_Produkt);
                        if (obj_Produkt.ObjectState == 1)
                            db.Entry<Produkt>(obj_Produkt).State = System.Data.Entity.EntityState.Added;
                        if (obj_Produkt.ObjectState == 2)
                            db.Entry<Produkt>(obj_Produkt).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();
                        mP_Produkts.Enabled = false;
                        obj_Produkt.ObjectState = 0;
                        TabControl.RefreshProdukt(List_Produkts, mlV_Products_Income);
                    }
                }
            }
        }

        /// <summary>
        /// Ändert die Maßeinheit entsprechend der ausgewählten Einheit in der ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mCB_Produkts_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCB_Produkts_Unit.SelectedIndex == 0)
                ml_Unit.Text = "pcs";
            else if (mCB_Produkts_Unit.SelectedIndex == 1)
                ml_Unit.Text = "g";
            else if (mCB_Produkts_Unit.SelectedIndex == 2)
                ml_Unit.Text = "lb";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mTB_Payment_Expenses_Click(object sender, EventArgs e)
        {

        }
    }
}
