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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form gestionarAlumnos = new GestionarAlumno();
            gestionarAlumnos.ShowDialog();
            this.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form gestionarUsuarios = new GestionarUsuarios();
            gestionarUsuarios.ShowDialog();
            this.Show();
        }
    }
}
