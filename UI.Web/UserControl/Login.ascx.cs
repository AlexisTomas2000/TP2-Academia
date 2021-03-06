using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web.UserControl
{
    public partial class Login : System.Web.UI.UserControl
    {
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usu = Logic.FindOne(txtUsu.Text, txtContra.Text);
            if (usu.IdPersona != 0)
            {
                int id = usu.ID;
                Session["Usuario"] = usu;
                Response.Write("<script> alert(" + "'Hola'" + ") </script>");
                PersonaLogic per = new PersonaLogic();
                Session["Persona"] = per.GetOne(usu.IdPersona);

                Response.Redirect("~/Default");

            }
            else { Response.Write("<script> alert(" + "'Datos incorrectos'" + ") </script>"); }
        }

        protected void btnOC_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/OlvideMiContra");
        }
    }
}