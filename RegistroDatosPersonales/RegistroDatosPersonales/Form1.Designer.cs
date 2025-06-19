namespace RegistroDatosPersonales
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
            this.gpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblECivil = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.rbnCasado = new System.Windows.Forms.RadioButton();
            this.rbnSoltero = new System.Windows.Forms.RadioButton();
            this.lblNombres = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpGenero = new System.Windows.Forms.GroupBox();
            this.rbnFemenino = new System.Windows.Forms.RadioButton();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.gpDatosPersonales.SuspendLayout();
            this.gpGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDatosPersonales
            // 
            this.gpDatosPersonales.Controls.Add(this.txtApellidos);
            this.gpDatosPersonales.Controls.Add(this.txtNombres);
            this.gpDatosPersonales.Controls.Add(this.btnRegistrar);
            this.gpDatosPersonales.Controls.Add(this.lblECivil);
            this.gpDatosPersonales.Controls.Add(this.lblApellidos);
            this.gpDatosPersonales.Controls.Add(this.rbnCasado);
            this.gpDatosPersonales.Controls.Add(this.rbnSoltero);
            this.gpDatosPersonales.Controls.Add(this.lblNombres);
            this.gpDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.gpDatosPersonales.Name = "gpDatosPersonales";
            this.gpDatosPersonales.Size = new System.Drawing.Size(776, 256);
            this.gpDatosPersonales.TabIndex = 0;
            this.gpDatosPersonales.TabStop = false;
            this.gpDatosPersonales.Text = "Datos Personales";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(64, 63);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(163, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(64, 32);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(163, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(384, 131);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 56);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblECivil
            // 
            this.lblECivil.AutoSize = true;
            this.lblECivil.Location = new System.Drawing.Point(6, 103);
            this.lblECivil.Name = "lblECivil";
            this.lblECivil.Size = new System.Drawing.Size(64, 13);
            this.lblECivil.TabIndex = 2;
            this.lblECivil.Text = "Estado civil:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(6, 66);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // rbnCasado
            // 
            this.rbnCasado.AutoSize = true;
            this.rbnCasado.Location = new System.Drawing.Point(22, 131);
            this.rbnCasado.Name = "rbnCasado";
            this.rbnCasado.Size = new System.Drawing.Size(61, 17);
            this.rbnCasado.TabIndex = 4;
            this.rbnCasado.TabStop = true;
            this.rbnCasado.Text = "Casado";
            this.rbnCasado.UseVisualStyleBackColor = true;
            // 
            // rbnSoltero
            // 
            this.rbnSoltero.AutoSize = true;
            this.rbnSoltero.Location = new System.Drawing.Point(22, 170);
            this.rbnSoltero.Name = "rbnSoltero";
            this.rbnSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbnSoltero.TabIndex = 5;
            this.rbnSoltero.TabStop = true;
            this.rbnSoltero.Text = "Soltero";
            this.rbnSoltero.UseVisualStyleBackColor = true;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(6, 35);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres:";
            // 
            // gpGenero
            // 
            this.gpGenero.Controls.Add(this.rbnFemenino);
            this.gpGenero.Controls.Add(this.rbnMasculino);
            this.gpGenero.Controls.Add(this.lblRespuesta);
            this.gpGenero.Location = new System.Drawing.Point(12, 310);
            this.gpGenero.Name = "gpGenero";
            this.gpGenero.Size = new System.Drawing.Size(776, 128);
            this.gpGenero.TabIndex = 0;
            this.gpGenero.TabStop = false;
            this.gpGenero.Text = "Genero";
            // 
            // rbnFemenino
            // 
            this.rbnFemenino.AutoSize = true;
            this.rbnFemenino.Location = new System.Drawing.Point(22, 82);
            this.rbnFemenino.Name = "rbnFemenino";
            this.rbnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbnFemenino.TabIndex = 7;
            this.rbnFemenino.TabStop = true;
            this.rbnFemenino.Text = "Femenino";
            this.rbnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(22, 34);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbnMasculino.TabIndex = 6;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(347, 34);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(58, 13);
            this.lblRespuesta.TabIndex = 3;
            this.lblRespuesta.Text = "Respuesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpGenero);
            this.Controls.Add(this.gpDatosPersonales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpDatosPersonales.ResumeLayout(false);
            this.gpDatosPersonales.PerformLayout();
            this.gpGenero.ResumeLayout(false);
            this.gpGenero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDatosPersonales;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblECivil;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.RadioButton rbnCasado;
        private System.Windows.Forms.RadioButton rbnSoltero;
        private System.Windows.Forms.Label lblNombres;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpGenero;
        private System.Windows.Forms.RadioButton rbnFemenino;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.Label lblRespuesta;
    }
}

