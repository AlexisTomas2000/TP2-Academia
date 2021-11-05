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
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        #region Props
        private int op=0;
        private Usuario Entity {
            get;
            set;
        }
        private int SelectedID {
            get {
                if (this.ViewState["SelectedID"] != null) { return (int)this.ViewState["SelectedID"]; }
                else { return 0; }
            }
            set {
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
        private Persona p;

        PersonaLogic _pLogic;
        private PersonaLogic PLogic
        {
            get
            {

                if (_pLogic == null)
                {
                    _pLogic = new PersonaLogic();
                }

                return _pLogic;
            }

        }
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {

                if (_logic == null) {
                    _logic = new UsuarioLogic();
                }

                return _logic;
            }

        }

        public Persona P { get => p; set => p = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
           this.LoadGrid();
            bool vuelta = false;
            if (Request.QueryString.AllKeys.Contains("vuelta"))
            {
                Boolean.TryParse(Request.QueryString["vuelta"], out vuelta);
            }
            if(vuelta){
                this.Panel1.Visible = false;
                op = 1;
                P = PLogic.Ult();
                this.nuevoLinkButton_Click(sender,e);
            }
            if(!IsPostBack)
            {
                Session["Usu"] = null;
            }else if (Session["Usu"]!=null)
            {
                this.EnableForm(true);
                Entity = (Usuario)Session["Usu"];
            }
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        private void LoadForm(int id) {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.emailTextBox.Text = this.Entity.EMail;
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;
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

        private void LoadEntity(Usuario usuario)
        {
            usuario.Nombre = this.nombreTextBox.Text;
            usuario.Apellido = this.apellidoTextBox.Text;
            usuario.EMail = this.emailTextBox.Text;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Clave = this.claveTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
        }
        private void LoadEntityAlt(Usuario usuario)
        {
            usuario.Nombre = P.Nombre;
            usuario.Apellido = P.Apellido;
            usuario.EMail = P.EMail;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Clave = this.claveTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
            usuario.IdPersona = P.ID;
        }

        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {


            switch (this.FormMode)
            {
                case FormModes.Baja:

                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Modificacion:

                    this.Entity = new Usuario();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:

                    this.Entity = new Usuario();
                    this.Entity.State = BusinessEntity.States.New;
                    if (op == 0)
                    { 
                    this.LoadEntity(this.Entity);
                    }
                    else { this.LoadEntityAlt(this.Entity); }

                    this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.formPanel.Visible = false;
       
                    break;
                    default:
                    break;
            }
        }


        private void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.nombreUsuarioTextBox.Enabled = enable;
            this.claveTextBox.Visible = enable;
            this.claveLabel.Visible = enable;
            this.txtBusN.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
        }

        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Checked = false;
            this.nombreUsuarioTextBox.Text = string.Empty;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
           
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
            if (op == 1) { this.cargatxt(); }
        }

        private void cargatxt()
        {
            nombreTextBox.Text = P.Nombre;
            apellidoTextBox.Text = P.Apellido;
            emailTextBox.Text = P.EMail;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
        }


        protected void txtBuscCla_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void txtBusN_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void repetirClaveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButtonBuscar_Click(object sender, EventArgs e)
        {
            Session["Usu"] = Logic.FindOne(txtBusN.Text, txtBuscCla.Text);
            Entity = (Usuario)Session["Usu"];
            if (Entity!=null)
            {
                this.formPanel.Visible = true;
               // this.FormMode = FormModes.Modificacion;
                this.LoadForm(Entity.ID);
            }

        }
    }
}