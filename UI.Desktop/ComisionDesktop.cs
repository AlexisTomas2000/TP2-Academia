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
    public partial class ComisionDesktop : ApplicationForm
    {
        private Business.Entities.Comision _ComisionActual;
        public ComisionDesktop()
        {
            InitializeComponent();
        }
        public Business.Entities.Comision ComisionActual { get=>this._ComisionActual; set=>this._ComisionActual=value; }
        private void ComisionDesktop_Load(object sender, EventArgs e)
        {
            PlanLogic plan = new PlanLogic();
            cbPlanes.DataSource = plan.GetAll();
            cbPlanes.DisplayMember = "Descripcion";
            cbPlanes.ValueMember = "Id";
        }
        public ComisionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public ComisionDesktop(int id,ModoForm modo) : this()
        {
            this.Modo = modo;
            ComisionLogic com = new ComisionLogic();
            ComisionActual = com.GetOne(id);
            this.MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.txbID.Text = this.ComisionActual.ID.ToString();
            this.txbDesc.Text = this.ComisionActual.Descripcion;
            this.txbAñoEsp.Text = this.ComisionActual.AnioEspecialidad.ToString();
            this.cbPlanes.SelectedValue = this.ComisionActual.IdPlan;
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

        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic com = new ComisionLogic();
            com.Save(this.ComisionActual);
        }
    }
}
