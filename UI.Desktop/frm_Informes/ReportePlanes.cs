using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.frm_Informes
{
    public partial class ReportePlanes : Form
    {
        public ReportePlanes()
        {
            InitializeComponent();
        }

        private void Reporte2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet7.sp_ListaPlanes' Puede moverla o quitarla según sea necesario.
            this.sp_ListaPlanesTableAdapter.Fill(this.tp2_netDataSet7.sp_ListaPlanes);
            this.planesTableAdapter.Fill(this.tp2_netDataSet.planes);
           // PlanLogic p = new PlanLogic();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
