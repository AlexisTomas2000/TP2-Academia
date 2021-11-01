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
    public partial class ReporteCursos : Form
    {
        public ReporteCursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet5.sp_ListaCursos' Puede moverla o quitarla según sea necesario.
            this.sp_ListaCursosTableAdapter.Fill(this.tp2_netDataSet5.sp_ListaCursos);

            this.reportViewer1.RefreshReport();
        }
    }
}
