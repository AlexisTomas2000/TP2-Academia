
namespace UI.Desktop
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.tsmOpciones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.spListaCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet9 = new UI.Desktop.tp2_netDataSet9();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.sp_ListaCursosTableAdapter = new UI.Desktop.tp2_netDataSet9TableAdapters.sp_ListaCursosTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsmOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // tsmOpciones
            // 
            this.tsmOpciones.Enabled = false;
            this.tsmOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tbsEditar,
            this.tsbEliminar});
            this.tsmOpciones.Location = new System.Drawing.Point(0, 0);
            this.tsmOpciones.Name = "tsmOpciones";
            this.tsmOpciones.Size = new System.Drawing.Size(561, 25);
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
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tbsEditar
            // 
            this.tbsEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsEditar.Image = ((System.Drawing.Image)(resources.GetObject("tbsEditar.Image")));
            this.tbsEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsEditar.Name = "tbsEditar";
            this.tbsEditar.Size = new System.Drawing.Size(23, 22);
            this.tbsEditar.Text = "toolStripButton2";
            this.tbsEditar.Click += new System.EventHandler(this.tbsEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton3";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToOrderColumns = true;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDCom,
            this.Desc_Com,
            this.IDMat,
            this.DescMat,
            this.Año,
            this.Cupo});
            this.dgvCursos.Location = new System.Drawing.Point(12, 28);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(865, 381);
            this.dgvCursos.TabIndex = 1;
            // 
            // spListaCursosBindingSource
            // 
            this.spListaCursosBindingSource.DataMember = "sp_ListaCursos";
            this.spListaCursosBindingSource.DataSource = this.tp2_netDataSet9;
            // 
            // tp2_netDataSet9
            // 
            this.tp2_netDataSet9.DataSetName = "tp2_netDataSet9";
            this.tp2_netDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(802, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(721, 415);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Enabled = false;
            this.btnReportes.Location = new System.Drawing.Point(12, 415);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(139, 23);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Generar Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Visible = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // sp_ListaCursosTableAdapter
            // 
            this.sp_ListaCursosTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_Curso";
            this.ID.HeaderText = "ID Curso";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IDCom
            // 
            this.IDCom.DataPropertyName = "Id_Comision";
            this.IDCom.HeaderText = "ID Comision";
            this.IDCom.Name = "IDCom";
            this.IDCom.ReadOnly = true;
            // 
            // Desc_Com
            // 
            this.Desc_Com.DataPropertyName = "DescComision";
            this.Desc_Com.HeaderText = "Descripcion Comision";
            this.Desc_Com.Name = "Desc_Com";
            this.Desc_Com.ReadOnly = true;
            this.Desc_Com.Width = 120;
            // 
            // IDMat
            // 
            this.IDMat.DataPropertyName = "Id_Materia";
            this.IDMat.HeaderText = "ID Materia";
            this.IDMat.Name = "IDMat";
            this.IDMat.ReadOnly = true;
            // 
            // DescMat
            // 
            this.DescMat.DataPropertyName = "Desc_Materia";
            this.DescMat.HeaderText = "Descripcion Materia";
            this.DescMat.Name = "DescMat";
            this.DescMat.ReadOnly = true;
            this.DescMat.Width = 120;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "anio";
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Cupo
            // 
            this.Cupo.DataPropertyName = "cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.tsmOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.tsmOpciones.ResumeLayout(false);
            this.tsmOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsmOpciones;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tbsEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnReportes;
        private tp2_netDataSet9 tp2_netDataSet9;
        private System.Windows.Forms.BindingSource spListaCursosBindingSource;
        private tp2_netDataSet9TableAdapters.sp_ListaCursosTableAdapter sp_ListaCursosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Com;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
    }
}