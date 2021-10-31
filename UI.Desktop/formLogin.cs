using Business.Entities;
using Business.Logic;
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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario u1 = new Usuario();
            u1.NombreUsuario = txtNomUsu.Text;
            u1.Clave = txtContra.Text;
            UsuarioLogic u2 = new UsuarioLogic();
            if (u2.GetOne(u1.NombreUsuario,u1.Clave))
            {
                MessageBox.Show("Usted ha ingresado al sistema correctamente."
                    , "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void ckMostrarCon_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtContra.Text;
            if(ckMostrarCon.Checked)
            {
                txtContra.UseSystemPasswordChar = false;
                txtContra.Text = text;
            }
            else
            {
                txtContra.UseSystemPasswordChar = true;
                txtContra.Text = text;
            }
        }
    }
}
