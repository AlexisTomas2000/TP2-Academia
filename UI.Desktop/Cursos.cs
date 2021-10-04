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
    public partial class Cursos : Form
    {
        private Business.Logic.CursoLogic c1;
        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            listar();
        }
        public void listar()
        {
            this.dgvCursos.AutoGenerateColumns = false;
            this.c1 = new CursoLogic();
            this.dgvCursos.DataSource = c1.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursosDesktop curs = new CursosDesktop(ApplicationForm.ModoForm.Alta);
            curs.ShowDialog();
            this.listar();
        }

        private void tbsEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursosDesktop curs = new CursosDesktop(id,ApplicationForm.ModoForm.Modificacion);
            curs.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursosDesktop curs = new CursosDesktop(id,ApplicationForm.ModoForm.Baja);
            curs.ShowDialog();
        }
    }
}
