﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Personas : System.Web.UI.Page
    {
        #region Props
        private Persona Entity
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

        private PersonaLogic _logic;
        private PersonaLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new PersonaLogic();
                }

                return _logic;
            }

        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack) {
                this.cargarDDLS();
                this.cargarDDLP();
            }
        }

        private void LoadGrid()
        {
        }
        private void cargarDDLP() {
            PlanLogic m = new PlanLogic();
            ddlPlan.DataSource = m.GetAll();
            ddlPlan.DataTextField = "Descripcion";
            ddlPlan.DataValueField = "ID";
            ddlPlan.DataBind();
        }
        private void cargarDDLS() {
            ddlSelec.Items.Add("Alumnos");
            ddlSelec.Items.Add("Profesores");
            if (ddlSelec.SelectedIndex == 1)
            {
                this.ListarP();
            }

            else { this.ListarA(); }

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Actualizar();
        }

        public void ListarA() {
            this.gridView.DataSource = this.Logic.GetAllA();
            this.gridView.DataBind();
        }

        public void ListarP() {
            this.gridView.DataSource = this.Logic.GetAllP();
            this.gridView.DataBind();
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.idPersonaTextBox.Text = this.Entity.ID.ToString();
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.legajoTextBox.Text = this.Entity.Legajo.ToString();
            this.direccionTextBox.Text = this.Entity.Direccion;
            this.telefonoTextBox.Text = this.Entity.Telefono;
            this.emailTextBox.Text = this.Entity.EMail;
            this.fechaNacTextBox.Text = this.Entity.FechaNacimiento.ToString("dd/MM/yyyy");
            this.ddlPlan.SelectedIndex = this.Entity.IDPlan;
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }
        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Persona();
                    this.Entity.State = BusinessEntity.States.New;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.Actualizar();
                    this.Form.Visible = false;
                    
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.Actualizar();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Persona();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.Actualizar();
                    this.formPanel.Visible = false;
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

        private void EnableForm(bool enable) {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.legajoTextBox.Enabled = enable;
            this.direccionTextBox.Enabled = enable;
            this.telefonoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.ddlPlan.Enabled = enable;
        }
        private void ClearForm() {
            this.idPersonaTextBox.Text = string.Empty;
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.legajoTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
        }

        private void DeleteEntity(int id) {
            this.Logic.Delete(id);
        }

        private void SaveEntity(Persona per) {
            this.Logic.Save(per);
        }

        private void LoadEntity(Persona per) {
            CultureInfo provider = CultureInfo.InvariantCulture;
            per.Nombre = this.nombreTextBox.Text;
            per.Apellido = this.apellidoTextBox.Text;
            per.Legajo = int.Parse(this.legajoTextBox.Text);
            per.Direccion = this.direccionTextBox.Text;
            per.FechaNacimiento = Convert.ToDateTime(this.fechaNacTextBox.Text);
            per.Telefono = this.telefonoTextBox.Text;
            if (ddlSelec.SelectedIndex == 1)
            {
                per.TipoPersona = 2;
            }
            else { per.TipoPersona = 1; }
            per.EMail = this.emailTextBox.Text;
            per.IDPlan = int.Parse(this.ddlPlan.Text);
        }

        private void Actualizar() {
            if (ddlSelec.SelectedIndex == 1)
            {
                this.ListarP();
            }

            else { this.ListarA(); }
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
    }
}