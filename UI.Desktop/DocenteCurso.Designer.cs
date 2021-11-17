
namespace UI.Desktop
{
    partial class DocentesCursos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocentesCursos));
            this.dgvDocCur = new System.Windows.Forms.DataGridView();
            this.splistaDocenteCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet12 = new UI.Desktop.tp2_netDataSet12();
            this.tsmOpciones = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.sp_listaDocenteCursoTableAdapter = new UI.Desktop.tp2_netDataSet12TableAdapters.sp_listaDocenteCursoTableAdapter();
            this.IDDictado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescMate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocCur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistaDocenteCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet12)).BeginInit();
            this.tsmOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocCur
            // 
            this.dgvDocCur.AllowUserToAddRows = false;
            this.dgvDocCur.AllowUserToDeleteRows = false;
            this.dgvDocCur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocCur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDictado,
            this.IDCurso,
            this.DescMate,
            this.DescCom,
            this.Nombre,
            this.Apellido,
            this.Cargo});
            this.dgvDocCur.Location = new System.Drawing.Point(12, 28);
            this.dgvDocCur.MultiSelect = false;
            this.dgvDocCur.Name = "dgvDocCur";
            this.dgvDocCur.ReadOnly = true;
            this.dgvDocCur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocCur.Size = new System.Drawing.Size(908, 223);
            this.dgvDocCur.TabIndex = 0;
            this.dgvDocCur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocCur_CellContentClick);
            // 
            // splistaDocenteCursoBindingSource
            // 
            this.splistaDocenteCursoBindingSource.DataMember = "sp_listaDocenteCurso";
            this.splistaDocenteCursoBindingSource.DataSource = this.tp2_netDataSet12;
            // 
            // tp2_netDataSet12
            // 
            this.tp2_netDataSet12.DataSetName = "tp2_netDataSet12";
            this.tp2_netDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsmOpciones
            // 
            this.tsmOpciones.Enabled = false;
            this.tsmOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsmOpciones.Location = new System.Drawing.Point(0, 0);
            this.tsmOpciones.Name = "tsmOpciones";
            this.tsmOpciones.Size = new System.Drawing.Size(467, 25);
            this.tsmOpciones.TabIndex = 1;
            this.tsmOpciones.Text = "toolStrip1";
            this.tsmOpciones.Visible = false;
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregar.Image")));
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(23, 22);
            this.tsbAgregar.Text = "Agregar";
            this.tsbAgregar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(764, 257);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 2;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(845, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // sp_listaDocenteCursoTableAdapter
            // 
            this.sp_listaDocenteCursoTableAdapter.ClearBeforeFill = true;
            // 
            // IDDictado
            // 
            this.IDDictado.DataPropertyName = "ID";
            this.IDDictado.HeaderText = "ID Dictado";
            this.IDDictado.Name = "IDDictado";
            this.IDDictado.ReadOnly = true;
            // 
            // IDCurso
            // 
            this.IDCurso.DataPropertyName = "IDCurso";
            this.IDCurso.HeaderText = "ID Curso";
            this.IDCurso.Name = "IDCurso";
            this.IDCurso.ReadOnly = true;
            // 
            // DescMate
            // 
            this.DescMate.DataPropertyName = "DescMateria";
            this.DescMate.HeaderText = "Descripcion Materia Curso";
            this.DescMate.Name = "DescMate";
            this.DescMate.ReadOnly = true;
            this.DescMate.Width = 180;
            // 
            // DescCom
            // 
            this.DescCom.DataPropertyName = "Desc_Comision";
            this.DescCom.HeaderText = "Descripcion Comision Curso";
            this.DescCom.Name = "DescCom";
            this.DescCom.ReadOnly = true;
            this.DescCom.Width = 180;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 287);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.tsmOpciones);
            this.Controls.Add(this.dgvDocCur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocentesCursos";
            this.Text = "DocenteCurso";
            this.Load += new System.EventHandler(this.DocenteCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocCur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistaDocenteCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet12)).EndInit();
            this.tsmOpciones.ResumeLayout(false);
            this.tsmOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocCur;
        private System.Windows.Forms.ToolStrip tsmOpciones;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnSalir;
        private tp2_netDataSet12 tp2_netDataSet12;
        private System.Windows.Forms.BindingSource splistaDocenteCursoBindingSource;
        private tp2_netDataSet12TableAdapters.sp_listaDocenteCursoTableAdapter sp_listaDocenteCursoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDictado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescMate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}