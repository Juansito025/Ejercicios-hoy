namespace Piedra_papel_o_tijera
{
    partial class frmPPT
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
            this.gpJugador = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpMaquina = new System.Windows.Forms.GroupBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreM = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbnPiedra = new System.Windows.Forms.RadioButton();
            this.rbnPapel = new System.Windows.Forms.RadioButton();
            this.rbnTijeras = new System.Windows.Forms.RadioButton();
            this.rbnPiedraM = new System.Windows.Forms.RadioButton();
            this.rbnPapelM = new System.Windows.Forms.RadioButton();
            this.rbnTijerasM = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtScoreM = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.gpJugador.SuspendLayout();
            this.gpMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpJugador
            // 
            this.gpJugador.Controls.Add(this.rbnPiedra);
            this.gpJugador.Controls.Add(this.rbnPapel);
            this.gpJugador.Controls.Add(this.rbnTijeras);
            this.gpJugador.Location = new System.Drawing.Point(29, 43);
            this.gpJugador.Name = "gpJugador";
            this.gpJugador.Size = new System.Drawing.Size(297, 340);
            this.gpJugador.TabIndex = 0;
            this.gpJugador.TabStop = false;
            this.gpJugador.Text = "Jugador";
            // 
            // gpMaquina
            // 
            this.gpMaquina.Controls.Add(this.rbnPiedraM);
            this.gpMaquina.Controls.Add(this.rbnPapelM);
            this.gpMaquina.Controls.Add(this.rbnTijerasM);
            this.gpMaquina.Location = new System.Drawing.Point(700, 43);
            this.gpMaquina.Name = "gpMaquina";
            this.gpMaquina.Size = new System.Drawing.Size(268, 340);
            this.gpMaquina.TabIndex = 0;
            this.gpMaquina.TabStop = false;
            this.gpMaquina.Text = "Maquina";
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(436, 354);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(127, 55);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(26, 18);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreM
            // 
            this.lblScoreM.AutoSize = true;
            this.lblScoreM.Location = new System.Drawing.Point(737, 18);
            this.lblScoreM.Name = "lblScoreM";
            this.lblScoreM.Size = new System.Drawing.Size(38, 13);
            this.lblScoreM.TabIndex = 2;
            this.lblScoreM.Text = "Score:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(475, 292);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(48, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Ganador";
            // 
            // rbnPiedra
            // 
            this.rbnPiedra.AutoSize = true;
            this.rbnPiedra.Location = new System.Drawing.Point(51, 62);
            this.rbnPiedra.Name = "rbnPiedra";
            this.rbnPiedra.Size = new System.Drawing.Size(55, 17);
            this.rbnPiedra.TabIndex = 4;
            this.rbnPiedra.TabStop = true;
            this.rbnPiedra.Text = "Piedra";
            this.rbnPiedra.UseVisualStyleBackColor = true;
            // 
            // rbnPapel
            // 
            this.rbnPapel.AutoSize = true;
            this.rbnPapel.Location = new System.Drawing.Point(51, 124);
            this.rbnPapel.Name = "rbnPapel";
            this.rbnPapel.Size = new System.Drawing.Size(52, 17);
            this.rbnPapel.TabIndex = 5;
            this.rbnPapel.TabStop = true;
            this.rbnPapel.Text = "Papel";
            this.rbnPapel.UseVisualStyleBackColor = true;
            // 
            // rbnTijeras
            // 
            this.rbnTijeras.AutoSize = true;
            this.rbnTijeras.Location = new System.Drawing.Point(51, 192);
            this.rbnTijeras.Name = "rbnTijeras";
            this.rbnTijeras.Size = new System.Drawing.Size(56, 17);
            this.rbnTijeras.TabIndex = 6;
            this.rbnTijeras.TabStop = true;
            this.rbnTijeras.Text = "Tijeras";
            this.rbnTijeras.UseVisualStyleBackColor = true;
            this.rbnTijeras.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbnPiedraM
            // 
            this.rbnPiedraM.AutoSize = true;
            this.rbnPiedraM.Location = new System.Drawing.Point(71, 62);
            this.rbnPiedraM.Name = "rbnPiedraM";
            this.rbnPiedraM.Size = new System.Drawing.Size(55, 17);
            this.rbnPiedraM.TabIndex = 7;
            this.rbnPiedraM.TabStop = true;
            this.rbnPiedraM.Text = "Piedra";
            this.rbnPiedraM.UseVisualStyleBackColor = true;
            // 
            // rbnPapelM
            // 
            this.rbnPapelM.AutoSize = true;
            this.rbnPapelM.Location = new System.Drawing.Point(71, 124);
            this.rbnPapelM.Name = "rbnPapelM";
            this.rbnPapelM.Size = new System.Drawing.Size(52, 17);
            this.rbnPapelM.TabIndex = 8;
            this.rbnPapelM.TabStop = true;
            this.rbnPapelM.Text = "Papel";
            this.rbnPapelM.UseVisualStyleBackColor = true;
            // 
            // rbnTijerasM
            // 
            this.rbnTijerasM.AutoSize = true;
            this.rbnTijerasM.Location = new System.Drawing.Point(71, 192);
            this.rbnTijerasM.Name = "rbnTijerasM";
            this.rbnTijerasM.Size = new System.Drawing.Size(56, 17);
            this.rbnTijerasM.TabIndex = 9;
            this.rbnTijerasM.TabStop = true;
            this.rbnTijerasM.Text = "Tijeras";
            this.rbnTijerasM.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Piedra_papel_o_tijera.Properties.Resources.icons8_batalla_64;
            this.pictureBox1.Location = new System.Drawing.Point(462, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 87);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtScoreM
            // 
            this.txtScoreM.Location = new System.Drawing.Point(796, 15);
            this.txtScoreM.Name = "txtScoreM";
            this.txtScoreM.Size = new System.Drawing.Size(100, 20);
            this.txtScoreM.TabIndex = 5;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(93, 15);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 6;
            // 
            // frmPPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtScoreM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblScoreM);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.gpMaquina);
            this.Controls.Add(this.gpJugador);
            this.Name = "frmPPT";
            this.Text = "Juego";
            this.gpJugador.ResumeLayout(false);
            this.gpJugador.PerformLayout();
            this.gpMaquina.ResumeLayout(false);
            this.gpMaquina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpJugador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpMaquina;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreM;
        private System.Windows.Forms.RadioButton rbnPiedra;
        private System.Windows.Forms.RadioButton rbnPapel;
        private System.Windows.Forms.RadioButton rbnTijeras;
        private System.Windows.Forms.RadioButton rbnPiedraM;
        private System.Windows.Forms.RadioButton rbnPapelM;
        private System.Windows.Forms.RadioButton rbnTijerasM;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtScoreM;
        private System.Windows.Forms.TextBox txtScore;
    }
}

