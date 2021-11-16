using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Cursos : System.Web.UI.Page
    {
        #region props
        public Persona Ent { get => _ent; set => _ent = value; }

        private Persona _ent;

        private Curso Entity
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

        private CursoLogic _logic;
        private CursoLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new CursoLogic();
                }

                return _logic;
            }
        }


        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
            if (!this.IsPostBack)
            {
                this.cargarDDl();
            }
            Ent = (Persona)Session["Persona"];
            if (Ent.TipoPersona==1 || Ent.TipoPersona==2)
            {
                this.HideOrShow(false);
            }
            else
            {
                this.HideOrShow(true);
            }
           
        }

        private void listar()
        {
            this.gridView.DataSource = this.Logic.GetAllD();
            this.gridView.DataBind();
        }

        private void cargarDDl()
        {
            MateriaLogic m = new MateriaLogic();
            ddlMat.DataSource = m.GetAll();
            ddlMat.DataTextField = "Descripcion";
            ddlMat.DataValueField = "ID";
            ddlMat.DataBind();
            ComisionLogic c = new ComisionLogic();
            ddlCom.DataSource = c.GetAll();
            ddlCom.DataTextField = "Descripcion";
            ddlCom.DataValueField = "ID";
            ddlCom.DataBind();
        }

        private void LoadFrom(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.txtID.Text = this.Entity.ID.ToString();
            this.txtAño.Text = this.Entity.AnioCalendario.ToString();
            this.txtCupo.Text = this.Entity.Cupo.ToString();
            this.ddlCom.Text = this.Entity.IDComision.ToString();
            this.ddlMat.Text = this.Entity.IDMateria.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
            this.LoadFrom(this.SelectedID);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.formPanel.Visible = false;
        }
        private void DaleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DaleteEntity(this.SelectedID);
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Curso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Curso();
                    this.Entity.State = BusinessEntity.States.New;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.formPanel.Visible = false;

                    break;
                default:
                    break;
            }
        }
        private void EnableForm(bool enable)
        {
            this.txtAño.Enabled = enable;
            this.txtCupo.Enabled = enable;
            this.txtID.Enabled = enable;
            this.ddlCom.Enabled = enable;
            this.ddlMat.Enabled = enable;
        }
        private void ClearForm()
        {
            this.txtAño.Text = string.Empty;
            this.txtCupo.Text = string.Empty;
            this.txtID.Text = string.Empty; 

        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadFrom(this.SelectedID);
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if(this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadFrom(this.SelectedID);
            }
        }

        private void LoadEntity(Curso cur)
        {
            cur.IDComision = int.Parse(this.ddlCom.Text);
            cur.IDMateria = int.Parse(this.ddlMat.Text);
            cur.AnioCalendario = int.Parse(this.txtAño.Text);
            cur.Cupo = int.Parse(this.txtCupo.Text);
        }
        private void SaveEntity(Curso cur)
        {
            this.Logic.Save(cur);
        }
        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }
        private void HideOrShow(bool v)
        {
            this.formActionsPanel.Visible = v;
            this.gridActionsPanel.Visible = v;
            this.gridView.Columns[5].Visible = v;
            this.gridView.Columns[4].Visible = v;

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default");
        }
    }
}