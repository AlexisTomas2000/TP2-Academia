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
    public partial class Comisiones : Form
    {
        private Business.Logic.ComisionLogic _c1;
        private Business.Entities.Persona _entity;

        public Persona Entity { get => _entity; set => _entity = value; }
        public ComisionLogic C1 { get => _c1; set => _c1 = value; }

        public Comisiones()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            this.dgvComisiones.AutoGenerateColumns = false;
            this.C1 = new ComisionLogic();
            this.dgvComisiones.DataSource = C1.GetAll();
        }

        public Comisiones(Persona persona) : this() {
            Entity = persona;      
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            this.Listar();
            if ((Entity.TipoPersona==3))
            {
               this.tsmOpciones.Visible = true;
                this.tsmOpciones.Enabled = true;
            }
            

        }
   



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ComisionDesktop comd = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            comd.ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop comd = new ComisionDesktop(id, ApplicationForm.ModoForm.Modificacion);
            comd.ShowDialog();
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop comd = new ComisionDesktop(id, ApplicationForm.ModoForm.Baja);
            comd.ShowDialog();
        }
        #region BNR
        private void tsbAgregar_Click(object sender, EventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void dgvComisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvComisiones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}