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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Database.AccountingDatabase db = new Database.AccountingDatabase())
            {
                incomeBindingSource.DataSource = db.Incomes.ToList();
                customerBindingSource.DataSource = db.Customers.ToList();
                expansesBindingSource.DataSource = db.Expanses.ToList();
            }
            mP_Income.Enabled = false;
            mP_Customer.Enabled = false;
            mP_Expenses.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_ADD_Income_Click(object sender, EventArgs e)
        {
            mP_Income.Enabled = true;
            incomeBindingSource.Add(new Database.Income());
            incomeBindingSource.MoveLast();
            mT_Date_Income.Focus();

            //using (Database.AccountingDatabase db = new Database.AccountingDatabase())
            //{
            //    var obj = from Customer in db.Customers
            //              select Customer;

            //    mCB_Name_Income.DataSource = obj.ToList();
            //    mCB_Name_Income.DisplayMember = "FullName";
            //    mCB_Name_Income.ValueMember = "ID";
            //}

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Save_Tables_Click(object sender, EventArgs e)
        {
            using (Database.AccountingDatabase db = new Database.AccountingDatabase())
            {
                Database.Income obj_Income = incomeBindingSource.Current as Database.Income;
                
                Database.Customer obj_Customer = customerBindingSource.Current as Database.Customer;

                if (obj_Income != null)
                {
                    //obj_Income.Customer = mCB_Name_Income.SelectedItem as Database.Customer;
                    obj_Income.Customer = db.Customers.Find(mCB_Name_Income.SelectedValue);

                    if (db.Entry<Database.Income>(obj_Income).State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Set<Database.Income>().Attach(obj_Income);
                    }
                    mGrid_Income.Refresh();
                    mP_Income.Enabled = false;
                }
                if(obj_Customer != null)
                {
                    if (db.Entry<Database.Customer>(obj_Customer).State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Set<Database.Customer>().Attach(obj_Customer);
                    }
                    mG_Customer.Refresh();
                    mP_Customer.Enabled = false;
                }

                db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Add_Customer_Click(object sender, EventArgs e)
        {
            mP_Customer.Enabled = true;
            customerBindingSource.Add(new Database.Customer());
            customerBindingSource.MoveLast();
            mTB_Date_Customer.Focus();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void mB_Save_Customer_Click(object sender, EventArgs e)
        //{
        //    using (Database.AccountingDatabase db = new Database.AccountingDatabase())
        //    {
        //        Database.Customer obj = customerBindingSource.Current as Database.Customer;
        //        if (obj != null)
        //        {
        //            if (db.Entry<Database.Customer>(obj).State == System.Data.Entity.EntityState.Detached)
        //            {
        //                db.Set<Database.Customer>().Attach(obj);
        //            }
        //            db.SaveChanges();
        //            mG_Customer.Refresh();
        //            mP_Customer.Enabled = false;
        //        }
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Edit_Customer_Click(object sender, EventArgs e)
        {
            mP_Customer.Enabled = true;
            mTB_Date_Customer.Focus();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Delete_Customer_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Cancel_Tables_Click(object sender, EventArgs e)
        {
            mP_Customer.Enabled = false;
            mP_Expenses.Enabled = false;
            mP_Income.Enabled = false;
            incomeBindingSource.ResetBindings(false);
            expansesBindingSource.ResetBindings(false);
            customerBindingSource.ResetBindings(false);
            Form1_Load(sender, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Add_Expenses_Click(object sender, EventArgs e)
        {
            mP_Expenses.Enabled = true;
            expansesBindingSource.Add(new Database.Expanses());
            expansesBindingSource.MoveLast();
            mTB_Date_Expenses.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Edit_Expenses_Click(object sender, EventArgs e)
        {
            mP_Expenses.Enabled = true;
            mTB_Date_Expenses.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mB_Delete_Expenses_Click(object sender, EventArgs e)
        {

        }

        private void mCB_Name_Income_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
