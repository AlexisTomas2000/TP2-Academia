
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDYC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsbCursos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnsPrincipal.Size = new System.Drawing.Size(897, 24);
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
            this.tsbPlanes.Name = "tsbPlanes";
            this.tsbPlanes.Size = new System.Drawing.Size(180, 22);
            this.tsbPlanes.Text = "Planes";
            this.tsbPlanes.Visible = false;
            this.tsbPlanes.Click += new System.EventHandler(this.tsbPlanes_Click);
            // 
            // tsbMaterias
            // 
            this.tsbMaterias.Name = "tsbMaterias";
            this.tsbMaterias.Size = new System.Drawing.Size(180, 22);
            this.tsbMaterias.Text = "Materias";
            this.tsbMaterias.Visible = false;
            this.tsbMaterias.Click += new System.EventHandler(this.tsbMaterias_Click);
            // 
            // tsbEspecialidades
            // 
            this.tsbEspecialidades.Name = "tsbEspecialidades";
            this.tsbEspecialidades.Size = new System.Drawing.Size(180, 22);
            this.tsbEspecialidades.Text = "Especialidades";
            this.tsbEspecialidades.Visible = false;
            this.tsbEspecialidades.Click += new System.EventHandler(this.tsbEspecialidades_Click);
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
            this.tsbPersonas.Click += new System.EventHandler(this.tsbPersonas_Click);
            // 
            // tsbDYC
            // 
            this.tsbDYC.Name = "tsbDYC";
            this.tsbDYC.Size = new System.Drawing.Size(180, 22);
            this.tsbDYC.Text = "Docentes Y Cursos";
            this.tsbDYC.Visible = false;
            this.tsbDYC.Click += new System.EventHandler(this.tsbDYC_Click);
            // 
            // tsbInscripciones
            // 
            this.tsbInscripciones.Name = "tsbInscripciones";
            this.tsbInscripciones.Size = new System.Drawing.Size(180, 22);
            this.tsbInscripciones.Text = "Inscripciones";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 481);
            this.panel1.TabIndex = 14;
            // 
            // tsbCursos
            // 
            this.tsbCursos.Name = "tsbCursos";
            this.tsbCursos.Size = new System.Drawing.Size(180, 22);
            this.tsbCursos.Text = "Cursos";
            this.tsbCursos.Visible = false;
            this.tsbCursos.Click += new System.EventHandler(this.tsbCursos_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(897, 510);
            this.Controls.Add(this.mnsPrincipal);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem tsbComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsbPlanes;
        private System.Windows.Forms.ToolStripMenuItem tsbMaterias;
        private System.Windows.Forms.ToolStripMenuItem tsbEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tsbUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsbPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsbDYC;
        private System.Windows.Forms.ToolStripMenuItem tsbInscripciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tsbCursos;
    }
}