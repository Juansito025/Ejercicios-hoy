namespace Descuentos
{
    partial class frmDescuentos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpDatos = new GroupBox();
            btnCalcular = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            gpDescuentos = new GroupBox();
            rbn20Descuento = new RadioButton();
            rbn10Descuento = new RadioButton();
            rbn5Descuento = new RadioButton();
            gpTotal = new GroupBox();
            txtTotal = new TextBox();
            lblError = new Label();
            btnBorrar = new Button();
            gpDatos.SuspendLayout();
            gpDescuentos.SuspendLayout();
            gpTotal.SuspendLayout();
            SuspendLayout();
            // 
            // gpDatos
            // 
            gpDatos.BackColor = SystemColors.ActiveCaption;
            gpDatos.Controls.Add(btnCalcular);
            gpDatos.Controls.Add(txtPrecio);
            gpDatos.Controls.Add(lblPrecio);
            gpDatos.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpDatos.Location = new Point(12, 12);
            gpDatos.Name = "gpDatos";
            gpDatos.Size = new Size(658, 289);
            gpDatos.TabIndex = 0;
            gpDatos.TabStop = false;
            gpDatos.Text = "Datos";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(424, 109);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.RightToLeft = RightToLeft.No;
            btnCalcular.Size = new Size(150, 54);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(76, 139);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(191, 24);
            txtPrecio.TabIndex = 1;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(116, 89);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(122, 19);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Ingrese el precio:";
            // 
            // gpDescuentos
            // 
            gpDescuentos.BackColor = SystemColors.ActiveCaption;
            gpDescuentos.Controls.Add(rbn20Descuento);
            gpDescuentos.Controls.Add(rbn10Descuento);
            gpDescuentos.Controls.Add(rbn5Descuento);
            gpDescuentos.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpDescuentos.Location = new Point(691, 12);
            gpDescuentos.Name = "gpDescuentos";
            gpDescuentos.Size = new Size(358, 289);
            gpDescuentos.TabIndex = 1;
            gpDescuentos.TabStop = false;
            gpDescuentos.Text = "Descuentos %";
            // 
            // rbn20Descuento
            // 
            rbn20Descuento.AutoSize = true;
            rbn20Descuento.Location = new Point(62, 151);
            rbn20Descuento.Name = "rbn20Descuento";
            rbn20Descuento.Size = new Size(53, 23);
            rbn20Descuento.TabIndex = 5;
            rbn20Descuento.TabStop = true;
            rbn20Descuento.Text = "20%";
            rbn20Descuento.UseVisualStyleBackColor = true;
            // 
            // rbn10Descuento
            // 
            rbn10Descuento.AutoSize = true;
            rbn10Descuento.Location = new Point(62, 109);
            rbn10Descuento.Name = "rbn10Descuento";
            rbn10Descuento.Size = new Size(51, 23);
            rbn10Descuento.TabIndex = 4;
            rbn10Descuento.TabStop = true;
            rbn10Descuento.Text = "10%";
            rbn10Descuento.UseVisualStyleBackColor = true;
            // 
            // rbn5Descuento
            // 
            rbn5Descuento.AutoSize = true;
            rbn5Descuento.Location = new Point(62, 68);
            rbn5Descuento.Name = "rbn5Descuento";
            rbn5Descuento.Size = new Size(45, 23);
            rbn5Descuento.TabIndex = 3;
            rbn5Descuento.TabStop = true;
            rbn5Descuento.Text = "5%";
            rbn5Descuento.UseVisualStyleBackColor = true;
            // 
            // gpTotal
            // 
            gpTotal.BackColor = SystemColors.ActiveCaption;
            gpTotal.Controls.Add(btnBorrar);
            gpTotal.Controls.Add(txtTotal);
            gpTotal.Controls.Add(lblError);
            gpTotal.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpTotal.Location = new Point(12, 309);
            gpTotal.Name = "gpTotal";
            gpTotal.Size = new Size(1037, 219);
            gpTotal.TabIndex = 2;
            gpTotal.TabStop = false;
            gpTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(178, 107);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(191, 24);
            txtTotal.TabIndex = 2;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(511, 107);
            lblError.Name = "lblError";
            lblError.Size = new Size(76, 19);
            lblError.TabIndex = 1;
            lblError.Text = "No se aplico";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(790, 80);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(144, 51);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmDescuentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 543);
            Controls.Add(gpTotal);
            Controls.Add(gpDescuentos);
            Controls.Add(gpDatos);
            Name = "frmDescuentos";
            Text = "Descuentos";
            gpDatos.ResumeLayout(false);
            gpDatos.PerformLayout();
            gpDescuentos.ResumeLayout(false);
            gpDescuentos.PerformLayout();
            gpTotal.ResumeLayout(false);
            gpTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpDatos;
        private Label lblPrecio;
        private GroupBox gpDescuentos;
        private GroupBox gpTotal;
        private Label lblError;
        private Button btnCalcular;
        private TextBox txtPrecio;
        private RadioButton rbn20Descuento;
        private RadioButton rbn10Descuento;
        private RadioButton rbn5Descuento;
        private TextBox txtTotal;
        private Button btnBorrar;
    }
}
