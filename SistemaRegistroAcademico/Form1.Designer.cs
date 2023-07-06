namespace SistemaRegistroAcademico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnmatricula = new System.Windows.Forms.Button();
            this.btnestudiante = new System.Windows.Forms.Button();
            this.btnprofesor = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlocalidad = new System.Windows.Forms.Button();
            this.btncurso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            // 
            // btnmatricula
            // 
            this.btnmatricula.BackColor = System.Drawing.Color.Goldenrod;
            this.btnmatricula.FlatAppearance.BorderSize = 0;
            this.btnmatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmatricula.ForeColor = System.Drawing.Color.White;
            this.btnmatricula.Location = new System.Drawing.Point(12, 99);
            this.btnmatricula.Name = "btnmatricula";
            this.btnmatricula.Size = new System.Drawing.Size(136, 115);
            this.btnmatricula.TabIndex = 1;
            this.btnmatricula.Text = "Matrícula";
            this.btnmatricula.UseVisualStyleBackColor = false;
            // 
            // btnestudiante
            // 
            this.btnestudiante.BackColor = System.Drawing.Color.DarkOrange;
            this.btnestudiante.FlatAppearance.BorderSize = 0;
            this.btnestudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestudiante.ForeColor = System.Drawing.Color.White;
            this.btnestudiante.Location = new System.Drawing.Point(12, 220);
            this.btnestudiante.Name = "btnestudiante";
            this.btnestudiante.Size = new System.Drawing.Size(136, 115);
            this.btnestudiante.TabIndex = 2;
            this.btnestudiante.Text = "Estudiantes";
            this.btnestudiante.UseVisualStyleBackColor = false;
            // 
            // btnprofesor
            // 
            this.btnprofesor.BackColor = System.Drawing.Color.Goldenrod;
            this.btnprofesor.FlatAppearance.BorderSize = 0;
            this.btnprofesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofesor.ForeColor = System.Drawing.Color.White;
            this.btnprofesor.Location = new System.Drawing.Point(165, 220);
            this.btnprofesor.Name = "btnprofesor";
            this.btnprofesor.Size = new System.Drawing.Size(136, 115);
            this.btnprofesor.TabIndex = 3;
            this.btnprofesor.Text = "Profesores";
            this.btnprofesor.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Crimson;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(468, 280);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(86, 55);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlocalidad
            // 
            this.btnlocalidad.BackColor = System.Drawing.Color.DarkOrange;
            this.btnlocalidad.FlatAppearance.BorderSize = 0;
            this.btnlocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlocalidad.ForeColor = System.Drawing.Color.White;
            this.btnlocalidad.Location = new System.Drawing.Point(165, 99);
            this.btnlocalidad.Name = "btnlocalidad";
            this.btnlocalidad.Size = new System.Drawing.Size(136, 115);
            this.btnlocalidad.TabIndex = 5;
            this.btnlocalidad.Text = "Localidades";
            this.btnlocalidad.UseVisualStyleBackColor = false;
            this.btnlocalidad.Click += new System.EventHandler(this.btnlocalidad_Click);
            // 
            // btncurso
            // 
            this.btncurso.BackColor = System.Drawing.Color.DarkOrange;
            this.btncurso.FlatAppearance.BorderSize = 0;
            this.btncurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncurso.ForeColor = System.Drawing.Color.White;
            this.btncurso.Location = new System.Drawing.Point(317, 220);
            this.btncurso.Name = "btncurso";
            this.btncurso.Size = new System.Drawing.Size(136, 115);
            this.btncurso.TabIndex = 6;
            this.btncurso.Text = "Cursos";
            this.btncurso.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 85);
            this.label2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 354);
            this.Controls.Add(this.btncurso);
            this.Controls.Add(this.btnlocalidad);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnprofesor);
            this.Controls.Add(this.btnestudiante);
            this.Controls.Add(this.btnmatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmatricula;
        private System.Windows.Forms.Button btnestudiante;
        private System.Windows.Forms.Button btnprofesor;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlocalidad;
        private System.Windows.Forms.Button btncurso;
        private System.Windows.Forms.Label label2;
    }
}

