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

namespace UI.Desktop
{
    public partial class AlumnosInscripciones : Form
    {
        private Business.Logic.AlumnoInscripcionLogic _AI;
        public AlumnosInscripciones()
        {
            InitializeComponent();
        }

        private void AlumnosInscripciones_Load(object sender, EventArgs e)
        {
            this.listar();
        }
        public void listar()
        {
            this.dgvAluIns.AutoGenerateColumns = false;
            AlumnoInscripcionLogic ai = new AlumnoInscripcionLogic();
            this.dgvAluIns.DataSource = ai.GetAll();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(ApplicationForm.ModoForm.Alta);
            aid.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int IDA = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IDAlumno;
            int IDC = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IDCurso;
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(IDA, IDC, ApplicationForm.ModoForm.Modificacion);
            aid.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int IDA = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IDAlumno;
            int IDC = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IDCurso;
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(IDA, IDC, ApplicationForm.ModoForm.Baja);
            aid.ShowDialog();
        }
    }
}
