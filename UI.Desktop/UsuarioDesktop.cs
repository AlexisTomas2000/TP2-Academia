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
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Business.Entities.Usuario _UsuarioActual;
        public Business.Entities.Usuario UsuarioActual { get => this._UsuarioActual; set => this._UsuarioActual = value; }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
     
        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo =modo;
        }
        public UsuarioDesktop(int id,ModoForm modo):this()
        {
            this.Modo =modo;
            UsuarioLogic usu = new UsuarioLogic();
            UsuarioActual = usu.GetOne(id);
            this.MapearDeDatos();
            
        }
        public override void MapearDeDatos()
        {

            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
           
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.btnAceptar.Text = "Eliminar";
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.btnAceptar.Text = "Aceptar";
                        break;
                    }
                default:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
            }
        }
        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        Usuario usr = new Usuario();
                        UsuarioActual = usr;
                        this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                        this.UsuarioActual.Nombre = this.txtNombre.Text;
                        this.UsuarioActual.Apellido = this.txtApellido.Text;
                        this.UsuarioActual.Clave = this.txtClave.Text;
                        this.UsuarioActual.EMail = this.txtEmail.Text;
                        this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                        this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
                        UsuarioActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                        this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                        this.UsuarioActual.Nombre = this.txtNombre.Text;
                        this.UsuarioActual.Apellido = this.txtApellido.Text;
                        this.UsuarioActual.Clave = this.txtClave.Text;
                        this.UsuarioActual.EMail = this.txtEmail.Text;
                        this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                        this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
                        UsuarioActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                        this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                        this.UsuarioActual.Nombre = this.txtNombre.Text;
                        this.UsuarioActual.Apellido = this.txtApellido.Text;
                        this.UsuarioActual.Clave = this.txtClave.Text;
                        this.UsuarioActual.EMail = this.txtEmail.Text;
                        this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                        this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
                        UsuarioActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }

        }
        public override void GuardarCambios() 
        {
            MapearADatos();
            UsuarioLogic usu = new UsuarioLogic();
            usu.Save(this.UsuarioActual);
        }
        public override bool Validar() {
            bool resp = false;
            string rta;
            if(!("".Equals(txtNombre.Text)))
            {
                if (!("".Equals(txtApellido.Text)))
                {
                    if (!("".Equals(txtEmail.Text)))
                    {
                        if (!("".Equals(txtUsuario.Text)))
                        {
                          if(txtClave.Text.Equals(txtConfirmarClave.Text)&& txtClave.Text.Length>=8)
                            {
                                resp = true;
                            }else { { rta = "Las contraseñas no coinciden o tiene menos de 8 letras"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                        }
                        else { { rta = "El usuario no puede ser vacio"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                    }
                    else { { rta = "El Email no puede ser vacio"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                }
                else { { rta = "El apellido no puede ser vacio"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            }
            else { { rta = "El nombre no puede ser vacio"; }  this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            return resp; }

        public void Notificar(String titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        public void Escond() {
            this.btnCancelar.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar()) { this.GuardarCambios(); this.Close(); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UsuarioDesktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Notificar("No puede cancelar la carga de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
