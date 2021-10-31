using Business.Entities;
using Business.Logic;
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

namespace UI.Desktop
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            ReportDataSource rds = new ReportDataSource("CursosDataSet", GetPlanes());
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private List<Plan>GetPlanes()
        {
            PlanLogic p = new PlanLogic();
            return p.GetAll();
        }
    }
}
