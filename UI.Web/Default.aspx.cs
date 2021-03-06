using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        private Persona _entity;
        UsuarioLogic _logic;



        private UsuarioLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }

                return _logic;
            }

        }
        public Persona Entity { get => _entity; set => _entity = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.verificarSession();
                this.Entity = (Persona)Session["Persona"];
                Label1.Text = "Bienvenido: " + Entity.Nombre + " " + Entity.Apellido;

                switch (Entity.TipoPersona)
                {
                    case 1:
                        this.MostrarUsu();      
                        break;
                    case 2:
                        this.MostrarProf();
                        break;
                    case 3:
                        this.MostrarSuperAdmin();
                        break;

                    default:
                        break;
                }


            }
        }
        private void verificarSession()
        {
            if (Session["Persona"] == null)
            {
                Response.Redirect("~/Login");
            }
        }

        private void MostrarUsu() {
            btnPlanes.Visible = true;
            btnComisiones.Visible = true;
            btnMaterias.Visible = true;
            btnCursos.Visible = true;
            btnEspecialidades.Visible = true;
            btnEspecialidades.Enabled = true;
            btnCursos.Enabled = true;
            btnMaterias.Enabled = true;
            btnComisiones.Enabled = true;
            btnPlanes.Enabled = true;
            btnInscripciones.Enabled = true;
            btnInscripciones.Visible = true;
        }
        private void MostrarProf() {
            btnPlanes.Visible = true;
            btnComisiones.Visible = true;
            btnMaterias.Visible = true;
            btnCursos.Visible = true;
            btnEspecialidades.Visible = true;
            btnInscripciones.Visible = true;
            btnInscripciones.Enabled = true;
            btnEspecialidades.Enabled = true;
            btnCursos.Enabled = true;
            btnMaterias.Enabled = true;
            btnComisiones.Enabled = true;
            btnPlanes.Enabled = true;
            btnInscripciones.Text = "Registrar Notas";
        }
        private void MostrarSuperAdmin() {
            btnPlanes.Visible = true;
            btnComisiones.Visible = true;
            btnMaterias.Visible = true;
            btnCursos.Visible = true;
            btnEspecialidades.Visible = true;
            btnInscripciones.Visible = true;
            btnUsuarios.Visible = true;
            btnDocYCur.Visible = true;
            btnPersonas.Visible = true;
            btnPersonas.Enabled = true;
            btnDocYCur.Enabled = true;
            btnUsuarios.Enabled = true;
            btnInscripciones.Enabled = true;
            btnEspecialidades.Enabled = true;
            btnCursos.Enabled = true;
            btnMaterias.Enabled = true;
            btnComisiones.Enabled = true;
            btnPlanes.Enabled = true;
            btnReportesCursos.Enabled = true;
            btnReportesCursos.Visible = true;
            btnReportesPlanes.Enabled = true;
            btnReportesPlanes.Visible = true;
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session["Persona"] = null;
            Session["Usuario"] = null;
            this.verificarSession();
        }

        protected void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Especialidades");
        }

        protected void btnPlanes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Planes");
        }

        protected void btnComisiones_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Comisiones");
        }

        protected void btnCursos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cursos");
        }

        protected void btnMaterias_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Materias");
        }

        protected void btnUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Usuarios");
        }

        protected void btnDocYCur_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DocentesCursos");
        }

        protected void btnInscripciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AlumnoInscripciones");
        }

        protected void btnPersonas_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Personas");
        }

        protected void txtReportesCursos_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_Informes/InformesCursos.aspx");
        }

        protected void btnReportesPlanes_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_Informes/InformesPlanes.aspx");
        }
    }

}