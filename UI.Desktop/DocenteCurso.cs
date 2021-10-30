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
        public DocentesCursos()
        {
            InitializeComponent();
        }

        private void DocenteCurso_Load(object sender, EventArgs e)
        {
            listar();
        }
        public void listar()
        {
            this.dgvDocCur.AutoGenerateColumns = false;
            this.dc = new DocenteCursoLogic();
            this.dgvDocCur.DataSource = dc.GetAll();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DocenteCursoDesktop dcd = new DocenteCursoDesktop(ApplicationForm.ModoForm.Alta);
            dcd.ShowDialog();
            this.listar();
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
            this.listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
