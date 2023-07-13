namespace SistemaRegistroAcademico
{
    partial class frmreporteEstudiantes
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
            this.rvestudlocal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnreporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rvestudlocal
            // 
            this.rvestudlocal.LocalReport.ReportEmbeddedResource = "SistemaRegistroAcademico.reportesEstudiantes.rdlc";
            this.rvestudlocal.Location = new System.Drawing.Point(12, 56);
            this.rvestudlocal.Name = "rvestudlocal";
            this.rvestudlocal.ServerReport.BearerToken = null;
            this.rvestudlocal.Size = new System.Drawing.Size(988, 459);
            this.rvestudlocal.TabIndex = 0;
            // 
            // btnreporte
            // 
            this.btnreporte.Location = new System.Drawing.Point(39, 13);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(182, 37);
            this.btnreporte.TabIndex = 1;
            this.btnreporte.Text = "Generar reporte";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // frmreporteEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 544);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.rvestudlocal);
            this.Name = "frmreporteEstudiantes";
            this.Text = "frmreporteEstudiantes";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvestudlocal;
        private System.Windows.Forms.Button btnreporte;
    }
}