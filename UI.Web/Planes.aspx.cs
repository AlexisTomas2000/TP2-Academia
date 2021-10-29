using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;


namespace UI.Web
{
    public partial class Plan : System.Web.UI.Page
    {
        #region Props
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargarDD1();
            }
            this.LoadGrid();
        }

        private Business.Entities.Plan Entity
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
        #endregion
        PlanLogic _logic;
        private PlanLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new PlanLogic();
                }

                return _logic;
            }

        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        private void cargarDD1()
        {
            PlanLogic p = new PlanLogic();
            ddlIDEsp.DataSource = p.GetAll();
            ddlIDEsp.DataTextField = "Descripcion";
            ddlIDEsp.DataValueField = "ID";
            ddlIDEsp.DataBind();
        }

        private void LoadForm(int ID)
        {
            this.Entity = this.Logic.GetOne(ID);
            this.DescripcionTextBox.Text = this.Entity.Descripcion;
            ddlIDEsp.DataValueField = this.Entity.IDEspecialidad.ToString();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
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

        private void LoadEntity(Business.Entities.Plan plan)
        {
            plan.Descripcion = this.DescripcionTextBox.Text;
            plan.IDEspecialidad = int.Parse(this.ddlIDEsp.SelectedValue.ToString());
        }

        private void SaveEntity(Business.Entities.Plan plan)
        {
            this.Logic.Save(plan);
        }



        private void ocultarerror()
        {
            txtDesc.Visible = false;
            ddlIDEsp.Visible = false;

        }

        private void EnableForm(bool enable)
        {
            this.DescripcionTextBox.Enabled = enable;
            this.ddlIDEsp.Enabled = enable;
        }

        private void ClearForm()
        {
            this.DescripcionTextBox.Text = string.Empty;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private bool validar()
        {
            bool rta = false;
            Regex rx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!("".Equals(DescripcionTextBox.Text)))
            {
                if (!("".Equals(ddlIDEsp.Text)))
                {
                    rta = true;
                }
            }
            else { this.txtDesc.Visible = true; }
            return rta;
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
                        this.Entity = new Business.Entities.Plan();
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
                        this.Entity = new Business.Entities.Plan();
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

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
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
    }
}