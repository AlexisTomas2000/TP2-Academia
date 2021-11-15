
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
            this.tsmOpciones = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tp2_netDataSet12 = new UI.Desktop.tp2_netDataSet12();
            this.splistaDocenteCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_listaDocenteCursoTableAdapter = new UI.Desktop.tp2_netDataSet12TableAdapters.sp_listaDocenteCursoTableAdapter();
            this.iddictadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desccomisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocCur)).BeginInit();
            this.tsmOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistaDocenteCursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocCur
            // 
            this.dgvDocCur.AllowUserToAddRows = false;
            this.dgvDocCur.AllowUserToDeleteRows = false;
            this.dgvDocCur.AutoGenerateColumns = false;
            this.dgvDocCur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocCur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddictadoDataGridViewTextBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.descmateriaDataGridViewTextBoxColumn,
            this.desccomisionDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dgvDocCur.DataSource = this.splistaDocenteCursoBindingSource;
            this.dgvDocCur.Location = new System.Drawing.Point(11, 28);
            this.dgvDocCur.MultiSelect = false;
            this.dgvDocCur.Name = "dgvDocCur";
            this.dgvDocCur.ReadOnly = true;
            this.dgvDocCur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocCur.Size = new System.Drawing.Size(750, 223);
            this.dgvDocCur.TabIndex = 0;
            this.dgvDocCur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocCur_CellContentClick);
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
            this.btnAct.Location = new System.Drawing.Point(605, 257);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 2;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(686, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tp2_netDataSet12
            // 
            this.tp2_netDataSet12.DataSetName = "tp2_netDataSet12";
            this.tp2_netDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splistaDocenteCursoBindingSource
            // 
            this.splistaDocenteCursoBindingSource.DataMember = "sp_listaDocenteCurso";
            this.splistaDocenteCursoBindingSource.DataSource = this.tp2_netDataSet12;
            // 
            // sp_listaDocenteCursoTableAdapter
            // 
            this.sp_listaDocenteCursoTableAdapter.ClearBeforeFill = true;
            // 
            // iddictadoDataGridViewTextBoxColumn
            // 
            this.iddictadoDataGridViewTextBoxColumn.DataPropertyName = "id_dictado";
            this.iddictadoDataGridViewTextBoxColumn.HeaderText = "id_dictado";
            this.iddictadoDataGridViewTextBoxColumn.Name = "iddictadoDataGridViewTextBoxColumn";
            this.iddictadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            this.idcursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descmateriaDataGridViewTextBoxColumn
            // 
            this.descmateriaDataGridViewTextBoxColumn.DataPropertyName = "desc_materia";
            this.descmateriaDataGridViewTextBoxColumn.HeaderText = "desc_materia";
            this.descmateriaDataGridViewTextBoxColumn.Name = "descmateriaDataGridViewTextBoxColumn";
            this.descmateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desccomisionDataGridViewTextBoxColumn
            // 
            this.desccomisionDataGridViewTextBoxColumn.DataPropertyName = "desc_comision";
            this.desccomisionDataGridViewTextBoxColumn.HeaderText = "desc_comision";
            this.desccomisionDataGridViewTextBoxColumn.Name = "desccomisionDataGridViewTextBoxColumn";
            this.desccomisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 287);
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
            this.tsmOpciones.ResumeLayout(false);
            this.tsmOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistaDocenteCursoBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iddictadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desccomisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
    }
}