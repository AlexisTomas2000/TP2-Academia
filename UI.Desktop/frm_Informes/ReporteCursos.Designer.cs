﻿
namespace UI.Desktop.frm_Informes
{
    partial class ReporteCursos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tp2_netDataSet5 = new UI.Desktop.tp2_netDataSet5();
            this.spListaCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ListaCursosTableAdapter = new UI.Desktop.tp2_netDataSet5TableAdapters.sp_ListaCursosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaCursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spListaCursosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.Informe.InformaCursos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(940, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // tp2_netDataSet5
            // 
            this.tp2_netDataSet5.DataSetName = "tp2_netDataSet5";
            this.tp2_netDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListaCursosBindingSource
            // 
            this.spListaCursosBindingSource.DataMember = "sp_ListaCursos";
            this.spListaCursosBindingSource.DataSource = this.tp2_netDataSet5;
            // 
            // sp_ListaCursosTableAdapter
            // 
            this.sp_ListaCursosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaCursosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tp2_netDataSet5 tp2_netDataSet5;
        private System.Windows.Forms.BindingSource spListaCursosBindingSource;
        private tp2_netDataSet5TableAdapters.sp_ListaCursosTableAdapter sp_ListaCursosTableAdapter;
    }
}