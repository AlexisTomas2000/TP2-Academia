using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class OlvidarContra : Form
    {
        private Regex rx = new Regex(@"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$");
        public OlvidarContra()
        {
            InitializeComponent();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void OlvidarContra_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (validar()) 
            {
                this.Mandarmail();
            }
        }

        private void Mandarmail()
        {
            UsuarioLogic ug = new UsuarioLogic();
            Usuario u = ug.GetOneM(txtMail.Text);
            string body=""

        }
        private string sendMail(string to , string asunto, string body)
        {
            string msge = "Error al enviar este correo.Por favor verifique los datos o intente mas tarde";
            string from = "atomas@frro.utn.edu.ar";
            string displayName = "Academia";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);
                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.office365.com",587);
                client.Credentials = new NetworkCredential(from, "42178987Ale");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool validar()
        {
            bool r = false;
           
            if(this.rx.IsMatch(txtMail.Text){ r = true; }
        
             return r;
        }
    }

}
