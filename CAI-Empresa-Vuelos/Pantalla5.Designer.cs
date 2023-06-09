namespace CAI_Empresa_Vuelos
{
    partial class Pantalla5
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumeroReserva = new System.Windows.Forms.Label();
            this.textBoxNumeroReserva = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.lblEstadoReserva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(31, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 21);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Estado de reserva";
            // 
            // lblNumeroReserva
            // 
            this.lblNumeroReserva.AutoSize = true;
            this.lblNumeroReserva.Location = new System.Drawing.Point(31, 85);
            this.lblNumeroReserva.Name = "lblNumeroReserva";
            this.lblNumeroReserva.Size = new System.Drawing.Size(107, 15);
            this.lblNumeroReserva.TabIndex = 7;
            this.lblNumeroReserva.Text = "Numero de reserva";
            this.lblNumeroReserva.Visible = false;
            // 
            // textBoxNumeroReserva
            // 
            this.textBoxNumeroReserva.Location = new System.Drawing.Point(144, 82);
            this.textBoxNumeroReserva.Name = "textBoxNumeroReserva";
            this.textBoxNumeroReserva.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumeroReserva.TabIndex = 13;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(272, 85);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 14;
            this.lblDNI.Text = "DNI";
            this.lblDNI.Visible = false;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(343, 82);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 23);
            this.textBoxDNI.TabIndex = 15;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(523, 82);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 18;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Location = new System.Drawing.Point(523, 37);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(98, 15);
            this.lblEstadoReserva.TabIndex = 19;
            this.lblEstadoReserva.Text = "Estado de reserva";
            this.lblEstadoReserva.Visible = false;
            // 
            // Pantalla5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEstadoReserva);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.textBoxNumeroReserva);
            this.Controls.Add(this.lblNumeroReserva);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Pantalla5";
            this.Text = "Pantalla5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumeroReserva;
        private System.Windows.Forms.TextBox textBoxNumeroReserva;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label lblEstadoReserva;
    }
}