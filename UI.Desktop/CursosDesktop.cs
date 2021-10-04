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
    public partial class CursosDesktop : ApplicationForm
    {
        private Business.Entities.Curso _CursoActual;
        public Business.Entities.Curso CursoActual { get => this._CursoActual; set => this._CursoActual = value; }
        public CursosDesktop()
        {
            InitializeComponent();
        }
        public CursosDesktop(ModoForm modo):this()
        {
            this.Modo = modo;
        }
        public CursosDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            CursoLogic cur = new CursoLogic();
            CursoActual = cur.GetOne(id);
            this.MapearDeDatos();
        }
        public override void MapearDeDatos()
        {

            this.txtID.Text = this.CursoActual.ID.ToString();
            this.txbAño.Text = this.CursoActual.AnioCalendario.ToString();
            this.txbCupo.Text = this.CursoActual.Cupo.ToString();
            this.cbIDCom.SelectedValue = this.CursoActual.IDComision;
            this.cbMate.SelectedValue = this.CursoActual.IDMateria;

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
                        Curso cur = new Curso();
                        CursoActual = cur;
                        this.CursoActual.IDComision = int.Parse(cbIDCom.SelectedValue.ToString());
                        this.CursoActual.IDMateria = int.Parse(cbMate.SelectedValue.ToString());
                        this.CursoActual.Cupo = int.Parse(this.txbCupo.Text);
                        this.CursoActual.AnioCalendario = int.Parse(this.txbAño.Text);
                        CursoActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                            this.CursoActual.ID = int.Parse(this.txtID.Text);
                            this.CursoActual.IDComision = int.Parse(cbIDCom.SelectedValue.ToString());
                            this.CursoActual.IDMateria = int.Parse(cbMate.SelectedValue.ToString());
                            this.CursoActual.Cupo = int.Parse(this.txbCupo.Text);
                            this.CursoActual.AnioCalendario = int.Parse(this.txbAño.Text);
                            CursoActual.State = BusinessEntity.States.Modified;
                            break;                       
                    }
                case ModoForm.Baja:
                    {
                        this.CursoActual.ID = int.Parse(this.txtID.Text);
                        this.CursoActual.IDComision = int.Parse(cbIDCom.SelectedValue.ToString());
                        this.CursoActual.IDMateria = int.Parse(cbMate.SelectedValue.ToString());
                        this.CursoActual.Cupo = int.Parse(this.txbCupo.Text);
                        this.CursoActual.AnioCalendario = int.Parse(this.txbAño.Text);
                        CursoActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }

        }
        private void CursosDesktop_Load(object sender, EventArgs e)
        {
            MateriaLogic mat = new MateriaLogic();
            cbMate.DataSource = mat.GetAll();
            cbMate.DisplayMember = "Descripcion";
            cbMate.ValueMember = "id";
            ComisionLogic com = new ComisionLogic();
            cbIDCom.DataSource = com.GetAll();
            cbIDCom.DisplayMember = "Descripcion";
            cbIDCom.ValueMember = "id";
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic cur = new CursoLogic();
            cur.Save(this.CursoActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
