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
    public partial class Personas : Form
    {
        private Business.Logic.PersonaLogic u1;
        public Personas()
        {
            InitializeComponent();
        }
        private void Persona_Load(object sender, EventArgs e)
        {
            this.cbEleccion.SelectedIndex = 0;
            if (cbEleccion.SelectedIndex == 1)
            {
                cbEleccion.DisplayMember = "Profesores";
                this.ListarP();

            }
            else { this.ListarA();
                cbEleccion.DisplayMember = "Alumnos";
            }

        }
        public void ListarA()
        {
            this.dgvPersona.AutoGenerateColumns = false;
            this.u1 = new Business.Logic.PersonaLogic();
            this.dgvPersona.DataSource = u1.GetAllA();
        }
        public void ListarP()
        {
            this.dgvPersona.AutoGenerateColumns = false;
            this.u1 = new Business.Logic.PersonaLogic();
            this.dgvPersona.DataSource = u1.GetAllP();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            //this.ListarA();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
           // this.ListarP();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            PersonaDesktop pers = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            pers.ShowDialog();

            if (pers.dev() == 1)
            {
                this.ListarA();
            }
            else if (pers.dev() == 2) { ListarP(); }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Persona)this.dgvPersona.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pers = new PersonaDesktop(id, ApplicationForm.ModoForm.Modificacion);
            pers.ShowDialog();
            if (pers.dev() == 1)
            {
                this.ListarA();
            }
            else if (pers.dev() == 2) { ListarP(); }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Persona)this.dgvPersona.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pers = new PersonaDesktop(id, ApplicationForm.ModoForm.Baja);
            pers.ShowDialog();
            if (pers.dev() == 1)
            {
                this.ListarA();
            }
            else if (pers.dev() == 2)
            {
                ListarP();
            }
        }

        private void cbEleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEleccion.SelectedIndex == 1)
            {
                this.ListarP();
                cbEleccion.DisplayMember = "Profesores";

            }
            else { this.ListarA();
                cbEleccion.DisplayMember = "Alumnos";
            }
        }
    }
}
