using Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Accounting
{
    public partial class Form_Main : MetroFramework.Forms.MetroForm
    {

        public Form_Main()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            

            using (DatabaseContext db = new DatabaseContext())
            {
                customerBindingSource.DataSource = db.Customers.ToList();
                incomeBindingSource.DataSource = db.Incomes.ToList();
            }
            TabControl.RefreshIncome(List_Income);
            TabControl.RefreshCustomer(List_Customer);
            
            mP_Income.Enabled = false;
            mP_Customer.Enabled = false;
        }

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Save_Tables_Click(object sender, EventArgs e)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                Income obj_Income = incomeBindingSource.Current as Income;

                if (obj_Income != null)
                {
                    obj_Income.Customer = db.Customers.First(c => c.Id == obj_Income.Customer_Id);
                    //obj_Income.Customer = db.Customers.Find(mCB_Customer_Income.SelectedValue);
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
            }
            else if(mP_Income.Visible == true)
            {
                mP_Income.Enabled = true;
                incomeBindingSource.Add(new Income() { ObjectState = 1 });
                incomeBindingSource.MoveLast();
                mTB_Date_Income.Focus();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Edit_Customer_Click(object sender, EventArgs e)
        {
            if (mP_Customer.Visible == true)
            {
                mP_Customer.Enabled = true;
                mTB_Date_Customer.Focus();
                Customer obj = customerBindingSource.Current as Customer;
                if (obj != null)
                    obj.ObjectState = 2;
            }
            else if (mP_Income.Visible == true)
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
        private void mB_Cancel_Tables_Click(object sender, EventArgs e)
        {
            //mP_Customer.Enabled = false;
            //mP_Expenses.Enabled = false;
            //mP_Income.Enabled = false;
            //incomeBindingSource.ResetBindings(false);
            //expansesBindingSource.ResetBindings(false);
            //customerBindingSource.ResetBindings(false);
            //Form1_Load(sender, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Add_Expenses_Click(object sender, EventArgs e)
        {
            //mP_Expenses.Enabled = true;
            //expansesBindingSource.Add(new AccountingDatabase.Expanse());
            //expansesBindingSource.MoveLast();
            //mTB_Date_Expenses.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Edit_Expenses_Click(object sender, EventArgs e)
        {
            //mP_Expenses.Enabled = true;
            //mTB_Date_Expenses.Focus();
        }

        private void mCB_Name_Income_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                if (List_Customer.Visible)
                {
                    customerBindingSource.Position = (List_Customer.SelectedItems[0].Index);
                    Customer del_customer = customerBindingSource.Current as Customer;

                    a = MessageBox.Show(this, "Do really want to delete the customer " + List_Customer.SelectedItems[0].SubItems[1].Text, "Attantion", MessageBoxButtons.YesNo);
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
                else if (List_Income.Visible)
                {
                    incomeBindingSource.Position = (List_Income.SelectedItems[0].Index);
                    Income del_Income = incomeBindingSource.Current as Income;

                    a = MessageBox.Show(this, "Do really want to delete the selectet row?", "Attantion", MessageBoxButtons.YesNo);
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
            }
            
        }
    }
}
