using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using UI.Desktop.frm_Informes;

namespace UI.Desktop
{
    public partial class Planes : Form
    {
        private Business.Logic.PlanLogic p1;
        private Business.Entities.Persona _entity;

        public Persona Entity { get => _entity; set => _entity = value; }



        public Planes()
        {
            InitializeComponent();
        }
        public Planes(Persona entity):this()
        {
            Entity = entity;
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.listar();

            if (Entity.TipoPersona == 3)
            {
                this.tsmOpciones.Visible = true;
                this.tsmOpciones.Enabled = true;
                
            }
            if (Entity.TipoPersona ==2 || Entity.TipoPersona==3)
            {
                btnReportes.Visible = true;
                btnReportes.Enabled = true;
            }
           

        }

        private void listar()
        {
            this.dgvPlanes.AutoGenerateColumns = false;
            this.p1 = new PlanLogic();
            this.dgvPlanes.DataSource = p1.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop plan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            plan.ShowDialog();
            this.listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop plan = new PlanDesktop(id, ApplicationForm.ModoForm.Modificacion);
            plan.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop plan = new PlanDesktop(id, ApplicationForm.ModoForm.Baja);
            plan.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReportePlanes r = new ReportePlanes();
            r.ShowDialog();
        }

        #region BNR
        private void tsbReporte_Click(object sender, EventArgs e)
        {

        }
# endregion
    }
}
