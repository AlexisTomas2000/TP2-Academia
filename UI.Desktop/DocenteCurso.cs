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
    public partial class DocentesCursos : Form
    {
        private Business.Logic.DocenteCursoLogic dc;
        private Business.Entities.Persona _entity;

        public Persona Entity { get => _entity; set => _entity = value; }



        public DocentesCursos()
        {
            InitializeComponent();
        }

        public DocentesCursos(Persona entity) : this()
        {
            Entity = entity;
        }

        private void DocenteCurso_Load(object sender, EventArgs e)
        {
            this.sp_listaDocenteCursoTableAdapter.Fill(this.tp2_netDataSet12.sp_listaDocenteCurso);
            if (Entity.TipoPersona == 3)
            {
                this.tsmOpciones.Visible = true;
                this.tsmOpciones.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DocenteCursoDesktop dcd = new DocenteCursoDesktop(ApplicationForm.ModoForm.Alta);
            dcd.ShowDialog();
            this.sp_listaDocenteCursoTableAdapter.Fill(this.tp2_netDataSet12.sp_listaDocenteCurso);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.DocenteCurso)this.dgvDocCur.SelectedRows[0].DataBoundItem).ID;
            DocenteCursoDesktop dcd = new DocenteCursoDesktop(id, ApplicationForm.ModoForm.Modificacion);
            dcd.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.DocenteCurso)this.dgvDocCur.SelectedRows[0].DataBoundItem).ID;
            DocenteCursoDesktop dcd = new DocenteCursoDesktop(id, ApplicationForm.ModoForm.Baja);
            dcd.ShowDialog();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            this.sp_listaDocenteCursoTableAdapter.Fill(this.tp2_netDataSet12.sp_listaDocenteCurso);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDocCur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
