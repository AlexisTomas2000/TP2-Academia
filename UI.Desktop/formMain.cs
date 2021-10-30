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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }

        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materias materias = new Materias();
            materias.ShowDialog();
            this.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
            this.Show();
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comisiones comisiones = new Comisiones();
            comisiones.ShowDialog();
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

        private void btnCursos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cursos cur = new Cursos();
            cur.ShowDialog();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personas cur = new Personas();
            cur.ShowDialog();
            this.Show();
        }

        private void btbDC_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocentesCursos dc = new DocentesCursos();
            dc.ShowDialog();
            this.Show();
        }
    }
}
