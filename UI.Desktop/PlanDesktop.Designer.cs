
namespace UI.Desktop
{
    partial class PlanDesktop
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
            this.txtID = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtIDE = new System.Windows.Forms.Label();
            this.txtIDPlan = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtIDEsp = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(12, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(18, 13);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Location = new System.Drawing.Point(12, 60);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(63, 13);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "Descripcion";
            // 
            // txtIDE
            // 
            this.txtIDE.AutoSize = true;
            this.txtIDE.Location = new System.Drawing.Point(12, 94);
            this.txtIDE.Name = "txtIDE";
            this.txtIDE.Size = new System.Drawing.Size(81, 13);
            this.txtIDE.TabIndex = 2;
            this.txtIDE.Text = "ID Especialidad";
            // 
            // txtIDPlan
            // 
            this.txtIDPlan.Location = new System.Drawing.Point(99, 22);
            this.txtIDPlan.Name = "txtIDPlan";
            this.txtIDPlan.ReadOnly = true;
            this.txtIDPlan.Size = new System.Drawing.Size(190, 20);
            this.txtIDPlan.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(99, 57);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(190, 20);
            this.txtDesc.TabIndex = 4;
            // 
            // txtIDEsp
            // 
            this.txtIDEsp.Location = new System.Drawing.Point(99, 94);
            this.txtIDEsp.Name = "txtIDEsp";
            this.txtIDEsp.Size = new System.Drawing.Size(190, 20);
            this.txtIDEsp.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(214, 117);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // PlanDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 142);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtIDEsp);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtIDPlan);
            this.Controls.Add(this.txtIDE);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlanDesktop";
            this.Text = "PlanesDesktop";
            this.Load += new System.EventHandler(this.PlanesDesktop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtIDE;
        private System.Windows.Forms.TextBox txtIDPlan;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtIDEsp;
        private System.Windows.Forms.Button btnAceptar;
    }
}