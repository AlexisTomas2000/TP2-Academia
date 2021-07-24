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
    public partial class ApplicationForm : Form
    {
        private ModoForm _Modo;
        public ModoForm Modo 
        { 
            get=>this._Modo; 
            set=>this._Modo=value; 
        }
        public enum ModoForm 
        { 
            Alta,
            Baja,
            Modificacion,
            Consulta,
        }

        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }

        public virtual void MapearDeDatos() { }
        public virtual void MapearADatos() { }
        public virtual void GuardarCambios() { }
        public virtual bool Validar() { return false; }

        public void Notificar(String titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono) 
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text,mensaje,botones,icono);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
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
    }
}
