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
        private ReportDataSource reportDataSource;

        public String ReportDataSetName
        {
            get { return this.reportDataSource.Name; }
            set { this.reportDataSource.Name = value; }
        }

        public object Database
        {
            get { return this.reportDataSource.Value; }
            set { this.reportDataSource.Value = value; }
        }

        public string ReportName
        {
            get { return this.reportViewer1.LocalReport.ReportEmbeddedResource; }
            set { this.reportViewer1.LocalReport.ReportEmbeddedResource = value; }
        }

        Accounting.ucSearch ucSearch;

        public ReportViewer(Accounting.ucSearch ucSearch)
        {
            this.ucSearch = new ucSearch();
            this.ucSearch = ucSearch;
            reportDataSource = new ReportDataSource();
            InitializeComponent();
        }

        public void AddReportDataSouce()
        {
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            
            AddReportDataSouce();
 

                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",Settings.Default["BusinessName"].ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyOwner", Settings.Default["CompanyTitle"].ToString() +
                                                                    " " + Settings.Default["CompanyOwner"].ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyAddress",Settings.Default["CompanyPostcode"].ToString() +
                                                                    " " + Settings.Default["CompanyCity"].ToString() +
                                                                    "\n" + Settings.Default["CompanyCountry"].ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyPhone",Settings.Default["CompanyPhone"].ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("CompanyEMail",Settings.Default["CompanyEMail"].ToString()),
                   
                };

                reportViewer1.LocalReport.SetParameters(rParams);
                this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            ucSearch.Focus();
        }
    }
}
