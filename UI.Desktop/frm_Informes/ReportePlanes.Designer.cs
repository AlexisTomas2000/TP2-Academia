
namespace UI.Desktop.frm_Informes
{
    partial class ReportePlanes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportePlanes));
            this.spListaPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet7 = new UI.Desktop.tp2_netDataSet7();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2netDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.planesTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.planesTableAdapter();
            this.sp_ListaPlanesTableAdapter = new UI.Desktop.tp2_netDataSet7TableAdapters.sp_ListaPlanesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spListaPlanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2netDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // spListaPlanesBindingSource
            // 
            this.spListaPlanesBindingSource.DataMember = "sp_ListaPlanes";
            this.spListaPlanesBindingSource.DataSource = this.tp2_netDataSet7;
            // 
            // tp2_netDataSet7
            // 
            this.tp2_netDataSet7.DataSetName = "tp2_netDataSet7";
            this.tp2_netDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.tp2netDataSetBindingSource;
            // 
            // tp2netDataSetBindingSource
            // 
            this.tp2netDataSetBindingSource.DataSource = this.tp2_netDataSet;
            this.tp2netDataSetBindingSource.Position = 0;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spListaPlanesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.Informe.InformePlanes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(709, 458);
            this.reportViewer1.TabIndex = 0;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // sp_ListaPlanesTableAdapter
            // 
            this.sp_ListaPlanesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 482);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportePlanes";
            this.Text = "Reporte Planes";
            this.Load += new System.EventHandler(this.Reporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spListaPlanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2netDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource tp2netDataSetBindingSource;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private tp2_netDataSetTableAdapters.planesTableAdapter planesTableAdapter;
        private tp2_netDataSet7 tp2_netDataSet7;
        private System.Windows.Forms.BindingSource spListaPlanesBindingSource;
        private tp2_netDataSet7TableAdapters.sp_ListaPlanesTableAdapter sp_ListaPlanesTableAdapter;
    }
}