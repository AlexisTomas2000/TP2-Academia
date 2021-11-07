using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class DocenteCursoDesktop : ApplicationForm
    {
        private Business.Entities.DocenteCurso _dcActual;

        public Business.Entities.DocenteCurso DcActual { get => _dcActual; set => _dcActual = value; }
        public DocenteCursoDesktop()
        {
            InitializeComponent();
        }
        public DocenteCursoDesktop(ModoForm modo):this()
        {
            this.Modo = modo;
        }

        public DocenteCursoDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            DocenteCursoLogic dcl =new  DocenteCursoLogic();
            DcActual = dcl.GetOne(id);
            this.MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.DcActual.ID.ToString();
            this.txtIDdoc.Text = this.DcActual.IDDocente.ToString();
            this.cbCargo.SelectedIndex=this.DcActual.Cargo;
            this.cbIDcurso.SelectedValue = this.DcActual.IDCurso;
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
                        DocenteCurso Dc = new DocenteCurso();
                        DcActual = Dc;
                        this.DcActual.IDCurso = int.Parse(cbIDcurso.SelectedValue.ToString());
                        this.DcActual.Cargo = int.Parse(cbCargo.SelectedIndex.ToString());
                        this.DcActual.IDDocente = int.Parse(this.txtIDdoc.Text);
                        DcActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.DcActual.ID = int.Parse(txtID.Text);
                        this.DcActual.IDCurso = int.Parse(cbIDcurso.SelectedValue.ToString());
                        this.DcActual.Cargo = int.Parse(cbCargo.SelectedIndex.ToString());
                        this.DcActual.IDDocente = int.Parse(this.txtIDdoc.Text);
                        DcActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.DcActual.ID = int.Parse(txtID.Text);
                        this.DcActual.IDCurso = int.Parse(cbIDcurso.SelectedValue.ToString());
                        this.DcActual.Cargo = int.Parse(cbCargo.SelectedIndex.ToString());
                        this.DcActual.IDDocente = int.Parse(this.txtIDdoc.Text);
                        DcActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }
        }

        private void DocenteCursoDesktop_Load(object sender, EventArgs e)
        {
            CursoLogic curl = new CursoLogic();
            cbIDcurso.DataSource = curl.GetAll();
            cbIDcurso.DisplayMember = "IDCurso";
            cbIDcurso.ValueMember = "ID";
            cbCargo.SelectedIndex = 0;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            dcl.Save(this.DcActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Validar()){ 
            this.GuardarCambios();
            this.Close();
        
            }
        }
        public override bool Validar()
        {
           bool rta = false;
            Regex rx = new Regex(@"^[0-9]{1,5}$");
            if (!txtIDdoc.Text.Equals("")) { 
                if(rx.IsMatch(txtIDdoc.Text))
                {
                PersonaLogic p = new PersonaLogic();
                    Persona pe = p.GetOne(int.Parse(txtIDdoc.Text));
                    if (pe.ID != 0)
                    {
                        if(pe.TipoPersona==2)
                        {
                            DialogResult resul=MessageBox.Show(pe.Nombre + " " + pe.Apellido + "\n" +"Legajo:" + pe.Legajo, "Usted es:", MessageBoxButtons.YesNo);
                            if(resul==DialogResult.Yes)
                            {
                                rta=true;
                            }
                            else { MessageBox.Show("Vuelva a ingresar otro id"); }
                        }
                        else { MessageBox.Show("El id ingresado no es de un profesor"); }

                    } else { MessageBox.Show("El id ingresado no existe o es mayor a 5 digitos"); }
                }
                else { MessageBox.Show("El id ingresado debe tener solo numeros"); }
            }
            else { MessageBox.Show("El id ingresado no puede ser vacio"); }
            return rta;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
