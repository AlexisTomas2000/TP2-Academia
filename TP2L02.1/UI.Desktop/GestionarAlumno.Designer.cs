
namespace UI.Desktop
{
    partial class GestionarAlumno
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblIDAlumno = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.lblGestionAlum = new System.Windows.Forms.Label();
            this.dgvGA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGA)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(127, 53);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(100, 20);
            this.txtCondicion.TabIndex = 0;
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Location = new System.Drawing.Point(127, 107);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtIdAlumno.TabIndex = 1;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(482, 53);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(100, 20);
            this.txtIdCurso.TabIndex = 2;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(482, 107);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 3;
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(61, 56);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 4;
            this.lblCondicion.Text = "Condicion";
            // 
            // lblIDAlumno
            // 
            this.lblIDAlumno.AutoSize = true;
            this.lblIDAlumno.Location = new System.Drawing.Point(65, 110);
            this.lblIDAlumno.Name = "lblIDAlumno";
            this.lblIDAlumno.Size = new System.Drawing.Size(56, 13);
            this.lblIDAlumno.TabIndex = 5;
            this.lblIDAlumno.Text = "ID Alumno";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(420, 56);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(48, 13);
            this.lblIDCurso.TabIndex = 6;
            this.lblIDCurso.Text = "ID Curso";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(420, 114);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 7;
            this.lblNota.Text = "Nota";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 309);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(204, 309);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(409, 309);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(584, 309);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 11;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // lblGestionAlum
            // 
            this.lblGestionAlum.AutoSize = true;
            this.lblGestionAlum.Font = new System.Drawing.Font("Consolas", 14F);
            this.lblGestionAlum.Location = new System.Drawing.Point(239, 9);
            this.lblGestionAlum.Name = "lblGestionAlum";
            this.lblGestionAlum.Size = new System.Drawing.Size(170, 22);
            this.lblGestionAlum.TabIndex = 12;
            this.lblGestionAlum.Text = "Gestionar Alumno";
            this.lblGestionAlum.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvGA
            // 
            this.dgvGA.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvGA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGA.Location = new System.Drawing.Point(11, 133);
            this.dgvGA.Name = "dgvGA";
            this.dgvGA.Size = new System.Drawing.Size(648, 170);
            this.dgvGA.TabIndex = 13;
            this.dgvGA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GestionarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 344);
            this.Controls.Add(this.dgvGA);
            this.Controls.Add(this.lblGestionAlum);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.lblIDAlumno);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.txtIdAlumno);
            this.Controls.Add(this.txtCondicion);
            this.Name = "GestionarAlumno";
            this.Text = "GestionarAlumno";
            this.Load += new System.EventHandler(this.GestionarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtIdAlumno;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblIDAlumno;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label lblGestionAlum;
        private System.Windows.Forms.DataGridView dgvGA;
    }
}

