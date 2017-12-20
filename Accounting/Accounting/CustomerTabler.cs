using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

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
        private void mB_Save_Customer_Click(object sender, EventArgs e)
        {
            using (Database.AccountingDatabase db = new Database.AccountingDatabase())
            {
                Database.Customer obj = customerBindingSource.Current as Database.Customer;
                if (obj != null)
                {
                    if (db.Entry<Database.Customer>(obj).State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Set<Database.Customer>().Attach(obj);
                    }
                    db.SaveChanges();
                    mG_Customer.Refresh();
                    mP_Customer.Enabled = false;
                }
            }
        }
    }
}
