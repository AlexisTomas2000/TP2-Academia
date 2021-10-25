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
    public partial class ComisionDesktop : ApplicationForm
    {
        private Business.Entities.Comision _ComisionActual;
        public ComisionDesktop()
        {
            InitializeComponent();
        }
        public Business.Entities.Comision ComisionActual { get => this._ComisionActual; set => this._ComisionActual = value; }
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
        public ComisionDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            ComisionLogic com = new ComisionLogic();
            ComisionActual = com.GetOne(id);
            this.MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.txbID.Text = this.ComisionActual.ID.ToString();
            this.txbDescripcion.Text = this.ComisionActual.Descripcion;
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
        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        txbID.ReadOnly = false;
                        Comision com = new Comision();
                        ComisionActual = com;
                        this.ComisionActual.AnioEspecialidad = int.Parse(this.txbAñoEsp.Text);
                        this.ComisionActual.Descripcion = this.txbDescripcion.Text;
                        int i = cbPlanes.SelectedIndex;
                        this.ComisionActual.IdPlan = int.Parse(cbPlanes.SelectedValue.ToString());
                        ComisionActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.ComisionActual.ID = int.Parse(this.txbID.Text);
                        this.ComisionActual.AnioEspecialidad = int.Parse(this.txbAñoEsp.Text);
                        this.ComisionActual.Descripcion = this.txbDescripcion.Text;
                        int i = cbPlanes.SelectedIndex;
                        this.ComisionActual.IdPlan = int.Parse(cbPlanes.SelectedValue.ToString());
                        ComisionActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.ComisionActual.ID = int.Parse(this.txbID.Text);
                        this.ComisionActual.AnioEspecialidad = int.Parse(this.txbAñoEsp.Text);
                        this.ComisionActual.Descripcion = this.txbDescripcion.Text;
                        int i = cbPlanes.SelectedIndex;
                        this.ComisionActual.IdPlan = int.Parse(cbPlanes.SelectedValue.ToString());
                        ComisionActual.State = BusinessEntity.States.Deleted;
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
        public override bool Validar()
        {
            bool resp = false;
            ComisionLogic com = new ComisionLogic();
            string rta;
            if (!("".Equals(txbDescripcion.Text)))
            {
                if (!("".Equals(cbPlanes.Text)))
                {
                    if (!("".Equals(txbAñoEsp.Text)))
                    {
                        resp = true;
                    }
                    else { { rta = "El año de la especialidad no puede ser vacío" + this.txbAñoEsp.Text; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                }
                else { { rta = "Debe seleccionar un plan para la Comision"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            }
            else { { rta = "La descripción de la comision no puede ser vacía"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            return resp;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void cbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
