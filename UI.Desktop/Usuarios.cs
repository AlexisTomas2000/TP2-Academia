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
    public partial class Usuarios : Form
    {
        
        private Business.Logic.UsuarioLogic u1;
        private Business.Entities.Persona _entity;

        public Persona Entity { get => _entity; set => _entity = value; }



        public Usuarios()
        {
            InitializeComponent();
        }
        public Usuarios(Persona entity):this()
        {
            Entity = entity;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Entity.TipoPersona == 3)
            {
                this.tsmOpciones.Visible = true;
                this.tsmOpciones.Enabled = true;
            }
            Listar();
        }
        public void Listar()
        {
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.u1 = new UsuarioLogic();
            this.dgvUsuarios.DataSource = u1.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
           UsuarioDesktop usua = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            usua.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop usua= new UsuarioDesktop(id, ApplicationForm.ModoForm.Modificacion);
            usua.ShowDialog();
     
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop usua = new UsuarioDesktop(id, ApplicationForm.ModoForm.Baja);
            usua.ShowDialog();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usua = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            usua.ShowDialog();
        }

        /*private void tsbEsp_Click(object sender, EventArgs e)
        {
            Especialidades espe = new Especialidades();
            espe.ShowDialog();
        }*/
    }
}
