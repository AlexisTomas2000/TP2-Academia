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
    public partial class Comisiones : Form
    {
        private Business.Logic.ComisionLogic c1;
        public Comisiones()
        {
            InitializeComponent();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            listar();
        }
        public void listar()
        {
            this.dgvComisiones.AutoGenerateColumns = false;
            this.c1 = new ComisionLogic();
            this.dgvComisiones.DataSource = c1.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listar();
        }

    }
}
