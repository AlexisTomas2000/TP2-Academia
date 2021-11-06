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
        private Usuario _Usu;
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
        public Usuario Usu { get => _Usu; set => _Usu = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.verificarSession();
                this.Usu = (Usuario)Session["Usuario"];
                Label1.Text = "Bienvenido: " + Usu.Nombre + " " + Usu.Apellido;

            }
        }
        private void verificarSession()
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("~/Login");
            }
        }

    }

}