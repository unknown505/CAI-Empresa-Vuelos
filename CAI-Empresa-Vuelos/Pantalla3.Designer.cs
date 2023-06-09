
namespace CAI_Empresa_Vuelos
{
    partial class Pantalla3
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
            this.label2 = new System.Windows.Forms.Label();
            this.Alojamientos = new System.Windows.Forms.RadioButton();
            this.Vuelo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccion producto";
            // 
            // Alojamientos
            // 
            this.Alojamientos.AutoSize = true;
            this.Alojamientos.Location = new System.Drawing.Point(37, 115);
            this.Alojamientos.Name = "Alojamientos";
            this.Alojamientos.Size = new System.Drawing.Size(90, 19);
            this.Alojamientos.TabIndex = 2;
            this.Alojamientos.TabStop = true;
            this.Alojamientos.Text = "Alojamiento";
            this.Alojamientos.UseVisualStyleBackColor = true;
            // 
            // Vuelo
            // 
            this.Vuelo.AutoSize = true;
            this.Vuelo.Location = new System.Drawing.Point(210, 115);
            this.Vuelo.Name = "Vuelo";
            this.Vuelo.Size = new System.Drawing.Size(55, 19);
            this.Vuelo.TabIndex = 3;
            this.Vuelo.TabStop = true;
            this.Vuelo.Text = "Vuelo";
            this.Vuelo.UseVisualStyleBackColor = true;
            // 
            // Pantalla3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vuelo);
            this.Controls.Add(this.Alojamientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla3";
            this.Text = "Pantalla3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Alojamientos;
        private System.Windows.Forms.RadioButton Vuelo;
    }
}