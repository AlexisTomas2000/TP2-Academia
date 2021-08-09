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
        private Business.Logic.ComisionLogic c1;
        public Comisiones()
        {
            InitializeComponent();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            listar();
        }
        public void listar()
        {
            this.dgvComisiones.AutoGenerateColumns = false;
            this.c1 = new ComisionLogic();
            this.dgvComisiones.DataSource = c1.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listar();
        }

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
    }
}