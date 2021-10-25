using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Materias : System.Web.UI.Page
    {
        #region Props
        private Materia Entity{
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
        #endregion

        private MateriaLogic _logic;
        private MateriaLogic Logic {
            get
            {

                if (_logic == null)
                {
                    _logic = new MateriaLogic();
                }

                return _logic;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            this.LoadGrid();
            if (!this.IsPostBack) {
                this.cargarDDl();
            }
        }

        private void LoadGrid() {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.idTextBox.Text = (this.Entity.ID).ToString();
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.hsSemTextBox.Text = this.Entity.HsSemanales.ToString();
            this.hsTotTextBox.Text = this.Entity.HsTotales.ToString();
            this.ddlPlan.Text = this.Entity.IDPlan.ToString();
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
        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        private void LoadEntity(Materia materia)
        {
            materia.Descripcion= this.descripcionTextBox.Text;
            materia.HsSemanales = int.Parse(this.hsSemTextBox.Text);
            materia.HsTotales = int.Parse(this.hsTotTextBox.Text);
            materia.IDPlan = int.Parse(this.ddlPlan.Text);
        }

        private void SaveEntity(Materia materia)
        {
            this.Logic.Save(materia);
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
                    if (validar())
                    {
                        this.ocultarerror();
                        this.Entity = new Materia(); ;
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
                        this.Entity = new Materia() ;
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

        private void EnableForm(bool enable)
        {
            this.idTextBox.Enabled = enable;
            this.descripcionTextBox.Enabled = enable;
            this.hsSemTextBox.Enabled = enable;
            this.hsTotTextBox.Enabled = enable;
            this.ddlPlan.Enabled = enable;

        }

        private void ClearForm()
        {
            this.idTextBox.Text = string.Empty;
            this.descripcionTextBox.Text = string.Empty;
            this.hsSemTextBox.Text = string.Empty;
            this.hsTotTextBox.Text = string.Empty;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
        }

        private void ocultarerror()
        {
            txtDesc.Visible = false;
            txtHsSem.Visible = false;
            txtHsTot.Visible = false;
            txtIDPlan.Visible = false;
        }

        private bool validar()
        {
            bool rta = false;

            if (!("".Equals(descripcionTextBox.Text)))
            {
                if (!("".Equals(hsSemTextBox.Text)))
                {
                    if (!("".Equals(hsTotTextBox.Text)))
                    {
                        if (!("".Equals(ddlPlan.Text)))
                        {
                            rta = true;
                        }
                        else { this.txtIDPlan.Visible = true; }
                    }
                    else { this.txtHsTot.Visible = true; }
                }
                else { this.txtHsSem.Visible = true; }
            }
            else { this.txtDesc.Visible = true; }
            return rta;
        }

        private void cargarDDl() {
            PlanLogic p = new PlanLogic();
            ddlPlan.DataSource = p.GetAll();
            ddlPlan.DataTextField = "Descripcion";
            ddlPlan.DataValueField = "ID";
            ddlPlan.DataBind();
        }

    }
}