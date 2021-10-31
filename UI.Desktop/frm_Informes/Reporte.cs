using Data.Database;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Informes
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            PlanAdapter p = new PlanAdapter();
            //p.sqlConn.Open();
            SqlConnection cnn = new SqlConnection("Server=localhost;Database=tp2_net;Trusted_Connection=True; User=net; Password=net;");
            cnn.Open();
            string sqlpv = ("select * from planes");
           // SqlCommand cmd = new SqlCommand(sqlpv,cnn);
            SqlDataAdapter dapv = new SqlDataAdapter(sqlpv, cnn);
            DataSet.DataSet1 dsv = new DataSet.DataSet1();
            dapv.Fill(dsv, "DataSet1");
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dsv.Tables["DataSet1"]));
            reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.Informe.Report1.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            
        }
    }
}
