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
        protected void btnUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Usuarios");
        }

        protected void btnPlanes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Planes");
        }
        protected void btnPersonas_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Personas");
        }

        protected void btnInscripciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AlumnoInscripciones");
        }
    }

}