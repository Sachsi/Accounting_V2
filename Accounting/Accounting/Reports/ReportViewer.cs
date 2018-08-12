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
                customerBindingSource.DataSource = db.Customers.ToList();
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "TableCustomer";
                reportDataSource.Value = db.Customers.ToList();

                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyName","Pinsch of Soil Farm"),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyOwner","Marcel Sachse"),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyAddress","258 2078, Langley, Canada")
                };

                reportViewer1.LocalReport.SetParameters(rParams);
                this.reportViewer1.RefreshReport();
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
