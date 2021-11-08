using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Web
{
    public partial class OlvideMiContra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Mandarmail()
        {
            UsuarioLogic ug = new UsuarioLogic();
            Usuario u = ug.GetOneM(txtEmail.Text);
            string body = @"<style>
                           h1{color:dodgerblue;}
                           h1{color:darkorange;}
                            </style>
                        <h1>Su usuario es: " + u.NombreUsuario + "</h1></br>" +
                        "<h2>Su contraseña es:" + u.Clave + "</h2></br>";
            int rta = this.sendMail(txtEmail.Text, "Este correo fue enviado para recuperar la contraseña", body);
            if (rta == 0)
            {
                Response.Write("<script> alert(" + "'Error al enviar este correo.Por favor verifique los datos o intente mas tarde.Por favor verifica tu conexion y que tus datos sean correto e intente nuevamente'" + ") </script>");
            }
        }
        private int sendMail(string to, string asunto, string body)
        {
            //string msge = "Error al enviar este correo.Por favor verifique los datos o intente mas tarde";
            int a = 0;
            string from = "a_c_a_d_e_m0117@hotmail.com";
            string displayName = "Academia";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);
                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.Credentials = new NetworkCredential(from, "mdeveloper117");
                client.EnableSsl = true;
                client.Send(mail);
                a= 1;
              //  msge = "Correo enviado exitosamente";
            }
            catch (Exception ex)
            {
                //msge = ex.Message + "Por favor verifica tu conexion y que tus datos sean correto e intente nuevamente";
            }
            return a ;
        }

        private bool validar()
        {
            bool r = false;

            if (!this.rx.IsMatch(txtEmail.Text))
            { r = true; }

            return r;
        }
        private Regex rx = new Regex(@"\w + ([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click1(object sender, EventArgs e)
        {
            if (validar())
            {
                this.Mandarmail();
                Response.Redirect("~/Login");
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login");
        }
    }
}