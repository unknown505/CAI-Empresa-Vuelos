
namespace CAI_Empresa_Vuelos
{
    partial class Pantalla2
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReserva = new System.Windows.Forms.Button();
            this.buttonEdeReserva = new System.Windows.Forms.Button();
            this.buttonReclamos = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(304, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            // 
            // buttonReserva
            // 
            this.buttonReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReserva.Location = new System.Drawing.Point(240, 109);
            this.buttonReserva.Name = "buttonReserva";
            this.buttonReserva.Size = new System.Drawing.Size(320, 63);
            this.buttonReserva.TabIndex = 1;
            this.buttonReserva.Text = "Reserva";
            this.buttonReserva.UseVisualStyleBackColor = true;
            this.buttonReserva.Click += new System.EventHandler(this.buttonReserva_Click);
            // 
            // buttonEdeReserva
            // 
            this.buttonEdeReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdeReserva.Location = new System.Drawing.Point(240, 178);
            this.buttonEdeReserva.Name = "buttonEdeReserva";
            this.buttonEdeReserva.Size = new System.Drawing.Size(320, 63);
            this.buttonEdeReserva.TabIndex = 2;
            this.buttonEdeReserva.Text = "Estado de reserva";
            this.buttonEdeReserva.UseVisualStyleBackColor = true;
            this.buttonEdeReserva.Click += new System.EventHandler(this.buttonEdeReserva_Click);
            // 
            // buttonReclamos
            // 
            this.buttonReclamos.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReclamos.Location = new System.Drawing.Point(240, 249);
            this.buttonReclamos.Name = "buttonReclamos";
            this.buttonReclamos.Size = new System.Drawing.Size(320, 63);
            this.buttonReclamos.TabIndex = 3;
            this.buttonReclamos.Text = "Reclamos";
            this.buttonReclamos.UseVisualStyleBackColor = true;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVolver.Location = new System.Drawing.Point(240, 319);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(320, 63);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Pantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonReclamos);
            this.Controls.Add(this.buttonEdeReserva);
            this.Controls.Add(this.buttonReserva);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla2";
            this.Text = "Pantalla2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReserva;
        private System.Windows.Forms.Button buttonEdeReserva;
        private System.Windows.Forms.Button buttonReclamos;
        private System.Windows.Forms.Button buttonVolver;
    }
}