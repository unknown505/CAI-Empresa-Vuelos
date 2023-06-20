namespace CAI_Empresa_Vuelos
{
    partial class ResumenPresupuesto
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelResumen = new System.Windows.Forms.Label();
            this.labelVuelos = new System.Windows.Forms.Label();
            this.labelAlojamiento = new System.Windows.Forms.Label();
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
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(39, 391);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 20;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // labelResumen
            // 
            this.labelResumen.AutoSize = true;
            this.labelResumen.Location = new System.Drawing.Point(39, 88);
            this.labelResumen.Name = "labelResumen";
            this.labelResumen.Size = new System.Drawing.Size(0, 15);
            this.labelResumen.TabIndex = 21;
            // 
            // labelVuelos
            // 
            this.labelVuelos.AutoSize = true;
            this.labelVuelos.Location = new System.Drawing.Point(39, 127);
            this.labelVuelos.Name = "labelVuelos";
            this.labelVuelos.Size = new System.Drawing.Size(0, 15);
            this.labelVuelos.TabIndex = 22;
            // 
            // labelAlojamiento
            // 
            this.labelAlojamiento.AutoSize = true;
            this.labelAlojamiento.Location = new System.Drawing.Point(39, 243);
            this.labelAlojamiento.Name = "labelAlojamiento";
            this.labelAlojamiento.Size = new System.Drawing.Size(0, 15);
            this.labelAlojamiento.TabIndex = 23;
            // 
            // ResumenPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAlojamiento);
            this.Controls.Add(this.labelVuelos);
            this.Controls.Add(this.labelResumen);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.lblResumen);
            this.Name = "ResumenPresupuesto";
            this.Text = "Resumen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelResumen;
        private System.Windows.Forms.Label labelVuelos;
        private System.Windows.Forms.Label labelAlojamiento;
    }
}