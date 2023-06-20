namespace CAI_Empresa_Vuelos
{
    partial class DatosPasajeros
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(10, 53);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(779, 348);
            this.panelContenedor.TabIndex = 0;
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Location = new System.Drawing.Point(707, 406);
            this.buttonGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(82, 22);
            this.buttonGrabar.TabIndex = 1;
            this.buttonGrabar.Text = "Grabar";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(10, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(141, 21);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Datos de pasajeros";
            // 
            // DatosPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.panelContenedor);
            this.Name = "DatosPasajeros";
            this.Text = "Datos pasajeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Label lblTitulo;
    }
}