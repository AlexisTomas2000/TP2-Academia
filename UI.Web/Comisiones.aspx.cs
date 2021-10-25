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
    public partial class Comisiones : System.Web.UI.Page
    {
        private Comision Entity
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
        private ComisionLogic _logic;
        //private PlanLogic _plogic;

        public ComisionLogic Logic { get 
            {
                if(_logic==null)
                {
                    _logic = new ComisionLogic();
                }
                return _logic;
            } }
       // public PlanLogic Plogic { get => _plogic; set => _plogic = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            { this.cargarDDl();
            }
            
            this.LoadGrid();
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.txtID.Text = this.Entity.ID.ToString();
            this.txtDesc.Text = this.Entity.Descripcion;
            this.txtAño.Text = this.Entity.AnioEspecialidad.ToString();
            PlanLogic p = new PlanLogic();
            ddlIdPlan.DataValueField = this.Entity.IdPlan.ToString();
        }
        private void cargarDDl()
        {
            PlanLogic p = new PlanLogic();
            ddlIdPlan.DataSource = p.GetAll();
            ddlIdPlan.DataTextField = "Descripcion";
            ddlIdPlan.DataValueField = "ID";
            ddlIdPlan.DataBind();
        }
        private void LoadGrid()
        {
            this.gridView1.DataSource = this.Logic.GetAll();
            this.gridView1.DataBind();
        }

  
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView1.SelectedValue;
        }
        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.txtID.Enabled = false;
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            this.ocultarerror();
            switch (this.FormMode)
            { 
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    this.ocultarerror();
                    break;
                case FormModes.Modificacion:
                    if(validar())
                    {
                        this.ocultarerror();
                        this.Entity = new Comision();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.ocultarerror();
                        this.formPanel.Visible = false;
                    }
                    break;
                case FormModes.Alta:
                    if (validar())
                    {
                        
                        this.ocultarerror();
                        this.Entity = new Comision();
                        this.Entity.State = BusinessEntity.States.New;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.ocultarerror();
                        this.formPanel.Visible = false;
                    }
                    break;
                default:
                    break;

            }
        }

        private bool validar()
        {
            return true;
        }

        private void ocultarerror()
        {
            lblIDeE.Visible = false;
            lblIDeE.Visible = false;
            lblEA.Visible = false;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
        }
        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if(this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }
        private void EnableForm(bool enable)
        {
            this.txtID.Enabled = enable;
            this.txtDesc.Enabled = enable;
            this.txtAño.Enabled = enable;
            this.ddlIdPlan.Enabled = enable;
        }
        private void ClearForm()
        {
            this.txtID.Text = string.Empty;
            this.txtAño.Text = string.Empty;
            this.txtDesc.Text = string.Empty;
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
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        private void LoadEntity(Comision com)
        {
            //com.ID =int.Parse( this.txtID.Text);
            com.Descripcion = txtDesc.Text;
            com.AnioEspecialidad=int.Parse(this.txtAño.Text);
            com.IdPlan = this.ddlIdPlan.SelectedIndex;
        }
        private void SaveEntity(Comision com)
        {
            this.Logic.Save(com);
        }
    }
}