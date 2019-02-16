using Microsoft.Reporting.WinForms;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class IncomeReportViewer : Form
    {
        public List<IncomeAndRefund> IncomeAndRefunds { get; set; }
        public IncomeReportViewer()
        {
            InitializeComponent();
            IncomeAndRefunds = new List<IncomeAndRefund>();
        }

        private void IncomeReportViewer_Load(object sender, EventArgs e)
        {
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            string exeFolder = Application.StartupPath;
            string reportPath = Path.Combine(exeFolder, @"IncomeReport.rdlc");


            ReportDataSource rds = new ReportDataSource
            {
                Value = IncomeAndRefunds,
                Name = "IncomeDataSet"
            };

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = "IncomeReport.rdlc";
            reportViewer1.LocalReport.ReportPath = reportPath;
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
