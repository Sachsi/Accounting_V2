﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Accounting.Enums;

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

        public double IncomeSumMonth { get { return incomeSumMonth; } set { incomeSumMonth = value; } }
        private double incomeSumMonth;

        public double IncomeSumLast { get { return incomeSumLast; } set { incomeSumLast = value; } }
        private double incomeSumLast;

        public double IncomeSumLastMonth { get { return incomeSumLastMonth; } set { incomeSumLastMonth = value; } }
        private double incomeSumLastMonth;

        public double ExpensesSum { get { return expensesSum; } set { expensesSum = value; } }
        private double expensesSum;

        public double ExpensesSumMonth { get { return expensesSumMonth; } set { expensesSumMonth = value; } }
        private double expensesSumMonth;

        public double ExpensesSumLast { get { return expensesSumLast; } set { expensesSumLast = value; } }
        private double expensesSumLast;

        public double ExpensesSumLastMonth { get { return expensesSumLastMonth; } set { expensesSumLastMonth = value; } }
        private double expensesSumLastMonth;


        public ucOverview()
        {
            InitializeComponent();
        }

        private void ucOverview_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void RelaodChart()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<Income> source1 = SQLDatabase.SQLSearch.SearchIncomeDateYear(db.Incomes.ToList(), DateTime.Now.Year);
                List<Expense> source2 = SQLDatabase.SQLSearch.SearchExpenseDateYear(db.Expenses.ToList(), DateTime.Now.Year);

                ///Clear Chart
                InfoChart.Series["Income"].Points.Clear();
                InfoChart.Series["Expenses"].Points.Clear();
                InfoChart.Series["Volume of Sale"].Points.Clear();

                InfoChart.Series["Income"].ToolTip = "Income";
                InfoChart.Series["Expenses"].ToolTip = "Expenses";
                InfoChart.Series["Volume of Sale"].ToolTip = "Volume of Sale";

                for (int month = 1; month <= (int)DateTime.Now.Month; month++)
                {
                    double temp1 = SQLDatabase.SQLSearch.SearchIncomeDateMonth(source1, month).Sum(c => c.Price);
                    InfoChart.Series["Income"].Points.AddXY(((MonthEn)month).ToString(), temp1);
                    InfoChart.Series["Income"].Points[month-1].ToolTip = temp1.ToString("c");

                    double temp2 = SQLDatabase.SQLSearch.SearchExpenseDateMonth(source2, month).Sum(c => c.Price);
                    InfoChart.Series["Expenses"].Points.AddXY(((MonthEn)month).ToString(), temp2);
                    InfoChart.Series["Expenses"].Points[month - 1].ToolTip = temp2.ToString("c");


                    InfoChart.Series["Volume of Sale"].Points.AddXY(((MonthEn)month).ToString(), temp1 + temp2);
                    InfoChart.Series["Volume of Sale"].Points[month - 1].ToolTip = (temp1 + temp2).ToString("c");
                }
            }
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
            mL_SumIncome.Text = DateTime.Now.Year.ToString() + ": ";
            ml_Price_IS.Text = incomeSum.ToString("c", ucSetting.CurrencyDefault);

            Sum_IncomeMonth();
            mL_IncomeMonth.Text = ((MonthEn)DateTime.Now.Month).ToString() + ": ";
            ml_Price_IM.Text = incomeSumMonth.ToString("c", ucSetting.CurrencyDefault);

            Sum_IncomeLastMonth();
            mL_IncomeLastMonth.Text = ((MonthEn)DateTime.Now.AddMonths(-1).Month).ToString() + ": ";
            ml_Price_ILM.Text = incomeSumLastMonth.ToString("c", ucSetting.CurrencyDefault);

            Sum_IncomeLastYear();
            mL_IncomeLastYear.Text = DateTime.Now.AddYears(-1).Year.ToString() + ": ";
            ml_Price_ILY.Text = incomeSumLast.ToString("c", ucSetting.CurrencyDefault);

            using (DatabaseContext db = new DatabaseContext())
            {
                expensesSum = Sum_Expenses(db.Expenses, DateTime.Now, Periode.Year);
                mL_ExpensesYear.Text = DateTime.Now.Year.ToString() + ": ";
                ml_Price_ES.Text = expensesSum.ToString("c", ucSetting.CurrencyDefault);

                expensesSumLast =  Sum_Expenses(db.Expenses, DateTime.Now.AddYears(-1),Periode.Year);
                mL_ExpensesLastYear.Text = DateTime.Now.AddYears(-1).Year.ToString() + ": ";
                ml_Price_ELY.Text = expensesSumLast.ToString("c", ucSetting.CurrencyDefault);

                expensesSumMonth =  Sum_Expenses(db.Expenses,DateTime.Now,Periode.Month);
                mL_ExpensesMonth.Text = ((MonthEn)DateTime.Now.Month).ToString() + ": ";
                ml_Price_EM.Text = expensesSumMonth.ToString("c", ucSetting.CurrencyDefault);

                expensesSumLastMonth =  Sum_Expenses(db.Expenses, DateTime.Now.AddMonths(-1), Periode.Month);
                ml_ExpensesLastMonth.Text = ((MonthEn)DateTime.Now.AddMonths(-1).Month).ToString() + ": ";
                ml_Price_ELM.Text = expensesSumLastMonth.ToString("c", ucSetting.CurrencyDefault);

            }

            ///Volume of Sale for year 
            double VoluemOfSale = ExpensesSum + IncomeSum;
            ml_VolumeYear.Text = ((MonthEn)DateTime.Now.Year).ToString()+ ":";
            ml_Price_VSY.Text = VoluemOfSale.ToString("c", ucSetting.CurrencyDefault);

            /// volume of Sale for the last year
            VoluemOfSale = ExpensesSumLast + IncomeSumLast;
            ml_VolumeLastYear.Text = ((MonthEn)DateTime.Now.AddYears(-1).Year).ToString() + ":";
            ml_Price_VSLY.Text = VoluemOfSale.ToString("c", ucSetting.CurrencyDefault);

            ///Volume of Sale for this month 
            VoluemOfSale = ExpensesSumMonth + IncomeSumMonth;
            ml_VolumeMonth.Text = ((MonthEn)DateTime.Now.Month).ToString() + ":";
            ml_Price_VSM.Text = VoluemOfSale.ToString("c", ucSetting.CurrencyDefault);

            /// volume of Sale for the last month
            VoluemOfSale = ExpensesSumLastMonth + IncomeSumLastMonth;
            ml_VolumeLastMonth.Text = ((MonthEn)DateTime.Now.AddMonths(-1).Month).ToString() + ":";
            ml_Price_VSLM.Text = VoluemOfSale.ToString("c", ucSetting.CurrencyDefault);

            ///Reload the Chart
            RelaodChart();

        }

        private double Sum_Expenses(DbSet<Expense> expenses, DateTime date, Periode periode)
        {
            double sum = 0;

            if (periode == Periode.Year)
            {
                var sumExpenses = expenses.ToList().Where(c => c.Date.Year == date.Year);

                foreach (var item in sumExpenses)
                {
                    sum += item.Price;
                }
                return sum;
            }
            else if (periode == Periode.Month)
            {
                var sumExpenses = expenses.ToList().Where(c => c.Date.Month == date.Month);

                foreach (var item in sumExpenses)
                {
                    sum += item.Price;
                }
                return sum;
            }
            else
                return 0;


        }

        private void Sum_IncomeLastYear()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                incomeSumLast = 0;

                var income = db.Incomes.ToList().Where(c => c.Date.Year == DateTime.Now.AddYears(-1).Year);
                foreach (var item in income)
                {
                    incomeSumLast += item.Price;
                }
            }
        }

        private void Sum_IncomeLastMonth()
        {
            DateTime dateTimeLast = new DateTime();
            dateTimeLast = DateTime.Now.AddMonths(-1);

            using (DatabaseContext db = new DatabaseContext())
            {
                incomeSumLastMonth = 0;

                var income = db.Incomes.ToList().Where(c => c.Date.Month == dateTimeLast.Month);
                foreach (var item in income)
                {
                    incomeSumLastMonth += item.Price;
                }
            }
        }

        private void Sum_IncomeMonth()
        {
            
            using (DatabaseContext db = new DatabaseContext())
            {
                incomeSumMonth = 0;

                var income = db.Incomes.ToList().Where(c => c.Date.Month == DateTime.Now.Month);
                foreach (var item in income)
                {
                    incomeSumMonth += item.Price;
                }
            }
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

        private void mT_IncomeDetails_Click(object sender, EventArgs e)
        {
            InfoChart.Series["Income"].Enabled = !InfoChart.Series["Income"].Enabled;
        }

        private void mT_ExpensesDetails_Click(object sender, EventArgs e)
        {
            InfoChart.Series["Expenses"].Enabled = !InfoChart.Series["Expenses"].Enabled;
            
        }

        private void mT_VolumeOfSale_Click(object sender, EventArgs e)
        {
            InfoChart.Series["Volume of Sale"].Enabled = !InfoChart.Series["Volume of Sale"].Enabled;
        }
    }
}
