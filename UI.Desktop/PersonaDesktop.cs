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
using System.Globalization;
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class PersonaDesktop : ApplicationForm
    {
        private Regex rx = new Regex(@"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$");
        private Business.Entities.Persona _PersonaActual;
        public Business.Entities.Persona PersonaActual { get => this._PersonaActual; set => this._PersonaActual = value; }
        public PersonaDesktop(int id, ModoForm modo):this()
        {
            this.Modo = modo;
            PersonaLogic pl = new PersonaLogic();
            PersonaActual = pl.GetOne(id);
            this.MapearDeDatos();
        }
        public PersonaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;

        }

        public PersonaDesktop()
        {
            InitializeComponent();
        }
        public override void MapearADatos()
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        Persona per = new Persona();
                        PersonaActual = per;
                        this.PersonaActual.Apellido = this.txtApellido.Text;
                        this.PersonaActual.Nombre = this.txtNombre.Text;
                        this.PersonaActual.Direccion = this.txtDireccion.Text;
                        this.PersonaActual.EMail = this.txtEmail.Text;
                        this.PersonaActual.FechaNacimiento = DateTime.ParseExact(this.txtFechaNac.Text, "dd/MM/yyyy",provider);
                        this.PersonaActual.IDPlan = int.Parse(this.cbPlanes.SelectedValue.ToString());
                        this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                        this.PersonaActual.TipoPersona = this.cbTP.SelectedIndex+1;
                        this.PersonaActual.Telefono = txtTelefono.Text;
                        PersonaActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.PersonaActual.ID = int.Parse(this.txtId.Text);
                        this.PersonaActual.Apellido = this.txtApellido.Text;
                        this.PersonaActual.Nombre = this.txtNombre.Text;
                        this.PersonaActual.Direccion = this.txtDireccion.Text;
                        this.PersonaActual.EMail = this.txtEmail.Text;
                        this.PersonaActual.FechaNacimiento = DateTime.ParseExact(this.txtFechaNac.Text, "dd/MM/yyyy", provider);
                        this.PersonaActual.IDPlan = int.Parse(this.cbPlanes.SelectedValue.ToString());
                        this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                        this.PersonaActual.TipoPersona = this.cbTP.SelectedIndex+1;
                        this.PersonaActual.Telefono = txtTelefono.Text;
                        PersonaActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.PersonaActual.ID = int.Parse(this.txtId.Text);
                        this.PersonaActual.Apellido = this.txtApellido.Text;
                        this.PersonaActual.Nombre = this.txtNombre.Text;
                        this.PersonaActual.Direccion = this.txtDireccion.Text;
                        this.PersonaActual.EMail = this.txtEmail.Text;
                        this.PersonaActual.FechaNacimiento = DateTime.ParseExact(this.txtFechaNac.Text, "dd/MM/yyyy", provider);
                        this.PersonaActual.IDPlan = int.Parse(this.cbPlanes.SelectedValue.ToString());
                        this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                        this.PersonaActual.TipoPersona = this.cbTP.SelectedIndex+1;
                        this.PersonaActual.Telefono = txtTelefono.Text;
                        PersonaActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }

        }
        public override void MapearDeDatos()
        {

            this.txtId.Text = this.PersonaActual.ID.ToString();
            this.txtNombre.Text = this.PersonaActual.Nombre;
            this.txtApellido.Text = this.PersonaActual.Apellido;
            this.txtDireccion.Text = this.PersonaActual.Direccion;
            this.txtEmail.Text = this.PersonaActual.EMail;
            this.txtTelefono.Text = this.PersonaActual.Telefono;
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.txtFechaNac.Text = this.PersonaActual.FechaNacimiento.ToString("dd/MM/yyyy");
            this.cbPlanes.SelectedValue = this.PersonaActual.IDPlan;
            this.cbTP.SelectedIndex = this.PersonaActual.TipoPersona-1;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public override void GuardarCambios()
        {
            
            PersonaLogic per = new PersonaLogic();
            per.Save(this.PersonaActual);
        }
        public override bool Validar()
        {
            bool resp = false;

            if (this.rx.IsMatch(this.txtFechaNac.Text)) { resp = true; ; }
            else { this.Notificar("Mal formato", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            return resp;
        }
        public int dev()
        {
            if (this.PersonaActual != null)
            {
                return this.PersonaActual.TipoPersona;}
            else { return 0; }
          
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Validar()) { 
                    this.GuardarCambios();
                if (this.Modo == ModoForm.Alta) {
                    UsuarioDesktop usua = new UsuarioDesktop(true, ModoForm.Alta);
                    
                }
                    this.Close(); 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            PlanLogic plan = new PlanLogic();
            cbPlanes.DataSource = plan.GetAll();
            cbPlanes.DisplayMember = "Descripcion";
            cbPlanes.ValueMember = "id";
        }

        private void txtFechaNac_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFechaNac_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
