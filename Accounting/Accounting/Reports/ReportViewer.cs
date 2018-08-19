using Accounting.Properties;
using Microsoft.Reporting.WinForms;
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
    public partial class ReportViewer : MetroFramework.Forms.MetroForm
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();

            using (DatabaseContext db = new DatabaseContext())
            {
                ReportDataSource reportDataSourceC = new ReportDataSource();
                reportDataSourceC.Name = "TableIncome";
                reportDataSourceC.Value = db.Incomes.ToList();
                reportViewer1.LocalReport.DataSources.Add(reportDataSourceC);
                ReportDataSource reportDataSourceI = new ReportDataSource();
                reportDataSourceI.Name = "TableCustomer";
                reportDataSourceI.Value = db.Customers.ToList();
                reportViewer1.LocalReport.DataSources.Add(reportDataSourceI);
                ReportDataSource reportDataSourceE = new ReportDataSource();
                reportDataSourceE.Name = "TableExpenses";
                reportDataSourceE.Value = db.Expenses.ToList();
                reportViewer1.LocalReport.DataSources.Add(reportDataSourceE);
                ReportDataSource reportDataSourceP = new ReportDataSource();
                reportDataSourceP.Name = "TableProducts";
                reportDataSourceP.Value = db.Produkts.ToList();
                reportViewer1.LocalReport.DataSources.Add(reportDataSourceP);


                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyName","Pinsch of Soil Farm"),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyOwner","Marcel Sachse"),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyAddress","258 2078, Langley, Canada"),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyPhone","7788992185"),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyEMail","marcelsachse@msn.com"),
                    //new Microsoft.Reporting.WinForms.ReportParameter("Currency", a.ToString("c",ucSetting.CurrencyDefault))
                };

                reportViewer1.LocalReport.SetParameters(rParams);
                this.reportViewer1.RefreshReport();
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
