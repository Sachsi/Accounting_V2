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
            this.reportViewer2.RefreshReport();

            using (Database.AccountingDatabase db = new Database.AccountingDatabase())
            {
                incomeBindingSource.DataSource = db.Incomes.ToList();
                customerBindingSource.DataSource = db.Customers.ToList();
            }
            mP_Income.Enabled = false;
            mP_Customer.Enabled = false;

            //using (var db = new Database.AccountingDatabase())
            //{
            //    var customerTo = new Database.Customer() { FullName = "Marcel Sachse",EMail = "tobisachse27@msn.com" };
            //    var Strawberry = new Database.Product() { ProductName = "Strawberry" };
            //    var Blackberry = new Database.Product() { ProductName = "Blackberry" };

            //    var income0 = new Database.Income() { Price = 23.5 };
            //    var income1 = new Database.Income() { Price = 21.4 };

            //    Strawberry.Incomes.Add(income0);
            //    Blackberry.Incomes.Add(income1);

            //    customerTo.Incomes.Add(income0);
            //    customerTo.Incomes.Add(income1);

            //    db.Products.Add(Strawberry);
            //    db.Products.Add(Blackberry);
            //    db.Customers.Add(customerTo);

            //    db.SaveChanges();
            //}
        }

        private void mB_ADD_Income_Click(object sender, EventArgs e)
        {
            mP_Income.Enabled = true;
            incomeBindingSource.Add(new Database.Income());
            incomeBindingSource.MoveLast();
            mT_Date_Income.Focus();
        }

        private void mB_Save_Income_Click(object sender, EventArgs e)
        {
            using (Database.AccountingDatabase db = new Database.AccountingDatabase())
            {
                Database.Income obj = incomeBindingSource.Current as Database.Income;
                if (obj != null)
                {
                    if (db.Entry<Database.Income>(obj).State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Set<Database.Income>().Attach(obj);
                    }
                    db.SaveChanges();
                    mGrid_Income.Refresh();
                    mP_Income.Enabled = false;
                }
            }
        }


    }
}
