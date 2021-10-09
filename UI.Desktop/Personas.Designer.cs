
namespace UI.Desktop
{
    partial class Personas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbEleccion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersona
            // 
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Legajo,
            this.Direccion,
            this.Telefono,
            this.Email,
            this.Fecha_Nacimiento,
            this.IDPlan,
            this.Tipo_Persona});
            this.dgvPersona.Location = new System.Drawing.Point(12, 28);
            this.dgvPersona.MultiSelect = false;
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersona.Size = new System.Drawing.Size(945, 381);
            this.dgvPersona.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "EMail";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.DataPropertyName = "FechaNacimiento";
            this.Fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            // 
            // IDPlan
            // 
            this.IDPlan.DataPropertyName = "IDPlan";
            this.IDPlan.HeaderText = "IDPlan";
            this.IDPlan.Name = "IDPlan";
            // 
            // Tipo_Persona
            // 
            this.Tipo_Persona.DataPropertyName = "TipoPersona";
            this.Tipo_Persona.HeaderText = "Tipo_Persona";
            this.Tipo_Persona.Name = "Tipo_Persona";
            this.Tipo_Persona.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(881, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbEleccion
            // 
            this.cbEleccion.FormattingEnabled = true;
            this.cbEleccion.Location = new System.Drawing.Point(754, 415);
            this.cbEleccion.Name = "cbEleccion";
            this.cbEleccion.Size = new System.Drawing.Size(121, 21);
            this.cbEleccion.TabIndex = 5;
            this.cbEleccion.Text = "Alumnos";
            this.cbEleccion.SelectedIndexChanged += new System.EventHandler(this.cbEleccion_SelectedIndexChanged);
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.cbEleccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPersona);
            this.Name = "Personas";
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Persona;
        private System.Windows.Forms.ComboBox cbEleccion;
    }
}