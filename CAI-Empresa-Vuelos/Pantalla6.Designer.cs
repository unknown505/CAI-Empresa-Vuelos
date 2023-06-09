namespace CAI_Empresa_Vuelos
{
    partial class Pantalla6
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
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblNumeroReserva = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDetalleReserva = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResumen.Location = new System.Drawing.Point(39, 40);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(75, 21);
            this.lblResumen.TabIndex = 4;
            this.lblResumen.Text = "Resumen";
            // 
            // lblNumeroReserva
            // 
            this.lblNumeroReserva.AutoSize = true;
            this.lblNumeroReserva.Location = new System.Drawing.Point(39, 99);
            this.lblNumeroReserva.Name = "lblNumeroReserva";
            this.lblNumeroReserva.Size = new System.Drawing.Size(107, 15);
            this.lblNumeroReserva.TabIndex = 8;
            this.lblNumeroReserva.Text = "Numero de reserva";
            this.lblNumeroReserva.Visible = false;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(39, 138);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(43, 15);
            this.lblDetalle.TabIndex = 9;
            this.lblDetalle.Text = "Detalle";
            this.lblDetalle.Visible = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(191, 99);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(31, 15);
            this.lblNumero.TabIndex = 10;
            this.lblNumero.Text = "1234";
            this.lblNumero.Visible = false;
            // 
            // lblDetalleReserva
            // 
            this.lblDetalleReserva.AutoSize = true;
            this.lblDetalleReserva.Location = new System.Drawing.Point(191, 138);
            this.lblDetalleReserva.Name = "lblDetalleReserva";
            this.lblDetalleReserva.Size = new System.Drawing.Size(83, 15);
            this.lblDetalleReserva.TabIndex = 11;
            this.lblDetalleReserva.Text = "Detalle reserva";
            this.lblDetalleReserva.Visible = false;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(663, 391);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 19;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(39, 391);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 20;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // Pantalla6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.lblDetalleReserva);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblNumeroReserva);
            this.Controls.Add(this.lblResumen);
            this.Name = "Pantalla6";
            this.Text = "Pantalla6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblNumeroReserva;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDetalleReserva;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonSalir;
    }
}