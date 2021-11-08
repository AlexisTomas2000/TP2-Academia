using Business.Entities;
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
        private Business.Entities.Persona _entity;

        public Persona Entity { get => _entity; set => _entity = value; }

        public AlumnosInscripciones()
        {
            InitializeComponent();
        }

        public AlumnosInscripciones(Persona entity): this()
        {
            Entity = entity;
        }

        private void AlumnosInscripciones_Load(object sender, EventArgs e)
        {
            this.listar();
            this.Mostrar();
        }

        private void Mostrar()
        {
            if(Entity.TipoPersona==1)
            {
                this.tsbEditar.Enabled = false;
                this.tsbEditar.Visible = false;
                this.tsbEliminar.Visible = false;
                this.tsbEliminar.Enabled = false;
            }else if(Entity.TipoPersona==2)
            {
                tsbAgregar.Visible = false;
                tsbAgregar.Enabled = false;
                this.tsbEliminar.Visible = false;
                this.tsbEliminar.Enabled = false;
            }
        }

        private void listar()
        {
            if (Entity.TipoPersona == 3)
            {
                this.listarG();
            }
            else if (Entity.TipoPersona == 2)
            {
                this.listarD(Entity.ID);
            }
            else { this.listarA(Entity.ID); }
        }

        public void listarG()
        {
            this.dgvAluIns.AutoGenerateColumns = false;
            AlumnoInscripcionLogic ai = new AlumnoInscripcionLogic();
            this.dgvAluIns.DataSource = ai.GetAll();
        }
        public void listarD(int id)
        {
            this.dgvAluIns.AutoGenerateColumns = false;
            AlumnoInscripcionLogic ai = new AlumnoInscripcionLogic();
            this.dgvAluIns.DataSource = ai.GetAllD(id);
        }
        public void listarA(int id)
        {
            this.dgvAluIns.AutoGenerateColumns = false;
            AlumnoInscripcionLogic ai = new AlumnoInscripcionLogic();
            this.dgvAluIns.DataSource = ai.GetAllA(id);
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
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(Entity,ApplicationForm.ModoForm.Alta);
            aid.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int IDA = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IDAlumno;
            int IDC = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IDCurso;
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(Entity,IDA, IDC, ApplicationForm.ModoForm.Modificacion);
            aid.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int IDA = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IDAlumno;
            int IDC = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IDCurso;
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(Entity, IDA, IDC, ApplicationForm.ModoForm.Baja);
            aid.ShowDialog();
        }
    }
}
