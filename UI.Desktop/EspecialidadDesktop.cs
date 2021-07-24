using Business.Entities;
using Business.Logic;
using Data.Database;
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
    public partial class EspecialidadDesktop : ApplicationForm
    {
        private Business.Entities.Especialidad _EspecialidadActual;
        public Business.Entities.Especialidad EspecialidadActual { get => this._EspecialidadActual; set => this._EspecialidadActual = value; }
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        private void CargaEsp_Load(object sender, EventArgs e)
        {

        }

        public EspecialidadDesktop(ModoForm modo) : this() {

            Modo = modo;
        }

        public EspecialidadDesktop(int id, ModoForm modo) : this() 
        {
            Modo = modo;
            EspecialidadLogic esp = new EspecialidadLogic();
            EspecialidadActual = esp.GetOne(id);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = EspecialidadActual.ID.ToString();
            txtDescripcion.Text = EspecialidadActual.Descripcion; 
            

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
                        Especialidad esp = new Especialidad();
                        EspecialidadActual = esp;
                        EspecialidadActual.Descripcion = txtDescripcion.Text;
                        EspecialidadActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        
                        this.EspecialidadActual.ID = int.Parse(this.txtID.Text);
                        this.EspecialidadActual.Descripcion = txtDescripcion.Text;
                        this.EspecialidadActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        EspecialidadActual.Descripcion = txtDescripcion.Text; 
                        EspecialidadActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }

        }
        public override void GuardarCambios()
        {

            MapearADatos();
            EspecialidadLogic esp = new EspecialidadLogic();
            esp.Save(this.EspecialidadActual);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             
          
            this.GuardarCambios();
            this.Close();
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
