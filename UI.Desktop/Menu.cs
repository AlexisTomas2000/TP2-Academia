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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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

        private void btnPlanes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Planes planes = new Planes();
            planes.ShowDialog();
            this.Show();
        }

        private void btnEspecialidades_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Especialidades especialidades = new Especialidades();
            especialidades.ShowDialog();
            this.Show();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materias materias = new Materias();
            materias.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comisiones com = new Comisiones();
            com.ShowDialog();
            this.Show();
        }
    }
}
