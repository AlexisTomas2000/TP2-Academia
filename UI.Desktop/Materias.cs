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
    public partial class Materias : Form
    {
        private Business.Logic.MateriaLogic m1;
        public Materias()
        {
            InitializeComponent();
            listar();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            listar();
        }
        public void listar()
        {
            this.dgvMaterias.AutoGenerateColumns = false;
            this.m1 = new MateriaLogic();
            this.dgvMaterias.DataSource = m1.GetAll();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            MateriaDesktop mat = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            mat.ShowDialog();
            this.listar();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop mat = new MateriaDesktop(id,ApplicationForm.ModoForm.Modificacion);
            mat.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop mat = new MateriaDesktop(id, ApplicationForm.ModoForm.Baja);
            mat.ShowDialog();
            listar();
        }
    }
}
