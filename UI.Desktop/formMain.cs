using Business.Entities;
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
    public partial class formMain : Form
    {
        private Business.Entities.Persona _entity;

        public Persona Entity { get => _entity; set => _entity = value; }

        public formMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            formLogin appLogin = new formLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            else {
                this.Show();
                this.Entity = appLogin.Damelo();
                switch (this.Entity.TipoPersona)
                {
                    case  1:
                        this.MostrarUsu();
                        break;
                    case 2:
                        this.MostrarProfesor();
                        break;
                    case 3:
                        this.MostrarSuperAdmin();
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materias materias = new Materias();
            materias.ShowDialog();
            this.Show();
        }
        private void MostrarUsu() { 
                btnComisiones.Visible = true;
                btnMaterias.Visible = true;
                btnPlanes.Visible = true;
                btnEspecialidades.Visible = true;
                tsbComisiones.Visible = true;
                tsbMaterias.Visible = true;
                tsbPlanes.Visible = true;
                tsbEspecialidades.Visible = true;
                tsbInscripciones.Visible = true;
        }

        private void MostrarProfesor() {
                btnComisiones.Visible = true;
                btnMaterias.Visible = true;
                btnPlanes.Visible = true;
                btnEspecialidades.Visible = true;
                btnCursos.Visible = true;
                btnUsuarios.Visible = true;
                tsbUsuarios.Visible = true;
                tsbInscripciones.Visible = true;
                tsbComisiones.Visible = true;
                tsbMaterias.Visible = true;
                tsbPlanes.Visible = true;
                tsbRepoPlanes.Visible = true;
                tsbCursos.Visible = true;
                tsbRepoCurso.Visible = true;
                tsbEspecialidades.Visible = true;
           
        }
        private void MostrarSuperAdmin()
        {
            btnComisiones.Visible = true;
            btnMaterias.Visible = true;
            btnPlanes.Visible = true;
            btnEspecialidades.Visible = true;
            btnUsuarios.Visible = true;
            btnCursos.Visible = true;
            btbDC.Visible = true;
            btnPersonas.Visible = true;

            tsbComisiones.Visible = true;
            tsbMaterias.Visible = true;
            tsbPlanes.Visible = true;
            tsbEspecialidades.Visible = true;
            tsbUsuarios.Visible = true;
            tsbDYC.Visible = true;
            tsbInscripciones.Visible = true;
            tsbRepoPlanes.Visible = true;
            tsbCursos.Visible = true;
            tsbRepoCurso.Visible = true;

        }
        #region btns
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
            this.Show();
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comisiones comisiones = new Comisiones();
            comisiones.ShowDialog();
            this.Show();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Planes planes = new Planes();
            planes.ShowDialog();
            this.Show();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            this.Hide();
            Especialidades especialidades = new Especialidades();
            especialidades.ShowDialog();
            this.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cursos cur = new Cursos();
            cur.ShowDialog();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personas cur = new Personas();
            cur.ShowDialog();
            this.Show();
        }

        private void btbDC_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocentesCursos dc = new DocentesCursos();
            dc.ShowDialog();
            this.Show();
        }
        #endregion 
        private void mnsPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbComisiones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comisiones comisiones = new Comisiones(Entity);
            comisiones.ShowDialog();
            this.Show();
        }
    }
}
