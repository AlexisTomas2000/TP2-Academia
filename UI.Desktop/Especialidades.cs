using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;


namespace UI.Desktop
{
    public partial class Especialidades : Form
    {
        private Business.Logic.EspecialidadLogic e1;
        private Business.Entities.Persona _entity;

        public Persona Entity { get => _entity; set => _entity = value; }

        public Especialidades()
        {
            InitializeComponent();
        }

        public Especialidades(Persona entity): this()
        {
            Entity = entity;
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            listar();
            if (Entity.TipoPersona == 3)
            {
                this.tsmOpciones.Visible = true;
                this.tsmOpciones.Enabled = true;
            }
        }

        public void listar()
        {
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.e1 = new EspecialidadLogic();
            this.dgvEspecialidades.DataSource = e1.GetAll();
        }



        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop espe = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            espe.ShowDialog();
            this.listar();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop espe = new EspecialidadDesktop(id, ApplicationForm.ModoForm.Modificacion);
            espe.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop espe = new EspecialidadDesktop(id, ApplicationForm.ModoForm.Baja);
            espe.ShowDialog();
        }

        #region BNR
        private void tsdOpciones_Click(object sender, EventArgs e)
        {

        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {

        }
        private void dgvEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
