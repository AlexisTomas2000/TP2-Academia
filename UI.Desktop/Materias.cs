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
        private Persona _entity;

        public Persona Entity { get => _entity; set => _entity = value; }

        public Materias()
        {
            InitializeComponent();
        }

        public Materias( Persona entity):this()
        {

            Entity = entity;
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            this.sp_ListaMateriasTableAdapter.Fill(this.tp2_netDataSet11.sp_ListaMaterias);
            if (Entity.TipoPersona == 3)
            {
                this.tsmOpciones.Visible = true;
                this.tsmOpciones.Enabled = true;
            }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            MateriaDesktop mat = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            mat.ShowDialog();
            this.sp_ListaMateriasTableAdapter.Fill(this.tp2_netDataSet11.sp_ListaMaterias);
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
            this.sp_ListaMateriasTableAdapter.Fill(this.tp2_netDataSet11.sp_ListaMaterias);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           this.sp_ListaMateriasTableAdapter.Fill(this.tp2_netDataSet11.sp_ListaMaterias);
        }
    }
}
