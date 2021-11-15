
namespace UI.Desktop
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.tsmOpciones = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataSet21 = new UI.Desktop.DataSet.DataSet2();
            this.tp2_netDataSet11 = new UI.Desktop.tp2_netDataSet11();
            this.spListaMateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ListaMateriasTableAdapter = new UI.Desktop.tp2_netDataSet11TableAdapters.sp_ListaMateriasTableAdapter();
            this.idmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hssemanalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstotalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.tsmOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaMateriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoGenerateColumns = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmateriaDataGridViewTextBoxColumn,
            this.descmateriaDataGridViewTextBoxColumn,
            this.hssemanalesDataGridViewTextBoxColumn,
            this.hstotalesDataGridViewTextBoxColumn,
            this.idplanDataGridViewTextBoxColumn,
            this.descplanDataGridViewTextBoxColumn});
            this.dgvMaterias.DataSource = this.spListaMateriasBindingSource;
            this.dgvMaterias.Location = new System.Drawing.Point(12, 32);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(755, 405);
            this.dgvMaterias.TabIndex = 0;
            // 
            // tsmOpciones
            // 
            this.tsmOpciones.Enabled = false;
            this.tsmOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEditar,
            this.toolStripButton2});
            this.tsmOpciones.Location = new System.Drawing.Point(0, 0);
            this.tsmOpciones.Name = "tsmOpciones";
            this.tsmOpciones.Size = new System.Drawing.Size(654, 25);
            this.tsmOpciones.TabIndex = 1;
            this.tsmOpciones.Text = "toolStrip1";
            this.tsmOpciones.Visible = false;
            this.tsmOpciones.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregar.Image")));
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(23, 22);
            this.tsbAgregar.Text = "Agregar";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Eliminar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(611, 447);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(692, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tp2_netDataSet11
            // 
            this.tp2_netDataSet11.DataSetName = "tp2_netDataSet11";
            this.tp2_netDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListaMateriasBindingSource
            // 
            this.spListaMateriasBindingSource.DataMember = "sp_ListaMaterias";
            this.spListaMateriasBindingSource.DataSource = this.tp2_netDataSet11;
            // 
            // sp_ListaMateriasTableAdapter
            // 
            this.sp_ListaMateriasTableAdapter.ClearBeforeFill = true;
            // 
            // idmateriaDataGridViewTextBoxColumn
            // 
            this.idmateriaDataGridViewTextBoxColumn.DataPropertyName = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.HeaderText = "ID Materia";
            this.idmateriaDataGridViewTextBoxColumn.Name = "idmateriaDataGridViewTextBoxColumn";
            this.idmateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descmateriaDataGridViewTextBoxColumn
            // 
            this.descmateriaDataGridViewTextBoxColumn.DataPropertyName = "desc_materia";
            this.descmateriaDataGridViewTextBoxColumn.HeaderText = "Descripcion Materia";
            this.descmateriaDataGridViewTextBoxColumn.Name = "descmateriaDataGridViewTextBoxColumn";
            this.descmateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descmateriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // hssemanalesDataGridViewTextBoxColumn
            // 
            this.hssemanalesDataGridViewTextBoxColumn.DataPropertyName = "hs_semanales";
            this.hssemanalesDataGridViewTextBoxColumn.HeaderText = "Horas Semanales";
            this.hssemanalesDataGridViewTextBoxColumn.Name = "hssemanalesDataGridViewTextBoxColumn";
            this.hssemanalesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hstotalesDataGridViewTextBoxColumn
            // 
            this.hstotalesDataGridViewTextBoxColumn.DataPropertyName = "hs_totales";
            this.hstotalesDataGridViewTextBoxColumn.HeaderText = "Horas Totales";
            this.hstotalesDataGridViewTextBoxColumn.Name = "hstotalesDataGridViewTextBoxColumn";
            this.hstotalesDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.descplanDataGridViewTextBoxColumn.Width = 150;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 482);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tsmOpciones);
            this.Controls.Add(this.dgvMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.tsmOpciones.ResumeLayout(false);
            this.tsmOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaMateriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.ToolStrip tsmOpciones;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private DataSet.DataSet2 dataSet21;
        private tp2_netDataSet11 tp2_netDataSet11;
        private System.Windows.Forms.BindingSource spListaMateriasBindingSource;
        private tp2_netDataSet11TableAdapters.sp_ListaMateriasTableAdapter sp_ListaMateriasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hssemanalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstotalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descplanDataGridViewTextBoxColumn;
    }
}