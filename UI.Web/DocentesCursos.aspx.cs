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

        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
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

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {

        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {

        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {

        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {

        }
    }
}