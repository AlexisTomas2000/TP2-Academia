
namespace UI.Desktop
{
    partial class Planes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planes));
            this.tsmOpciones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.tp2_netDataSet13 = new UI.Desktop.tp2_netDataSet13();
            this.spListaPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ListaPlanesTableAdapter = new UI.Desktop.tp2_netDataSet13TableAdapters.sp_ListaPlanesTableAdapter();
            this.idplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsmOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaPlanesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsmOpciones
            // 
            this.tsmOpciones.Enabled = false;
            this.tsmOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsmOpciones.Location = new System.Drawing.Point(0, 0);
            this.tsmOpciones.Name = "tsmOpciones";
            this.tsmOpciones.Size = new System.Drawing.Size(644, 25);
            this.tsmOpciones.TabIndex = 0;
            this.tsmOpciones.Text = "toolStrip1";
            this.tsmOpciones.Visible = false;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
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
            // dgvPlanes
            // 
            this.dgvPlanes.AllowUserToAddRows = false;
            this.dgvPlanes.AllowUserToDeleteRows = false;
            this.dgvPlanes.AutoGenerateColumns = false;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idplanDataGridViewTextBoxColumn,
            this.descplanDataGridViewTextBoxColumn,
            this.idespecialidadDataGridViewTextBoxColumn,
            this.descespecialidadDataGridViewTextBoxColumn});
            this.dgvPlanes.DataSource = this.spListaPlanesBindingSource;
            this.dgvPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPlanes.Location = new System.Drawing.Point(0, 0);
            this.dgvPlanes.MultiSelect = false;
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.ReadOnly = true;
            this.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanes.Size = new System.Drawing.Size(644, 387);
            this.dgvPlanes.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(476, 419);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(557, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Enabled = false;
            this.btnReportes.Location = new System.Drawing.Point(13, 419);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(118, 23);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Generar Reporte";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Visible = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // tp2_netDataSet13
            // 
            this.tp2_netDataSet13.DataSetName = "tp2_netDataSet13";
            this.tp2_netDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListaPlanesBindingSource
            // 
            this.spListaPlanesBindingSource.DataMember = "sp_ListaPlanes";
            this.spListaPlanesBindingSource.DataSource = this.tp2_netDataSet13;
            // 
            // sp_ListaPlanesTableAdapter
            // 
            this.sp_ListaPlanesTableAdapter.ClearBeforeFill = true;
            // 
            // idplanDataGridViewTextBoxColumn
            // 
            this.idplanDataGridViewTextBoxColumn.DataPropertyName = "id_plan";
            this.idplanDataGridViewTextBoxColumn.HeaderText = "ID Plan";
            this.idplanDataGridViewTextBoxColumn.Name = "idplanDataGridViewTextBoxColumn";
            this.idplanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descplanDataGridViewTextBoxColumn
            // 
            this.descplanDataGridViewTextBoxColumn.DataPropertyName = "desc_plan";
            this.descplanDataGridViewTextBoxColumn.HeaderText = "Descripcion Plan";
            this.descplanDataGridViewTextBoxColumn.Name = "descplanDataGridViewTextBoxColumn";
            this.descplanDataGridViewTextBoxColumn.ReadOnly = true;
            this.descplanDataGridViewTextBoxColumn.Width = 200;
            // 
            // idespecialidadDataGridViewTextBoxColumn
            // 
            this.idespecialidadDataGridViewTextBoxColumn.DataPropertyName = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.HeaderText = "ID Especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.Name = "idespecialidadDataGridViewTextBoxColumn";
            this.idespecialidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descespecialidadDataGridViewTextBoxColumn
            // 
            this.descespecialidadDataGridViewTextBoxColumn.DataPropertyName = "desc_especialidad";
            this.descespecialidadDataGridViewTextBoxColumn.HeaderText = "Descripcion Especialidad";
            this.descespecialidadDataGridViewTextBoxColumn.Name = "descespecialidadDataGridViewTextBoxColumn";
            this.descespecialidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.descespecialidadDataGridViewTextBoxColumn.Width = 200;
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 444);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPlanes);
            this.Controls.Add(this.tsmOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Planes";
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.Planes_Load);
            this.tsmOpciones.ResumeLayout(false);
            this.tsmOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaPlanesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsmOpciones;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
        private tp2_netDataSet13 tp2_netDataSet13;
        private System.Windows.Forms.BindingSource spListaPlanesBindingSource;
        private tp2_netDataSet13TableAdapters.sp_ListaPlanesTableAdapter sp_ListaPlanesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descespecialidadDataGridViewTextBoxColumn;
    }
}