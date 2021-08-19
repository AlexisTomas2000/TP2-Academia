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
        public Especialidades()
        {
            InitializeComponent();
            listar();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            listar();
        }

        public void listar()
        {
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.e1 = new EspecialidadLogic();
            this.dgvEspecialidades.DataSource = e1.GetAll();
        }

        private void dgvEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void tsdOpciones_Click(object sender, EventArgs e)
        {

        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop espe = new EspecialidadDesktop(ApplicationForm.ModoForm.Modificacion);
            espe.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop espe = new EspecialidadDesktop(id, ApplicationForm.ModoForm.Modificacion);
            espe.ShowDialog();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop espe = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            espe.ShowDialog();
            this.listar();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop espe = new EspecialidadDesktop(id, ApplicationForm.ModoForm.Baja);
            espe.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
