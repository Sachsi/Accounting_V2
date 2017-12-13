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

            this.reportViewer1.RefreshReport();

            using (var db = new Database.AccountingDatabase())
            {
                var customerTo = new Database.Customer() { FullName = "Marcel Sachse",EMail = "tobisachse27@msn.com" };
                var Strawberry = new Database.Produce() { ProduceName = "Strawberry" };
                var Blackberry = new Database.Produce() { ProduceName = "Blackberry" };

                var income0 = new Database.Income() { Price = 23.5 };
                var income1 = new Database.Income() { Price = 21.4 };

                Strawberry.Incomes.Add(income0);
                Blackberry.Incomes.Add(income1);

                customerTo.Incomes.Add(income0);
                customerTo.Incomes.Add(income1);

                db.Produces.Add(Strawberry);
                db.Produces.Add(Blackberry);
                db.Customers.Add(customerTo);
                                
                db.SaveChanges();
            }
        }
    }
}
