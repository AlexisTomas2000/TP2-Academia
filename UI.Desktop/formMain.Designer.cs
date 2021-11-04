
namespace UI.Desktop
{
    partial class formMain
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
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRepoPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRepoCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDYC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnComisiones = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btbDC = new System.Windows.Forms.Button();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.BackColor = System.Drawing.Color.Bisque;
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            this.mnsPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsPrincipal_ItemClicked);
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbComisiones,
            this.tsbPlanes,
            this.tsbMaterias,
            this.tsbEspecialidades,
            this.tsbCursos,
            this.tsbUsuarios,
            this.tsbPersonas,
            this.tsbDYC,
            this.tsbInscripciones});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // tsbComisiones
            // 
            this.tsbComisiones.Name = "tsbComisiones";
            this.tsbComisiones.Size = new System.Drawing.Size(180, 22);
            this.tsbComisiones.Text = "Comisiones";
            this.tsbComisiones.Visible = false;
            this.tsbComisiones.Click += new System.EventHandler(this.tsbComisiones_Click);
            // 
            // tsbPlanes
            // 
            this.tsbPlanes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRepoPlanes});
            this.tsbPlanes.Name = "tsbPlanes";
            this.tsbPlanes.Size = new System.Drawing.Size(180, 22);
            this.tsbPlanes.Text = "Planes";
            this.tsbPlanes.Visible = false;
            // 
            // tsbRepoPlanes
            // 
            this.tsbRepoPlanes.Name = "tsbRepoPlanes";
            this.tsbRepoPlanes.Size = new System.Drawing.Size(180, 22);
            this.tsbRepoPlanes.Text = "Reporte de Planes";
            this.tsbRepoPlanes.Visible = false;
            // 
            // tsbMaterias
            // 
            this.tsbMaterias.Name = "tsbMaterias";
            this.tsbMaterias.Size = new System.Drawing.Size(180, 22);
            this.tsbMaterias.Text = "Materias";
            this.tsbMaterias.Visible = false;
            // 
            // tsbEspecialidades
            // 
            this.tsbEspecialidades.Name = "tsbEspecialidades";
            this.tsbEspecialidades.Size = new System.Drawing.Size(180, 22);
            this.tsbEspecialidades.Text = "Especialidades";
            this.tsbEspecialidades.Visible = false;
            // 
            // tsbCursos
            // 
            this.tsbCursos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRepoCurso});
            this.tsbCursos.Name = "tsbCursos";
            this.tsbCursos.Size = new System.Drawing.Size(180, 22);
            this.tsbCursos.Text = "Cursos";
            this.tsbCursos.Visible = false;
            // 
            // tsbRepoCurso
            // 
            this.tsbRepoCurso.Name = "tsbRepoCurso";
            this.tsbRepoCurso.Size = new System.Drawing.Size(180, 22);
            this.tsbRepoCurso.Text = "Reporte de cursos";
            this.tsbRepoCurso.Visible = false;
            this.tsbRepoCurso.Click += new System.EventHandler(this.tsbRepoCurso_Click);
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.Visible = false;
            // 
            // tsbPersonas
            // 
            this.tsbPersonas.Name = "tsbPersonas";
            this.tsbPersonas.Size = new System.Drawing.Size(180, 22);
            this.tsbPersonas.Text = "Personas";
            this.tsbPersonas.Visible = false;
            // 
            // tsbDYC
            // 
            this.tsbDYC.Name = "tsbDYC";
            this.tsbDYC.Size = new System.Drawing.Size(180, 22);
            this.tsbDYC.Text = "Docentes Y Cursos";
            this.tsbDYC.Visible = false;
            // 
            // tsbInscripciones
            // 
            this.tsbInscripciones.Name = "tsbInscripciones";
            this.tsbInscripciones.Size = new System.Drawing.Size(180, 22);
            this.tsbInscripciones.Text = "Inscripciones";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(10, 197);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(119, 32);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Visible = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnComisiones
            // 
            this.btnComisiones.Location = new System.Drawing.Point(175, 197);
            this.btnComisiones.Name = "btnComisiones";
            this.btnComisiones.Size = new System.Drawing.Size(119, 32);
            this.btnComisiones.TabIndex = 3;
            this.btnComisiones.Text = "Comisiones";
            this.btnComisiones.UseVisualStyleBackColor = true;
            this.btnComisiones.Visible = false;
            this.btnComisiones.Click += new System.EventHandler(this.btnComisiones_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Location = new System.Drawing.Point(337, 197);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(119, 32);
            this.btnPlanes.TabIndex = 4;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Visible = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.Location = new System.Drawing.Point(499, 197);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(119, 32);
            this.btnMaterias.TabIndex = 5;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Visible = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Location = new System.Drawing.Point(667, 197);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(119, 32);
            this.btnEspecialidades.TabIndex = 6;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Visible = false;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Location = new System.Drawing.Point(10, 252);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(119, 32);
            this.btnCursos.TabIndex = 8;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Visible = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.Location = new System.Drawing.Point(175, 252);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(119, 32);
            this.btnPersonas.TabIndex = 10;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Visible = false;
            this.btnPersonas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btbDC
            // 
            this.btbDC.Location = new System.Drawing.Point(337, 252);
            this.btbDC.Name = "btbDC";
            this.btbDC.Size = new System.Drawing.Size(119, 32);
            this.btbDC.TabIndex = 12;
            this.btbDC.Text = "Docentes Cursos";
            this.btbDC.UseVisualStyleBackColor = true;
            this.btbDC.Visible = false;
            this.btbDC.Click += new System.EventHandler(this.btbDC_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbDC);
            this.Controls.Add(this.btnPersonas);
            this.Controls.Add(this.btnCursos);
            this.Controls.Add(this.btnEspecialidades);
            this.Controls.Add(this.btnMaterias);
            this.Controls.Add(this.btnPlanes);
            this.Controls.Add(this.btnComisiones);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.mnsPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.Text = "Academia";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnComisiones;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btbDC;
        private System.Windows.Forms.ToolStripMenuItem tsbComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsbPlanes;
        private System.Windows.Forms.ToolStripMenuItem tsbRepoPlanes;
        private System.Windows.Forms.ToolStripMenuItem tsbMaterias;
        private System.Windows.Forms.ToolStripMenuItem tsbEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tsbCursos;
        private System.Windows.Forms.ToolStripMenuItem tsbRepoCurso;
        private System.Windows.Forms.ToolStripMenuItem tsbUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsbPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsbDYC;
        private System.Windows.Forms.ToolStripMenuItem tsbInscripciones;
    }
}