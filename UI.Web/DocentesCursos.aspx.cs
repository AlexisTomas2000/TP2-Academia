using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;

namespace UI.Web
{
    public partial class DocentesCursos : System.Web.UI.Page
    {
        #region props
        private Business.Entities.Persona _ent;

        public Persona Ent { get => _ent; set => _ent = value; }
        private DocenteCurso Entity {
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



        private DocenteCursoLogic _logic;
        public DocenteCursoLogic Logic {
            get
            {

                if (_logic == null)
                {
                    _logic = new DocenteCursoLogic();
                }

                return _logic;
            }
        }

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
            if (!this.IsPostBack) {
                this.cargarDDL();
            }
            Ent = (Persona)Session["Persona"];
            
        }

        private void listar()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
            this.LoadForm(this.SelectedID);
        }
        private void cargarDDL() {
            CursoLogic cur = new CursoLogic();
            ddlCurso.DataSource = cur.GetAll();
            ddlCurso.DataTextField = "ID";
            ddlCurso.DataValueField = "ID";
            ddlCurso.DataBind();
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.idTextBox.Text = (this.Entity.ID).ToString();
            this.ddlCurso.Text = this.Entity.IDCurso.ToString();
            this.idDocenteTextBox.Text = this.Entity.IDDocente.ToString();
            this.ddlCargo.Text = this.Entity.Cargo.ToString();

        }

        private void LoadEntity(DocenteCurso doc) {
            doc.IDDocente = int.Parse(this.idDocenteTextBox.Text);
            doc.IDCurso = int.Parse(this.ddlCurso.Text);
            doc.Cargo = this.ddlCargo.SelectedIndex;
        }

        private void SaveEntity(DocenteCurso doc) {
            this.Logic.Save(doc);
        }

        private void DeleteEntity(int id) {
            this.Logic.Delete(id);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {


            switch (this.FormMode)
            {
                case FormModes.Baja:

                    this.DeleteEntity(this.SelectedID);
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Modificacion:

                    {

                        this.Entity = new DocenteCurso(); ;
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.formPanel.Visible = false;

                    }
                    break;
                case FormModes.Alta:

                    {

                        this.Entity = new DocenteCurso();
                        this.Entity.State = BusinessEntity.States.New;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.formPanel.Visible = false;

                    }
                    break;
                default:
                    break;
            }
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.formPanel.Visible = false;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected) {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void EnableForm(bool enable) {
            this.idDocenteTextBox.Enabled = enable;
            this.ddlCargo.Enabled = enable;
            this.ddlCurso.Enabled = enable;
        }

        private void ClearForm() {
            this.idTextBox.Text = string.Empty;
            this.idDocenteTextBox.Text = string.Empty;
            //this.ddlCurso.Text = string.Empty;
            //this.ddlCargo.Text =string.Empty;
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default");
        }
    }
}