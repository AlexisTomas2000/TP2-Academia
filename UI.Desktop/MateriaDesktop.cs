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
    public partial class MateriaDesktop : ApplicationForm
    {
        private Business.Entities.Materia _MateriaActual;
        public Business.Entities.Materia MateriaActual { get => this._MateriaActual; set => this._MateriaActual = value; }
 
        public MateriaDesktop()
        {
            InitializeComponent();

        }
      
        public MateriaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            txbID.ReadOnly = true;
        }
        public MateriaDesktop(int id, ModoForm modo) : this()
        {
            Modo = modo;
            MateriaLogic mat = new MateriaLogic();
            MateriaActual = mat.GetOne(id);
            this.MapearDeDatos();
        }
        public override void MapearDeDatos()
        {

            this.txbID.Text = this.MateriaActual.ID.ToString();
            this.txbDesc.Text = this.MateriaActual.Descripcion;
            this.txtHS.Text = this.MateriaActual.HsSemanales.ToString();
            this.txtHT.Text = this.MateriaActual.HsTotales.ToString();
            this.cbPlanes.SelectedValue = this.MateriaActual.IDPlan;

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
            MateriaLogic mat = new MateriaLogic();
            mat.Save(this.MateriaActual);
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        Materia mat = new Materia();
                        MateriaActual = mat;
                        this.MateriaActual.HsSemanales = int.Parse(this.txtHS.Text);
                        this.MateriaActual.HsTotales = int.Parse(this.txtHT.Text);
                        //int i = cbPlanes.SelectedIndex;
                        this.MateriaActual.IDPlan = int.Parse(cbPlanes.SelectedValue.ToString());
                        this.MateriaActual.Descripcion = this.txbDesc.Text;
                        MateriaActual.State = BusinessEntity.States.New;
                        break;
                    }
                    case ModoForm.Modificacion:
                        {
                        this.MateriaActual.ID = int.Parse(this.txbID.Text);
                        this.MateriaActual.HsSemanales = int.Parse(this.txtHS.Text);
                        this.MateriaActual.HsTotales = int.Parse(this.txtHT.Text);
                        //int i = cbPlanes.SelectedIndex;
                        this.MateriaActual.IDPlan = int.Parse(cbPlanes.SelectedValue.ToString());
                        this.MateriaActual.Descripcion = this.txbDesc.Text;
                        MateriaActual.State = BusinessEntity.States.Modified;
                        break;
                        }
                    case ModoForm.Baja:
                        {
                        this.MateriaActual.ID = int.Parse(this.txbID.Text);
                        this.MateriaActual.HsSemanales = int.Parse(this.txtHS.Text);
                        this.MateriaActual.HsTotales = int.Parse(this.txtHT.Text);
                       // int i = cbPlanes.SelectedIndex;
                        this.MateriaActual.IDPlan = int.Parse(cbPlanes.SelectedValue.ToString());
                        this.MateriaActual.Descripcion = this.txbDesc.Text;
                        MateriaActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.Close();
        }

        private void txtHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
