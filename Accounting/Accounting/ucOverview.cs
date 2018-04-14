using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class ucOverview : MetroFramework.Controls.MetroUserControl
    {
        public int Customer { get { return customer; } private set {; } }
        private int customer;

        public int CSAcustomer { get { return csaCustomer; } private set {; } }
        private int csaCustomer;

        public int Nieghtbarhood { get { return nieghtbarhood; } private set {; } }
        private int nieghtbarhood;

        public int HorseBarn { get { return horseBarn; } private set {; } }
        private int horseBarn;

        public double IncomeSum { get { return incomeSum; } set { incomeSum = value; } }
        private double incomeSum;

        public ucOverview()
        {
            InitializeComponent();
        }

        private void ucOverview_Load(object sender, EventArgs e)
        {
        }

        private void Timer_Overview_Tick(object sender, EventArgs e)
        {
            Count_CSA_Customer();
            mL_CSA_Customer.Text = "CSA Customer: " + csaCustomer.ToString();

            Count_Nieghtbarhood();
            mL_Nieghtbarhood.Text = "Nieghtbarhood: " + nieghtbarhood.ToString();

            Count_HorseBarn();
            mL_HorseBarn.Text = "Horse Barn: " + horseBarn.ToString();

            Count_Customer();
            mL_Customer.Text = "Customer: " + customer.ToString();

            Sum_Income();
            mL_SumIncome.Text = "Income " + DateTime.Now.Year.ToString() + ": " + incomeSum.ToString("c", ucSetting.CurrencyDefault);
        }

        private void Count_HorseBarn()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                Customer obj = new Customer();

                horseBarn = 0;

                var result = db.Customers.Select(c => c.Hors_Barn == true);
                foreach (var item in result)
                {
                    if (item == true)
                        horseBarn++;
                }
            }
        }

        private void Count_CSA_Customer()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                Customer obj = new Customer();

                csaCustomer = 0;

                var result = db.Customers.Select(c => c.CSA == true);
                foreach (var item in result)
                {
                    if (item == true)
                        csaCustomer++;
                }
            }
        }

        private void Count_Customer()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                customer = 0;

                var result = db.Customers.Select(c => c.Id >= 0 );
                foreach (var item in result)
                {
                    if (item == true)
                        customer++;
                }
            }
        }

        private void Count_Nieghtbarhood()
        {
            using (DatabaseContext db = new DatabaseContext())
            {

                nieghtbarhood = 0;

                var result = db.Customers.Select(c => c.Neighbarhood == true);
                foreach (var item in result)
                {
                    if (item == true)
                        nieghtbarhood++;
                }
            }
        }

        private void Sum_Income()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var sumIncome = db.Incomes.ToList().Where(c => c.Date.Year == DateTime.Now.Year);

                incomeSum = 0;

                foreach (var item in sumIncome)
                {
                    incomeSum += item.Price;
                }
                
            }
        }
    }
}
