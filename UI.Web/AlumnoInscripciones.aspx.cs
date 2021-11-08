using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;

namespace UI.Web
{

    public partial class AlumnoInscripciones : System.Web.UI.Page
    {
        private Persona p;
        private AlumnoInscripcion Entity
        {
            get;
            set;
        }
        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null) { return (int)this.ViewState["SelectedID"]; }
                else { return 0; }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        private bool isEntitySelected
        {
            get { return (this.SelectedID != 0); }
        }
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private AlumnoInscripcionLogic _logic;
        private AlumnoInscripcionLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new AlumnoInscripcionLogic();
                }

                return _logic;
            }

        }

        public Persona P { get => p; set => p = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            this.Listar();
            if (!this.IsPostBack) 
            {
                this.cargarddl();
            }
            if(Session["Persona"]!=null)
            {
                P = (Persona)Session["Persona"];
                txtIDAlumno.Text = p.ID.ToString();
            }
        }

        private void Listar()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        private void cargarddl()
        {
            CursoLogic cl = new CursoLogic();
            ddlCurso.DataSource = cl.GetAll();
            ddlCurso.DataTextField = "ID";
            ddlCurso.DataValueField = "ID";
            ddlCurso.DataBind();
            ListItem i= new ListItem("Inscripto", "1");
            ddlCondicion.Items.Add(i);
            ListItem w = new ListItem("Regular", "2");
            ddlCondicion.Items.Add(w);
            ListItem b = new ListItem("Aprobacion Directa", "3");
            ddlCondicion.Items.Add(b);
            ListItem d = new ListItem("Recursa", "4");
            ddlCondicion.Items.Add(d);
            for (int c = 0; c < 10; c++)
            {
                ListItem a = new ListItem(c.ToString(), c.ToString());
                ddlNota.Items.Add(a);
            }
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new AlumnoInscripcion();
                    this.Entity.State = BusinessEntity.States.New;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.Form.Visible = false;
                    this.Listar();
                    break;
                case FormModes.Baja:
                    this.DeleteEntity();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Modificacion:
                    this.Entity = new AlumnoInscripcion();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.formPanel.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void DeleteEntity()
        {
            AlumnoInscripcion a = Logic.GetOne2(this.SelectedID);
            this.Logic.Delete(a.IDAlumno,a.IDCurso);
        }

        private void SaveEntity(AlumnoInscripcion entity)
        {
            this.Logic.Save(entity);
        }

        private void LoadEntity(AlumnoInscripcion entity)
        {
            entity.IDCurso = int.Parse(this.ddlCurso.Text);
            entity.Condicion = ddlCondicion.SelectedItem.Text;
            entity.Nota = int.Parse(this.ddlNota.Text);
            entity.IDAlumno = p.ID;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.formPanel.Visible = false;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if(this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                    this.LoadFrom(this.SelectedID);
            }
        }

        private void LoadFrom(int selectedID)
        {
            this.Entity = this.Logic.GetOne2(selectedID);
            this.txtIDAlumno.Text = this.Entity.IDAlumno.ToString();
            this.ddlCurso.SelectedValue = this.Entity.IDCurso.ToString();
            this.ddlCondicion.SelectedItem.Text = this.Entity.Condicion;
            this.ddlNota.SelectedIndex = this.Entity.Nota;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if(this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableFrom(false);
                this.LoadFrom(this.SelectedID);
            }
        }
        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.txtIDAlumno.Text = p.ID.ToString();
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableFrom(true);
        }

        private void ClearForm()
        {
            this.txtIDAlumno.Text = string.Empty;
        }

        private void EnableFrom(bool enable)
        {
            this.txtIDAlumno.Enabled = enable;
            this.ddlCondicion.Enabled = enable;
            this.ddlCurso.Enabled = enable;
            this.ddlNota.Enabled = enable;
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }
    }
}