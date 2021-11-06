
namespace UI.Desktop
{
    partial class Comisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comisiones));
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsmOpciones = new System.Windows.Forms.ToolStrip();
            this.tp2_netDataSet8 = new UI.Desktop.tp2_netDataSet8();
            this.comisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comisionesTableAdapter = new UI.Desktop.tp2_netDataSet8TableAdapters.comisionesTableAdapter();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsmOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(388, 421);
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
            this.btnSalir.Location = new System.Drawing.Point(469, 421);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton2";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click_1);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton3";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click_1);
            // 
            // tsmOpciones
            // 
            this.tsmOpciones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsmOpciones.Enabled = false;
            this.tsmOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsmOpciones.Location = new System.Drawing.Point(0, -3);
            this.tsmOpciones.Name = "tsmOpciones";
            this.tsmOpciones.Size = new System.Drawing.Size(81, 25);
            this.tsmOpciones.TabIndex = 1;
            this.tsmOpciones.Text = "toolStrip1";
            this.tsmOpciones.Visible = false;
            // 
            // tp2_netDataSet8
            // 
            this.tp2_netDataSet8.DataSetName = "tp2_netDataSet8";
            this.tp2_netDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comisionesBindingSource
            // 
            this.comisionesBindingSource.DataMember = "comisiones";
            this.comisionesBindingSource.DataSource = this.tp2_netDataSet8;
            // 
            // comisionesTableAdapter
            // 
            this.comisionesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AllowUserToDeleteRows = false;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion_Comision,
            this.Año_Especialidad,
            this.Id_Plan});
            this.dgvComisiones.Location = new System.Drawing.Point(12, 33);
            this.dgvComisiones.MultiSelect = false;
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComisiones.Size = new System.Drawing.Size(520, 382);
            this.dgvComisiones.TabIndex = 4;
            this.dgvComisiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComisiones_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descripcion_Comision
            // 
            this.Descripcion_Comision.DataPropertyName = "Descripcion";
            this.Descripcion_Comision.HeaderText = "Descripcion Comision";
            this.Descripcion_Comision.Name = "Descripcion_Comision";
            this.Descripcion_Comision.ReadOnly = true;
            this.Descripcion_Comision.Width = 150;
            // 
            // Año_Especialidad
            // 
            this.Año_Especialidad.DataPropertyName = "AnioEspecialidad";
            this.Año_Especialidad.HeaderText = "Año Especialidad";
            this.Año_Especialidad.Name = "Año_Especialidad";
            this.Año_Especialidad.ReadOnly = true;
            this.Año_Especialidad.Width = 120;
            // 
            // Id_Plan
            // 
            this.Id_Plan.DataPropertyName = "IdPlan";
            this.Id_Plan.HeaderText = "ID Plan";
            this.Id_Plan.Name = "Id_Plan";
            this.Id_Plan.ReadOnly = true;
            // 
            // Comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 449);
            this.Controls.Add(this.dgvComisiones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tsmOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comisiones";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Comisiones_Load);
            this.tsmOpciones.ResumeLayout(false);
            this.tsmOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStrip tsmOpciones;
        private tp2_netDataSet8 tp2_netDataSet8;
        private System.Windows.Forms.BindingSource comisionesBindingSource;
        private tp2_netDataSet8TableAdapters.comisionesTableAdapter comisionesTableAdapter;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año_Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Plan;
    }
}